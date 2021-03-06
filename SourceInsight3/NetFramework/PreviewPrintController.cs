public class PreviewPrintController : PrintController
{

	// Constructors
	public PreviewPrintController() {}

	// Methods
	public virtual void OnStartPrint(PrintDocument document, PrintEventArgs e) {}
	public virtual System.Drawing.Graphics OnStartPage(PrintDocument document, PrintPageEventArgs e) {}
	public virtual void OnEndPage(PrintDocument document, PrintPageEventArgs e) {}
	public virtual void OnEndPrint(PrintDocument document, PrintEventArgs e) {}
	public PreviewPageInfo[] GetPreviewPageInfo() {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public bool IsPreview { get{} }
	public bool UseAntiAlias { get{} set{} }
}

