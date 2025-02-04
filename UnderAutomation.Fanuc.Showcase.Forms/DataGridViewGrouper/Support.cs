using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Text;

//this file contains several support functions that are part of the library the grouper is kept in

namespace Subro.IO
{
    public static partial class IOFunctions
    {
        public static SimpleObjectSerializer Serialize(object o, Stream s)
        {
            var os = new SimpleObjectSerializer(o);
            os.SerializeTo(s);
            return os;
        }

        public static byte[] Serialize(object o)
        {
            var os = new SimpleObjectSerializer(o);
            return os.Serialize();
        }

        public static byte[] Serialize(object o, SimpleObjectFieldSerializationMode FieldMode)
        {
            var os = new SimpleObjectSerializer(o, FieldMode);
            return os.Serialize();
        }

        public static object Deserialize(byte[] data)
        {
            using (var ms = new MemoryStream(data))
            using (var b = new BinaryReader(ms))
                return new SimpleObjectDeserializer(b).Object;
        }
        public static object Deserialize(BinaryReader b)
        {
            return new SimpleObjectDeserializer(b).Object;
        }

        public static SimpleObjectFieldSerializationMode DefaultFieldSerialization = SimpleObjectFieldSerializationMode.Fields;

        public static string GetTempFile(string Extension)
        {
            if (Extension == null) return Path.GetTempFileName();
            return Path.Combine(Path.GetTempPath(),
                Path.ChangeExtension(Guid.NewGuid().ToString(), Extension));
        }
    }

    public enum SimpleObjectFieldSerializationMode
    {
        /// <summary>
        /// Same as binary serialization: public and private fields
        /// </summary>
        Fields,
        /// <summary>
        /// Same as xml: public writable fields and properties
        /// </summary>
        PublicFieldsAndProperties,
    }

    public abstract class SimpleObjectSerializationBase
    {
        public readonly TypeCode TypeCode;
        public readonly object Object;
        public readonly bool IsArray;
        protected readonly DefinitionList defs;
        protected readonly TypeReference TypeRef;
        protected int ObjectIndex;

        protected const byte CommandArraySpecifier = 128;
        protected const byte TypeCodeCompressedStringCollection = 64;
        protected const byte TypeCodeTypeCollection = 65;
        protected const byte TypeCodePreviousObject = 66;
        protected const BindingFlags Fieldflags = BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic;

        SimpleObjectSerializationBase(DefinitionList defs)
        {
            this.defs = defs;
        }

        protected SimpleObjectSerializationBase(object Value, DefinitionList defs) :
            this(defs)
        {
            this.Object = Value;
            if (Value == null) return;

            var type = Value.GetType();
            if (type.IsArray)
            {
                IsArray = true;
                type = type.GetElementType();
            }
            this.TypeCode = Type.GetTypeCode(type);
            if (TypeCode == TypeCode.Object)
            {
                TypeRef = defs.RegisterType(type);
            }

            if (NeedRegister)
                defs.Register(Object, this);

        }

        protected bool NeedRegister
        {
            get
            {
                return IsArray || TypeCode == TypeCode.Object;
            }
        }


        /// <summary>
        /// deserialization constructor
        /// </summary>        
        protected SimpleObjectSerializationBase(BinaryReader b, DefinitionList defs)
            : this(defs)
        {
            var by = b.ReadByte();

            while (true)
            {
                if (by == TypeCodeCompressedStringCollection)
                {
                    defs.Strings.Deserialize(b);
                }
                else if (by == TypeCodeTypeCollection)
                {
                    defs.DeserializeTypes(b);
                }
                else if (by == TypeCodePreviousObject)
                {
                    ObjectIndex = b.ReadUInt16();
                    var po = defs.Objects[ObjectIndex];
                    Object = po.Object;
                    TypeCode = po.Serializer.TypeCode;
                    IsArray = po.Serializer.IsArray;
                    return;
                }
                else
                    break;

                by = b.ReadByte();
            }

            if ((by & CommandArraySpecifier) > 0)
            {
                IsArray = true;
                by ^= CommandArraySpecifier;
            }

            if (by == 0) return;
            TypeCode = (TypeCode)by;

            if (TypeCode == TypeCode.Object)
            {
                var tn = b.ReadUInt16();
                TypeRef = defs.GetType(tn);
            }

            this.Object = Restore(b);
        }

        protected virtual object Restore(BinaryReader b)
        {
            return null;
        }

