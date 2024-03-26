using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using System.Windows.Forms;
using System.Drawing;

namespace Subro.Controls
{
    public partial class DataGridViewGrouperContextMenuStrip : ContextMenuStrip
    {
        public readonly ToolStripMenuItem
            CollapseAllItem,
            ExpandAllItem,
            RemoveGroupingItem,
            GroupOnMenuItem,
            OverViewMenuItem,
            SortMenuItem,
            OptionsMenuItem;

        public DataGridViewGrouperContextMenuStrip(DataGridViewGrouper Grouper)
            : this()
        {
            this.Grouper = Grouper;
        }

        partial void GetText(string keyword, ref string Value);

        public DataGridViewGrouperContextMenuStrip()
        {
            CollapseAllItem = Add("CollapseAll", "Collapse all", collapse);
            ExpandAllItem = Add("ExpandAll", "Expand all", expand);

            GroupOnMenuItem = Add("Grouping style", null);
            GroupOnMenuItem.DropDown.ItemClicked += new ToolStripItemClickedEventHandler(GroupOnDropDown_ItemClicked);
            AddGroupOnItem("Force as text", () => new StringGroupWrapper(grouper.GroupOn));
            AddGroupOnItem("First letter", () => new StartLetterGrouper(grouper.GroupOn));
            AddGroupOnItem("First word", () => new FirstWordGrouper(grouper.GroupOn));
            AddGroupOnItem("Last word", () => new LastWordGrouper(grouper.GroupOn));

            SortMenuItem = Add("Sort groups", null);
            foreach (SortOrder s in Enum.GetValues(typeof(SortOrder)))
                AddSortItem(s);
            SortMenuItem.DropDown.ItemClicked += new ToolStripItemClickedEventHandler(SortDropDown_ItemClicked);


            OptionsMenuItem = Add("OtherOptions", "Other Options", null);
            AddOption("Start collapsed", GroupingOption.StartCollapsed);
            AddOption("Always group on text value", GroupingOption.AlwaysGroupOnText);
            OptionsMenuItem.DropDownItems.Add(new ToolStripSeparator());
            AddOption("Show row counts", GroupingOption.ShowCount);
            AddOption("Show group field names", GroupingOption.ShowGroupName);
            AddOption("Select rows if double clicked on header", GroupingOption.SelectRowsOnDoubleClick);

            Items.Add(new ToolStripSeparator());
            OverViewMenuItem = Add("JumpGroup", "Jump to ...", jumptogroup);
            Items.Add(new ToolStripSeparator());
            RemoveGroupingItem = Add("RemoveGroup", "Remove grouping", RemoveGrouping);
        }

        void SortDropDown_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            var item = e.ClickedItem as SortItem;
            if (item == null) return;
            grouper.Options.GroupSortOrder = item.SortOrder;
        }

