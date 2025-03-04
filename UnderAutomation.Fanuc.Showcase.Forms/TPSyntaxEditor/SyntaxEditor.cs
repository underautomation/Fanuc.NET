using System;
using System.Collections.Generic;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace UnderAutomation.Fanuc.Showcase.Forms.TPSyntaxEditor { 
#region CustomRichTextBox
/// <summary>
/// RichTextBox personnalisé qui, après avoir dessiné son contenu, ajoute en overlay :
/// - Un trait rouge au-dessus de chaque ligne possédant un breakpoint.
/// - Un surlignage jaune semi-transparent pour la ligne en cours d'exécution.
/// </summary>
public class CustomRichTextBox : RichTextBox
{
    // Collection de breakpoints (numéro de ligne, indexé à partir de 0)
    public HashSet<int> Breakpoints { get; set; } = new HashSet<int>();
    // Numéro de la ligne en cours d'exécution (-1 si aucune)
    public int CurrentExecutionLine { get; set; } = -1;

    [DllImport("user32.dll")]
    private static extern int SendMessage(IntPtr hWnd, int msg, int wParam, int lParam);
    private const int EM_GETFIRSTVISIBLELINE = 0xCE;

    protected override void WndProc(ref Message m)
    {
        base.WndProc(ref m);
        // Après le dessin standard, ajouter nos décorations personnalisées
        if (m.Msg == 0x000F) // WM_PAINT
        {
            using (Graphics g = Graphics.FromHwnd(this.Handle))
            {
                // Dessiner pour chaque breakpoint un trait rouge au-dessus de la ligne
                foreach (int line in Breakpoints)
                {
                    int index = this.GetFirstCharIndexFromLine(line);
                    if (index >= 0)
                    {
                        Point pt = this.GetPositionFromCharIndex(index);
                        // Si la ligne est visible
                        if (pt.Y < this.ClientSize.Height)
                        {
                            g.DrawLine(Pens.Red, 0, pt.Y, this.ClientSize.Width, pt.Y);
                        }
                    }
                }

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
                            // Tentative de calculer la hauteur réelle de la ligne
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
/// <summary>
/// Contrôle utilisateur combinant une marge et un éditeur (CustomRichTextBox).
/// Dans la marge, pour chaque ligne visible, on affiche :
/// - Le numéro de ligne (aligné à droite) dans une zone à gauche, qui se décale si des indicateurs sont présents.
/// - Une zone réservée (à droite) pour afficher un rond rouge (breakpoint) et/ou une flèche jaune (ligne d'exécution).
/// Le dessin se base sur la position réelle de chaque ligne dans le RichTextBox pour rester synchronisé.
/// </summary>
public class BreakpointEditor : UserControl
{
    private Panel marginPanel;
    private CustomRichTextBox richTextBox;
    // Collection de breakpoints partagée avec le CustomRichTextBox
    private HashSet<int> breakpoints = new HashSet<int>();
    // Numéro de la ligne en cours d'exécution (0-based, -1 si aucune)
    private int currentExecutionLine = -1;

    [DllImport("user32.dll")]
    private static extern int SendMessage(IntPtr hWnd, int msg, int wParam, int lParam);
    private const int EM_GETFIRSTVISIBLELINE = 0xCE;

    // Constantes pour la mise en page de la marge
    private const int totalMarginWidth = 60;  // largeur totale de la marge
    private const int markerAreaWidth = 20;   // largeur réservée aux indicateurs

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
        richTextBox.VScroll += (s, e) => { marginPanel.Invalidate(); richTextBox.Invalidate(); };
        richTextBox.TextChanged += (s, e) => { marginPanel.Invalidate(); richTextBox.Invalidate(); };

        this.Controls.Add(richTextBox);
        this.Controls.Add(marginPanel);
    }

    /// <summary>
    /// Au clic dans la marge, détermine la ligne cliquée (via la position réelle dans l'éditeur)
    /// et bascule son état de breakpoint.
    /// </summary>
    private void MarginPanel_MouseClick(object sender, MouseEventArgs e)
    {
        int firstVisibleLine = SendMessage(richTextBox.Handle, EM_GETFIRSTVISIBLELINE, 0, 0);
        // Pour déterminer la ligne cliquée, on parcourt les lignes visibles en fonction de leur position réelle.
        int clickedLine = firstVisibleLine;
        for (int line = firstVisibleLine; ; line++)
        {
            int charIndex = richTextBox.GetFirstCharIndexFromLine(line);
            if (charIndex < 0)
                break;
            Point pt = richTextBox.GetPositionFromCharIndex(charIndex);
            // Si la position Y de cette ligne dépasse la coordonnée du clic, c'est la ligne concernée.
            // On ajoute une tolérance égale à la moitié de la hauteur de la ligne.
            int lineHeight = GetLineHeight(line);
            if (e.Y < pt.Y + lineHeight)
            {
                clickedLine = line;
                break;
            }
        }

        if (breakpoints.Contains(clickedLine))
            breakpoints.Remove(clickedLine);
        else
            breakpoints.Add(clickedLine);

        marginPanel.Invalidate();
        richTextBox.Invalidate();
    }

    /// <summary>
    /// Méthode pour calculer la hauteur d'une ligne en se basant sur la position de la ligne suivante.
    /// En cas d'échec, on retourne la hauteur de la police.
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
    /// Dans la marge, on affiche pour chaque ligne visible, en se basant sur sa position réelle dans l'éditeur :
    /// - Le numéro de ligne (aligné à droite).
    /// - Une zone dédiée à droite pour le rond rouge (breakpoint) et/ou la flèche jaune (ligne d'exécution).
    /// Si un indicateur est présent, le numéro se décale vers la gauche afin de rester visible.
    /// </summary>
    private void MarginPanel_Paint(object sender, PaintEventArgs e)
    {
        int firstVisibleLine = SendMessage(richTextBox.Handle, EM_GETFIRSTVISIBLELINE, 0, 0);
        // Parcourir les lignes visibles à partir de la première
        for (int line = firstVisibleLine; ; line++)
        {
            int charIndex = richTextBox.GetFirstCharIndexFromLine(line);
            if (charIndex < 0)
                break;
            Point pt = richTextBox.GetPositionFromCharIndex(charIndex);
            // Si la ligne est en dessous de la zone de la marge, on arrête
            if (pt.Y > marginPanel.Height)
                break;
            int lineHeight = GetLineHeight(line);

            bool hasBreakpoint = breakpoints.Contains(line);
            bool isExecution = (line == currentExecutionLine);
            bool hasMarker = hasBreakpoint || isExecution;

            // Définir la zone pour le numéro :
            // Si un indicateur est présent, réserver markerAreaWidth à droite
            Rectangle numberRect = hasMarker ?
                new Rectangle(0, pt.Y, totalMarginWidth - markerAreaWidth, lineHeight) :
                new Rectangle(0, pt.Y, totalMarginWidth, lineHeight);

            // Afficher le numéro de ligne (1-based) aligné à droite
            string lineText = (line + 1).ToString();
            TextFormatFlags flags = TextFormatFlags.Right | TextFormatFlags.VerticalCenter | TextFormatFlags.NoPadding;
            TextRenderer.DrawText(e.Graphics, lineText, richTextBox.Font, numberRect, Color.Black, flags);

            // Dans la zone réservée, afficher les indicateurs si présents
            if (hasMarker)
            {
                Rectangle markerRect = new Rectangle(totalMarginWidth - markerAreaWidth, pt.Y, markerAreaWidth, lineHeight);
                if (hasBreakpoint && isExecution)
                {
                    // Diviser la zone en deux pour afficher les deux indicateurs côte à côte.
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
    /// Dessine un rond rouge centré dans le rectangle fourni.
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
    /// Méthode publique pour définir la ligne en cours d'exécution.
    /// Met à jour l'indicateur dans le CustomRichTextBox et dans la marge.
    /// </summary>
    /// <param name="line">Numéro de la ligne (0-based)</param>
    public void SetCurrentExecutionLine(int line)
    {
        currentExecutionLine = line;
        richTextBox.CurrentExecutionLine = line;
        marginPanel.Invalidate();
        richTextBox.Invalidate();
    }

    // Propriété d'accès à l'éditeur si besoin
    public CustomRichTextBox Editor => richTextBox;
}
#endregion
}