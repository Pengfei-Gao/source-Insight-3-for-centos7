public class TreeViewArray : BaseControlArray, System.ComponentModel.IComponent, System.IDisposable, System.ComponentModel.ISupportInitialize, System.ComponentModel.IExtenderProvider
{

	// Constructors
	public TreeViewArray() {}
	public TreeViewArray(System.ComponentModel.IContainer Container) {}

	// Methods
	public virtual bool CanExtend(object target) {}
	public short GetIndex(System.Windows.Forms.TreeView o) {}
	public void SetIndex(System.Windows.Forms.TreeView o, short Index) {}
	public bool ShouldSerializeIndex(System.Windows.Forms.TreeView o) {}
	public void ResetIndex(System.Windows.Forms.TreeView o) {}
	public void Load(short Index) {}
	public void Unload(short Index) {}
	public short LBound() {}
	public short UBound() {}
	public short Count() {}
	public System.Collections.IEnumerator GetEnumerator() {}
	public virtual void Dispose() {}
	public virtual string ToString() {}
	public virtual object GetLifetimeService() {}
	public virtual object InitializeLifetimeService() {}
	public virtual System.Runtime.Remoting.ObjRef CreateObjRef(Type requestedType) {}
	public Type GetType() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public System.Windows.Forms.TreeView Item { get{} }
	public System.ComponentModel.ISite Site { get{} set{} }
	public System.ComponentModel.IContainer Container { get{} }

	// Events
	public event System.Windows.Forms.TreeViewEventHandler AfterCheck;
	public event System.Windows.Forms.TreeViewEventHandler AfterCollapse;
	public event System.Windows.Forms.TreeViewEventHandler AfterExpand;
	public event System.Windows.Forms.NodeLabelEditEventHandler AfterLabelEdit;
	public event System.Windows.Forms.TreeViewEventHandler AfterSelect;
	public event System.EventHandler BackColorChanged;
	public event System.Windows.Forms.TreeViewCancelEventHandler BeforeCheck;
	public event System.Windows.Forms.TreeViewCancelEventHandler BeforeCollapse;
	public event System.Windows.Forms.TreeViewCancelEventHandler BeforeExpand;
	public event System.Windows.Forms.NodeLabelEditEventHandler BeforeLabelEdit;
	public event System.Windows.Forms.TreeViewCancelEventHandler BeforeSelect;
	public event System.EventHandler BindingContextChanged;
	public event System.EventHandler CausesValidationChanged;
	public event System.Windows.Forms.UICuesEventHandler ChangeUICues;
	public event System.EventHandler Click;
	public event System.EventHandler ClientSizeChanged;
	public event System.EventHandler ContextMenuChanged;
	public event System.EventHandler ContextMenuStripChanged;
	public event System.Windows.Forms.ControlEventHandler ControlAdded;
	public event System.Windows.Forms.ControlEventHandler ControlRemoved;
	public event System.EventHandler CursorChanged;
	public event System.EventHandler DockChanged;
	public event System.EventHandler DoubleClick;
	public event System.Windows.Forms.DragEventHandler DragDrop;
	public event System.Windows.Forms.DragEventHandler DragEnter;
	public event System.EventHandler DragLeave;
	public event System.Windows.Forms.DragEventHandler DragOver;
	public event System.Windows.Forms.DrawTreeNodeEventHandler DrawNode;
	public event System.EventHandler EnabledChanged;
	public event System.EventHandler Enter;
	public event System.EventHandler FontChanged;
	public event System.EventHandler ForeColorChanged;
	public event System.Windows.Forms.GiveFeedbackEventHandler GiveFeedback;
	public event System.Windows.Forms.HelpEventHandler HelpRequested;
	public event System.EventHandler ImeModeChanged;
	public event System.Windows.Forms.ItemDragEventHandler ItemDrag;
	public event System.Windows.Forms.KeyEventHandler KeyDown;
	public event System.Windows.Forms.KeyPressEventHandler KeyPress;
	public event System.Windows.Forms.KeyEventHandler KeyUp;
	public event System.Windows.Forms.LayoutEventHandler Layout;
	public event System.EventHandler Leave;
	public event System.EventHandler LocationChanged;
	public event System.EventHandler MarginChanged;
	public event System.EventHandler MouseCaptureChanged;
	public event System.Windows.Forms.MouseEventHandler MouseClick;
	public event System.Windows.Forms.MouseEventHandler MouseDoubleClick;
	public event System.Windows.Forms.MouseEventHandler MouseDown;
	public event System.EventHandler MouseEnter;
	public event System.EventHandler MouseHover;
	public event System.EventHandler MouseLeave;
	public event System.Windows.Forms.MouseEventHandler MouseMove;
	public event System.Windows.Forms.MouseEventHandler MouseUp;
	public event System.EventHandler Move;
	public event System.Windows.Forms.TreeNodeMouseClickEventHandler NodeMouseClick;
	public event System.Windows.Forms.TreeNodeMouseClickEventHandler NodeMouseDoubleClick;
	public event System.Windows.Forms.TreeNodeMouseHoverEventHandler NodeMouseHover;
	public event System.EventHandler PaddingChanged;
	public event System.EventHandler ParentChanged;
	public event System.Windows.Forms.QueryAccessibilityHelpEventHandler QueryAccessibilityHelp;
	public event System.Windows.Forms.QueryContinueDragEventHandler QueryContinueDrag;
	public event System.EventHandler RegionChanged;
	public event System.EventHandler Resize;
	public event System.EventHandler RightToLeftChanged;
	public event System.EventHandler RightToLeftLayoutChanged;
	public event System.EventHandler SizeChanged;
	public event System.EventHandler StyleChanged;
	public event System.EventHandler SystemColorsChanged;
	public event System.EventHandler TabIndexChanged;
	public event System.EventHandler TabStopChanged;
	public event System.EventHandler Validated;
	public event System.ComponentModel.CancelEventHandler Validating;
	public event System.EventHandler VisibleChanged;
	public event System.EventHandler Disposed;
}

