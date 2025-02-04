using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using System.Windows.Forms;
using System.Runtime.Serialization;
using System.Linq;
using Subro.IO;

namespace Subro.Controls
{
    [Serializable]
    public partial class GroupingOptions : INotifyPropertyChanged ,IEquatable<GroupingOptions>
    {
        public GroupingOptions()
        {
            add(GroupingOption.StartCollapsed, false);
            add(GroupingOption.GroupSortOrder, DefaultGroupSortOrder);
            add(GroupingOption.AlwaysGroupOnText, false);
            add(GroupingOption.ShowCount, true);
            add(GroupingOption.ShowGroupName, true);
            add(GroupingOption.SelectRowsOnDoubleClick, true);
        }

        List<GroupingOptionValue> list = new List<GroupingOptionValue>();



        void add<T>(GroupingOption o, T Default)
        {
            list.Add(new GroupingOptionValue<T>(Default, o)
            {
                Owner = this
            });
        }

        public GroupingOptionValue this[GroupingOption option]
        {
            get
            {
                for (int i = 0; i < list.Count; i++)
                {
                    if (list[i].Option == option) return list[i];
                }
                return null;
            }
        }


        T GetValue<T>(GroupingOption o)
        {
            return ((GroupingOptionValue<T>)this[o]).Value;
        }
        void SetValue<T>(GroupingOption o, T value)
        {
            ((GroupingOptionValue<T>)this[o]).Value = value;
        }

        bool ShouldSerialize(GroupingOption o)
        {
            return !this[o].IsDefault;
        }

        /// <summary>
        /// If true, new groups always start collapsed
        /// </summary>
        public bool StartCollapsed
        {
            get { return GetValue<bool>(GroupingOption.StartCollapsed); }
            set{SetValue(GroupingOption.StartCollapsed, value);}
        }
        bool ShouldSerializeStartCollapsed() { return ShouldSerialize(GroupingOption.StartCollapsed); }

        public const SortOrder DefaultGroupSortOrder = SortOrder.Ascending;
        [DefaultValue(DefaultGroupSortOrder)]
        public SortOrder GroupSortOrder
        {
            get { return GetValue<SortOrder>(GroupingOption.GroupSortOrder); }
            set { SetValue(GroupingOption.GroupSortOrder, value); }
        }
        bool ShouldSerializeGroupSortOrder() { return ShouldSerialize(GroupingOption.GroupSortOrder); }

        public bool AlwaysGroupOnText
        {
            get { return GetValue<bool>(GroupingOption.AlwaysGroupOnText); }
            set { SetValue(GroupingOption.AlwaysGroupOnText, value); }
        }
        bool ShouldSerializeAlwaysGroupOnText() { return ShouldSerialize(GroupingOption.AlwaysGroupOnText); }

        public bool ShowCount
        {
            get { return GetValue<bool>(GroupingOption.ShowCount); }
            set { SetValue(GroupingOption.ShowCount, value); }
        }
        bool ShouldSerializeShowCount() { return ShouldSerialize(GroupingOption.ShowCount); }

        public bool ShowGroupName
        {
            get { return GetValue<bool>(GroupingOption.ShowGroupName); }
            set { SetValue(GroupingOption.ShowGroupName, value); }
        }
        bool ShouldSerializeShowGroupName() { return ShouldSerialize(GroupingOption.ShowGroupName); }

        public bool SelectRowsOnDoubleClick
        {
            get { return GetValue<bool>(GroupingOption.SelectRowsOnDoubleClick); }
            set { SetValue(GroupingOption.SelectRowsOnDoubleClick, value); }
        }
        bool ShouldSerializeSelectRowsOnDoubleClick() { return ShouldSerialize(GroupingOption.SelectRowsOnDoubleClick); }

        public bool HasNonDefaultValues
        {
            get
            {
                foreach (var g in list)
                    if (!g.IsDefault) return true;
                return false;
            }
        }

        public void CopyValues(GroupingOptions options)
        {
            foreach (var g in list)
            {
                g.CopyValue(options[g.Option]);
            }
        }

        public void SetDefaults()
        {
            foreach (var g in list)
            {
                g.Reset();
            }
        }

