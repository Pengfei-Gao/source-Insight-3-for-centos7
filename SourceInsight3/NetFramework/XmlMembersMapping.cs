public class XmlMembersMapping : XmlMapping
{

	// Methods
	public void SetKey(string key) {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public string TypeName { get{} }
	public string TypeNamespace { get{} }
	public XmlMemberMapping Item { get{} }
	public int Count { get{} }
	public string ElementName { get{} }
	public string XsdElementName { get{} }
	public string Namespace { get{} }
}

