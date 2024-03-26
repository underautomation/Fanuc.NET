using System;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Text;

namespace Subro.Controls
{
    [DefaultEvent("GroupingChanged")]
    public partial class GroupingSource : BindingSource,ICancelAddNew
    {
        public GroupingSource()            
        {
            
        }
        public GroupingSource(object DataSource)
            : this()
        {
            this.DataSource = DataSource;
        }

        public GroupingSource(object DataSource, string GroupOn)
            : this(DataSource)
        {
        }

        GroupingInfo groupon;

        [DefaultValue(null)]
        public GroupingInfo GroupOn
        {
            get
            {
                return groupon;
            }
            set
            {
                if (groupon == value) return;

                if (value == null)
                    RemoveGrouping();
                else
                {
                    if (value.Equals(groupon)) return;
                    setgroupon(value, Options.AlwaysGroupOnText);
                }
            }
        }

        void setgroupon(GroupingInfo value,bool forcetext)
        {
            info = null;
            if (forcetext && value.GroupValueType != typeof(string))
            {
                value = new StringGroupWrapper(value);
            }
            groupon = value;
            OnListChanged(new ListChangedEventArgs(ListChangedType.Reset, -1));
            OnGroupingChanged();
        }

        public bool IsGrouped
        {
            get { return groupon != null; }
        }

        internal DataGridViewGrouper Grouper;

        public void RemoveGrouping()
        {
            if (groupon == null ) return;
            groupon = null;
            ResetGroups();
            OnGroupingChanged();
        }

        public bool SetGroupOn(string Property)
        {
            return SetGroupOn(GetProperty(Property));
        }

        public PropertyDescriptor GetProperty(string Name)
        {
            var pd = this.GetItemProperties(null)[Name];
            if (pd == null)
                throw new Exception(Name + " is not a valid property");
            return pd;
        }

        public bool SetGroupOn(PropertyDescriptor p)
        {
            if (p == null) throw new ArgumentNullException();
            if (groupon == null || !groupon.IsProperty(p))
            {
                GroupOn = new PropertyGrouper(p);
                return true;
            }
            return false;
        }

        public void SetCustomGroup<T>(Func<T, object> GroupValueProvider, string Description = null)
        {
            if (GroupValueProvider == null) throw new ArgumentNullException();
            GroupOn = new DelegateGrouper<T>(GroupValueProvider, Description);
        }

        public void SetGroupOnStartLetters(GroupingInfo g, int Letters)
        {
            GroupOn = new StartLetterGrouper(g, Letters);
        }
        public void SetGroupOnStartLetters(string Property, int Letters)
        {
            SetGroupOnStartLetters(GetProperty(Property), Letters);
        }

        public bool IsGroupRow(int Index)
        {
            if (info == null) return false;
            if (Index < 0 || Index >= Count) return false;
            return info.Rows[Index] is GroupRow;
        }


        public void CollapseExpandAll(bool collapse)
        {
            if (Groups == null) return;
            var cur = CurrentGroup;
            Groups.CollapseExpandAll(collapse);
            if (cur != null)
                try
                {
                    CurrentGroup = cur;
                }catch{}
        }


        
        [DefaultValue(GroupingOptions.DefaultGroupSortOrder)]
        public SortOrder GroupSortOrder
        {
            get
            {
                if (options == null) return GroupingOptions.DefaultGroupSortOrder;
                return options.GroupSortOrder;
            }
            set
            {
                Options.GroupSortOrder = value;
            }
        }

        GroupingOptions options;
        [DefaultValue(null)]
        public GroupingOptions Options
        {
            get
            {
                if (options == null && !DesignMode)
                    Options = new GroupingOptions();
                return options;
            }
            set
            {
                if (options == value) return;
                var cursort = GroupSortOrder;
                if (options != null)                
                {
                    options.OptionChanged -= new EventHandler<GroupingOptionChangedEventArgs>(options_OptionChanged);
                    cursort = options.GroupSortOrder;
                }                
                options = value;
                if (options != null)
                {                    
                    options.OptionChanged += new EventHandler<GroupingOptionChangedEventArgs>(options_OptionChanged);
                }
                if (GroupSortOrder != cursort)
                    sort();
            }
        }