        protected class RegisteredObject
        {
            public object Object;
            public SimpleObjectSerializationBase Serializer;
            public int Index;
        }

        protected class DefinitionList
        {
            List<TypeReference> types = new List<TypeReference>();
            public readonly StringCompacterCollection Strings = new StringCompacterCollection();

            public readonly List<RegisteredObject> Objects = new List<RegisteredObject>();

            public TypeReference RegisterType(Type type)
            {
                var tr = types.FirstOrDefault(t => t.Type == type);
                if (tr == null)
                {
                    tr = new TypeReference(
                         type,
                         Strings.Add(type.FullName + ", " + type.Assembly.GetName().Name),
                         types.Count
                    );
                    //if (tr.Constructor == null)throw new Exception(type.FullName + " is not valid for serialization: the object does not contain a parameterless constructor");
                    types.Add(tr);
                }
                return tr;
            }

            public RegisteredObject Register(object obj, SimpleObjectSerializationBase o)
            {
                var r = new RegisteredObject { Object = obj, Serializer = o, Index = Objects.Count };
                Objects.Add(r);
                o.ObjectIndex = r.Index;
                return r;
            }

            public TypeReference GetType(int i)
            {
                return types[i];
            }


            public int AddString(string s)
            {
                return Strings.Add(s);
            }

            internal void Serialize(SimpleObjectSerializer s)
            {
                var w = s.Writer;
                if (Strings.Count > 0)
                {
                    w.Write(TypeCodeCompressedStringCollection);
                    Strings.Serialize(s);
                }
                if (types.Count > 0)
                {
                    w.Write(TypeCodeTypeCollection);
                    w.Write((UInt16)types.Count);
                    for (int i = 0; i < types.Count; i++)
                    {
                        w.Write((UInt16)types[i].StringIndex);
                    }
                }
            }

            public SimpleObjectSerializer NullValueSerializer;

            public void DeserializeTypes(BinaryReader b)
            {
                types.Clear();
                int cnt = b.ReadUInt16();
                for (int i = 0; i < cnt; i++)
                {
                    int ti = b.ReadUInt16();
                    var name = Strings[ti];
                    Type type = null;
                    try
                    {
                        type = Type.GetType(name, false);
                    }
                    catch { }

                    if (type == null)
                    {
                        if (clean(ref name))
                            try
                            {
                                type = Type.GetType(name, false);
                            }
                            catch { }

                        if (type == null)
                            throw new TypeLoadException("Could not determine type for " + name + ". Does the executing assembly contain the specified assembly?");
                    }
                    types.Add(new TypeReference(
                        type,
                        ti, i
                    ));
                }
            }

            //public bool IgnoreTypeErrors = true;

            bool clean(ref string name)
            {
                var cleaned = System.Text.RegularExpressions.Regex.Replace(name, @",\s*Version=[0-9\.]+", string.Empty);
                if (cleaned == name) return false;
                name = cleaned;
                return true;
            }
        }

        public class TypeReference
        {
            public readonly Type Type;
            public readonly int StringIndex;
            public readonly int Index;

            public TypeReference(Type Type, int StringIndex, int Index)
            {
                this.Type = Type;
                this.StringIndex = StringIndex;
                this.Index = Index;
            }

            ConstructorInfo ci;
            public ConstructorInfo Constructor
            {
                get
                {
                    if (ci == null)
                        ci = Type.GetConstructor(Fieldflags, null, Type.EmptyTypes, null);
                    return ci;
                }
            }
        }

        public override string ToString()
        {
            if (Object == null) return null;
            return Object.ToString();
        }

        public bool IsEmpty
        {
            get
            {
                return TypeCode == TypeCode.Empty;
            }
        }
    }

    public interface IContentWriter
    {
        void WriteContents(BinaryWriter w);
    }

    public class SimpleObjectSerializer : SimpleObjectSerializationBase, IContentWriter
    {

        public readonly SimpleObjectFieldSerializationMode FieldMode;
        public readonly IContentWriter[] Children;
        public readonly ICustomSerializer CustomSerializer;
        protected readonly int StringIndex;

        public SimpleObjectSerializer(object Value)
            : this(Value, IOFunctions.DefaultFieldSerialization)
        {
        }

        public SimpleObjectSerializer(object Value, SimpleObjectFieldSerializationMode FieldMode)
            : this(Value, FieldMode, new DefinitionList())
        {
        }

