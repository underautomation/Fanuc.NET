using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace Subro.Controls
{
    /// <summary>
    /// Add this component in runtime or designtime and assign a datagridview to it to enable grouping on that grid.
    /// You can also add an <see cref="DataGridViewGrouperControl"/> which will create its own grouper.
    /// </summary>
    [DefaultEvent("DisplayGroup")]
    public partial class DataGridViewGrouper : Component
    {
        public DataGridViewGrouper()
        {
            source.DataSourceChanged += new EventHandler(source_DataSourceChanged);
            source.Grouper = this;
        }

        public DataGridViewGrouper(DataGridView Grid)
            : this()
        {
            this.DataGridView = Grid;
        }

        public DataGridViewGrouper(IContainer Container)
            : this()
        {
            Container.Add(this);
        }


        private DataGridView grid;
        [DefaultValue(null)]
        public DataGridView DataGridView
        {
            get { return grid; }
            set
            {
                if (grid == value) return;

                if (grid != null)
                {
                    //grid.Sorted -= new EventHandler(grid_Sorted);
                    grid.RowPrePaint -= new DataGridViewRowPrePaintEventHandler(grid_RowPrePaint);
                    grid.RowPostPaint -= new DataGridViewRowPostPaintEventHandler(grid_RowPostPaint);
                    grid.CellBeginEdit -= new DataGridViewCellCancelEventHandler(grid_CellBeginEdit);
                    grid.CellDoubleClick -= new DataGridViewCellEventHandler(grid_CellDoubleClick);
                    grid.CellClick -= new DataGridViewCellEventHandler(grid_CellClick);
                    grid.MouseMove -= new MouseEventHandler(grid_MouseMove);
                    grid.SelectionChanged -= new EventHandler(grid_SelectionChanged);
                    grid.DataSourceChanged -= new EventHandler(grid_DataSourceChanged);
                    grid.AllowUserToAddRowsChanged -= new EventHandler(grid_AllowUserToAddRowsChanged);    
                }
                RemoveGrouping();
                selectedGroups.Clear();
                grid = value;

                if (grid != null)
                {
                    //grid.Sorted += new EventHandler(grid_Sorted);
                    grid.RowPrePaint += new DataGridViewRowPrePaintEventHandler(grid_RowPrePaint);
                    grid.RowPostPaint += new DataGridViewRowPostPaintEventHandler(grid_RowPostPaint);
                    grid.CellBeginEdit += new DataGridViewCellCancelEventHandler(grid_CellBeginEdit);
                    grid.CellDoubleClick += new DataGridViewCellEventHandler(grid_CellDoubleClick);
                    grid.CellClick += new DataGridViewCellEventHandler(grid_CellClick);
                    grid.MouseMove += new MouseEventHandler(grid_MouseMove);
                    grid.SelectionChanged += new EventHandler(grid_SelectionChanged);
                    grid.DataSourceChanged += new EventHandler(grid_DataSourceChanged);
                    grid.AllowUserToAddRowsChanged += new EventHandler(grid_AllowUserToAddRowsChanged);       
                }
            }
        }


        void grid_AllowUserToAddRowsChanged(object sender, EventArgs e)
        {
            source.CheckNewRow();
        }




        #region Select /  Collapse/Expand


        Point capturedcollapsebox = new Point(-1, -1);

        void grid_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.X < HeaderOffset && e.X >= HeaderOffset - collapseboxwidth)
            {
                DataGridView.HitTestInfo ht = grid.HitTest(e.X, e.Y);
                if (IsGroupRow(ht.RowIndex))
                {
                    var y = e.Y - ht.RowY;

                    if (y >= CollapseBox_Y_Offset && y <= CollapseBox_Y_Offset + collapseboxwidth)
                    {
                        checkcollapsedfocused(ht.ColumnIndex, ht.RowIndex);
                        return;
                    }
                }
            }            
            checkcollapsedfocused(-1, -1);

        }

        void InvalidateCapturedBox()
        {
            if (capturedcollapsebox.Y == -1) return;
            try
            {
                grid.InvalidateCell(capturedcollapsebox.X, capturedcollapsebox.Y);
            }
            catch
            {
                capturedcollapsebox = new Point(-1, -1);
            }
        }

        void checkcollapsedfocused(int col, int row)
        {
            if (capturedcollapsebox.X != col || capturedcollapsebox.Y != row)
            {
                InvalidateCapturedBox();
                capturedcollapsebox = new Point(col, row);
                InvalidateCapturedBox();
            }
        }


        void grid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1) return;
            if (e.RowIndex == capturedcollapsebox.Y)
            {
                var gr = GetGroupRow(e.RowIndex);
                gr.Collapsed = !gr.Collapsed;
            }
        }

        /// <summary>
        /// selected group rows are kept seperately in order to invalidate the entire row
        /// and not just one cell when the selection is changed
        /// </summary>
        List<int> selectedGroups = new List<int>();

        void grid_SelectionChanged(object sender, EventArgs e)
        {
            if (selectionset)
            {
                selectionset = false;
                invalidateselected();
            }
        }

        bool selectionset;
        void setselection()
        {
            //invalidateselected();

            selectionset = true;
            selectedGroups.Clear();
            foreach (DataGridViewCell c in grid.SelectedCells)
                if (IsGroupRow(c.RowIndex))
                    if (!selectedGroups.Contains(c.RowIndex))
                        selectedGroups.Add(c.RowIndex);
            invalidateselected();
        }

        
        void invalidateselected()
        {
            if (selectedGroups.Count == 0 || grid.SelectionMode == DataGridViewSelectionMode.FullRowSelect) return;
            int count = grid.Rows.Count;
            foreach (int i in selectedGroups)
                if (i < count)
                    grid.InvalidateRow(i);
        }
        
       

        public void ExpandAll()
        {
            source.CollapseExpandAll(false);
        }

        public void CollapseAll()
        {
            source.CollapseExpandAll(true);
        }


        void grid_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (IsGroupRow(e.RowIndex) && capturedcollapsebox.Y != e.RowIndex && Options.SelectRowsOnDoubleClick)
            {
                var gr = GetGroupRow(e.RowIndex);
                gr.Collapsed = false;                
                grid.SuspendLayout();
                grid.CurrentCell = grid[1, e.RowIndex + 1];
                grid.Rows[e.RowIndex].Selected = false;
                SelectGroup(e.RowIndex);
                grid.ResumeLayout();
            }
        }

        GroupRow GetGroupRow(int RowIndex)
        {
            return (GroupRow)source.Groups.Rows[RowIndex];
        }

        IEnumerable<DataGridViewRow> GetRows(int index)
        {
            var gr = GetGroupRow(index);
            
            for (int i = 0; i < gr.Count; i++)
            {
                yield return grid.Rows[++index];
            }
            
        }

        void SelectGroup(int offset)
        {
            foreach (DataGridViewRow row in GetRows(offset))
                row.Selected = true;
        }



        #endregion


        public GroupList Groups
        {
            get
            {
                return source.Groups;
            }
        }

        public bool IsGroupRow(int RowIndex)
        {
            return source.IsGroupRow(RowIndex);
        }

        void source_DataSourceChanged(object sender, EventArgs e)
        {
            OnPropertiesChanged();
        }

        void OnPropertiesChanged()
        {
            if (PropertiesChanged != null)
                PropertiesChanged(this, EventArgs.Empty);
        }

        public event EventHandler PropertiesChanged;

        public IEnumerable<PropertyDescriptor> GetProperties()
        {
            foreach (PropertyDescriptor pd in source.GetItemProperties(null))
                yield return pd;
        }

        void grid_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            if (IsGroupRow(e.RowIndex))
                e.Cancel = true;
        }

        protected override void Dispose(bool disposing)
        {
            DataGridView = null;
            source.Dispose();
            base.Dispose(disposing);
        }
        /*
        void grid_Sorted(object sender, EventArgs e)
        {
            ResetGrouping();
        }*/

        readonly GroupingSource source = new GroupingSource();

        public GroupingSource GroupingSource
        {
            get
            {
                return source;
            }
        }

        void grid_DataSourceChanged(object sender, EventArgs e)
        {
            if (!GridUsesGroupSource)
            {
                try
                {
                    source.DataSource = grid.DataSource;
                }
                catch
                {
                    source.RemoveGrouping();
                }
            }
        }

        public bool RemoveGrouping()
        {
            if (GridUsesGroupSource)
                try
                {
                    grid.DataSource = source.DataSource;
                    grid.DataMember = source.DataMember;
                    source.RemoveGrouping();
                    return true;
                }
                catch { }
            return false;
        }


        public event EventHandler GroupingChanged
        {
            add { source.GroupingChanged += value; }
            remove { source.GroupingChanged -= value; }
        }


        bool GridUsesGroupSource
        {
            get
            {
                return grid != null && grid.DataSource == source;
            }
        }

        public void ResetGrouping()
        {
            if (!GridUsesGroupSource) return;
            this.capturedcollapsebox = new Point(-1, -1);
            source.ResetGroups();
        }


        [DefaultValue(null)]
        public GroupingInfo GroupOn
        {
            get
            {
                return source.GroupOn;
            }
            set
            {
                if (GroupOn == value) return;
                if (value == null)
                    RemoveGrouping();
                else
                    CheckSource().GroupOn = value;
            }
        }

        public bool IsGrouped
        {
            get
            {
                return source.IsGrouped;
            }
        }

        [DefaultValue(SortOrder.Ascending)]
        public SortOrder GroupSortOrder
        {
            get
            {
                return source.GroupSortOrder;
            }
            set
            {
                source.GroupSortOrder = value;
            }
        }

        [DefaultValue(null)]
        public GroupingOptions Options
        {
            get { return source.Options; }
            set { source.Options = value; }
        }


        public bool SetGroupOn(DataGridViewColumn col)
        {
            return SetGroupOn(col == null ? null : col.DataPropertyName);
        }

        public bool SetGroupOn(PropertyDescriptor Property)
        {
            return CheckSource().SetGroupOn(Property);
        }

        public void SetCustomGroup<T>(Func<T,object> GroupValueProvider, string Description = null)
        {
            CheckSource().SetCustomGroup(GroupValueProvider, Description);
        }

        public void SetGroupOnStartLetters(GroupingInfo g, int Letters)
        {
            CheckSource().SetGroupOnStartLetters(g, Letters);
        }

        public void SetGroupOnStartLetters(string Property, int Letters)
        {
            CheckSource().SetGroupOnStartLetters(Property, Letters);
        }

        public bool SetGroupOn(string Name)
        {
            if (string.IsNullOrEmpty(Name))
                return RemoveGrouping();
            return CheckSource().SetGroupOn(Name);
        }

        //added after linq was added to the framework to facilitate setting properties
        public bool SetGroupOn<T>(System.Linq.Expressions.Expression<Func<T, object>> Property)
        {
            if (Property == null)
                return RemoveGrouping();
            return CheckSource().SetGroupOn(Parser.GetFieldName(Property));
        }

        public PropertyDescriptor GetProperty(string Name)
        {
            return CheckSource().GetProperty(Name);
        }

        /// <summary>
        /// Ensures the datagridview uses the groupingsource as its datasource
        /// </summary>
        /// <returns></returns>
        GroupingSource CheckSource()
        {
            if (grid == null)
                throw new Exception("No target datagridview set");

            if (!GridUsesGroupSource)
            {
                source.DataSource = grid.DataSource;
                source.DataMember = grid.DataMember;
                grid.DataSource = source;
            }
            return source;
        }

        #region Painting

        void grid_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            if (IsGroupRow(e.RowIndex))
            {
                e.Handled = true;
                PaintGroupRow(e);                
            }
        }

        const int collapseboxwidth = 10;
        const int lineoffset = collapseboxwidth / 2;

        int HeaderOffset
        {
            get
            {
                if (grid.RowHeadersVisible) return grid.RowHeadersWidth;
                return lineoffset * 4;
            }
        }

        Pen linepen = Pens.SteelBlue;

        bool DrawExpandCollapseLines
        {
            get
            {
                return grid.RowHeadersVisible;
            }
        }

        void grid_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            if (!DrawExpandCollapseLines || e.RowIndex >= source.Count || source.GroupOn == null) return;
            int next = e.RowIndex + 1;

            int r = grid.RowHeadersWidth;
            int x = HeaderOffset - lineoffset;
            int y = e.RowBounds.Top + e.RowBounds.Height / 2;
            e.Graphics.DrawLine(linepen, x, y, r, y);

            if (next < source.Count && !IsGroupRow(next))
                y = e.RowBounds.Bottom;

            e.Graphics.DrawLine(linepen, x, e.RowBounds.Top, x, y);


        }

        /// <summary>
        /// This event is fired when the group row has to be painted and the display values are requested
        /// </summary>
        public event EventHandler<GroupDisplayEventArgs> DisplayGroup
        {
            add { source.DisplayGroup += value; }
            remove { source.DisplayGroup -= value; }
        }

        public DataGridViewGrouper this[int GroupIndex]
        {
            get { return (DataGridViewGrouper)source[GroupIndex]; }
        }

        void PaintGroupRow(DataGridViewRowPrePaintEventArgs e)
        {
            var grouprow = (GroupRow)source[e.RowIndex];
            if (!selectionset)
            {
                setselection();
            }
            var info = grouprow.GetDisplayInfo(selectedGroups.Contains(e.RowIndex));
            if (info == null || info.Cancel) return; //cancelled

            if (info.Font == null)
                info.Font = e.InheritedRowStyle.Font;
            var r = e.RowBounds;
            r.Height--;
            
            using (var bgb = new SolidBrush(info.BackColor))
            {
                //line under the group row
                e.Graphics.DrawLine(Pens.SteelBlue, r.Left, r.Bottom, r.Right, r.Bottom);



                //group value
                {
                    int l = HeaderOffset + 1;
                    r.X = l - grid.HorizontalScrollingOffset;
                    

                    //clear background
                    e.Graphics.FillRectangle(bgb, r);

                    using (var fb = new SolidBrush(info.ForeColor))
                    {
                        var sf = new StringFormat { LineAlignment = StringAlignment.Center };
                        if (info.Header != null)
                        {
                            var size = e.Graphics.MeasureString(info.Header, info.Font);
                            e.Graphics.DrawString(info.Header, info.Font, fb, r, sf);
                            r.X += (int)size.Width + 5;
                        }

                        if (info.DisplayValue != null)
                        {
                            using (var f = new Font(info.Font.FontFamily, info.Font.Size + 2, FontStyle.Bold))
                            {
                                var size = e.Graphics.MeasureString(info.DisplayValue, f);
                                e.Graphics.DrawString(info.DisplayValue, f, fb, r, sf);
                                r.X += (int)size.Width + 10;
                            }
                        }
                        if (info.Summary != null)
                        {
                            e.Graphics.DrawString(info.Summary, info.Font, fb, r, sf);
                        }
                    }
                    

                    e.Graphics.FillRectangle(bgb, 0, r.Top, l, r.Height);
                        
                }
            }

            //collapse/expand symbol               
            {

                var cer = GetCollapseBoxBounds(e.RowBounds.Y);

                if (capturedcollapsebox.Y == e.RowIndex)
                    e.Graphics.FillEllipse(Brushes.Yellow, cer);
                e.Graphics.DrawEllipse(linepen, cer);
                bool collapsed = grouprow.Collapsed;
                int cx;

                if (DrawExpandCollapseLines && !collapsed)
                {
                    cx = HeaderOffset - lineoffset;
                    e.Graphics.DrawLine(linepen, cx, cer.Bottom, cx, r.Bottom);
                }
                cer.Inflate(-2, -2);
                var cy = cer.Y + cer.Height / 2;
                e.Graphics.DrawLine(linepen, cer.X, cy, cer.Right, cy);
                if (collapsed)
                {
                    cx = cer.X + cer.Width / 2;
                    e.Graphics.DrawLine(linepen, cx, cer.Top, cx, cer.Bottom);
                }
            }

        }



        const int CollapseBox_Y_Offset = 5;

        private Rectangle GetCollapseBoxBounds(int Y_Offset)
        {
            return new Rectangle(HeaderOffset - collapseboxwidth, Y_Offset + CollapseBox_Y_Offset, collapseboxwidth, collapseboxwidth);
        }

        #endregion

        public bool CurrentRowIsGroupRow
        {
            get
            {
                if (grid == null) return false;
                return IsGroupRow(grid.CurrentCellAddress.Y);
            }
        }

        [DefaultValue(null)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public GroupRow CurrentGroup
        {
            get
            {
                return source.CurrentGroup;
            }
            set
            {
                source.CurrentGroup = value;
            }
        }
    }

    public class GroupDisplayEventArgs : CancelEventArgs
    {
        /// <summary>
        /// Contains the details of the grouping information being displayed 
        /// </summary>
        public readonly GroupRow Group;
        public readonly GroupingInfo GroupingInfo;
        public GroupDisplayEventArgs(GroupRow Row, GroupingInfo Info)
        {
            this.Group = Row;
            this.GroupingInfo = Info;
        }
        /// <summary>
        /// Returns the grouping value for the row being drawn
        /// </summary>
        public object Value { get { return Group.Value; } }
        /// <summary>
        /// Gets or sets the value being displayed (after header)
        /// </summary>
        public string DisplayValue { get; set; }
        /// <summary>
        /// The header normally contains the property/grouper name, it can be changed here
        /// </summary>
        public string Header { get; set; }
        /// <summary>
        /// The summary is the smaller value displayed between () after the <see cref="DisplayValue"/>. 
        /// With default settings this contains the rowcount
        /// </summary>
        public string Summary { get; set; }
        public Color BackColor { get; set; }
        public Color ForeColor { get; set; }
        public Font Font { get; set; }
        /// <summary>
        /// Indicates if the row begin displayed is currently selected
        /// </summary>
        public bool Selected { get; internal set; }

        public override string ToString()
        {
            if (Summary == null)
                return DisplayValue;
            return string.Format("{0}   {1}", DisplayValue, Summary);            
        }

        /// <summary>
        /// Same as <see cref="Group"/>. Added for backward compatibility
        /// </summary>
        public GroupRow Row { get { return Group; } }
    }

    public interface IDataGridViewGrouperOwner
    {
        DataGridViewGrouper Grouper { get; }
    }
}