        void options_OptionChanged(object sender, GroupingOptionChangedEventArgs e)
        {

            if (!shouldreset) return;
            if (e.Option ==  GroupingOption.GroupSortOrder)
                sort();
            else if (e.Option == GroupingOption.AlwaysGroupOnText)
            {
                setgroupontext();
            }
            else if (e.Option == GroupingOption.StartCollapsed)
            {
                CollapseExpandAll(options.StartCollapsed);
            }
            else if (e.Option == GroupingOption.ShowCount
                || e.Option == GroupingOption.ShowGroupName)
            {
                if (Grid != null)
                    InvalidateGridGroupRows();
            }
        }

        void InvalidateGridGroupRows()
        {
            var grid = Grid;
            foreach (var gr in info.Groups)
                grid.InvalidateRow(gr.Index);
        }

        void setgroupontext()
        {
            var istext = groupon.GroupValueType == typeof(string);
            if (istext == options.AlwaysGroupOnText) return;
            if (istext)
            {
                if (groupon is StringGroupWrapper)
                    GroupOn = ((StringGroupWrapper)groupon).Grouper;
            }
            else
                setgroupon(groupon, true);
        }

        void sort()
        {
            if (info == null) return;
            if (GroupSortOrder == SortOrder.None)
                reset(false);
            else
                info.Sort();  
        }