        private SimpleObjectSerializer(object Value, SimpleObjectFieldSerializationMode FieldMode, DefinitionList Types)
            : base(Value, Types)
        {
            this.FieldMode = FieldMode;
            if (IsEmpty) return;

            if (IsArray)
            {
                Children = GetArrayValues().ToArray();
            }
            else if (TypeCode == TypeCode.Object)
            {
                this.CustomSerializer = Object as ICustomSerializer;
                if (CustomSerializer != null && CustomSerializer.Initialize(this))
                    return;
                Children = GetFields().ToArray();
            }
            else if (TypeCode == TypeCode.String)
                StringIndex = defs.Strings.Add((string)Value);
        }

        IEnumerable<IContentWriter> GetArrayValues()
        {
            var arr = (Array)Object;
            for (int i = 0; i < arr.Length; i++)
            {
                var o = arr.GetValue(i);
                yield return GetSubValue(o);
            }
        }

        IContentWriter GetSubValue(object o)
        {
            if (o == null)
            {
                if (defs.NullValueSerializer == null)
                    defs.NullValueSerializer = new SimpleObjectSerializer(null, FieldMode, defs);
                return defs.NullValueSerializer;
            }
            var res = defs.Objects.FirstOrDefault(r => r.Object == o);
            if (res == null)
                return new SimpleObjectSerializer(o, FieldMode, defs);
            return new PreviousObjectWriter
            {
                Object = (SimpleObjectSerializer)res.Serializer
            };
        }

        class PreviousObjectWriter : IContentWriter
        {
            public SimpleObjectSerializer Object;

            public void WriteContents(BinaryWriter w)
            {
                w.Write(TypeCodePreviousObject);
                w.Write((UInt16)Object.ObjectIndex);
            }
        }

        IEnumerable<FieldReference> GetFields()
        {
            var vars = GetVariables(TypeRef.Type).Select(mi => new MemberValue { Member = mi }).
                 Where(m => ShouldSerialize(m.Member, ref m.Value)).ToArray();

            foreach (var mi in vars)
            {
                var o = GetSubValue(mi.Value);
                yield return new FieldReference
                {
                    FieldIndex = defs.Strings.Add(mi.Member.Name),
                    Serializer = o
                };
            }
        }


        BinaryWriter w;
        public BinaryWriter Writer
        {
            get { return w; }
        }


        public void SerializeTo(Stream s)
        {
            var b = new BinaryWriter(s);
            SerializeTo(b);
        }

        void writeindex(int i)
        {
            w.Write((UInt16)i);
        }

        void IContentWriter.WriteContents(BinaryWriter w)
        {
            WriteContents(w);
        }

        void WriteContents(BinaryWriter w)
        {
            this.w = w;

            if (IsEmpty)
            {
                WriteEmpty();
                return;
            }


            var tc = (byte)TypeCode;
            if (IsArray) tc |= CommandArraySpecifier;
            w.Write(tc);

            if (TypeRef != null)
                writeindex(TypeRef.Index);

            if (CustomSerializer != null)
            {
                if (CustomSerializer.Serialize(this)) return;
            }

            if (Children != null)
            {
                if (IsArray)
                    w.Write(Children.Length);
                else
                    w.Write((UInt16)Children.Length);
                foreach (var o in Children)
                {
                    o.WriteContents(w);
                }
            }
            else if (TypeCode != TypeCode.DBNull)
                WriteValue();
        }

        public void SerializeTo(BinaryWriter w)
        {
            this.w = w;

            //write defs
            defs.Serialize(this);


            //write
            WriteContents(w);

        }

        public byte[] Serialize()
        {
            using (var ms = new MemoryStream())
            {
                SerializeTo(ms);
                return ms.ToArray();
            }
        }


        void WriteEmpty()
        {
            w.Write((byte)0);
        }

        public void WriteSubValue(object value)
        {
            if (value == null)
                WriteEmpty();
            else
            {
                GetSubValue(value).WriteContents(w);
            }
        }

