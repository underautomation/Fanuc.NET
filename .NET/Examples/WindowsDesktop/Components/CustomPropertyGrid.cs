using System.Linq;
using System.Windows.Forms;

// Advanced Property Grid thats displays a Primary Interface Package
public partial class CustomPropertyGrid : UserControl
{
    private VScrollBar _vscroll;

    public CustomPropertyGrid()
    {
        InitializeComponent();
        _vscroll = grid.Controls.OfType<Control>().FirstOrDefault(ctl => ctl.AccessibilityObject.Role == AccessibleRole.Table)?.Controls?.OfType<VScrollBar>()?.FirstOrDefault();
    }


    public string LabelText
    {
        get
        {
            return lbl.Text;
        }
        set
        {
            lbl.Text = value;
        }
    }

    public object SelectedObject => grid.SelectedObject;


    public void SetSelectedObject(object value)
    {
        this.SuspendLayout();

        // conserve scroll bar position after a refresh
        var vScrollValue = _vscroll?.Value;

        if (value is object)
        {
            grid.SelectedObject = value;
            grid.ExpandAllGridItems();

            if (_vscroll != null)
                _vscroll.Value = vScrollValue ?? 0;
        }
        this.ResumeLayout();
    }
}

