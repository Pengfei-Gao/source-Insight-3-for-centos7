public class ImportedFromTypeLibAttribute : System.Attribute, _Attribute
{

	// Constructors
	public ImportedFromTypeLibAttribute(string tlbFile) {}

	// Methods
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}
	public virtual bool Match(object obj) {}
	public virtual bool IsDefaultAttribute() {}
	public Type GetType() {}
	public virtual string ToString() {}

	// Properties
	public string Value { get{} }
	public object TypeId { get{} }
}

