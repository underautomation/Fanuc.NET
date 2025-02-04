using System;
using System.Collections.Generic;
using System.Collections;
using System.Text;
using System.Windows.Forms;
using System.ComponentModel;

namespace Subro.Controls
{
    /// <summary>
    /// A collection of <see cref="GroupRow"/>s used by a <see cref="GroupingSource"/>
    /// </summary>
    public class GroupList : IEnumerable<GroupRow>
    {

        GroupingInfo gi;
        public readonly GroupingSource Source;
        public readonly Type GroupValueType;
        GenericComparer comparer;
        /// <summary>
        /// The current collection of <see cref="GroupRow"/>s
        /// </summary>
        internal List<GroupRow> List = new List<GroupRow>();
        /// <summary>
        /// Collections of all groups. The entries in this list are saved to store settings (such as collapsed)
        /// for each group. Only the row collection inside each <see cref="GroupRow"/> is cleared
        /// </summary>
        List<GroupRow> allgroups = new List<GroupRow>();

        public GroupList(GroupingSource Source)
        {
            this.Source = Source;
            this.gi = Source.GroupOn;
            this.GroupValueType = gi.GroupValueType;
        }

        internal IList Fill()
        {
            var options = Source.Options;
            bool startcollapsed = options.StartCollapsed;
            bool RemoveEmpty = allgroups.Count > 0;

            if (RemoveEmpty)
            {
                foreach (var g in allgroups)
                {
                    g.Rows.Clear();
                    //if (startcollapsed)g.SetCollapsed(true, false);
                }                
            }
            List.Clear();
            if (newrows != null)
                newrows.Rows.Clear();

            foreach (object row in Source.List)
            {
                object key = gi.GetGroupValue(row);
                int hash = key == null ? 0 : key.GetHashCode();
                GroupRow gr = null;
                for (int i = 0; i < allgroups.Count; i++)
                {
                    if (allgroups[i].HashCode == hash &&
                        (key == null || key.Equals(allgroups[i].value))
                        )
                    {
                        gr = allgroups[i];
                        break;
                    }
                }

                if (gr == null)
                {
                    gr = new GroupRow(this);
                    gr.value = key;
                    gr.HashCode = hash;
                    if (startcollapsed)
                        gr.SetCollapsed(true, false);

                    allgroups.Add(gr);
                }
                gr.Rows.Add(row); //not gr.Add to prevent listchanged events
            }


            if (RemoveEmpty)
            {
                foreach (var g in allgroups)
                    if (g.Count > 0)
                        List.Add(g);
            }
            else
                List.AddRange(allgroups);            

            sort(Source.GroupSortOrder, false);

            if (Rows == null)
                Rows = new ArrayList(List.Count + Source.BaseCount);
            else
                Rows.Clear();

            if (startcollapsed && !RemoveEmpty)
                AddGroupsOnly();
            else
                RebuildRows();

            CheckNewRow(false);
            return Rows;
        }

        int compare(GroupRow g1, GroupRow g2)
        {
            return comparer.Compare(g1.value, g2.value);
        }



        internal ArrayList Rows;

        internal void RebuildRows()
        {
            int gi = 0;
            foreach (GroupRow g in List)
            {
                g.Index = Rows.Count;
                g.GroupIndex = gi++;
                Rows.Add(g);
                if (!g.Collapsed)
                    foreach (object row in g.Rows)
                        Rows.Add(row);
            }
        }

        /// <summary>
        /// Adds the groups to the row collection and reindexes the groups
        /// </summary>
        /// <param name="ReIndex"></param>
        internal void AddGroupsOnly()
        {
            Rows.AddRange(List);
            ReIndex(0);
        }

        internal void ReIndex(int From)
        {
            int last = From == 0 ? 0 : List[From - 1].LastIndex + 1;
            for (int i = From; i < List.Count; i++)
            {
                List[i].Index = last;
                List[i].GroupIndex = i;
                last = List[i].LastIndex + 1;
            }
        }

        public GroupRow[] ToArray()
        {
            return List.ToArray();
        }

        public int Count { get { return List.Count; } }
        public GroupRow this[int Index]
        {
            get { return List[Index]; }
        }

        public int IndexOf(GroupRow row)
        {
            return List.IndexOf(row);
        }

