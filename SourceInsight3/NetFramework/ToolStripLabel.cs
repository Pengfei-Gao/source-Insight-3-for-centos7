public class ToolStripLabel : ToolStripItem, System.ComponentModel.IComponent, System.IDisposable, IDropTarget, ISupportOleDropSource, System.Windows.Forms.Layout.IArrangedElement
{

	// Constructors
	public ToolStripLabel() {}
	public ToolStripLabel(string text) {}
	public ToolStripLabel(System.Drawing.Image image) {}
	public ToolStripLabel(string text, System.Drawing.Image image) {}
	public ToolStripLabel(string text, System.Drawing.Image image, bool isLink) {}
	public ToolStripLabel(string text, System.Drawing.Image image, bool isLink, System.EventHandler onClick) {}
	public ToolStripLabel(string text, System.Drawing.Image image, bool isLink, System.EventHandler onClick, string name) {}

	// Methods
	public void PerformClick() {}
	public void Select() {}
	public virtual void ResetBackColor() {}
	public virtual void ResetDisplayStyle() {}
	public virtual void ResetForeColor() {}
	public virtual void ResetFont() {}
	public virtual void ResetImage() {}
	public void ResetMargin() {}
	public void ResetPadding() {}
	public virtual void ResetRightToLeft() {}
	public virtual void ResetTextDirection() {}
	public virtual string ToString() {}
	public DragDropEffects DoDragDrop(object data, DragDropEffects allowedEffects) {}
	public ToolStrip GetCurrentParent() {}
	public virtual System.Drawing.Size GetPreferredSize(System.Drawing.Size constrainingSize) {}
	public void Invalidate() {}
	public void Invalidate(System.Drawing.Rectangle r) {}
	public virtual void Dispose() {}
	public virtual object GetLifetimeService() {}
	public virtual object InitializeLifetimeService() {}
	public virtual System.Runtime.Remoting.ObjRef CreateObjRef(Type requestedType) {}
	public Type GetType() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public bool CanSelect { get{} }
	public bool IsLink { get{} set{} }
	public System.Drawing.Color ActiveLinkColor { get{} set{} }
	public LinkBehavior LinkBehavior { get{} set{} }
	public System.Drawing.Color LinkColor { get{} set{} }
	public bool LinkVisited { get{} set{} }
	public System.Drawing.Color VisitedLinkColor { get{} set{} }
	public AccessibleObject AccessibilityObject { get{} }
	public string AccessibleDefaultActionDescription { get{} set{} }
	public string AccessibleDescription { get{} set{} }
	public string AccessibleName { get{} set{} }
	public AccessibleRole AccessibleRole { get{} set{} }
	public ToolStripItemAlignment Alignment { get{} set{} }
	public bool AllowDrop { get{} set{} }
	public bool AutoSize { get{} set{} }
	public bool AutoToolTip { get{} set{} }
	public bool Available { get{} set{} }
	public System.Drawing.Image BackgroundImage { get{} set{} }
	public ImageLayout BackgroundImageLayout { get{} set{} }
	public System.Drawing.Color BackColor { get{} set{} }
	public System.Drawing.Rectangle Bounds { get{} }
	public System.Drawing.Rectangle ContentRectangle { get{} }
	public AnchorStyles Anchor { get{} set{} }
	public DockStyle Dock { get{} set{} }
	public ToolStripItemDisplayStyle DisplayStyle { get{} set{} }
	public bool DoubleClickEnabled { get{} set{} }
	public bool Enabled { get{} set{} }
	public System.Drawing.Color ForeColor { get{} set{} }
	public System.Drawing.Font Font { get{} set{} }
	public int Height { get{} set{} }
	public System.Drawing.ContentAlignment ImageAlign { get{} set{} }
	public System.Drawing.Image Image { get{} set{} }
	public System.Drawing.Color ImageTransparentColor { get{} set{} }
	public int ImageIndex { get{} set{} }
	public string ImageKey { get{} set{} }
	public ToolStripItemImageScaling ImageScaling { get{} set{} }
	public bool IsDisposed { get{} }
	public bool IsOnDropDown { get{} }
	public bool IsOnOverflow { get{} }
	public Padding Margin { get{} set{} }
	public MergeAction MergeAction { get{} set{} }
	public int MergeIndex { get{} set{} }
	public string Name { get{} set{} }
	public ToolStrip Owner { get{} set{} }
	public ToolStripItem OwnerItem { get{} }
	public ToolStripItemOverflow Overflow { get{} set{} }
	public Padding Padding { get{} set{} }
	public ToolStripItemPlacement Placement { get{} }
	public bool Pressed { get{} }
	public RightToLeft RightToLeft { get{} set{} }
	public bool RightToLeftAutoMirrorImage { get{} set{} }
	public bool Selected { get{} }
	public System.Drawing.Size Size { get{} set{} }
	public object Tag { get{} set{} }
	public string Text { get{} set{} }
	public System.Drawing.ContentAlignment TextAlign { get{} set{} }
	public ToolStripTextDirection TextDirection { get{} set{} }
	public TextImageRelation TextImageRelation { get{} set{} }
	public string ToolTipText { get{} set{} }
	public bool Visible { get{} set{} }
	public int Width { get{} set{} }
	public System.ComponentModel.ISite Site { get{} set{} }
	public System.ComponentModel.IContainer Container { get{} }

	// Events
	public event System.EventHandler AvailableChanged;
	public event System.EventHandler BackColorChanged;
	public event System.EventHandler Click;
	public event System.EventHandler DisplayStyleChanged;
	public event System.EventHandler DoubleClick;
	public event System.Windows.Forms.DragEventHandler DragDrop;
	public event System.Windows.Forms.DragEventHandler DragEnter;
	public event System.Windows.Forms.DragEventHandler DragOver;
	public event System.EventHandler DragLeave;
	public event System.EventHandler EnabledChanged;
	public event System.EventHandler ForeColorChanged;
	public event System.Windows.Forms.GiveFeedbackEventHandler GiveFeedback;
	public event System.EventHandler LocationChanged;
	public event System.Windows.Forms.MouseEventHandler MouseDown;
	public event System.EventHandler MouseEnter;
	public event System.EventHandler MouseLeave;
	public event System.EventHandler MouseHover;
	public event System.Windows.Forms.MouseEventHandler MouseMove;
	public event System.Windows.Forms.MouseEventHandler MouseUp;
	public event System.EventHandler OwnerChanged;
	public event System.Windows.Forms.PaintEventHandler Paint;
	public event System.Windows.Forms.QueryContinueDragEventHandler QueryContinueDrag;
	public event System.Windows.Forms.QueryAccessibilityHelpEventHandler QueryAccessibilityHelp;
	public event System.EventHandler RightToLeftChanged;
	public event System.EventHandler TextChanged;
	public event System.EventHandler VisibleChanged;
	public event System.EventHandler Disposed;
}