        void WriteValue()
        {
            if (TypeCode == TypeCode.DateTime)
                w.Write(((DateTime)Object).Ticks);
            else if (TypeCode == TypeCode.String)
                w.Write((UInt16)StringIndex);

            else if (TypeCode == TypeCode.Int32)
                w.Write((int)Object);
            else if (TypeCode == TypeCode.Int64)
                w.Write((long)Object);
            else if (TypeCode == TypeCode.UInt32)
                w.Write((uint)Object);
            else if (TypeCode == TypeCode.UInt64)
                w.Write((ulong)Object);
            else if (TypeCode == TypeCode.Double)
                w.Write((double)Object);
            else if (TypeCode == TypeCode.Single)
                w.Write((float)Object);
            else if (TypeCode == TypeCode.Byte)
                w.Write((byte)Object);
            else if (TypeCode == TypeCode.Boolean)
                w.Write((bool)Object);

            else
            {
                var type = Type.GetType("System." + TypeCode);
                var p = w.GetType().GetMethod("Write", new Type[] { type });
                p.Invoke(w, new object[] { Object });
            }
        }

        protected bool ShouldSerialize(MemberInfo m, ref object val)
        {
            if (!m.GetIsWritable()) return false; //don't serialize readonly fields and properties
            if (m.GetCustomAttributes(typeof(NonSerializedAttribute), false).Length > 0) return false; //skip fields/props with the nonserialized attribute
            var shs = m.DeclaringType.GetMethod("ShouldSerialize" + m.Name,
                BindingFlags.Instance | BindingFlags.NonPublic | BindingFlags.Public,
                null, Type.EmptyTypes, null);
            if (shs != null && !(bool)shs.Invoke(Object, null))
                return false;
            val = m.GetValue(Object);
            if (val is Pointer || val is IntPtr) return false;
            var dv = (DefaultValueAttribute)m.GetCustomAttributes(typeof(DefaultValueAttribute), true).FirstOrDefault();
            if (dv == null) return true;
            return !object.Equals(val, dv.Value);
        }


        protected virtual IEnumerable<MemberInfo> GetVariables(Type type)
        {
            if (FieldMode == SimpleObjectFieldSerializationMode.Fields)
            {
                while (type != typeof(object))
                {
                    foreach (var m in type.GetFields(Fieldflags))
                        yield return m;
                    type = type.BaseType;
                }
            }
            else
            {
                foreach (var m in type.GetFields())
                {
                    yield return m;
                }
                foreach (var m in type.GetProperties())
                {
                    yield return m;
                }
            }
        }

        class FieldReference : IContentWriter
        {
            public IContentWriter Serializer;
            public int FieldIndex;
            public void WriteContents(BinaryWriter w)
            {
                w.Write((UInt16)FieldIndex);
                Serializer.WriteContents(w);
            }
        }

        class MemberValue
        {
            public MemberInfo Member;
            public object Value;
        }


    }

    public class SimpleObjectDeserializer : SimpleObjectSerializationBase
    {

        internal SimpleObjectDeserializer(BinaryReader b)
            : this(b, new DefinitionList())
        {
        }

        private SimpleObjectDeserializer(BinaryReader b, DefinitionList types)
            : base(b, types)
        {

        }

        Type GetObjectType()
        {
            if (TypeRef == null)
                return Type.GetType("System." + TypeCode);
            return TypeRef.Type;
        }

        public BinaryReader Reader
        {
            get { return b; }
        }

        BinaryReader b;

        protected override object Restore(BinaryReader reader)
        {
            this.b = reader;
            if (IsArray)
                return RestoreArray();
            else if (TypeCode == TypeCode.Object)
                return restoreobject();
            else if (TypeCode == TypeCode.DateTime)
                return new DateTime(b.ReadInt64());
            else if (TypeCode == TypeCode.Int32)
                return b.ReadInt32();
            else if (TypeCode == TypeCode.String)
                return defs.Strings[b.ReadUInt16()];
            else if (TypeCode == TypeCode.DBNull)
                return DBNull.Value;
            else
            {
                //most common types are strongly referenced, other methods are referenced with reflection
                var p = b.GetType().GetMethod("Read" + TypeCode.ToString());
                return p.Invoke(b, null);
            }
        }

        public Array RestoreArray()
        {
            var len = b.ReadInt32();
            var arr = Array.CreateInstance(GetObjectType(), len);
            defs.Register(arr, this);
            for (int i = 0; i < len; i++)
            {
                var val = GetSubValue();
                arr.SetValue(val, i);
            }
            return arr;
        }

        public object GetSubValue()
        {
            return new SimpleObjectDeserializer(b, defs).Object;
        }