        [DefaultValue(null)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public GroupRow CurrentGroup
        {
            get
            {
                return GetGroup(Position);
            }
            set
            {
                if (value == null)
                    throw new ArgumentNullException();
                Position = value.Index;                
                if (!value.Collapsed)
                {
                    Position++;
                }
            }
        }

        public GroupRow GetGroup(int RowIndex)
        {
            if (RowIndex == -1 || Groups == null) return null;
            return Groups.GetByRow(RowIndex);
        }

        public GroupList Groups
        {
            get
            {
                return Info.Groups;
            }
        }

        internal void CheckNewRow()
        {
            if (shouldreset)
                info.Groups.CheckNewRow(true);
        }

        class NullValue
        {
            public override string ToString()
            {
                return "<Null>";
            }

            public static readonly NullValue Instance = new NullValue();
        }



        class GroupInfo
        {
            public readonly GroupingSource Owner;


            public GroupInfo(GroupingSource Owner)
            {
                this.Owner = Owner;

                set();
            }

            public IList Rows;
            //public List<GroupRow> Groups = new List<GroupRow>();

            public GroupList Groups;




            void set()
            {
                Groups = null;

                if (Owner.groupon == null)
                {
                    Rows = Owner.List;
                    return;
                }

                Groups = new GroupList(Owner);

                Rows = Groups.Fill();
            }

            public void ReBuild()
            {
                if (Groups == null)
                    set();
                else
                    Groups.Fill();
            }

            public void Sort()
            {
                if (Groups == null) return;
                Groups.Sort(Owner.GroupSortOrder);
            }
        }



        GroupInfo info;

        GroupInfo Info
        {
            get
            {
                if (info == null)
                {
                    info = new GroupInfo(this);
                    if (NeedSync)
                        SyncCurrencyManagers();
                }
                return info;
            }
        }

        void OnGroupingChanged()
        {
            if (GroupingChanged != null)
                GroupingChanged(this, EventArgs.Empty);
        }

        public event EventHandler GroupingChanged;


        internal DataGridView Grid
        {
            get
            {
                if (Grouper == null) return null;
                return Grouper.DataGridView;
            }
        }

        public void ResetGroups()
        {
            reset(false);
        }

        bool resetting;
        void reset(bool fromlistchange)
        {
            if (info == null || resetting) return;
            int pos = Position;
            var cur = Current;
            var grid = Grid;
            int? firstrow = grid == null ? (int?)null : grid.FirstDisplayedScrollingRowIndex;
            resetting = true;
            try
            {
                if (fromlistchange)
                    info.ReBuild();
                else
                    info = null;
                base.OnListChanged(new ListChangedEventArgs(ListChangedType.Reset, -1));

                if (pos != -1)
                {
                    int i = cur is GroupRow ? pos : IndexOf(cur);
                    if (i == -1) i = pos;

                    if (Position == i)
                        OnPositionChanged(EventArgs.Empty);
                    else
                        this.Position = i;


                    if (firstrow.HasValue)
                    {
                        try
                        {
                            if (grid.Rows.Count > firstrow.Value && firstrow.Value > -1)
                                grid.FirstDisplayedScrollingRowIndex = firstrow.Value;
                            //OnPositionChanged(EventArgs.Empty);
                        }
                        catch
                        {
                        }
                    }
                }
            }
            finally
            {
                resetting = false;

                if (NeedSync)
                    SyncCurrencyManagers();
            }
        }

        internal void FireBaseReset(bool PreserveScrollPosition)
        {
            FireBaseChanged(new ListChangedEventArgs(ListChangedType.Reset, -1), PreserveScrollPosition);
        }

        internal void FireBaseChanged(ListChangedType type, int index, bool PreserveScrollPosition)
        {
            FireBaseChanged(new ListChangedEventArgs(type, index), PreserveScrollPosition);
        }
        internal void FireBaseChanged(ListChangedEventArgs e, bool PreserveScrollPosition)
        {
            int soffset = -1;
            PreserveScrollPosition &= Grid != null;
            if (PreserveScrollPosition)
                soffset = Grid.FirstDisplayedScrollingRowIndex;
            base.OnListChanged(e);
            if (soffset > 0)
                try
                {
                    Grid.FirstDisplayedScrollingRowIndex = soffset;
                }
                catch { }

        }

        /// <summary>
        /// This event is fired when the group row has to be painted and the display values are requested
        /// </summary>
        public event EventHandler<GroupDisplayEventArgs> DisplayGroup;

        internal void FireDisplayGroup(GroupDisplayEventArgs e)
        {
            if (DisplayGroup != null)
                DisplayGroup(this, e);
        }

        CurrencyManager cm;

        void UnwireCurMan()
        {
            if (cm == null) return;
            cm.CurrentChanged -= new EventHandler(bsource_CurrentChanged);
        }

        protected override void Dispose(bool disposing)
        {
            UnwireCurMan();
            groupon = null;
            base.Dispose(disposing);
        }

        protected override void OnDataSourceChanged(EventArgs e)
        {            
            UnwireCurMan();            
            ResetGroups();
            var ds = DataSource;
            if (ds is ICurrencyManagerProvider)
                cm = ((ICurrencyManagerProvider)ds).CurrencyManager;
            else
            {
                //find from bindingcontext?
            }

            if (cm != null)
            {
                cm.CurrentChanged += new EventHandler(bsource_CurrentChanged);
                if (NeedSync) SyncCurrencyManagers();
            }
            base.OnDataSourceChanged(e);
        }

        int suspendlistchange;

        protected override void OnListChanged(ListChangedEventArgs e)
        {
            if (suspendlistchange > 0 || resetting) return;


            if (shouldreset)
            {
                switch (e.ListChangedType)
                {
                    case ListChangedType.ItemChanged:
                        if (groupon.IsProperty(e.PropertyDescriptor) && !info.Groups.IsNewRow(e.NewIndex))
                            reset(true);
                        else    
                            FireBaseChanged(new ListChangedEventArgs( ListChangedType.ItemChanged,
                                IndexOf(List[e.NewIndex]),
                                e.PropertyDescriptor),
                                false);
                        return;
                    case ListChangedType.ItemAdded:
                        if (info.Groups.HasNewRow)
                            info.Groups.AddNew(List[e.NewIndex], true);
                        else
                            reset(true);                    
                        return;
                    case ListChangedType.ItemDeleted:
                        reset(true);
                        return;
                    case ListChangedType.Reset:
                        reset(true);
                        return;
                    case ListChangedType.ItemMoved:
                        reset(true); //check sorting??
                        return;
                }
            }

            switch (e.ListChangedType)
            {
                case ListChangedType.PropertyDescriptorAdded:
                case ListChangedType.PropertyDescriptorChanged:
                case ListChangedType.PropertyDescriptorDeleted:
                    props = null;
                    break;
            }

            base.OnListChanged(e);
        }

        bool shouldreset
        {
            get { return info != null && info.Groups != null; }
        }

        public override object AddNew()
        {
            if (!shouldreset) return base.AddNew();

            object res;
            int newrow;
            suspendlistchange++;
            try
            {
                res = base.AddNew();
                newrow  =info.Groups.AddNew(res,false);
            }
            finally
            {
                suspendlistchange--;
            }

            Position = newrow;
            return res;
        }

       

  
        
        public override void ApplySort(PropertyDescriptor property, ListSortDirection sort)
        {
            if (property is PropertyWrapper)
                property = (property as PropertyWrapper).Property;
            base.ApplySort(property, sort);
        }

        public override void ApplySort(ListSortDescriptionCollection sorts)
        {
            base.ApplySort(sorts);
        }


        public override void RemoveAt(int index)
        {
            if (!shouldreset)
                base.RemoveAt(index);
            else if (!IsGroupRow(index))
            {

                suspendlistchange++;
                try
                {
                    //remove from underlying list
                    var rec = this[index];
                    var i = List.IndexOf(rec);
                    if (i != -1)
                        List.RemoveAt(i);

                    //remove from rowlist            
                    info.Rows.RemoveAt(index);

                    base.OnListChanged(new ListChangedEventArgs(ListChangedType.ItemDeleted, index));

                    var gr = GetGroup(index);
                    if (gr != null)
                        gr.Remove(rec);
                }
                finally
                {
                    suspendlistchange--;
                }

            }
        }



        public override void Remove(object value)
        {
            if (value is GroupRow) return;

            int index = this.IndexOf(value);

            if (index != -1)
            {
                RemoveAt(index);
            }
        }

        void ICancelAddNew.CancelNew(int pos)
        {
            if (!shouldreset || !info.Groups.IsNewRow(pos)) return;

            ICancelAddNew list = this.List as ICancelAddNew;
            if (list != null)
            {
                suspendlistchange++;
                try
                {
                    int  li = List.IndexOf(this[pos]);                    
                    list.CancelNew(li);
                }
                finally { suspendlistchange--; }
            }

            RemoveAt(pos);


        }


        protected override void OnCurrentChanged(EventArgs e)
        {
            base.OnCurrentChanged(e);
            if (NeedSync)
            {
                var cur = Current;
                while (cur is GroupRow)
                {
                    cur = ((GroupRow)cur).FirstRow;
                    if (cur == cm.Current) return;
                }
                suspendsync = true;
                try
                {
                    cm.Position = cm.List.IndexOf(cur);
                }
                finally { suspendsync = false; }
            }
        }

        void bsource_CurrentChanged(object sender, EventArgs e)
        {
            if (NeedSync)
                SyncCurrencyManagers();
        }

        bool suspendsync;
        bool NeedSync
        {
            get
            {
                if (cm == null || suspendlistchange > 0 || suspendsync || cm.Count == 0) return false;
                //if (cm.IsBindingSuspended || this.IsBindingSuspended) return false;
                var p1 = Position;
                if (p1 == cm.Position)
                {
                    if (p1 == -1) return false;
                    return Current != cm.Current;
                }
                return true;
            }
        }


        private void SyncCurrencyManagers()
        {
            suspendsync = true;
            try
            {
                if (cm.Count > 0)
                    Position = IndexOf(cm.Current);
            }
            finally { suspendsync = false; }
            
        }

        public override int IndexOf(object value)
        {
            return Info.Rows.IndexOf(value);
        }

        public override bool Contains(object value)
        {
            return Info.Rows.Contains(value);
        }

        public override void Clear()
        {
            suspendlistchange++;
            try
            {
                base.Clear();
                if (shouldreset)
                    info.Groups.Fill();
                FireBaseReset(false);
            }
            finally
            {
                suspendlistchange--;
            }
        }

        public override int Add(object value)
        {
            return base.Add(value);
        }

        public override void Insert(int index, object value)
        {
            base.Insert(index, value);
        }

        

        public partial class PropertyWrapper : PropertyDescriptor
        {

            public readonly PropertyDescriptor Property;
            public readonly GroupingSource Owner;
            public PropertyWrapper(PropertyDescriptor Property, GroupingSource Owner)
                : base(Property)
            {
                this.Property = Property;
                this.Owner = Owner;
            }
            public override bool CanResetValue(object component)
            {
                return Property.CanResetValue(component);
            }

            public override Type ComponentType
            {
                get { return Property.ComponentType; }
            }

            public override object GetValue(object component)
            {
                if (component is GroupRow)
                {
                    if (Owner.groupon is object && Owner.groupon.IsProperty(Property))
                        return (component as GroupRow).Value;
                    return null;
                }
                return Property.GetValue(component);
            }

            public override bool IsReadOnly
            {
                get { return Property.IsReadOnly; }
            }

            public override Type PropertyType
            {
                get { return Property.PropertyType; }
            }

            public override string Category
            {
                get
                {
                    return Property.Category;
                }
            }

            public override string Description
            {
                get
                {
                    return Property.Description;
                }
            }

            public override string DisplayName
            {
                get
                {
                    return Property.DisplayName;
                }
            }

            public override bool DesignTimeOnly
            {
                get
                {
                    return Property.DesignTimeOnly;
                }
            }

            public override AttributeCollection Attributes
            {
                get
                {
                    return Property.Attributes;
                }
            }

            public override string Name
            {
                get
                {
                    return Property.Name;
                }
            }

            public override void ResetValue(object component)
            {
                Property.ResetValue(component);
            }

            public override void SetValue(object component, object value)
            {
                Property.SetValue(component, value);
            }

            public override bool ShouldSerializeValue(object component)
            {
                return Property.ShouldSerializeValue(component);
            }
        }


        PropertyDescriptorCollection props;

        public override PropertyDescriptorCollection GetItemProperties(PropertyDescriptor[] listAccessors)
        {
            if (listAccessors == null)
            {
                if (props == null)
                {
                    /*
                    props = new PropertyDescriptorCollection(
                        base.GetItemProperties(null).Cast<PropertyDescriptor>()
                        .Select(pd => new PropertyWrapper(pd, this)).ToArray());*/
                    props = base.GetItemProperties(null);
                    if (props == null) return null;
                    PropertyDescriptor[] arr = new PropertyDescriptor[props.Count];

                    for (int i = 0; i < props.Count; i++)
                    {
                        arr[i] = new PropertyWrapper(props[i], this);
                    }
                    props = new PropertyDescriptorCollection(arr);
                }
                return props;
            }
            return base.GetItemProperties(listAccessors);
        }

        /// <summary>
        /// The count of the underlying source (without the grouprows)
        /// </summary>
        public int BaseCount
        {
            get
            {
                return List.Count;
            }
        }

        public object GetBaseRow(int Index)
        {
            return List[Index];
        }

        /// <summary>
        /// The total count: number of records plus number of grouprows
        /// </summary>
        public override int Count
        {
            get
            {
                return Info.Rows.Count;
            }
        }

        public override object this[int index]
        {
            get
            {
                return Info.Rows[index];
            }
            set
            {
                Info.Rows[index] = value;
            }
        }
    }

}
