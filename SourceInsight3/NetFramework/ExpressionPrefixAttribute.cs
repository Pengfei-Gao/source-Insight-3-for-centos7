public class ExpressionPrefixAttribute : System.Attribute, System.Runtime.InteropServices._Attribute
{

	// Constructors
	public ExpressionPrefixAttribute(string expressionPrefix) {}

	// Methods
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}
	public virtual bool Match(object obj) {}
	public virtual bool IsDefaultAttribute() {}
	public Type GetType() {}
	public virtual string ToString() {}

	// Properties
	public string ExpressionPrefix { get{} }
	public object TypeId { get{} }
}

