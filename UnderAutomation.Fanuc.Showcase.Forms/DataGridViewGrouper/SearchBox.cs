using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing.Design;
using System.Windows.Forms.Design;
using System.Text.RegularExpressions;

namespace Subro.Controls
{

    public abstract partial class SearchBoxBase : UserControl, ISupportInitialize
    {
        public SearchBoxBase()
        {
            searchmatcher = new StringSearchMatcher(GetDefaultMode());
            InitializeComponent();            
        }

        StringSearchMatcher searchmatcher;

        protected virtual SearchBoxMode GetDefaultMode()
        {
            return SearchBoxMode.Lookup_Wildcards;
        }


        public SearchBoxMode Mode
        {
            get { return searchmatcher.Mode; }
            set
            {
                if (Mode == value) return;
                searchmatcher.Mode = value;
                btnNext.Visible = value != SearchBoxMode.Filter;                
                NotifyStateChanged(true);
            }
        }

        bool ShouldSerializeMode()
        {
            return Mode != GetDefaultMode();
        }

        public void ResetMode()
        {
            Mode = GetDefaultMode();
        }

        public Func<string, bool> SearchDelegate { get { return searchmatcher.SearchDelegate; } }

        bool alwayswildcard = false;
        [DefaultValue(false)]
        public bool AlwaysSearchInnerText
        {
            get
            {
                return alwayswildcard;
            }
            set
            {
                if (alwayswildcard == value) return;
                alwayswildcard = value;
                searchmatcher.AlwaysSearchInnerText = value;
                NotifyStateChanged(false);
            }
        }

        protected void NotifyStateChanged(bool resettext)
        {
            if (IsBusy || disposed) return;
            ResetStartPosition(null);
            NullResult = false;
            checkvalid();

            if (txt.TextLength > 0)
            {
                if (resettext)
                    txt.Clear();
                else
                    check();
            }
        }

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override sealed void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
            while (registeredcontrols.Count > 0)
                UnRegisterControl(registeredcontrols[0]);
            disposed = true;
            OnDisposed();
        }
        

        bool disposed;
        

        protected virtual void OnDisposed() { }

        #region ISupportInitialize Members

        int initializing;

        public bool IsInitializing { get { return initializing > 0; } }
        public void BeginInit()
        {
            initializing++;
        }

        public void EndInit()
        {
            if (--initializing == 0)
                OnEndInit();
        }

        protected virtual void OnEndInit()
        {
            NotifyStateChanged(false);
        }

        #endregion

        #region validate mode and state of readiness

        void checkvalid()
        {
            isvalid = CheckIsReady();
            if (isvalid && !Supports(Mode))
            {
                isvalid=false;
                OnInvalidModeSelected();                
            }
            txt.Enabled = isvalid;
            
        }


        bool isvalid;
        public bool IsValid
        {
            get
            {
                return isvalid;
            }
        }

        protected virtual void OnInvalidModeSelected()
        {
            var ex = new Exception("Source does not support " + Mode);
            if(DesignMode)
                throw ex;
            ShowException(ex);
        }

        protected virtual bool CheckIsReady()
        {
            return initializing==0;
        }

        protected virtual bool Supports(SearchBoxMode Mode)
        {
            return true;
        }

        #endregion


        Label lbl;
        [DefaultValue(false)]
        [Category("Label")]
        public bool ShowLabel
        {
            get { return lbl != null; }
            set
            {
                if (ShowLabel == value) return;
                if (value)
                {
                    lbl = new Label();
                    setlabeltext();
                    lbl.Dock = DockStyle.Left;
                    lbl.AutoSize = true;
                    Controls.Add(lbl);
                }
                else
                {
                    lbl.Dispose();
                    lbl = null;
                }
            }
        }

        void setlabeltext()
        {
            if (labeltext == null)
            {
                var val = "Search";
                GetText(val, ref val);
                lbl.Text = val;
            }
            else
                lbl.Text = labeltext;
        }

        partial void GetText(string keyword, ref string Value);

        string labeltext = null;
        [Category("Label")]
        [DefaultValue(null)]
        public string CustomLabelText
        {
            get
            {
                return labeltext;
            }
            set
            {                
                labeltext = value;
                if (lbl == null)
                {
                    if (DesignMode) ShowLabel = true;
                }
                else
                    setlabeltext();
            }
        }


        protected bool HandleKey(KeyEventArgs k)
        {
            return HandleKey(k.KeyCode, k.Modifiers);
        }

        protected bool HandleKey(Keys key, Keys mod)
        {
            if (key == Keys.Back)
            {
                if (mod == Keys.Control)
                    Text = null;
                else if (Text.Length > 0)
                    Text = Text.Substring(0, Text.Length - 1);
            }
            else if (key == Keys.Escape)
                Text = null;
            else
                return false;
            return true;
        }