        object restoreobject()
        {
            var ci = TypeRef.Constructor;
            if (ci == null)
                throw new Exception("Cannot create an instance of " + TypeRef.Type.FullName);
            var o = ci.Invoke(null);
            defs.Register(o, this);
            var co = o as ICustomSerializer;
            if (co != null)
            {
                if (co.Deserialize(this)) return o;
            }

            var cnt = b.ReadUInt16(); //object serialized field count
            if (cnt > 0)
            {
                for (int i = 0; i < cnt; i++)
                {
                    int fi = b.ReadUInt16();
                    string name = defs.Strings[fi];
                    var mi = GetMember(TypeRef.Type, name);
                    var val = GetSubValue();
                    if (mi == null) continue; //possible version difference
                    mi.SetValue(o, val);
                }
            }

            return o;
        }


        MemberInfo GetMember(Type type, string field)
        {
            var mi = type.GetMember(field, MemberTypes.Field | MemberTypes.Property, Fieldflags);
            if (mi.Length == 0)
            {
                if (type == typeof(object)) return null;
                return GetMember(type.BaseType, field);
            }
            return mi[0];
        }
    }

    public interface ICustomSerializer
    {
        bool Initialize(SimpleObjectSerializer serializer);
        bool Serialize(SimpleObjectSerializer serializer);
        bool Deserialize(SimpleObjectDeserializer deserializer);
    }

    public class StringCompacter
    {
        List<char> chars;

        public StringCompacter()
        {
            chars = new List<char>();
            for (char c = 'A'; c < 91; c++)
            {
                chars.Add(c);
                chars.Add(char.ToLower(c));
            }
            chars.AddRange("._+, <>");
            setbase();
        }

        public StringCompacter(IEnumerable<char> chars)
        {
            this.chars = new List<char>(chars);
            setbase();
        }

        public StringCompacter(params char[] chars)
        {
            this.chars = new List<char>(chars);
            setbase();
        }

        void setbase()
        {
            Base = (int)Math.Ceiling(Math.Log(chars.Count + 1, 2));
        }

        int Base;


        public char[] GetChars()
        {
            return chars.ToArray();
        }

        public byte[] Serialize(string s)
        {
            var ba = new System.Collections.BitArray(s.Length * Base);

            int pos = 0;
            foreach (var c in s)
            {
                int mask = 1;
                int val = chars.IndexOf(c) + 1;
                if (val == 0)
                    throw new ArgumentException();
                for (int i = 0; i < Base; i++)
                {
                    if ((val & mask) > 0)
                        ba[pos] = true;
                    mask <<= 1;
                    pos++;
                }
            }

            int len = (int)Math.Ceiling((ba.Length + Base) / 8d);
            byte[] arr = new byte[len];

            ba.CopyTo(arr, 0);

            return arr;
        }

        public string Deserialize(BinaryReader b)
        {
            return Deserialize(Enumerate(b));
        }

        IEnumerable<byte> Enumerate(BinaryReader b)
        {
            var s = b.BaseStream;
            var len = s.Length;
            while (s.Position < len)
                yield return b.ReadByte();
        }

        StringBuilder sb;
        public string Deserialize(IEnumerable<byte> data)
        {
            if (sb == null) sb = new StringBuilder();
            else sb.Length = 0;

            var en = data.GetEnumerator();

            int pos = 256;
            byte b = 0;
            while (true)
            {
                int val = 0;
                for (int i = 0; i < Base; i++)
                {
                    if (pos > 128)
                    {
                        pos = 1;
                        if (!en.MoveNext()) break;
                        b = en.Current;
                    }
                    if ((b & pos) > 0)
                    {
                        val |= (1 << i);
                    }

                    pos <<= 1;
                }
                if (val == 0) break;
                sb.Append(chars[--val]);
            }


            return sb.ToString();
        }
    }

    public class StringCompacterCollection : ICustomSerializer
    {
        List<string> list = new List<string>();

        public int Count
        {
            get
            {
                return list.Count;
            }
        }

        public int Add(string s)
        {
            int i = list.IndexOf(s);
            if (i == -1)
            {
                list.Add(s);
                compacter = null;
                return list.Count - 1;
            }
            return i;
        }

        public string this[int index]
        {
            get { return list[index]; }
        }

        StringCompacter compacter;

        #region ICustomSerializer Members

