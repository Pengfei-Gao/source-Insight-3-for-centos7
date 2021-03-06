public class GridView : CompositeDataBoundControl, System.ComponentModel.IComponent, System.IDisposable, System.Web.UI.IParserAccessor, System.Web.UI.IUrlResolutionService, System.Web.UI.IDataBindingsAccessor, System.Web.UI.IControlBuilderAccessor, System.Web.UI.IControlDesignerAccessor, System.Web.UI.IExpressionsAccessor, System.Web.UI.IAttributeAccessor, System.Web.UI.INamingContainer, IPostBackContainer, System.Web.UI.IPostBackEventHandler, ICallbackContainer, System.Web.UI.ICallbackEventHandler
{

	// Constructors
	public GridView() {}

	// Methods
	public virtual bool IsBindableType(Type type) {}
	public virtual void DataBind() {}
	public virtual void DeleteRow(int rowIndex) {}
	public virtual void Sort(string sortExpression, SortDirection sortDirection) {}
	public virtual void UpdateRow(int rowIndex, bool causesValidation) {}
	public void ApplyStyle(Style s) {}
	public void CopyBaseAttributes(WebControl controlSrc) {}
	public void MergeStyle(Style s) {}
	public virtual void RenderBeginTag(System.Web.UI.HtmlTextWriter writer) {}
	public virtual void RenderEndTag(System.Web.UI.HtmlTextWriter writer) {}
	public virtual void ApplyStyleSheetSkin(System.Web.UI.Page page) {}
	public virtual void Focus() {}
	public virtual void RenderControl(System.Web.UI.HtmlTextWriter writer) {}
	public virtual void Dispose() {}
	public string ResolveUrl(string relativeUrl) {}
	public virtual string ResolveClientUrl(string relativeUrl) {}
	public virtual System.Web.UI.Control FindControl(string id) {}
	public virtual bool HasControls() {}
	public void SetRenderMethodDelegate(System.Web.UI.RenderMethod renderMethod) {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public bool AllowPaging { get{} set{} }
	public bool AllowSorting { get{} set{} }
	public TableItemStyle AlternatingRowStyle { get{} }
	public bool AutoGenerateDeleteButton { get{} set{} }
	public bool AutoGenerateEditButton { get{} set{} }
	public bool AutoGenerateSelectButton { get{} set{} }
	public bool AutoGenerateColumns { get{} set{} }
	public string BackImageUrl { get{} set{} }
	public GridViewRow BottomPagerRow { get{} }
	public string Caption { get{} set{} }
	public TableCaptionAlign CaptionAlign { get{} set{} }
	public int CellPadding { get{} set{} }
	public int CellSpacing { get{} set{} }
	public DataControlFieldCollection Columns { get{} }
	public DataKeyArray DataKeys { get{} }
	public string[] DataKeyNames { get{} set{} }
	public int EditIndex { get{} set{} }
	public TableItemStyle EditRowStyle { get{} }
	public bool EnableSortingAndPagingCallbacks { get{} set{} }
	public TableItemStyle EmptyDataRowStyle { get{} }
	public System.Web.UI.ITemplate EmptyDataTemplate { get{} set{} }
	public string EmptyDataText { get{} set{} }
	public GridViewRow FooterRow { get{} }
	public TableItemStyle FooterStyle { get{} }
	public GridLines GridLines { get{} set{} }
	public GridViewRow HeaderRow { get{} }
	public TableItemStyle HeaderStyle { get{} }
	public HorizontalAlign HorizontalAlign { get{} set{} }
	public int PageCount { get{} }
	public int PageIndex { get{} set{} }
	public PagerSettings PagerSettings { get{} }
	public TableItemStyle PagerStyle { get{} }
	public System.Web.UI.ITemplate PagerTemplate { get{} set{} }
	public int PageSize { get{} set{} }
	public string RowHeaderColumn { get{} set{} }
	public GridViewRowCollection Rows { get{} }
	public TableItemStyle RowStyle { get{} }
	public DataKey SelectedDataKey { get{} }
	public int SelectedIndex { get{} set{} }
	public object SelectedValue { get{} }
	public GridViewRow SelectedRow { get{} }
	public TableItemStyle SelectedRowStyle { get{} }
	public bool ShowFooter { get{} set{} }
	public bool ShowHeader { get{} set{} }
	public SortDirection SortDirection { get{} }
	public string SortExpression { get{} }
	public GridViewRow TopPagerRow { get{} }
	public bool UseAccessibleHeader { get{} set{} }
	public System.Web.UI.ControlCollection Controls { get{} }
	public string DataMember { get{} set{} }
	public string DataSourceID { get{} set{} }
	public object DataSource { get{} set{} }
	public string AccessKey { get{} set{} }
	public System.Web.UI.AttributeCollection Attributes { get{} }
	public System.Drawing.Color BackColor { get{} set{} }
	public System.Drawing.Color BorderColor { get{} set{} }
	public Unit BorderWidth { get{} set{} }
	public BorderStyle BorderStyle { get{} set{} }
	public Style ControlStyle { get{} }
	public bool ControlStyleCreated { get{} }
	public string CssClass { get{} set{} }
	public System.Web.UI.CssStyleCollection Style { get{} }
	public bool Enabled { get{} set{} }
	public bool EnableTheming { get{} set{} }
	public FontInfo Font { get{} }
	public System.Drawing.Color ForeColor { get{} set{} }
	public bool HasAttributes { get{} }
	public Unit Height { get{} set{} }
	public string SkinID { get{} set{} }
	public short TabIndex { get{} set{} }
	public string ToolTip { get{} set{} }
	public Unit Width { get{} set{} }
	public string ClientID { get{} }
	public string ID { get{} set{} }
	public bool EnableViewState { get{} set{} }
	public System.Web.UI.Control NamingContainer { get{} }
	public System.Web.UI.Control BindingContainer { get{} }
	public System.Web.UI.Page Page { get{} set{} }
	public System.Web.UI.TemplateControl TemplateControl { get{} set{} }
	public System.Web.UI.Control Parent { get{} }
	public string TemplateSourceDirectory { get{} }
	public string AppRelativeTemplateSourceDirectory { get{} set{} }
	public System.ComponentModel.ISite Site { get{} set{} }
	public bool Visible { get{} set{} }
	public string UniqueID { get{} }

	// Events
	public event System.Web.UI.WebControls.GridViewDeletedEventHandler RowDeleted;
	public event System.Web.UI.WebControls.GridViewUpdatedEventHandler RowUpdated;
	public event System.Web.UI.WebControls.GridViewCancelEditEventHandler RowCancelingEdit;
	public event System.Web.UI.WebControls.GridViewDeleteEventHandler RowDeleting;
	public event System.Web.UI.WebControls.GridViewEditEventHandler RowEditing;
	public event System.EventHandler PageIndexChanged;
	public event System.Web.UI.WebControls.GridViewPageEventHandler PageIndexChanging;
	public event System.EventHandler SelectedIndexChanged;
	public event System.Web.UI.WebControls.GridViewSelectEventHandler SelectedIndexChanging;
	public event System.EventHandler Sorted;
	public event System.Web.UI.WebControls.GridViewSortEventHandler Sorting;
	public event System.Web.UI.WebControls.GridViewUpdateEventHandler RowUpdating;
	public event System.Web.UI.WebControls.GridViewCommandEventHandler RowCommand;
	public event System.Web.UI.WebControls.GridViewRowEventHandler RowCreated;
	public event System.Web.UI.WebControls.GridViewRowEventHandler RowDataBound;
	public event System.EventHandler DataBound;
	public event System.EventHandler Disposed;
	public event System.EventHandler DataBinding;
	public event System.EventHandler Init;
	public event System.EventHandler Load;
	public event System.EventHandler PreRender;
	public event System.EventHandler Unload;
}