        protected bool HandleKey(KeyPressEventArgs e)
        {
            var c = e.KeyChar;
            if (c < 32 || c > 127) return false;
            Text += c.ToString();
            return true;
        }

        void c_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (HandleRegisteredKeyDowns)
                e.Handled = HandleKey(e);
        }

        void c_KeyDown(object sender, KeyEventArgs e)
        {
            if(HandleRegisteredKeyDowns)
                e.Handled = HandleKey(e);
        }

        protected bool HandleRegisteredKeyDowns = true;

        List<Control> registeredcontrols = new List<Control>();
        protected void RegisterControl(Control c)
        {
            if (registeredcontrols.Contains(c)) return;
            registeredcontrols.Add(c);
            c.KeyDown += new KeyEventHandler(c_KeyDown);
            c.KeyPress += new KeyPressEventHandler(c_KeyPress);
        }       

        protected void UnRegisterControl(Control c)
        {
            if (registeredcontrols.Remove(c))
            {
                c.KeyDown -= new KeyEventHandler(c_KeyDown);
                c.KeyPress -= new KeyPressEventHandler(c_KeyPress);
            }
        }

        private void txt_TextChanged(object sender, EventArgs e)
        {
            searchmatcher.SearchText = Text;
            check();
            OnTextChanged(e);
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            SearchNext();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            Text = null;
        }

        [DefaultValue(null)]
        public override string Text
        {
            get
            {
                return txt.Text;
            }
            set
            {
                txt.Text = value;
            }
        }

        public int TextLength
        {
            get { return searchmatcher.TextLength; }
        }

        int prevlen;
        void check()
        {
            setvisible();
            if (!isvalid) return;
            if (txt.TextLength < prevlen)
                ResetStartPosition(null);
            prevlen = txt.TextLength;

            if (Mode == SearchBoxMode.Filter)
                Filter();
            else
                Search();

            btnNext.Enabled = prevlen > 0 && !nullresult;
        }

        void setvisible()
        {
            if (autohide)
                Visible = txt.TextLength > 0;
        }

        private bool autohide;
        [DefaultValue(false)]
        public bool AutoHide
        {
            get { return autohide; }
            set
            {
                if (autohide == value) return;
                autohide = value;
                setvisible();
            }
        }


        protected abstract void ResetStartPosition(object storedpos);

        protected abstract bool IncreasePosition();

        protected abstract void SetFoundPosition();

        bool nullresult;

        [Browsable(false),DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public bool NullResult
        {
            get { return nullresult; }
            private set
            {
                if (nullresult == value) return;
                nullresult = value;
                txt.BackColor = value ? notfoundcol : Color.Empty;
            }
        }

        Color notfoundcol = Color.Red;

        public Color NotFoundColor
        {
            get { return notfoundcol; }
            set { notfoundcol = value; }
        }

        bool ShouldSerializeNotFoundColor()
        {
            return notfoundcol != Color.Red;
        }

        bool searching;
        public bool Search()
        {
            var res = search();
            NullResult = txt.TextLength > 0 && !res;
            return res;
        }

        public bool IsSearching
        {
            get { return searching; }
        }

        public bool IsFiltering
        {
            get
            {
                return filtering;
            }
        }

        /// <summary>
        /// Indicates if either a filtering or searching is in progress
        /// </summary>
        public bool IsBusy
        {
            get
            {
                return searching || filtering || initializing > 0;
            }
        }


        public bool SearchNext()
        {
            IncreasePosition();
            return Search();
        }

        bool search()
        {
            searching = true;
            try
            {
                return txt.TextLength > 0 && search(searchmatcher);
            }
            catch (Exception ex)
            {
                ShowException(ex);
            }
            finally
            {
                searching = false;
            }
            return false;
        }

        protected abstract object GetPosition();

        protected abstract object GetCurrent();

        protected virtual bool search(StringSearchMatcher search)
        {
            object pos = GetPosition();
            for (; ; )
            {

                var val = GetCurrent();
                if (val != null && search.Matches(val.ToString()))
                {
                    SetFoundPosition();
                    return true;
                }
                if (!IncreasePosition()) break;
            }
            ResetStartPosition(pos);
            return false;
        }



        bool filtering;
        public void Filter()
        {
            filtering = true;
            try
            {
                filter(searchmatcher);
            }
            catch (Exception ex)
            {
                ShowException(ex);
            }
            finally
            {
                filtering = false;
            }
        }


        protected virtual void ShowException(Exception ex)
        {
            if (Disposing) return;            
            //new ErrorForm(ex).Show(this);            
            MessageBox.Show(ex.Message); //call your own error routine here
        }

        protected abstract void filter(StringSearchMatcher search);

        /// <summary>
        /// The underlying textbox
        /// </summary>
        public System.Windows.Forms.TextBox TextBox { get { return txt; } }


        ContextMenuStripButton btnOptions;
        [DefaultValue(false)]
        public bool ShowOptionsButton
        {
            get { return btnOptions != null; }
            set
            {
                if (ShowOptionsButton == value) return;
                if (value)
                {
                    btnOptions = new ContextMenuStripButton();
                    btnOptions.Dock = DockStyle.Right;
                    btnOptions.ContextMenuStrip = menu;
                    Controls.Add(btnOptions);
                }
                else
                {
                    btnOptions.Dispose();
                    btnOptions = null;
                }
            }
        }

        ModeItem[] modeitems;
        private void menu_Opening(object sender, CancelEventArgs e)
        {
            if (modeitems == null)
            {
                modeitems = Enum.GetValues(typeof(SearchBoxMode)).Cast<SearchBoxMode>()
                    .Select(sm => new ModeItem(this, sm)).ToArray();
                for (int i = 0; i < modeitems.Length; i++)
                    menu.Items.Insert(i, modeitems[i]);
                OnOpeningContextMenu(menu,true);
            }
            else
            {
                foreach (var m in modeitems)
                    m.Check();
                OnOpeningContextMenu(menu,false);
            }
            tsInner.Checked = alwayswildcard;
            tsClear.Enabled = txt.TextLength > 0;
        }

        protected virtual void OnOpeningContextMenu(ContextMenuStrip menu,bool FirstTime)
        {
        }

        void tsClear_Click(object sender, System.EventArgs e)
        {
            txt.Clear();
        }

        void tsInner_Click(object sender, System.EventArgs e)
        {
            AlwaysSearchInnerText = !alwayswildcard;
        }

        protected class SearchBoxItem : ToolStripMenuItem
        {
            public readonly SearchBoxBase SearchBox;
            public SearchBoxItem(SearchBoxBase sb)
            {
                this.SearchBox = sb;
            }
        }

        protected class ModeItem : SearchBoxItem
        {
            public readonly SearchBoxMode Mode;
            public ModeItem(SearchBoxBase sb, SearchBoxMode mode):base(sb)
            {
                this.Mode = mode;
                this.Text = Mode.ToString();
                Check();
            }

            public void Check()
            {
                this.Checked = SearchBox.Mode == Mode;
            }

            protected override void OnClick(EventArgs e)
            {
                SearchBox.Mode = Mode;
            }
        }
    }

    public abstract class SourceSearchBox : SearchBoxBase
    {
        #region props

        private Column col;
        [DefaultValue(null)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        [Editor(typeof(Editor), typeof(UITypeEditor))]
        public Column SearchProperty
        {
            get { return col; }
            set
            {
                if (col == value) return;
                col = value;
                propname = value == null ? null : value.Name;
                pos.X = col == null ? 0 : col.Index.Value;
                NotifyStateChanged(true);
            }
        }

        private string propname;
        [DefaultValue(null)]
        public string PropertyName
        {
            get { return propname; }
            set
            {
                if (propname == value) return;
                propname = value;
                if (IsInitializing) return;
                if (needsetprops)
                    setprops();
                else if (value == null || Columns == null)
                    NotifyStateChanged(false);                
                else
                    SearchProperty = getcol(value,true);                
            }
        }

        Column getcol(string name, bool Throw)
        {
            var col = props.FirstOrDefault(c => c.Name == name);
            if (col == null && Throw)
                throw new ArgumentException(name + " is not a valid property");
            return col;
        }

        protected void SourceChanged()
        {            
            needsetprops = true;
            NotifyStateChanged(true);
        }

        protected override void OnEndInit()
        {
            base.OnEndInit();
            if (propname != null)
                PropertyName = propname;            
        }

        protected override bool search(StringSearchMatcher search)
        {
            if (needsetprops) setprops();
            return base.search(search);
        }

        Column[] props;
        public Column[] Columns
        {
            get
            {
                if (needsetprops)
                {
                    if (IsInitializing) return null;
                    setprops();

                }
                return props;
            }
        }

        protected void ResetColumns()
        {
            needsetprops = true;
        }

        void setprops()
        {
            needsetprops = false;
            var cols = GetColumns();
            if (cols == null)
                props = null;
            else
            {
                props = GetColumns().ToArray();
                if (props.Length == 0) props = null;
                else
                {
                    for (int i = 0; i < props.Length; i++)
                    {
                        if (props[i].Index == null)
                            props[i].Index = i;
                    }
                }
                if (propname != null)
                {
                    col = getcol(propname, false);
                    if (col == null)
                    {
                        propname = null;
                        pos.X = 0;
                    }
                }
            }

        }

        protected abstract IEnumerable<Column> GetColumns();

        public class Column
        {

            public readonly string Name;
            public readonly Func<int, object> GetValue;
            public int? Index;
            public Column(string Name, Func<int,object> GetValue)
            {
                this.Name = Name;
                this.GetValue = GetValue;
            }

            private string header;

            public string Header
            {
                get
                {
                    if (header == null) return Name;
                    return header;
                }
                set { header = value; }
            }

            public override string ToString()
            {
                return Header;
            }
        }

        bool needsetprops = true;

        class Editor : UITypeEditor
        {
            public override UITypeEditorEditStyle GetEditStyle(ITypeDescriptorContext context)
            {
                return UITypeEditorEditStyle.DropDown;
            }

            public override object EditValue(ITypeDescriptorContext context, IServiceProvider provider, object value)
            {
                var b = (SourceSearchBox)context.Instance;
                if (b != null && b.Columns != null)
                {
                    var lb = new ListBox();
                    foreach (var pd in b.props)
                    {
                        int i = lb.Items.Add(pd);
                        if (b.col == pd || pd.Name == b.propname)
                            lb.SelectedIndex = i;
                    }
                    var iw = (IWindowsFormsEditorService)provider.GetService(typeof(IWindowsFormsEditorService));
                    lb.Click += delegate
                    {
                        b.PropertyName = (string)lb.SelectedItem;
                        iw.CloseDropDown();
                    };

                    iw.DropDownControl(lb);

                }
                return base.EditValue(context, provider, value);
            }

        }

        #endregion

        Point pos;
        int curcol;

        protected override sealed void ResetStartPosition(object stored)
        {
            if (stored == null)
            {
                pos = Point.Empty;
                if (col != null)
                    pos.X = col.Index.Value;
            }
            else
            {
                pos = (Point)stored;
            }
            if (Columns != null && col != null)
                curcol = Array.IndexOf(props, col);
            else
                curcol = 0;
        }

        /// <summary>
        /// The last search position
        /// </summary>
        public Point Position
        {
            get { return pos; }
            set { pos = value; }
        }        

        protected sealed override void SetFoundPosition()
        {
            try
            {
                SetPosition(pos.X, pos.Y);
            }
            catch (Exception ex)
            {
                ShowException(ex);
            }
        }

        protected abstract void SetPosition(int col,int row);

        protected override object GetCurrent()
        {
            return props[curcol].GetValue(pos.Y);
        }

        protected abstract int RecordCount
        {
            get;
        }


        protected override bool IncreasePosition()
        {
            if (col == null)
            {
                if (++curcol < props.Length)
                {
                    pos.X = props[curcol].Index.Value;
                    return true;
                }
                curcol = 0;
                pos.X = props[0].Index.Value;                
            }
            return ++pos.Y < RecordCount;
        }

        protected override object GetPosition()
        {
            return pos;
        }

        protected override bool Supports(SearchBoxMode Mode)
        {
            switch (Mode)
            {
                case SearchBoxMode.Filter:
                    return CanFilter;
                case SearchBoxMode.Lookup:
                    //isvalid &= source.SupportsSearching;
                    break;
            }
            //DataGridView dg;
            
            return true;
        }

        protected abstract bool CanFilter { get; }


        protected override bool CheckIsReady()
        {
            if (Columns == null)return false;
            if (col == null)
                return Mode != SearchBoxMode.Filter;
            return true;
        }

        protected abstract Point GetCurrentPosition();

        protected void filter(IBindingListView source, StringSearchMatcher search)
        {
            if (propname == null || search.TextLength == 0)
            {
                source.RemoveFilter();
                if (propname == null) TextBox.Clear();
            }
            else
                source.Filter = propname + " like " + (AlwaysSearchInnerText ? "*" : null) + Text + "*";


            var p = GetCurrentPosition();
            if (p.X != pos.X && pos.X != -1 && RecordCount > 0 && p.Y != -1)
            {
                SetPosition(pos.X, p.Y);
            }
        }

        protected void NotifyPositionChanged()
        {
            if (IsBusy || Mode == SearchBoxMode.Filter) return;
            ResetStartPosition(null);
            Text = null;
        }

    }

    public class BindingSourceSearchBox : SourceSearchBox
    {

        protected override void SetPosition(int col, int row)
        {
            source.Position = row;
        }

        protected override Point GetCurrentPosition()
        {
            if (source == null) return Point.Empty;
            return new Point(0, source.Position);
        }
        
        protected override int RecordCount
        {
            get { return source.Count; }
        }

        

        protected override bool CanFilter
        {
            get
            {
                var l = source.List as IBindingListView;
                return l != null && l.SupportsFiltering;
            }
        }

        protected override void filter(StringSearchMatcher search)
        {
            filter(source.List as IBindingListView, search);
        }

        protected override void OnDisposed()
        {        
            BindingSource = null;            
        }

        private CurrencyManager source;
        [DefaultValue(null)]
        public CurrencyManager BindingSource
        {
            get { return source; }
            set
            {
                if (source == value) return;
                if (source != null)
                {
                    source.PositionChanged -= source_PositionChanged;                    
                    source.ListChanged -= new ListChangedEventHandler(source_ListChanged);
                }
                source = value;
                if (source != null)
                {
                    source.PositionChanged += source_PositionChanged;
                    source.ListChanged += new ListChangedEventHandler(source_ListChanged);
                }
                SourceChanged();
            }
        }

        void source_ListChanged(object sender, ListChangedEventArgs e)
        {
            switch (e.ListChangedType)
            {
                case ListChangedType.PropertyDescriptorAdded:
                case ListChangedType.PropertyDescriptorChanged:
                case ListChangedType.PropertyDescriptorDeleted:
                    SourceChanged();
                    break;
            }
        }

        protected override IEnumerable<Column> GetColumns()
        {
            if (source == null || source.List ==null ) return null;
            return source.GetItemProperties().Cast<PropertyDescriptor>()
                .Select(pd => new Column(pd.Name, i => pd.GetValue(source.List[i])) { Header = pd.DisplayName });
        }

  

        void source_PositionChanged(object sender, EventArgs e)
        {
            NotifyPositionChanged();
        }

    }

    public class DataGridSearchBox : SourceSearchBox
    {
        DataGridView grid;
        [DefaultValue(null)]
        [Description("The DataGridView coupled to this searchBox. When the grid is readonly, keystrokes of the grid itself are handled as well")]
        public DataGridView DataGridView
        {
            get { return grid; }
            set
            {
                if (grid == value) return;
                if (grid != null)
                {
                    grid.DataSourceChanged -= grid_DataSourceChanged;
                    grid.CurrentCellChanged -= grid_CurrentCellChanged;
                    grid.ColumnAdded -= grid_ColumnsChanged;
                    grid.ColumnRemoved -= grid_ColumnsChanged;
                    grid.ColumnStateChanged -= grid_ColumnStateChanged;
                    UnRegisterControl(grid);
                }
                grid = value;
                if (grid != null)
                {
                    grid.DataSourceChanged += grid_DataSourceChanged;
                    grid.CurrentCellChanged += grid_CurrentCellChanged;
                    grid.ColumnAdded += grid_ColumnsChanged;
                    grid.ColumnRemoved += grid_ColumnsChanged;
                    grid.ColumnStateChanged += grid_ColumnStateChanged;
                    RegisterControl(grid);
                }
                SourceChanged();
            }
        }

        protected override bool CheckIsReady()
        {
            if (grid == null) return false;
            if (grid.Columns.Count == 0) return false;
            if (SearchProperty == null)
            {
                if (SearchModeColumn != ColumnSearchMode.AllColumns && Mode != SearchBoxMode.Filter)
                    return false;
            }
            return true;
        }

        void grid_ColumnStateChanged(object sender, DataGridViewColumnStateChangedEventArgs e)
        {            
            if (e.StateChanged == DataGridViewElementStates.Visible)
                ResetColumns();
        }

        void grid_ColumnsChanged(object sender, DataGridViewColumnEventArgs e)
        {
            ResetColumns();
            if (!IsValid) NotifyStateChanged(true);
        }

        protected override int RecordCount
        {
            get
            {
                if (grid == null) return 0;
                return grid.Rows.Count;
            }
        }

        protected override Point GetCurrentPosition()
        {
            if (grid == null) return Point.Empty;
            return grid.CurrentCellAddress;
        }

        protected override void SetPosition(int col, int row)
        {
            grid.CurrentCell = grid[col, row];
        }

        protected override void OnDisposed()
        {
            DataGridView = null;
        }

        protected override IEnumerable<Column> GetColumns()
        {
            if (grid == null) return null;
            return from c in grid.Columns.Cast<DataGridViewColumn>()
                   where c.Visible
                   orderby c.DisplayIndex
                   select new Column(c.DataPropertyName, i => grid[c.Index, i].Value)
                {
                    Header = c.HeaderText,
                    Index = c.Index
                };            
        }

        void grid_DataSourceChanged(object sender, EventArgs e)
        {
            SourceChanged();
        }


        void grid_CurrentCellChanged(object sender, EventArgs e)
        {
            if (IsBusy) return;
            setcurrentprop();
        }

        IBindingListView BindingListView
        {
            get
            {
                if (grid == null) return null;
                return grid.DataSource as IBindingListView;
            }
        }

        protected override bool CanFilter
        {
            get { return BindingListView != null && BindingListView.SupportsFiltering; }
        }

        protected override void filter(StringSearchMatcher search)
        {
            filter(BindingListView, search);
        }

        #region column searchmode
        private ColumnSearchMode colsearchmode = ColumnSearchMode.ActiveColumn;

        [DefaultValue(ColumnSearchMode.ActiveColumn)]
        public ColumnSearchMode SearchModeColumn
        {
            get { return colsearchmode; }
            set
            {
                if (colsearchmode == value) return;
                colsearchmode = value;
                setcurrentprop();
                NotifyStateChanged(false);
            }
        }

        DataGridViewCell lastcell;
        void setcurrentprop()
        {
            if (IsBusy) return;
            var cell = grid.CurrentCell;
            if (cell == lastcell) return;
            lastcell = cell;
            var i = cell == null ? -1 : cell.ColumnIndex;
            Column prop;
            if (i == -1)
            {
                prop = null;
                HandleRegisteredKeyDowns = false;
            }
            else
            {
                var col = grid.Columns[i];
                prop = colsearchmode == ColumnSearchMode.ActiveColumn || Mode== SearchBoxMode.Filter ? Columns.First(c=>c.Index == i) : null;
                HandleRegisteredKeyDowns = col.ReadOnly;
            }
            if (SearchProperty == prop)
            {
                Text = null;
                //NotifyStateChanged(true);
            }
            else
                SearchProperty = prop;
        }

        public enum ColumnSearchMode
        {
            ActiveColumn,
            AllColumns
        }

        protected override void OnOpeningContextMenu(ContextMenuStrip menu, bool FirstTime)
        {
            base.OnOpeningContextMenu(menu, FirstTime);
            if (FirstTime)
            {
                searchitems = Enum.GetValues(typeof(ColumnSearchMode)).Cast<ColumnSearchMode>()
                    .Select(g => new GridSearchModeItem(this, g))
                    .ToArray();
                menu.Items.Add(new ToolStripSeparator());
                menu.Items.AddRange(searchitems);
            }
            else
            {
                foreach (var m in searchitems)
                    m.Check();
            }
        }

        GridSearchModeItem[] searchitems;

        class GridSearchModeItem : SearchBoxItem
        {
            ColumnSearchMode mode;
            DataGridSearchBox sb;
            public GridSearchModeItem(DataGridSearchBox sb, ColumnSearchMode mode)
                : base(sb)
            {
                this.mode = mode;
                this.sb = sb;
                this.Text = mode.ToString();
                Check();
            }

            public void Check()
            {
                Checked = mode == sb.colsearchmode;
                Enabled = sb.Mode != SearchBoxMode.Filter;
            }

            protected override void OnClick(EventArgs e)
            {
                sb.SearchModeColumn = mode;
            }
        }

        #endregion
    }

    public class TreeviewSearchBox : SearchBoxBase
    {
        TreeNode lastnode;

        protected override void ResetStartPosition(object storedpos)
        {
            if (storedpos != null)
                lastnode = (TreeNode)storedpos;
            else if(tv==null || tv.Nodes.Count==0)
                lastnode = null;
            else
                lastnode = tv.Nodes[0];            
        }        

        protected override bool IncreasePosition()
        {
            if (lastnode == null || lastnode.TreeView==null)
            {
                if(tv.Nodes.Count==0)
                    return false;
                lastnode = tv.Nodes[0];
                return true;
            }
            lastnode = GetNextNode(lastnode,false);
            return lastnode!=null;            
        }

        protected override void SetFoundPosition()
        {
            tv.SelectedNode = lastnode;
        }

        protected override object GetPosition()
        {
            return lastnode;
        }

        TreeNode GetNextNode(TreeNode n, bool SkipChildren)
        {
            if (n == null) return null;
            if (!SkipChildren && n.Nodes.Count > 0)
                return n.Nodes[0];

            if (n.NextNode != null)
                return n.NextNode;

            return GetNextNode(n.Parent, true);            
        }

        protected override bool CheckIsReady()
        {
            return base.CheckIsReady() && tv != null;
        }

        protected override object GetCurrent()
        {
            if (lastnode == null) return null;
            return lastnode.Text;
        }


        protected override void filter(StringSearchMatcher search)
        {
            throw new NotImplementedException();
        }

        protected override bool Supports(SearchBoxMode Mode)
        {
            return base.Supports(Mode) && Mode != SearchBoxMode.Filter;
        }

        private TreeView tv;
        [DefaultValue(null)]
        public TreeView TreeView
        {
            get { return tv; }
            set
            {
                if (tv == value) return;
                if (tv != null)
                {
                    tv.AfterSelect -= new TreeViewEventHandler(tv_AfterSelect);
                    UnRegisterControl(tv);
                }
                tv = value;
                if (tv != null)
                {
                    tv.AfterSelect += new TreeViewEventHandler(tv_AfterSelect);
                    RegisterControl(tv);
                    
                }
                NotifyStateChanged(true);
            }
        }

        protected override void OnDisposed()
        {        
            TreeView = null;         
        }

        void tv_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (IsBusy) return;
            ResetStartPosition(null);
            Text = null;
        }

    }
    /*
    public class TextBoxSearchBox : SearchBoxBase
    {

        private TextBoxBase tb;
        [DefaultValue(null)]
        public TextBoxBase TextBox
        {
            get { return tb; }
            set
            {
                if (tb == value) return;
                if (tb != null)
                {
                    tb.TextChanged -= new EventHandler(tb_TextChanged);
                }
                tb = value;
                if (tb != null)
                {
                    tb.TextChanged += new EventHandler(tb_TextChanged);
                }
                NotifyStateChanged(true);
            }
        }

        void tb_TextChanged(object sender, EventArgs e)
        {
            
        }

        int pos;

        protected override void ResetStartPosition(object storedpos)
        {
            pos = 0;
        }

        protected override bool IncreasePosition()
        {
            return ++pos < tb.TextLength - Text.Length;
        }

        protected override bool Supports(SearchMode Mode)
        {
            return Mode != SearchMode.Filter && base.Supports(Mode);
        }

        protected override bool CheckIsReady()
        {
            return tb!=null && base.CheckIsReady();
        }

        protected override void SetFoundPosition()
        {
            tb.SelectionStart = pos;
            tb.SelectionLength = Text.Length;
        }

        protected override object GetPosition()
        {
            return pos;
        }

        protected override bool search(StringSearchMatcher search)
        {
  
        }
   
        protected override object GetCurrent()
        {
            throw new NotImplementedException();
        }

        protected override void filter(StringSearchMatcher search)
        {
            throw new NotImplementedException();
        }
    }
    */
    public enum SearchBoxMode
    {
        Lookup,
        Lookup_Wildcards,
        Lookup_Regex,
        Filter,
    }

    public class StringSearchMatcher
    {
        
        Func<string, bool> fn;
        public StringSearchMatcher()
        {

        }
        public StringSearchMatcher(SearchBoxMode Mode)
        {
            this.Mode = Mode;            
        }

        public StringSearchMatcher(SearchBoxMode Mode, string SearchValue):this(Mode)
        {
            this.SearchText = SearchValue;
        }

        private SearchBoxMode mode = SearchBoxMode.Lookup_Wildcards;

        public SearchBoxMode Mode
        {
            get { return mode; }
            set
            {
                if (mode == value) return;
                mode = value;
                rx = null;
                fn = null;
            }
        }

        bool searchinner;
        public bool AlwaysSearchInnerText
        {
            get
            {
                return searchinner;
            }
            set
            {
                if (searchinner == value) return;
                searchinner = value;
                rx = null;
                fn = null;
            }
        }

        private string txt;

        public string SearchText
        {
            get { return txt; }
            set
            {
                txt = value;
                rx = null;
                len = txt == null ? 0 : txt.Length;
                if (mode == SearchBoxMode.Lookup_Wildcards)
                    fn = WildCardSearch; //forced set to recheck if regex is needed
            }
        }

        public override string ToString()
        {
            return Mode + " for " + txt;
        }

        int len;
        public int TextLength
        {
            get { return len; }
        }

        public bool Matches(string s)
        {
            if (fn == null) setSearchMatcher();
            return fn(s);
        }

        public bool Matches(object o)
        {
            if (o == null) return txt == null;
            return Matches(o.ToString());
        }

        public Func<string, bool> SearchDelegate
        {
            get
            {
                if (fn == null) setSearchMatcher();
                return fn;
            }
        }

        void setSearchMatcher()
        {
            if (mode == SearchBoxMode.Lookup)
            {
                if (searchinner)
                    fn = ContainsSearch;
                else
                    fn = StartSearch;
            }
            else if (mode == SearchBoxMode.Lookup_Wildcards)
                fn = WildCardSearch;
            else
                fn = RegExSearch;
        }

        bool ContainsSearch(string s)
        {
            return s.IndexOf(txt, StringComparison.OrdinalIgnoreCase) != -1;
        }

        bool StartSearch(string s)
        {
            return s.StartsWith(txt, StringComparison.OrdinalIgnoreCase);
        }

        Regex rx;
        bool WildCardSearch(string s)
        {
            if (rx == null)
            {
                var text = txt;
                if (searchinner || text.Contains('*') || text.Contains('?'))
                {
                    var pattern = (searchinner ? null : "^") + Regex.Escape(text)
                        .Replace(@"\?", ".")
                        .Replace(@"\*", ".*");

                    rx = new Regex(pattern, RegexOptions.IgnoreCase);
                }
                else
                {
                    fn = StartSearch;
                    return StartSearch(s);
                }
            }
            return rx.IsMatch(s ?? string.Empty);
        }

        bool RegExSearch(string s)
        {
            if (rx == null)
            {
                if (searchinner)
                    rx = new Regex(txt, RegexOptions.IgnoreCase);
                else
                    rx = new Regex("^"  + txt, RegexOptions.IgnoreCase);
            }
            return rx.IsMatch(s);
        }
    }

    public class ToolstripSearchBox<CT> : ToolStripControlHost,ISupportInitialize
        where CT : SearchBoxBase,new()
    {
        public ToolstripSearchBox()
            : base(new CT())
        {
            SearchBoxControl.MinimumSize = new Size(150, 20);   
        }

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        public CT SearchBoxControl
        {
            get { return (CT)Control; }
        }

        public override string Text
        {
            get
            {
                return SearchBoxControl.Text;
            }
            set
            {
                SearchBoxControl.Text = value;
            }
        }

        [DefaultValue(SearchBoxMode.Lookup_Wildcards)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public SearchBoxMode Mode
        {
            get
            {
                return SearchBoxControl.Mode;
            }
            set
            {
                SearchBoxControl.Mode = value;
            }
        }

        [DefaultValue(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public bool AlwaysSearchInnerText
        {
            get
            {
                return SearchBoxControl.AlwaysSearchInnerText;
            }
            set
            {
                SearchBoxControl.AlwaysSearchInnerText = value;
            }
        }


        [DefaultValue(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public bool ShowOptionsButtons
        {
            get
            {
                return SearchBoxControl.ShowOptionsButton;
            }
            set
            {
                SearchBoxControl.ShowOptionsButton = value;
            }
        }

        #region ISupportInitialize Members

        public void BeginInit()
        {
            SearchBoxControl.BeginInit();
        }

        public void EndInit()
        {
            SearchBoxControl.EndInit();
        }

        #endregion
    }

    public class ToolStripSourceSearchBox<CT> : ToolstripSearchBox<CT>
        where CT : SourceSearchBox,new()
    {
        [DefaultValue(null)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public string PropertyName
        {
            get
            {
                return SearchBoxControl.PropertyName;
            }
            set
            {
                SearchBoxControl.PropertyName = value;
            }
        }

        [DefaultValue(null)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public SourceSearchBox.Column SearchProperty
        {
            get
            {
                return SearchBoxControl.SearchProperty;
            }
            set
            {
                SearchBoxControl.SearchProperty = value;
            }
        }
    }


    /// <summary>
    /// Encapsulates a <see cref="BindingSourceSearchBox"/> in a <see cref="ToolStripItem"/>
    /// </summary>
    public class ToolstripBindingSourceSearchBox:ToolStripSourceSearchBox<BindingSourceSearchBox>
    {
        [DefaultValue(null)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public CurrencyManager CurrencyManager
        {
            get
            {
                return SearchBoxControl.BindingSource;
            }
            set
            {
                SearchBoxControl.BindingSource = value;
            }
        }

    }

    public class ToolstripDataGridSearchBox : ToolStripSourceSearchBox<DataGridSearchBox>
    {

        [DefaultValue(null)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public DataGridView DataGridView
        {
            get
            {
                return SearchBoxControl.DataGridView;
            }
            set
            {
                SearchBoxControl.DataGridView = value;
            }
        }

        [DefaultValue(null)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public DataGridSearchBox.ColumnSearchMode SearchModeColumn
        {
            get
            {
                return SearchBoxControl.SearchModeColumn;
            }
            set
            {
                SearchBoxControl.SearchModeColumn = value;
            }
        }

        

    }

    public class ContextMenuStripButton : Control
    {
        bool down;
        protected override void OnMouseDown(MouseEventArgs e)
        {
            base.OnMouseDown(e);
            if (!down)
            {
                down = true;
                ContextMenuStrip cm = this.ContextMenuStrip;
                if (cm != null)
                {
                    cm.Show(this, new Point(Width, Height), ToolStripDropDownDirection.BelowLeft);
                    cm.Closed += new ToolStripDropDownClosedEventHandler(cm_Closed);
                }
                Invalidate();
            }

        }

        protected override void OnMouseUp(MouseEventArgs e)
        {
            base.OnMouseUp(e);
            down = false;
            Invalidate();
        }

        protected override Size DefaultSize
        {
            get { return new Size(10, 24); }
        }

        void cm_Closed(object sender, ToolStripDropDownClosedEventArgs e)
        {
            ((ContextMenuStrip)sender).Closed -= cm_Closed;
            down = false;
            Invalidate();
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
    }
}