        public bool Serialize(SimpleObjectSerializer serializer)
        {
            serializer.Writer.Write((UInt16)Count);
            if (Count == 0) return true;

            if (compacter == null)
            {
                var chars = new List<char>();
                foreach (var s in list)
                {
                    foreach (var c in s)
                        if (!chars.Contains(c))
                            chars.Add(c);
                }

                compacter = new StringCompacter(chars);
            }

            serializer.Writer.Write(new string(compacter.GetChars()));
            foreach (var s in list)
                serializer.Writer.Write(compacter.Serialize(s));

            return true;
        }

        bool ICustomSerializer.Initialize(SimpleObjectSerializer s)
        {
            return true;
        }

        public bool SerializationHandled { get { return true; } }

        internal void Deserialize(BinaryReader reader)
        {
            list.Clear();
            compacter = null;
            int cnt = reader.ReadUInt16();
            if (cnt > 0)
            {
                var chars = reader.ReadString();
                compacter = new StringCompacter(chars);

                for (int i = 0; i < cnt; i++)
                {
                    list.Add(compacter.Deserialize(reader));
                }
            }
        }

        public bool Deserialize(SimpleObjectDeserializer deserializer)
        {
            Deserialize(deserializer.Reader);
            return true;
        }

        #endregion
    }

}

namespace Subro
{
    public static class ReflectionExtensions
    {
        [DebuggerHidden]
        public static object GetValue(this MemberInfo mi, object o)
        {
            //if (o == null) return null; //can be static
            if (mi is PropertyInfo)
                return ((PropertyInfo)mi).GetValue(o, null);
            if (mi is FieldInfo)
                return ((FieldInfo)mi).GetValue(o);
            return null;
        }

        [DebuggerHidden]
        public static object GetValue(this PropertyInfo pi, object o)
        {
            //if (o == null) return null;
            return pi.GetValue(o, null);
        }

        public static Type GetMemberType(this MemberInfo mi)
        {
            if (mi is PropertyInfo)
                return ((PropertyInfo)mi).PropertyType;
            if (mi is FieldInfo)
                return ((FieldInfo)mi).FieldType;
            return null;
        }

        public static bool GetIsWritable(this MemberInfo mi)
        {
            if (mi is FieldInfo)
                return !((FieldInfo)mi).IsInitOnly;
            return ((PropertyInfo)mi).CanWrite;
        }

        public static IEnumerable<MemberInfo> GetFieldsAndProperties(this Type type)
        {
            MemberInfo[] fields = type.GetFields();
            return fields.Concat(type.GetProperties());
        }

        [DebuggerHidden]
        public static void SetValue(this MemberInfo mi, object obj, object value)
        {
            if (mi is PropertyInfo)
                ((PropertyInfo)mi).SetValue(obj, value, null);
            else
                ((FieldInfo)mi).SetValue(obj, value);
        }

        public static IEnumerable<T> GetAttributes<T>(this ICustomAttributeProvider cap)
        {
            return from a in cap.GetCustomAttributes(typeof(T), true)
                   select (T)a;
        }
        public static T GetAttribute<T>(this ICustomAttributeProvider cap)
            where T : Attribute
        {
            return GetAttributes<T>(cap).FirstOrDefault();
        }
    }
}


namespace Subro
{
    /// <summary>
    /// Comparer that tries to find the 'strongest' comparer for a type. 
    /// if the type implements a generic IComparable, that is used.
    /// otherwise if it implements a normal IComparable, that is used.
    /// If neither are implemented, the ToString versions are compared. 
    /// INullable structures are also supported.
    /// This way, the DefaultComparer can compare any object types and can be used for sorting any source.
    /// </summary>
    /// <example>Array.Sort(YourArray,new GenericComparer());</example>
    public class GenericComparer : IGenericComparer
    {
        public GenericComparer()
        {

        }
        public GenericComparer(Type Type)
        {
            this.Type = Type;
        }

        Type type;
        public Type Type
        {
            get
            {
                return type;
            }
            set
            {
                if (type == value) return;
                if (value == null) throw new ArgumentNullException();
                type = value;
                reset();
            }
        }

        Type targettype;
        /// <summary>
        /// normally the same as the type, but can be set to a different type
        /// </summary>
        public Type TargetType
        {
            get
            {
                if (targettype == null) return type;
                return targettype;
            }
            set
            {
                if (TargetType == value) return;
                targettype = value;
                reset();
            }
        }

        void reset()
        {
            comp = null;
            eq = null;
        }



        IComparer comp;
        IEqualityComparer eq;


        public bool Descending
        {
            get
            {
                return factor < 0;
            }
            set
            {
                factor = value ? -1 : 1;
            }
        }