        internal void NotifyChanged(GroupingOption o)
        {
            if(OptionChanged != null)
                OptionChanged(this,new GroupingOptionChangedEventArgs(o));
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(o.ToString()));
        }

        [field: NonSerialized]
        public event PropertyChangedEventHandler PropertyChanged;

        [field: NonSerialized]
        public event EventHandler<GroupingOptionChangedEventArgs> OptionChanged;

        
 

        public bool Equals(GroupingOptions o)
        {
            if (o == null) return false;
            if (o.list.Count != list.Count) return false;
            foreach (var g in list)
                if (!g.Equals(o[g.Option])) return false;
            return true;
        }
    }

    partial class GroupingOptions:ISerializable
    {
        #region ISerializable Members

        GroupingOptions(SerializationInfo info, StreamingContext context)
            : this()
        {
            foreach (var kv in info)
            {
                try
                {
                    var o = EnumFunctions.Parse<GroupingOption>(kv.Name);
                    this[o].SetValue(kv.Value);
                }
                catch
                {
                }
            }
        }

        public void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            foreach (var g in list)
                if (!g.IsDefault)
                {
                    info.AddValue(g.Option.ToString(), g.GetValue());
                }
        }

        #endregion
    }

    partial class GroupingOptions:ICustomSerializer
    {

        #region ICustomSerializer Members

        bool ICustomSerializer.Serialize(SimpleObjectSerializer s)
        {
            
            var vals = list.Where(g => !g.IsDefault).ToArray();
            s.Writer.Write((byte)vals.Length);
            if (vals.Length  > 0)
                foreach (var g in vals)
                {
                    s.Writer.Write(g.Option.ToString());
                    s.WriteSubValue(g.GetValue());                    
                }
            return true;
        }

        bool ICustomSerializer.Deserialize(SimpleObjectDeserializer ds)
        {
            int cnt = ds.Reader.ReadByte();            
            for (int i = 0; i < cnt; i++)
            {
                var name = ds.Reader.ReadString();
                var val = ds.GetSubValue();
                var o = EnumFunctions.Parse<GroupingOption>(name);
                this[o].SetValue(val);
            }
            return true;
        }

        bool ICustomSerializer.Initialize(SimpleObjectSerializer s)
        {
            return true;
        }

        #endregion
    }

    public enum GroupingOption
    {
        StartCollapsed,
        GroupSortOrder,
        AlwaysGroupOnText,
        ShowCount,
        ShowGroupName,
        SelectRowsOnDoubleClick
    }

    public class GroupingOptionChangedEventArgs:EventArgs
    {
        public readonly GroupingOption Option;
        public GroupingOptionChangedEventArgs(GroupingOption Option)
        {
            this.Option = Option;
        }
    }

    [Serializable]
    public abstract class GroupingOptionValue
    {
        internal GroupingOptions Owner;
        public readonly GroupingOption Option;
        protected GroupingOptionValue(GroupingOption o)
        {
            this.Option = o;
        }

        public abstract bool IsDefault
        {
            get;
        }

        public abstract object GetValue();
        public abstract object GetDefaultValue();
        public abstract void Reset();
        internal abstract void CopyValue(GroupingOptionValue o);
        public abstract Type ValueType{get;}
        public abstract void SetValue(object value);

        public abstract bool Equals(GroupingOptionValue v);
    }


    [Serializable]
    internal class GroupingOptionValue<T> : GroupingOptionValue
    {
        public GroupingOptionValue(T Default, GroupingOption o)
            : base(o)
        {
            this.DefaultValue = Default;
            this.value = DefaultValue;
        }
        [NonSerialized]
        public T DefaultValue;

        T value;
        public T Value
        {
            get
            {
                return value;
            }
            set
            {
                if (Equals(value, this.value)) return;
                this.value = value;
                Owner.NotifyChanged(Option);
            }
        }

        [NonSerialized]
        EqualityComparer<T> eq;
        bool Equals(T t1, T t2)
        {
            if (eq == null)
                eq = EqualityComparer<T>.Default;
            return eq.Equals(t1, t2);
        }

        public override bool Equals(GroupingOptionValue v)
        {
            if (v == null) return false;
            var o = v.GetValue();
            if (o is T)
                return Equals(value, (T)o);
            return false;
        }

        public override bool IsDefault
        {
            get { return Equals(value, DefaultValue); }
        }

        public override Type ValueType
        {
            get { return typeof(T); }
        }

        public override object GetValue()
        {
            return value;
        }

        public override void SetValue(object value)
        {
            Value = (T)value;
        }

        public override object GetDefaultValue()
        {
            return DefaultValue;
        }

        internal override void CopyValue(GroupingOptionValue o)
        {
            Value = ((GroupingOptionValue<T>)o).value;
        }

        public override void Reset()
        {
            Value = DefaultValue;
        }

        
    }

    public static class EnumFunctions
    {
        /// <summary>
        /// Gets all values of the specified enumeration
        /// </summary>
        public static IEnumerable<T> GetValues<T>()
            where T : IComparable, IFormattable, IConvertible
        {
            return GetValues<T>(x => x);
        }

        /// <summary>
        /// Gets all values of the specified enumeration
        /// </summary>
        public static IEnumerable<T> GetValues<T>(Func<T, T> pred)
            where T : IComparable, IFormattable, IConvertible
        {
            foreach (T item in Enum.GetValues(typeof(T)))
            {
                yield return pred(item);
            }
        }

        /// <summary>
        /// Gets all values of the specified enumeration that comply
        /// to the specified predicate
        /// </summary>
        public static IEnumerable<T> GetValues<T>(Func<T, bool> predicate)
            where T : IComparable, IFormattable, IConvertible
        {
            foreach (var item in GetValues<T>())
            {
                if (predicate(item))
                    yield return item;
            }
        }

        /// <summary>
        /// Checks if the specified enumeration value has the flag bit set
        /// </summary>        
        [Obsolete("Framework 4.0 contains a native HasFlag function :D")]
        public static bool HasFlag<T>(this T value, T flag)
            where T : IComparable, IFormattable, IConvertible
        {
            int fl = flag.ToInt32(null);
            return (value.ToInt32(null) & fl) == fl;
        }

        /// <summary>
        /// Calls <see cref="Enum.Parse"/> and creates the strongly typed result
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="Value"></param>
        /// <returns></returns>
        public static T Parse<T>(string Value)
               where T : IComparable, IFormattable, IConvertible
        {
            if (string.IsNullOrEmpty(Value)) return default(T);
            return (T)Enum.Parse(typeof(T), Value, true);
        }


        /// <summary>
        /// Splits up a flags enumeration into its base values
        /// </summary>
        public static IEnumerable<T> Select<T>(this T e, Func<T, T> pred)
            where T : IComparable, IFormattable, IConvertible
        {
            foreach (T item in Split(e))
            {
                yield return pred(item);
            }
        }

        /// <summary>
        /// Splits up a flags enumeration into its base values
        /// </summary>
        public static IEnumerable<T> Split<T>(this T enumeration)
            where T : IComparable, IFormattable, IConvertible
        {
            int val = Convert.ToInt32(enumeration);
            foreach (var item in GetValues<T>())
            {
                int i = item.ToInt32(null);
                if (i > 0 & (i & val) == i)
                    yield return item;
            }
        }

        /// <summary>
        /// Splits up a flags enumeration into its base values, and filters values already set
        /// by a mask
        /// </summary>
        public static IEnumerable<T> Split<T>(this T enumeration, bool CompactMaskedValues)
            where T : IComparable, IFormattable, IConvertible
        {
            var res = Split(enumeration);
            if (!CompactMaskedValues) return res;

            var list = res.OrderByDescending(r => r.ToInt32(null)).ToList();
            for (int i = 0; i < list.Count; i++)
            {
                var val = list[i].ToInt32(null);
                for (int j = i + 1; j < list.Count; j++)
                {
                    if ((val & list[j].ToInt32(null)) == list[j].ToInt32(null))
                        list.RemoveAt(j--);
                }
            }
            return list;

        }


        public static IEnumerable<T> GetValues<T>(this T e, Func<T, bool> pred)
            where T : IComparable, IFormattable, IConvertible
        {
            foreach (T item in Split(e))
            {
                if (pred(item))
                    yield return item;
            }
        }
    }
}

