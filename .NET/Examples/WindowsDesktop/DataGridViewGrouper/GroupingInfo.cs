using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace Subro.Controls
{
    /// <summary>
    /// Information on how a <see cref="GroupingSource"/> should group its information
    /// </summary>
    public abstract class GroupingInfo
    {
        public abstract object GetGroupValue(object Row);

        public virtual bool IsProperty(PropertyDescriptor p)
        {
            return p != null && IsProperty(p.Name);
        }
        public virtual bool IsProperty(string Name)
        {
            return Name == ToString();
        }

        public static implicit operator GroupingInfo(PropertyDescriptor p)
        {
            return new PropertyGrouper(p);
        }

        public virtual Type GroupValueType
        {
            get { return typeof(object); }
        }

        public virtual void SetDisplayValues(GroupDisplayEventArgs e)
        {
            var o = e.Value;
            e.DisplayValue = o == null ? "<Null>" : o.ToString();
        }
    }

    /// <summary>
    /// Groups on the value of a property
    /// </summary>
    public class PropertyGrouper : GroupingInfo
    {
        public readonly PropertyDescriptor Property;
        public PropertyGrouper(PropertyDescriptor Property)
        {
            if (Property == null) throw new ArgumentNullException();
            this.Property = Property;
        }

        public override bool IsProperty(PropertyDescriptor p)
        {
            return p == Property || (p != null && p.Name == Property.Name);
        }

        public override object GetGroupValue(object Row)
        {
            return Property.GetValue(Row);
        }

        public override string ToString()
        {
            return Property.Name;
        }

        public override Type GroupValueType
        {
            get { return Property.PropertyType; }
        }
    }

    public class DelegateGrouper<T> : GroupingInfo
    {
        public readonly string Name;
        public readonly Func<T, object> GroupProvider;

        public DelegateGrouper(Func<T, object> GroupProvider, string Name)
        {
            if (GroupProvider == null) throw new ArgumentNullException();
            this.Name = Name;
            if (Name == null) this.Name = GroupProvider.ToString();
            this.GroupProvider = GroupProvider;
        }

        public override string ToString()
        {
            return Name;
        }

        public override object GetGroupValue(object Row)
        {
            return GroupProvider((T)Row);
        }


    }


    public abstract class GroupWrapper : GroupingInfo
    {
        public readonly GroupingInfo Grouper;
        public GroupWrapper(GroupingInfo Grouper)
            : this(Grouper, true)
        {
        }
        public GroupWrapper(GroupingInfo Grouper, bool RemovePreviousWrappers)
        {
            if (Grouper == null) throw new ArgumentNullException();
            if (RemovePreviousWrappers)
                while (Grouper is GroupWrapper)
                    Grouper = ((GroupWrapper)Grouper).Grouper;
            this.Grouper = Grouper;
        }

        public override string ToString()
        {
            return Grouper.ToString();
        }

        public override bool IsProperty(PropertyDescriptor p)
        {
            return Grouper.IsProperty(p);
        }

        public override object GetGroupValue(object Row)
        {
            return GetValue(Grouper.GetGroupValue(Row));
        }

        public override Type GroupValueType
        {
            get
            {
                return Grouper.GroupValueType;
            }
        }

        protected abstract object GetValue(object GroupValue);
    }

    /// <summary>
    /// Forces grouping whichever value is grouped on its string value
    /// </summary>
    public class StringGroupWrapper : GroupWrapper
    {
        public StringGroupWrapper(GroupingInfo Grouper)
            : base(Grouper)
        {

        }

        protected override object GetValue(object GroupValue)
        {
            if (GroupValue == null) return (string)null;
            return GetValue(GroupValue.ToString());
        }

        public override Type GroupValueType
        {
            get
            {
                return typeof(string);
            }
        }

        protected virtual string GetValue(string s)
        {
            return s;
        }
    }

    public class StartLetterGrouper : StringGroupWrapper
    {

        public readonly int Letters;
        public StartLetterGrouper(GroupingInfo Grouper)
            : this(Grouper, 1)
        {
        }
        public StartLetterGrouper(GroupingInfo Grouper, int Letters)
            : base(Grouper)
        {
            this.Letters = Letters;
        }

        protected override string GetValue(string s)
        {
            if (s.Length < Letters) return s;
            return s.Substring(0, Letters);
        }
    }

    public class FirstWordGrouper : StringGroupWrapper
    {
        public FirstWordGrouper(GroupingInfo Grouper)
            : base(Grouper)
        {

        }

        internal static char[] EndOfWordChars = new char[] { ' ', '\r', '\n', '\t' };

        protected override string GetValue(string s)
        {
            int i = s.IndexOfAny(EndOfWordChars);
            if (i == -1) return s;
            return s.Substring(0, i);
        }
    }

    public class LastWordGrouper : StringGroupWrapper
    {
        public LastWordGrouper(GroupingInfo Grouper)
            : base(Grouper)
        {

        }

        protected override string GetValue(string s)
        {
            int i = s.LastIndexOfAny(FirstWordGrouper.EndOfWordChars);
            if (i == -1) return s;
            return s.Substring(++i);
        }
    }

    public class DateTimeGrouper : GroupWrapper
    {
        public readonly DateTimeGrouping Mode;
        public DateTimeGrouper(GroupingInfo Grouper)
            : this(Grouper, DateTimeGrouping.Date)
        {
        }

        public DateTimeGrouper(GroupingInfo Grouper, DateTimeGrouping Mode)
            : base(Grouper)
        {
            this.Mode = Mode;
        }

        bool set(DateTimeGrouping val)
        {
            return (Mode & val) > 0;
        }

        public override Type GroupValueType
        {
            get
            {
                if (Mode == DateTimeGrouping.Date)
                    return typeof(DateTime);
                return typeof(int);
            }
        }

        protected override object GetValue(object GroupValue)
        {
            DateTime dt = (DateTime)GroupValue;
            if (Mode == DateTimeGrouping.Date)
                return dt.Date;
            if (Mode == DateTimeGrouping.WeekDay)
                return (int)dt.DayOfWeek;
            int i = 0;
            if (set(DateTimeGrouping.Year))
                i += dt.Year * 10000;
            if (set(DateTimeGrouping.Month))
                i += dt.Month * 100;
            if (set(DateTimeGrouping.Day))
                i += dt.Day;
            return i;
        }

        public override void SetDisplayValues(GroupDisplayEventArgs e)
        {
            base.SetDisplayValues(e);
            if (Mode == DateTimeGrouping.Date)
                e.DisplayValue = ((DateTime)e.Value).ToShortDateString();
            else if (e.Value is int)
            {
                int i = (int)e.Value;
                string value = null;
                if (set(DateTimeGrouping.Year))
                    value = "Year: " + i / 10000;
                if (set(DateTimeGrouping.Month))
                {
                    if (value != null) value += ", ";
                    int m = (i / 100) % 100;
                    value += System.Globalization.DateTimeFormatInfo.CurrentInfo.GetMonthName(m);
                }
                if (set(DateTimeGrouping.Day) || set(DateTimeGrouping.WeekDay))
                {
                    if (value != null) value += ", ";
                    int d = i % 10000;
                    value += set(DateTimeGrouping.WeekDay)
                        ? System.Globalization.DateTimeFormatInfo.CurrentInfo.GetDayName((DayOfWeek)d)
                        : "Day: " + d;

                }
                e.DisplayValue = value;
            }
        }
    }


    public enum DateTimeGrouping
    {
        Year = 1,
        Month = 2,
        YearAndMonth = 3,
        Day = 4,
        Date = 7,
        WeekDay = 32
    }


}