        int factor = 1;


        public int Compare(object x, object y)
        {
            if (x == y) return 0;
            if (x == null) return -factor;
            if (y == null) return factor;
            if (type == null)
                Type = x.GetType();
            if (comp == null)
                comp = CompareFunctions.GetComparer(type, TargetType);
            return factor * comp.Compare(x, y);
        }

        #region IEqualityComparer Members

        public new bool Equals(object x, object y)
        {
            if (x == y) return true;
            if (x == null || y == null) return false;
            if (type == null)
                Type = x.GetType();
            if (eq == null)
                eq = CompareFunctions.GetEqualityComparer(type, TargetType);
            return eq.Equals(x, y);
        }

        public int GetHashCode(object obj)
        {
            if (obj == null) return 0; return obj.GetHashCode();
        }

        #endregion

        public IGenericComparer ThenBy(GenericComparer cmp)
        {
            var list = new GenericComparers();
            list.Add(cmp);
            return list;
        }
    }

    public interface IGenericComparer : IComparer, IEqualityComparer
    {
        IGenericComparer ThenBy(GenericComparer cmp);
    }

    /// <summary>
    /// A list of <see cref="GenericComparer"/> to compare multiple GenericComparers after one and other
    /// </summary>
    public class GenericComparers : List<GenericComparer>, IGenericComparer
    {
        public int Compare(object x, object y)
        {
            return ObjectExtensions.Compare(this.OfType<IComparer>(), x, y);
        }

        public new bool Equals(object x, object y)
        {
            return this.All(c => c.Equals(x, y));
        }

        public int GetHashCode(object obj)
        {
            if (obj == null) return 0; return obj.GetHashCode();
        }

        public IGenericComparer ThenBy(GenericComparer cmp)
        {
            Add(cmp);
            return this;
        }
    }

    public static partial class ObjectExtensions
    {
        public static int Compare(this IEnumerable<IComparer> cmp, object x, object y)
        {
            foreach (var c in cmp)
            {
                int i = c.Compare(x, y);
                if (i != 0) return i;
            }
            return 0;
        }
    }

    static partial class CompareFunctions
    {
        static IComparer GetGenericComparer(Type From, Type To)
        {
            return (IComparer)GetGeneric(From, To, typeof(IComparable<>));
        }

        static IEqualityComparer GetGenericEqualityComparer(Type From, Type To)
        {
            return (IEqualityComparer)GetGeneric(From, To, typeof(IEquatable<>), typeof(IComparable<>));
        }

        static Type GetInnerType(Type type)
        {
            if (type.IsGenericType && typeof(Nullable<>) == type.GetGenericTypeDefinition())
                return type.GetGenericArguments()[0];
            return type;
        }

        static bool hasbase(Type type)
        {
            return type.BaseType != null && type.BaseType != typeof(object);
        }

        static object GetGeneric(Type From, Type To, params Type[] GenericBaseTypes)
        {
            //From = GetBaseType(From);
            while (true)
            {
                foreach (var g in GenericBaseTypes)
                {
                    var type = To;
                    while (type != null)
                    {

                        if (g.MakeGenericType(type).IsAssignableFrom(From))
                        {
                            if (g == typeof(IEquatable<>))
                                return Activator.CreateInstance(typeof(StrongEquatable<,>).MakeGenericType(From, type));
                            return Activator.CreateInstance(typeof(StrongCompare<,>).MakeGenericType(From, type));
                        }
                        var inner = GetInnerType(type);
                        if (inner == type)
                            type = type.BaseType;
                        else
                            type = inner;
                    }
                }

                if (hasbase(From))
                    From = From.BaseType;
                else
                    return null;
            }
            //return null;
        }

        internal static IComparer GetComparer(Type From, Type To)
        {
            if (From == To && From == typeof(string)) return new StringComparer();
            From = GetInnerType(From);

            var gen = GetGenericComparer(From, To);
            if (gen != null)
                return gen;
            else if (typeof(IComparable).IsAssignableFrom(From))
            {
                return (IComparer)Activator.CreateInstance(typeof(NonGenericCompare<>).MakeGenericType(From));
            }
            return new StringComparer();
        }

        internal static IEqualityComparer GetEqualityComparer(Type From, Type To)
        {
            if (From == To && From == typeof(string)) return new StringComparer();
            From = GetInnerType(From);

            var eq = GetGenericEqualityComparer(From, To);
            if (eq != null)
                return eq;

            return new DefaultEquals();
        }

