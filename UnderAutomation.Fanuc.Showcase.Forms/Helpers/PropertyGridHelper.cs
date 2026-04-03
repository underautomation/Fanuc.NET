using System.Collections;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Data;
using System.Globalization;
using System.Reflection;
using System.Text;

public class ObjectConverter : ExpandableObjectConverter
{
    public override bool GetPropertiesSupported(ITypeDescriptorContext context)
    {
        return true;
    }

    public override PropertyDescriptorCollection GetProperties(ITypeDescriptorContext context, object value, Attribute[] attributes)
    {
        if (value is string) return null;
        IList list = value as IList;
        if (list == null || list.Count == 0)
            return base.GetProperties(context, value, attributes);

        var items = new PropertyDescriptorCollection(null);
        for (int i = 0; i < list.Count; i++)
        {
            object item = list[i];
            items.Add(new ExpandableCollectionPropertyDescriptor(list, i));
        }
        return items;
    }

    public override object ConvertTo(ITypeDescriptorContext pContext, CultureInfo pCulture, object value, Type pDestinationType)
    {
        if (pDestinationType == typeof(string) && value is IList)
        {
            IList v = value as IList;
            return (v == null) ? "" : $"({v.Count} Item{(v.Count > 1 ? "s" : "")})";
        }
        var defaultValue = base.ConvertTo(pContext, pCulture, value, pDestinationType);

        if (value is object && string.Equals(defaultValue, value.GetType().FullName)) return "";

        return defaultValue;
    }
}
public class ExpandableCollectionPropertyDescriptor : PropertyDescriptor
{
    private IList _Collection;
    private readonly int _Index;

    public ExpandableCollectionPropertyDescriptor(IList coll, int idx) : base(GetDisplayName(coll, idx), null)
    {
        _Collection = coll;
        _Index = idx;
    }

    private static string GetDisplayName(IList list, int index)
    {
        return "[" + index + "] " + CSharpName(list[index].GetType());
    }

    private static string CSharpName(Type type)
    {
        var sb = new StringBuilder();
        var name = type.Name;
        if (!type.IsGenericType) return name;
        sb.Append(name.Substring(0, name.IndexOf('`')));
        sb.Append("<");
        sb.Append(string.Join(", ", type.GetGenericArguments().Select(CSharpName).ToArray()));
        sb.Append(">");
        return sb.ToString();
    }

    public override bool CanResetValue(object component)
    {
        return true;
    }

    public override Type ComponentType
    {
        get { return this._Collection.GetType(); }
    }

    public override object GetValue(object component)
    {
        return _Collection[_Index];
    }

    public override bool IsReadOnly => true;

    public override string Name
    {
        get { return _Index.ToString(CultureInfo.InvariantCulture); }
    }

    public override Type PropertyType
    {
        get { return _Collection[_Index].GetType(); }
    }

    public override void ResetValue(object component)
    {
    }

    public override bool ShouldSerializeValue(object component)
    {
        return true;
    }

    public override void SetValue(object component, object value)
    {
        _Collection[_Index] = value;
    }
}


public class CollectionEditorBase : CollectionEditor
{
    protected PropertyGrid _PropertyGrid;
    private bool _ExpandedBefore;
    private int _CountBefore;

    public CollectionEditorBase(Type type) : base(type) { }

    public override object EditValue(ITypeDescriptorContext context, IServiceProvider provider, object value)
    {
        //Record entry state of property grid item
        GridItem giThis = (GridItem)provider;
        _ExpandedBefore = giThis.Expanded;
        _CountBefore = (giThis.Value as IList).Count;

        //Get the grid so later we can refresh it on close of editor
        PropertyInfo piOwnerGrid = provider.GetType().GetProperty("OwnerGrid", BindingFlags.Instance | BindingFlags.NonPublic | BindingFlags.Public);
        _PropertyGrid = (PropertyGrid)piOwnerGrid.GetValue(provider, null);

        //Edit the collection
        return base.EditValue(context, provider, value);
    }

    protected override CollectionForm CreateCollectionForm()
    {
        CollectionForm cf = base.CreateCollectionForm();
        cf.FormClosing += delegate (object sender, FormClosingEventArgs e)
        {
            _PropertyGrid.Refresh();
            //Because nothing changes which grid item is the selected one, expand as desired
            if (_ExpandedBefore || _CountBefore == 0) _PropertyGrid.SelectedGridItem.Expanded = true;
        };
        return cf;
    }

    protected override object CreateInstance(Type itemType)
    {
        //Fixes the "Constructor on type 'System.String' not found." when it is an empty list of strings
        if (itemType == typeof(string)) return string.Empty;
        else return Activator.CreateInstance(itemType);
    }
}