        #region IEnumerable Members

        IEnumerator IEnumerable.GetEnumerator()
        {
            return List.GetEnumerator();
        }

        #endregion

        #region IEnumerable<GroupRow> Members

        IEnumerator<GroupRow> IEnumerable<GroupRow>.GetEnumerator()
        {
            return List.GetEnumerator();
        }

        #endregion

        public GroupRow GetByRow(int RowIndex)
        {
            GroupRow res = null;
            foreach (GroupRow g in List)
            {
                if (g.Index > RowIndex) break;
                res = g;
            }
            return res;
        }

        public void CollapseExpandAll(bool collapse)
        {
            foreach (var gr in List)
                gr.SetCollapsed(collapse, false);

            Rows.Clear();
            if (collapse)
            {
                AddGroupsOnly();
            }
            else
                RebuildRows();

            Source.FireBaseReset(false);
        }

        void sort(SortOrder order, bool Rebuild)
        {
            if (order != SortOrder.None)
            {
                GroupRow g = Rebuild ? Source.GetGroup(Source.Position) : null;

                if (comparer == null)
                    comparer = new GenericComparer(GroupValueType);

                comparer.Descending = order == SortOrder.Descending;
                List.Sort(compare);

                if (Rebuild)
                {
                    Rows.Clear();
                    RebuildRows();
                    Source.FireBaseReset(false);
                    if (g != null)
                    {
                        Source.Position = g.Index;
                        if (!g.Collapsed)
                            Source.Position++;
                    }
                }
            }
        }

        public void Sort(SortOrder sortOrder)
        {
            sort(sortOrder, true);
        }

        internal int AddNew(object res, bool GroupOnly)
        {
            if (newrows == null)
            {
                int i = Rows.Add(res);
                Source.FireBaseChanged(ListChangedType.ItemAdded, i, false);
                return i;
            }
            else
                return newrows.Add(res);
           
        }

        internal bool HasNewRow
        {
            get
            {
                return newrows != null;
            }
        }

        internal bool IsNewRow(int pos)
        {
            if (newrows == null) return false;
            return pos > newrows.Index;
        }

        internal void CheckNewRow(bool FireChanged)
        {
            var grid = Source.Grid;
            bool nr = grid != null && grid.AllowUserToAddRows;

            int i = FireChanged && newrows != null ? Rows.IndexOf(newrows) : -1;

            if (nr)
            {
                if (i == -1)
                {
                    if (newrows == null)
                    {
                        newrows = new NewRowsGroup(this);
                        //allgroups.Add(newrows);
                    }
                    newrows.Index = Rows.Count;
                    List.Add(newrows);
                    Rows.Add(newrows);
                    if (FireChanged)
                        Source.FireBaseChanged(ListChangedType.ItemAdded, newrows.Index, true);
                }
            }
            else if (i != -1)
            {
                Rows.RemoveAt(i);
                if(newrows.Count == 0)
                    Source.FireBaseChanged(ListChangedType.ItemDeleted, i, true);
                else
                {
                    newrows.Rows.Clear();
                    Fill();
                    Source.FireBaseReset(true);
                }
            }

        }

        NewRowsGroup newrows;

        class NewRowsGroup:GroupRow
        {
            public NewRowsGroup(GroupList list):base(list)
            {

            }

            protected override void SetDisplayInfo(GroupDisplayEventArgs e)
            {
                base.SetDisplayInfo(e);
                e.Header = "New Rows";
                e.DisplayValue = null;
            }

            protected override bool AllowRemove
            {
                get
                {
                    return false;
                }
            }

            protected override bool AllowCollapse
            {
                get
                {
                    return false;
                }
            }
        }
    }

    /// <summary>
    /// Information of a single Group inside a <see cref="GroupingSource"/>
    /// </summary>
    public class GroupRow : IEnumerable
    {
        /// <summary>
        /// The owning list that created this GroupRow
        /// </summary>
        public readonly GroupList Owner;
        internal GroupRow(GroupList Owner)
        {
            this.Owner = Owner;
        }

        /// <summary>
        /// The index this group has as row entity in the TOTAL collection.
        /// </summary>
        public int Index { get; internal set; }

