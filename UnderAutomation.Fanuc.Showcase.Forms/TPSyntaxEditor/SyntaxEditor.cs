using System;
using System.Collections.Generic;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace UnderAutomation.Fanuc.Showcase.Forms.TPSyntaxEditor
{
    #region CustomRichTextBox
    public class CustomRichTextBox : RichTextBox
    {
        // Collection de breakpoints (index physique de la ligne, 0-based)
        public HashSet<int> Breakpoints { get; set; } = new HashSet<int>();

        // Numéro de la ligne d’exécution (index physique, 0-based, -1 si aucune)
        public int CurrentExecutionLine { get; set; } = -1;

        [DllImport("user32.dll")]
        private static extern int SendMessage(IntPtr hWnd, int msg, int wParam, int lParam);
        private const int EM_GETFIRSTVISIBLELINE = 0xCE;

        protected override void WndProc(ref Message m)
        {
            base.WndProc(ref m);

            // Après le dessin standard, on dessine nos overlays
            if (m.Msg == 0x000F) // WM_PAINT
            {
                using (Graphics g = Graphics.FromHwnd(this.Handle))
                {
                    /*
                    // Dessiner un trait rouge au-dessus de chaque ligne qui possède un breakpoint
                    foreach (int line in Breakpoints)
                    {
                        int index = this.GetFirstCharIndexFromLine(line);
                        if (index >= 0)
                        {
                            Point pt = this.GetPositionFromCharIndex(index);
                            // Si la ligne est visible dans le contrôle
                            if (pt.Y < this.ClientSize.Height)
                            {
                                g.DrawLine(Pens.Red, 0, pt.Y, this.ClientSize.Width, pt.Y);
                            }
                        }
                    }*/

                    // Surligner en jaune (semi-transparent) la ligne en cours d'exécution
                    if (CurrentExecutionLine >= 0)
                    {
                        int index = this.GetFirstCharIndexFromLine(CurrentExecutionLine);
                        if (index >= 0)
                        {
                            Point pt = this.GetPositionFromCharIndex(index);
                            if (pt.Y < this.ClientSize.Height)
                            {
                                int lineHeight = this.Font.Height;

                                // Calculer éventuellement la hauteur “réelle” de la ligne
                                int nextIndex = this.GetFirstCharIndexFromLine(CurrentExecutionLine + 1);
                                if (nextIndex > 0)
                                {
                                    Point ptNext = this.GetPositionFromCharIndex(nextIndex);
                                    int calculatedHeight = ptNext.Y - pt.Y;
                                    if (calculatedHeight > 0)
                                        lineHeight = calculatedHeight;
                                }

                                Rectangle rect = new Rectangle(0, pt.Y, this.ClientSize.Width, lineHeight);
                                using (SolidBrush brush = new SolidBrush(Color.FromArgb(64, Color.Yellow)))
                                {
                                    g.FillRectangle(brush, rect);
                                }
                            }
                        }
                    }
                }
            }
        }
    }
    #endregion

    #region BreakpointEditor
    public class BreakpointEditor : UserControl
    {
        private Panel marginPanel;
        private CustomRichTextBox richTextBox;

        // Range physique des lignes correspondant aux directives /MN et /POS
        private int mnLineIndex = -1;   // Ligne physique où se trouve "/MN"
        private int posLineIndex = -1;  // Ligne physique où se trouve "/POS"

        // Collection de breakpoints partagée avec le CustomRichTextBox (index physique)
        private HashSet<int> breakpoints = new HashSet<int>();

        // Numéro de ligne d’exécution (index physique, 0-based, -1 si aucune)
        private int currentExecutionLine = -1;

        // Largeur totale de la marge
        private const int totalMarginWidth = 60;
        // Largeur réservée à la zone d’indicateur (breakpoint/flèche)
        private const int markerAreaWidth = 20;

        // Événements levés lorsqu’on ajoute/supprime un breakpoint.
        // On fournit ici le numéro *logique* de la ligne (tel qu’affiché, commençant à 1).
        public event EventHandler<int> BreakpointAdded;
        public event EventHandler<int> BreakpointRemoved;

        [DllImport("user32.dll")]
        private static extern int SendMessage(IntPtr hWnd, int msg, int wParam, int lParam);
        private const int EM_GETFIRSTVISIBLELINE = 0xCE;

        public BreakpointEditor()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            marginPanel = new Panel();
            richTextBox = new CustomRichTextBox();

            // Lier la collection de breakpoints du contrôle à celui de l'éditeur personnalisé
            richTextBox.Breakpoints = breakpoints;

            // Configuration de la marge
            marginPanel.Width = totalMarginWidth;
            marginPanel.Dock = DockStyle.Left;
            marginPanel.BackColor = Color.LightGray;
            marginPanel.MouseClick += MarginPanel_MouseClick;
            marginPanel.Paint += MarginPanel_Paint;

            // Configuration du CustomRichTextBox
            richTextBox.Dock = DockStyle.Fill;
            richTextBox.Font = new Font("Consolas", 10);
            richTextBox.WordWrap = false;
            // À chaque scrolling ou changement de texte, on redessine la marge et l'éditeur
            richTextBox.VScroll += (s, e) => { marginPanel.Invalidate(); richTextBox.Invalidate(); };
            richTextBox.TextChanged += (s, e) =>
            {
                UpdateMnPosIndices();
                marginPanel.Invalidate();
                richTextBox.Invalidate();
            };

            this.Controls.Add(richTextBox);
            this.Controls.Add(marginPanel);
        }

        /// <summary>
        /// Met à jour mnLineIndex et posLineIndex en fonction du contenu actuel du RichTextBox.
        /// </summary>
        private void UpdateMnPosIndices()
        {
            mnLineIndex = -1;
            posLineIndex = -1;

            // Parcourir les lignes pour trouver celles qui contiennent /MN et /POS
            var lines = richTextBox.Lines;
            for (int i = 0; i < lines.Length; i++)
            {
                // À adapter si vous voulez faire un match exact ou insensible à la casse
                if (lines[i].Contains("/MN"))
                    mnLineIndex = i;
                if (lines[i].Contains("/POS"))
                {
                    posLineIndex = i;
                    // Inutile de chercher plus loin si on veut le premier /POS
                    // break; // décommentez si besoin
                }
            }
        }

        /// <summary>
        /// Clic dans la marge : on détermine la ligne physique cliquée (0-based).
        /// Puis, si elle est éligible à recevoir un breakpoint (numérotée),
        /// on bascule le breakpoint sur cette ligne.
        /// </summary>
        private void MarginPanel_MouseClick(object sender, MouseEventArgs e)
        {
            int firstVisibleLine = SendMessage(richTextBox.Handle, EM_GETFIRSTVISIBLELINE, 0, 0);

            // On itère sur les lignes visibles selon leur position physique.
            int clickedPhysicalLine = firstVisibleLine;
            for (int line = firstVisibleLine; ; line++)
            {
                int charIndex = richTextBox.GetFirstCharIndexFromLine(line);
                if (charIndex < 0)
                    break;

                Point pt = richTextBox.GetPositionFromCharIndex(charIndex);
                int lineHeight = GetLineHeight(line);

                // On regarde si le clic se trouve dans la zone verticale de cette ligne
                if (e.Y < pt.Y + lineHeight)
                {
                    clickedPhysicalLine = line;
                    break;
                }
            }

            // Calculer le numéro logique correspondant
            int logicalLine = GetLogicalLineNumber(clickedPhysicalLine);
            // S’il n’y a pas de numéro (hors segment /MN.. /POS), on ignore
            if (logicalLine == -1)
                return;

            // Basculer dans la collection de breakpoints (physiques)
            if (breakpoints.Contains(logicalLine))
            {
                breakpoints.Remove(logicalLine);
                // Lever l’événement
                BreakpointRemoved?.Invoke(this, logicalLine);
            }
            else
            {
                breakpoints.Add(logicalLine);
                // Lever l’événement
                BreakpointAdded?.Invoke(this, logicalLine);
            }

            marginPanel.Invalidate();
            richTextBox.Invalidate();
        }

        public void InitializeBreakpoints(IEnumerable<int> lines)
        {
            breakpoints.Clear();
            foreach (int line in lines)
            {
                breakpoints.Add(line);
            }
            marginPanel.Invalidate();
            richTextBox.Invalidate();
        }

        /// <summary>
        /// Calcule la hauteur d'une ligne (en pixels) à partir de la position de la ligne suivante.
        /// </summary>
        private int GetLineHeight(int lineNumber)
        {
            int index = richTextBox.GetFirstCharIndexFromLine(lineNumber);
            if (index < 0)
                return richTextBox.Font.Height;

            Point currentPos = richTextBox.GetPositionFromCharIndex(index);
            int nextIndex = richTextBox.GetFirstCharIndexFromLine(lineNumber + 1);

            if (nextIndex < 0)
                return richTextBox.Font.Height;

            Point nextPos = richTextBox.GetPositionFromCharIndex(nextIndex);
            int height = nextPos.Y - currentPos.Y;
            return (height > 0 ? height : richTextBox.Font.Height);
        }

        /// <summary>
        /// Dessin de la marge (numéros de ligne + marqueurs de breakpoints/flèche d’exécution).
        /// Seules les lignes comprises entre /MN et /POS (exclues ou incluses selon le besoin)
        /// sont numérotées.
        /// </summary>
        private void MarginPanel_Paint(object sender, PaintEventArgs e)
        {
            int firstVisibleLine = SendMessage(richTextBox.Handle, EM_GETFIRSTVISIBLELINE, 0, 0);

            for (int line = firstVisibleLine; ; line++)
            {
                int charIndex = richTextBox.GetFirstCharIndexFromLine(line);
                if (charIndex < 0)
                    break;

                Point pt = richTextBox.GetPositionFromCharIndex(charIndex);
                if (pt.Y > marginPanel.Height)
                    break; // on ne dessine plus en dehors de la zone visible

                int lineHeight = GetLineHeight(line);
                bool isExecution = (line == currentExecutionLine);

                // Calcul du numéro logique
                int logicalLine = GetLogicalLineNumber(line);
                if (logicalLine == -1)
                {
                    // Hors segment /MN.. /POS => pas de numéro
                    // On n’affiche rien, sauf si vous vouliez griser quelque chose.
                    continue;
                }

                bool hasBreakpoint = breakpoints.Contains(logicalLine);

                // Déterminer si un indicateur (rond rouge/flèche) est présent
                bool hasMarker = hasBreakpoint || isExecution;

                // Zone d’affichage du numéro
                Rectangle numberRect = hasMarker
                    ? new Rectangle(0, pt.Y, totalMarginWidth - markerAreaWidth, lineHeight)
                    : new Rectangle(0, pt.Y, totalMarginWidth, lineHeight);

                // Afficher le numéro logique, aligné à droite
                string lineText = logicalLine.ToString();
                TextFormatFlags flags = TextFormatFlags.Right | TextFormatFlags.VerticalCenter | TextFormatFlags.NoPadding;
                TextRenderer.DrawText(e.Graphics, lineText, richTextBox.Font, numberRect, Color.Black, flags);

                // Zone des marqueurs (à droite)
                if (hasMarker)
                {
                    Rectangle markerRect = new Rectangle(totalMarginWidth - markerAreaWidth, pt.Y, markerAreaWidth, lineHeight);
                    if (hasBreakpoint && isExecution)
                    {
                        // Deux indicateurs : on divise la zone en deux
                        Rectangle leftHalf = new Rectangle(markerRect.X, markerRect.Y, markerRect.Width / 2, markerRect.Height);
                        Rectangle rightHalf = new Rectangle(markerRect.X + markerRect.Width / 2, markerRect.Y, markerRect.Width / 2, markerRect.Height);
                        DrawBreakpointMarker(e.Graphics, leftHalf);
                        DrawExecutionMarker(e.Graphics, rightHalf);
                    }
                    else if (hasBreakpoint)
                    {
                        DrawBreakpointMarker(e.Graphics, markerRect);
                    }
                    else if (isExecution)
                    {
                        DrawExecutionMarker(e.Graphics, markerRect);
                    }
                }
            }
        }

        /// <summary>
        /// Retourne le numéro logique de la ligne physique “lineIndex” ou -1 si
        /// la ligne est en dehors de la zone numérotée (/MN.. /POS).
        /// 
        /// Exemple : 
        ///   - si mnLineIndex=2, on veut commencer la numérotation à 1 pour la ligne physique 3.
        ///   - on arrête juste avant posLineIndex, donc si posLineIndex=10, la ligne 9 est la dernière numérotée.
        /// </summary>
        private int GetLogicalLineNumber(int lineIndex)
        {
            if (mnLineIndex == -1 || posLineIndex == -1)
                return -1; // on n’a pas trouvé /MN ou /POS

            // On veut que la ligne qui suit mnLineIndex corresponde au numéro 1
            // Donc la ligne mnLineIndex+1 = numéro 1
            // => lineIndex - (mnLineIndex+1) + 1 = lineIndex - mnLineIndex
            // On arrête la numérotation juste avant posLineIndex

            if (lineIndex <= mnLineIndex) return -1;
            if (lineIndex >= posLineIndex) return -1;

            // Sinon on calcule le décalage
            return lineIndex - mnLineIndex;
        }

        /// <summary> 
        /// Dessine un rond rouge (breakpoint) centré dans le rectangle fourni. 
        /// </summary>
        private void DrawBreakpointMarker(Graphics g, Rectangle rect)
        {
            int diameter = 10;
            int x = rect.X + (rect.Width - diameter) / 2;
            int y = rect.Y + (rect.Height - diameter) / 2;
            g.FillEllipse(Brushes.Red, x, y, diameter, diameter);
        }

        /// <summary>
        /// Dessine une flèche jaune pointant vers la droite, centrée dans le rectangle fourni.
        /// </summary>
        private void DrawExecutionMarker(Graphics g, Rectangle rect)
        {
            int arrowWidth = 10;
            int arrowHeight = 10;
            int centerX = rect.X + rect.Width / 2;
            int centerY = rect.Y + rect.Height / 2;

            Point[] arrowPoints = new Point[]
            {
                new Point(centerX - arrowWidth / 2, centerY - arrowHeight / 2),
                new Point(centerX - arrowWidth / 2, centerY + arrowHeight / 2),
                new Point(centerX + arrowWidth / 2, centerY)
            };
            g.FillPolygon(Brushes.Yellow, arrowPoints);
        }

        /// <summary>
        /// Définit la ligne d'exécution en passant un *index physique* (0-based).
        /// </summary>
        private void SetCurrentExecutionLine(int line)
        {
            if(currentExecutionLine == line && richTextBox.CurrentExecutionLine == line)  return;
            currentExecutionLine = line;
            richTextBox.CurrentExecutionLine = line;
            marginPanel.Invalidate();
            richTextBox.Invalidate();
        }

        /// <summary>
        /// Définit la ligne d’exécution en passant un *numéro logique* (celui affiché dans la marge).
        /// </summary>
        public void SetCurrentExecutionLineNumber(int logicalLineNumber)
        {
            // On convertit ce numéro logique en index physique
            int physicalLine = GetPhysicalLineFromLogicalLine(logicalLineNumber);
            if (physicalLine != -1)
                SetCurrentExecutionLine(physicalLine);
            else
                SetCurrentExecutionLine(-1);
        }

        /// <summary>
        /// Convertit un numéro logique (1…N) en index physique, ou -1 si invalide.
        /// </summary>
        private int GetPhysicalLineFromLogicalLine(int logicalLine)
        {
            // Inverse de GetLogicalLineNumber(int lineIndex)
            // lineIndex - mnLineIndex = logicalLine  => lineIndex = mnLineIndex + logicalLine
            if (mnLineIndex == -1 || posLineIndex == -1)
                return -1;

            // lineIndex = mnLineIndex + logicalLine
            int lineIndex = mnLineIndex + logicalLine;
            // On s’assure que lineIndex est bien dans la zone
            if (lineIndex <= mnLineIndex)
                return -1;
            if (lineIndex >= posLineIndex)
                return -1;

            // Contrôle final : existe-t-il vraiment dans le RichTextBox ?
            if (lineIndex < 0 || lineIndex >= richTextBox.Lines.Length)
                return -1;

            return lineIndex;
        }

        // Propriété d'accès direct au CustomRichTextBox si nécessaire
        public CustomRichTextBox Editor => richTextBox;
    }
    #endregion
}