        class DefaultEquals : IEqualityComparer
        {
            public new bool Equals(object x, object y)
            {
                return x.Equals(y);
            }

            public int GetHashCode(object o)
            {
                return o.GetHashCode();
            }
        }
        /*
        class NullableComparer<T> : IComparer
            where T : struct
        {

            public readonly IComparer BaseComparer;
            public NullableComparer(IComparer BaseComparer)
            {
                this.BaseComparer = BaseComparer;

            }

            object getval(object o)
            {
                return ((Nullable<T>)o).Value;
            }

            public int Compare(object x, object y)
            {
                return BaseComparer.Compare(getval(x), getval(y));
            }
        }*/

        class StrongEquatable<F, T> : IEqualityComparer
          where F : IEquatable<T>
        {
            public new bool Equals(object x, object y)
            {
                return ((F)x).Equals((T)y);
            }

            public int GetHashCode(object o)
            {
                return o.GetHashCode();
            }
        }

        class StrongCompare<F, T> : IComparer, IEqualityComparer
            where F : IComparable<T>
        {
            public int Compare(object x, object y)
            {
                return ((F)x).CompareTo((T)y);
            }

            public new bool Equals(object x, object y)
            {
                return Compare(x, y) == 0;
            }

            public int GetHashCode(object o)
            {
                return o.GetHashCode();
            }
        }

        class NonGenericCompare<T> : IComparer
            where T : IComparable
        {
            public int Compare(object x, object y)
            {
                return ((T)x).CompareTo(y);
            }
        }

        class StringComparer : IComparer, IEqualityComparer
        {
            public int Compare(object x, object y)
            {
                return string.Compare(x.ToString(), y.ToString());
            }

            public new bool Equals(object x, object y)
            {
                return string.Equals(x.ToString(), y.ToString());
            }

            public int GetHashCode(object o)
            {
                return o.GetHashCode();
            }
        }
    }

    public class GenericComparer<T> : GenericComparer, IComparer<T>
    {

        public GenericComparer()
            : base(typeof(T))
        { }

        public int Compare(T a, T b)
        {
            return base.Compare(a, b);
        }
    }

    public class GenericComparer<T1, T2> : GenericComparer
    {
        public GenericComparer()
            : base(typeof(T1))
        {
            TargetType = typeof(T2);
        }
        public int Compare(T1 a, T2 b)
        {
            return base.Compare(a, b);
        }

        public bool Equals(T1 a, T2 b)
        {
            return base.Equals(a, b);
        }
    }


    public class PropertyDescriptorComparer : GenericComparer
    {
        public readonly PropertyDescriptor Prop;

        public PropertyDescriptorComparer(PropertyDescriptor Prop)
            : this(Prop, true)
        {
        }
        public PropertyDescriptorComparer(PropertyDescriptor Prop, bool Descending)
            : base(Prop.PropertyType)
        {
            this.Prop = Prop;
            this.Descending = Descending;
        }
    }



    static class Parser
    {

        public static string GetFieldName(Expression Field)
        {
            var arr = GetMembers(Field).ToArray();
            if (arr.Length == 0) throw new Exception("Could not resolve FieldName of " + Field);
            if (arr.Length == 1) return arr[0].Member.Name;
            throw new Exception("Multipe field names found for " + Field);
        }


        public static string GetFieldName<RecordType, T>(Expression<Func<RecordType, T>> Field)
        {
            return GetFieldName((LambdaExpression)Field);

        }

        public static IEnumerable<string> GetFieldNames<RecordType, T>(params Expression<Func<RecordType, T>>[] Fields)
        {
            return GetMembers(Fields).Select(f => f.Member.Name);
        }

        static IEnumerable<MemberExpression> GetMembers(params Expression[] expr)
        {
            foreach (var e in expr)
            {
                var exp = e;
                if (exp is LambdaExpression)
                    exp = (exp as LambdaExpression).Body;
                if (exp.NodeType == ExpressionType.Convert)
                    exp = (exp as UnaryExpression).Operand;
                if (exp is MemberExpression)
                    yield return (MemberExpression)exp;
                else if (exp is NewExpression)
                {
                    foreach (var me in
                        from ne in ((NewExpression)exp).Arguments
                        from m in GetMembers(ne)
                        select m)
                        yield return me;
                }


            }
        }
    }

}