        void GroupOnDropDown_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            var item = e.ClickedItem as GroupOnItem;
            if (item == null) return;
            var cur = grouper.GroupOn;
            if (item.EqualsInfo(cur))
            {
                if (cur is GroupWrapper)
                    grouper.GroupOn = ((GroupWrapper)cur).Grouper;
                item.Checked = false;
            }
            else
            {
                grouper.GroupOn = item.CreateInfo();
                item.Checked = true;
            }
        }



        void jumptogroup(object sender, EventArgs e)
        {

            var f = new FormJumpTo(Grouper);
            //f.MakeDialogForm(MessageBoxButtons.OK);
            f.Show(this);
        }

        class FormJumpTo : Form
        {

            public readonly DataGridViewGrouper Grouper;
            DataGridView GrouperGrid;
            DataGridView dg = new DataGridView();
            public FormJumpTo(DataGridViewGrouper Grouper)
            {
                this.Grouper = Grouper;
                this.GrouperGrid = Grouper.DataGridView;


                dg.AutoGenerateColumns = false;
                dg.Columns.Add(new DataGridViewTextBoxColumn()
                {
                    DataPropertyName = "Value",
                    HeaderText = "Group",
                    AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill,
                    ReadOnly = true
                });
                dg.Columns.Add(new DataGridViewTextBoxColumn()
                {
                    DataPropertyName = "Count",
                    Width = 60,
                    ReadOnly = true
                });
                dg.Columns.Add(new DataGridViewCheckBoxColumn()
                {
                    DataPropertyName = "Collapsed",
                    HeaderText = "Collapse",
                    Width = 60
                });

                dg.AllowUserToAddRows = false;
                dg.AllowUserToDeleteRows = false;

                ClientSize = new Size(400, 400);

                dg.Dock = DockStyle.Fill;

                Controls.Add(dg);
                Controls.Add(new DataGridSearchBox() { DataGridView = dg, Dock = DockStyle.Top, ShowOptionsButton = true });
                dg.CreateControl();



            }

            void setdata()
            {
                var groups = Grouper.GroupingSource.Groups;
                var arr = groups == null ? null : groups.ToArray();
                settingcur = true;
                try
                {
                    dg.DataSource = arr;
                }
                finally
                {
                    settingcur = false;
                }
                dg.Enabled = arr != null;
                syncwithdg();
            }

            protected override void OnClosing(CancelEventArgs e)
            {
                Grouper.GroupingChanged -= new EventHandler(Grouper_GroupingChanged);
                GrouperGrid.CurrentCellChanged -= new EventHandler(GrouperGrid_CurrentCellChanged);
                base.OnClosing(e);
            }


            protected override void OnLoad(EventArgs e)
            {
                base.OnLoad(e);

                dg.CurrentCellChanged += new EventHandler(dg_CurrentCellChanged);
                dg.CellDoubleClick += new DataGridViewCellEventHandler(dg_CellDoubleClick);
                GrouperGrid.CurrentCellChanged += new EventHandler(GrouperGrid_CurrentCellChanged);
                Grouper.GroupingChanged += new EventHandler(Grouper_GroupingChanged);
                setdata();
            }

            void Grouper_GroupingChanged(object sender, EventArgs e)
            {
                setdata();
            }

            void GrouperGrid_CurrentCellChanged(object sender, EventArgs e)
            {
                syncwithdg();
            }

            void dg_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
            {
                SelectCurrent();
                DialogResult = DialogResult.OK;
                Close();
            }

            void syncwithdg()
            {
                if (settingcur) return;
                var gr = Grouper.GroupingSource.CurrentGroup;
                if (gr == null) return;
                int pos = Grouper.GroupingSource.Groups.IndexOf(gr);
                if (dg.CurrentCellAddress.Y == pos) return;
                settingcur = true;
                try
                {
                    dg.CurrentCell = dg[0, pos];
                }
                catch { }
                finally
                {
                    settingcur = false;
                }
            }

            void dg_CurrentCellChanged(object sender, EventArgs e)
            {
                SelectCurrent();
            }

            bool settingcur;
            public void SelectCurrent()
            {
                if (settingcur) return;
                settingcur = true;
                try
                {
                    Grouper.GroupingSource.CurrentGroup = Current;
                }
                finally
                {
                    settingcur = false;
                }
            }

            public GroupRow Current
            {
                get { return (GroupRow)dg.CurrentRow.DataBoundItem; }
            }
        }


        private DataGridViewGrouper grouper;

        public DataGridViewGrouper Grouper
        {
            get { return grouper; }
            set { grouper = value; }
        }

        protected override void OnOpening(CancelEventArgs e)
        {
            Initialize();
            base.OnOpening(e);
        }

        public void Initialize()
        {
            bool hasgrouper = grouper != null;
            bool isgrouped = hasgrouper && grouper.IsGrouped;
            CollapseAllItem.Enabled = isgrouped;
            ExpandAllItem.Enabled = isgrouped;
            RemoveGroupingItem.Enabled = isgrouped;
            GroupOnMenuItem.Enabled = isgrouped;
            OverViewMenuItem.Enabled = isgrouped;
            SortMenuItem.Enabled = hasgrouper;
            OptionsMenuItem.Enabled = hasgrouper;

            if (hasgrouper)
            {
                var sort = grouper.Options.GroupSortOrder;
                foreach (var si in GetSortItems())
                    si.Checked = si.SortOrder == sort;

                foreach (var m in OptionsMenuItem.DropDownItems)
                    if (m is booloption)
                        ((booloption)m).Init();
            }

            if (isgrouped)
            {
                var cur = grouper.GroupOn;
                foreach (var item in this.GetGroupOnItems())
                    item.Checked = item.EqualsInfo(cur);
            }

        }

        ToolStripMenuItem Add(string txt)
        {
            return Add(txt, null);
        }

        ToolStripMenuItem Add(string txt, EventHandler onClick)
        {
            return Add(null, txt, onClick);
        }

        ToolStripMenuItem Add(string kw, string txt, EventHandler onClick)
        {
            if (kw != null) GetText(kw, ref txt);
            return Add(txt, onClick, Items);
        }

        ToolStripMenuItem Add(string txt, EventHandler onClick, ToolStripItemCollection Items)
        {
            ToolStripMenuItem m = new ToolStripMenuItem(txt, null, onClick);
            Items.Add(m);
            return m;
        }

        booloption AddOption(string txt, GroupingOption o)
        {
            var res = new booloption(o);
            res.Text = txt;
            res.Strip = this;
            OptionsMenuItem.DropDownItems.Add(res);
            return res; 
        }

        void expand(object sender, EventArgs e)
        {
            Grouper.GroupingSource.CollapseExpandAll(false);
        }

        void collapse(object sender, EventArgs e)
        {
            Grouper.GroupingSource.CollapseExpandAll(true);
        }

        void RemoveGrouping(object sender, EventArgs e)
        {
            Grouper.GroupOn = null;
        }

        public ToolStripMenuItem AddGroupOnItem<T>(string Text, Func<T> Creator)
            where T : GroupingInfo
        {
            var mi = new GroupOnItem<T>();
            mi.Text = Text;
            mi.CreateInfoDelegate = Creator;
            GroupOnMenuItem.DropDownItems.Add(mi);
            return mi;
        }

        public IEnumerable<GroupOnItem> GetGroupOnItems()
        {
            foreach (var item in GroupOnMenuItem.DropDownItems)
                if (item is GroupOnItem)
                    yield return (GroupOnItem)item;
        }

        public abstract class GroupOnItem : ToolStripMenuItem
        {
            public virtual GroupingInfo CreateInfo()
            {
                return (GroupingInfo)Activator.CreateInstance(GroupInfoType);
            }

            public abstract Type GroupInfoType { get; }

            public virtual bool EqualsInfo(GroupingInfo g)
            {
                return GroupInfoType.IsAssignableFrom(g.GetType());
            }
        }

        public class GroupOnItem<T> : GroupOnItem
            where T : GroupingInfo
        {
            public override Type GroupInfoType
            {
                get { return typeof(T); }
            }

            public Func<T> CreateInfoDelegate;


            public override GroupingInfo CreateInfo()
            {
                if (CreateInfoDelegate == null)
                    return base.CreateInfo();
                return CreateInfoDelegate();
            }

            public override bool EqualsInfo(GroupingInfo g)
            {
                return g is T;
            }
        }



        public IEnumerable<SortItem> GetSortItems()
        {
            foreach (var item in SortMenuItem.DropDownItems)
                if (item is SortItem)
                    yield return (SortItem)item;
        }

        public class SortItem : ToolStripMenuItem
        {
            public readonly SortOrder SortOrder;
            public SortItem(SortOrder SortOrder)
            {
                this.SortOrder = SortOrder;
                this.Text = SortOrder.ToString();
            }
        }

        SortItem AddSortItem(SortOrder s)
        {
            var si = new SortItem(s);
            SortMenuItem.DropDownItems.Add(si);
            return si;
        }


        class booloption : ToolStripMenuItem
        {
            
            public readonly GroupingOption Option;
            public booloption(GroupingOption Option)
            {
                this.Option = Option;

            }

            internal DataGridViewGrouperContextMenuStrip Strip;
            GroupingOptionValue<bool> GetOption()
            {
                return (GroupingOptionValue<bool>)Strip.grouper.Options[Option];
            }

            protected override void OnClick(EventArgs e)
            {
                base.OnClick(e);
                var o = GetOption();
                Checked = !Checked;
                o.Value = Checked;
            }

            public void Init()
            {
                Checked = GetOption().Value;
            }
        }
    }
}