        /// <summary>
        /// The collection-index of the last row in this group
        /// </summary>
        public int LastIndex
        {
            get
            {
                if (collapsed) return Index;
                return Index + Rows.Count;
            }
        }

        /// <summary>
        /// The index of the group itself within the groups collection
        /// </summary>
        public int GroupIndex { get; internal set; }

        internal object value;
        /// <summary>
        /// The key value this group is based on.
        /// </summary>
        public object Value
        {
            get { return value; }
        }

        /// <summary>
        /// The number of rows inside this group
        /// </summary>
        public int Count
        {
            get { return Rows.Count; }
        }

        bool collapsed;
        /// <summary>
        /// gets or sets if the group should be displayed collapsed (group only) or completely
        /// </summary>
        public bool Collapsed
        {
            get { return collapsed; }
            set
            {
                SetCollapsed(value, true);
            }
        }

        internal void SetCollapsed(bool collapse, bool Perform)
        {
            if (collapsed == collapse) return;
            if (collapse && !AllowCollapse) return;
            collapsed = collapse;

            if (Perform)
            {
                int index = Index + 1;
                if (collapse)
                    Owner.Rows.RemoveRange(index, Rows.Count);
                else
                    Owner.Rows.InsertRange(index, Rows);
                Owner.ReIndex(Owner.IndexOf(this));
                try
                {
                    if (Rows.Count > 1)
                        Owner.Source.FireBaseReset(true);
                    else
                    {

                        Owner.Source.FireBaseChanged(
                            collapsed ? ListChangedType.ItemDeleted : ListChangedType.ItemAdded, index, true);
                    }
                }
                catch { }
            }
        }

        protected virtual bool AllowCollapse
        {
            get { return true; }
        }

        internal List<object> Rows = new List<object>();
        internal int HashCode;

        /// <summary>
        /// Gets the row at the specified index inside this group. The index is 0 based inside this group,
        /// not the index of the collection it is based on
        /// </summary>        
        public object this[int Index]
        {
            get { return Rows[Index]; }
        }

        public object FirstRow
        {
            get
            {
                if (Rows.Count == 0) return null;
                return Rows[0];
            }
        }

        public GroupDisplayEventArgs GetDisplayInfo(bool selected)
        {
            GroupDisplayEventArgs e = new GroupDisplayEventArgs(this,Owner.Source.GroupOn);
            e.Selected = selected;
            SetDisplayInfo(e);
            if (e.Cancel) return null;
            Owner.Source.FireDisplayGroup(e);
            return e;
        }


        protected virtual void SetDisplayInfo(GroupDisplayEventArgs e)
        {
            var grid = Owner.Source.Grid;
            if (grid != null)
            {
                e.BackColor = e.Selected ? grid.DefaultCellStyle.SelectionBackColor : grid.DefaultCellStyle.BackColor;
                e.ForeColor = e.Selected ? grid.DefaultCellStyle.SelectionForeColor : grid.DefaultCellStyle.ForeColor;
            }

            var o = Owner.Source.Options;
            if (o.ShowCount)
                e.Summary = "(" + Count + ")";
            if (o.ShowGroupName)
                e.Header = e.GroupingInfo.ToString();
            e.GroupingInfo.SetDisplayValues(e);
        }

        public virtual void Remove(object rec)
        {
            if (!Rows.Remove(rec)) return;
            bool delete = Count == 0 && AllowRemove;
            int i = Owner.List.IndexOf(this);
            if (delete)
            {
                Owner.Rows.RemoveAt(Index);
                Owner.List.RemoveAt(i);                
            }
            Owner.ReIndex(i);
            Owner.Source.FireBaseChanged(
                delete ? ListChangedType.ItemDeleted : ListChangedType.ItemChanged, Index, true);
        }

        public virtual int Add(object rec)
        {
            int i  = Owner.Rows.Add(rec);
            Owner.Source.FireBaseChanged(ListChangedType.ItemAdded, i, false);
            Rows.Add(rec);
            Owner.Source.FireBaseChanged(ListChangedType.ItemChanged, Index, false);
            return i;
        }

        protected virtual bool AllowRemove
        {
            get { return true; }
        }

        #region IEnumerable Members

        IEnumerator IEnumerable.GetEnumerator()
        {
            return Rows.GetEnumerator();
        }

        #endregion
    }
}
