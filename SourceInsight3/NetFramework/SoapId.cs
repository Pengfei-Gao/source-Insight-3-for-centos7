public class SoapId : ISoapXsd
{

	// Constructors
	public SoapId() {}
	public SoapId(string value) {}

	// Methods
	public virtual string GetXsdType() {}
	public virtual string ToString() {}
	public static SoapId Parse(string value) {}
	public Type GetType() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public string XsdType { get{} }
	public string Value { get{} set{} }
}

