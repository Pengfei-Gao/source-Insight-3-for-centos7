public class PRINTDLGX86
{

	// Constructors
	public PRINTDLGX86() {}

	// Methods
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Fields
	public int lStructSize;
	public System.IntPtr hwndOwner;
	public System.IntPtr hDevMode;
	public System.IntPtr hDevNames;
	public System.IntPtr hDC;
	public int Flags;
	public short nFromPage;
	public short nToPage;
	public short nMinPage;
	public short nMaxPage;
	public short nCopies;
	public System.IntPtr hInstance;
	public System.IntPtr lCustData;
	public System.IntPtr lpfnPrintHook;
	public System.IntPtr lpfnSetupHook;
	public string lpPrintTemplateName;
	public string lpSetupTemplateName;
	public System.IntPtr hPrintTemplate;
	public System.IntPtr hSetupTemplate;
}

