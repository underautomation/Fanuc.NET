using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace Subro.Controls
{
    /// <summary>
    /// The <see cref="DataGridViewGrouper"/> can work on its own. This control is used to provide a user interface for its functionality.
    /// </summary>
    public partial class DataGridViewGrouperControl : UserControl
    {
        public DataGridViewGrouperControl()
        {
            InitializeComponent();
        }

        private DataGridViewGrouper grouper;
        /// <summary>
        /// The grouper component used to do the actual grouping. If none is set or can be obtained, 
        /// a <see cref="DataGridViewGrouper"/>  is created when the <see cref="DataGridView"/> property is set        
        /// </summary>
        [DefaultValue(null)]
        public DataGridViewGrouper Grouper
        {
            get { return grouper; }
            set
            {
                if (grouper == value) return;
                if (!DesignMode)
                    cmbFields.Enabled = value != null;

                if (grouper != null)
                {
                    grouper.PropertiesChanged -= new EventHandler(GroupingSource_DataSourceChanged);
                    grouper.GroupingChanged -= new EventHandler(grouper_GroupingChanged);
                    if (grouperowned)
                    {
                        if (grouper is IDisposable)
                            (grouper as IDisposable).Dispose();
                        grouperowned = false;
                    }
                }
                grouper = value;
                if (grouper != null)
                {
                    grouper.PropertiesChanged += new EventHandler(GroupingSource_DataSourceChanged);
                    grouper.GroupingChanged += new EventHandler(grouper_GroupingChanged);
                }

                setprops();

                if (cm != null)
                    cm.Grouper = value;
            }
        }


        bool settingvalues;

        bool ShouldSerializeGrouper()
        {
            return grouper != null && !grouperowned;
        }

        bool grouperowned;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            Grouper = null;
            if (cm != null)
                cm.Dispose();
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        public override string Text
        {
            get
            {
                return chk.Text;
            }
            set
            {
                chk.Text = value;
            }
        }


        [DefaultValue(null)]
        public DataGridView DataGridView
        {
            get
            {                
                if (grouper != null)
                    return grouper.DataGridView;
                return null;
            }
            set
            {
                if (DataGridView == value) return;
                if (DataGridView != null)
                    DataGridView.DataSourceChanged -= value_DataSourceChanged;
                if (grouperowned || value == null)
                    Grouper = null;
                if (value != null)
                {
                    if (grouper != null)
                        grouper.DataGridView = value;
                    else if (value is IDataGridViewGrouperOwner)
                    {
                        Grouper = (value as IDataGridViewGrouperOwner).Grouper;
                        grouper.DataGridView = value;
                    }
                    else
                    {
                        Grouper = new DataGridViewGrouper(value);
                        grouperowned = true;
                    }

                }
            }
        }

        void value_DataSourceChanged(object sender, EventArgs e)
        {
            setprops();
        }




        public GroupingSource GroupingSource
        {
            get
            {
                if (grouper == null) return null;
                return grouper.GroupingSource;
            }
        }

        void setprops()
        {
            if (settingvalues) return;
            settingvalues = true;
            cmbFields.BeginUpdate();
            cmbFields.Items.Clear();


            try
            {
                if (grouper != null)
                {
                    IEnumerable<PropertyDescriptor> props = grouper.GetProperties();
                    if (props != null)
                    {
                        GroupingInfo cur = grouper.GroupOn;
                        foreach (PropertyDescriptor p in props)
                        {
                            cmbFields.Items.Add(p);
                            if (cur != null && cur.IsProperty(p.Name))
                                cmbFields.SelectedItem = p;
                        }
                    }
                }
                chk.Checked = grouper != null && grouper.GroupOn != null;
            }
            catch (Exception ex)
            {
                ShowEx(ex);
            }
            settingvalues = false;
            cmbFields.EndUpdate();
        }

        void ShowEx(Exception ex)
        {
            MessageBox.Show(ex.Message);
        }


        void grouper_GroupingChanged(object sender, EventArgs e)
        {
            if (settingvalues) return;
            settingvalues = true;
            try
            {
                GroupingInfo gr = grouper.GroupOn;
                chk.Checked = gr != null;
                if (chk.Checked)
                {
                    var prop = FindProperty(gr);
                    cmbFields.SelectedItem = prop;
                    if (prop == null)
                        cmbFields.Text = gr.ToString();
                }
                /*if (cm != null)cm.Grouper = dgvGrouper;*/
            }
            finally
            {
                settingvalues = false;
            }
        }

        public PropertyDescriptor FindProperty(GroupingInfo gr)
        {
            foreach (PropertyDescriptor pd in cmbFields.Items)
                if (gr.IsProperty(pd.Name)) return pd;
            return null;
        }

        public bool IsGrouped
        {
            get { return grouper != null && grouper.GroupOn != null; }
        }

        void GroupingSource_DataSourceChanged(object sender, EventArgs e)
        {
            setprops();
        }

        private void chk_CheckedChanged(object sender, EventArgs e)
        {
            setgroup();
        }

        private void cmbFields_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!chk.Checked) return;
            setgroup();
        }

        void setgroup()
        {
            if (settingvalues || grouper == null) return;
            settingvalues = true;
            if (!chk.Checked || cmbFields.SelectedItem == null)
                grouper.RemoveGrouping();
            else
            {
                PropertyDescriptor p = SelectedProperty;
                try
                {
                    grouper.SetGroupOn(p);
                    /*if (cm != null)cm.Grouper = dgvGrouper;*/
                }
                catch (Exception ex)
                {
                    ShowEx(new Exception("Error while grouping on " + p.Name + ": " + ex.Message, ex));
                }
            }
            settingvalues = false;
        }

        public PropertyDescriptor SelectedProperty
        {
            get
            {
                return (PropertyDescriptor)cmbFields.SelectedItem;
            }
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            try
            {
                Rectangle r = e.ClipRectangle;
                if (r.IsEmpty) return;
                ControlPaint.DrawButton(e.Graphics, r, down ? ButtonState.Pushed : ButtonState.Normal);

                if (down) r.Offset(1, 1);
                e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
                Point p = new Point(r.X + 2, r.Y + r.Height / 2 - 2);
                for (int i = 0; i < 2; i++)
                {
                    int w = r.Right - p.X - 4;
                    Point[] ps = { p, new Point(p.X + w / 2, p.Y + 2), new Point(p.X + w, p.Y) };
                    e.Graphics.DrawLines(Pens.Black, ps);
                    p.Y += 3;
                }
            }
            catch { }
        }


        protected override void OnMouseDown(MouseEventArgs e)
        {
            base.OnMouseDown(e);
            if (!down)
            {
                down = true;
                ContextMenuStrip.Show(this, new Point(Width, Height), ToolStripDropDownDirection.BelowLeft);
                Invalidate();
            }
        }

        DataGridViewGrouperContextMenuStrip cm;
        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public new DataGridViewGrouperContextMenuStrip ContextMenuStrip
        {
            get
            {
                if (cm == null)
                {
                    cm = new DataGridViewGrouperContextMenuStrip(grouper);
                    cm.Closed += new ToolStripDropDownClosedEventHandler(cm_Closed);
                }
                return cm;
            }
        }

        void cm_Closed(object sender, ToolStripDropDownClosedEventArgs e)
        {
            down = false;
            Invalidate();
        }


        bool down;


    }



    /// <summary>
    /// Encapsulates a <see cref="DataGridViewGrouperControl"/> in a <see cref="ToolStripItem"/>
    /// </summary>
    public class DataGridViewGrouperControlItem : ToolStripControlHost
    {
        public DataGridViewGrouperControlItem()
            : base(new DataGridViewGrouperControl())
        {
            DataGridViewGrouperControl.MinimumSize = new Size(150, 20);
        }

        public DataGridViewGrouperControl DataGridViewGrouperControl
        {
            get { return (DataGridViewGrouperControl)Control; }
        }

        [DefaultValue(null)]
        public DataGridView DataGridView
        {
            get
            {
                return DataGridViewGrouperControl.DataGridView;
            }
            set
            {
                DataGridViewGrouperControl.DataGridView = value;
            }
        }
    }
}
