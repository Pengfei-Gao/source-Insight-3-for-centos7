public class XmlSchemaException : System.SystemException, System.Runtime.Serialization.ISerializable, System.Runtime.InteropServices._Exception
{

	// Constructors
	public XmlSchemaException() {}
	public XmlSchemaException(string message) {}
	public XmlSchemaException(string message, System.Exception innerException) {}
	public XmlSchemaException(string message, System.Exception innerException, int lineNumber, int linePosition) {}

	// Methods
	public virtual void GetObjectData(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) {}
	public virtual System.Exception GetBaseException() {}
	public virtual string ToString() {}
	public virtual Type GetType() {}
	public Type GetType() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public string SourceUri { get{} }
	public int LineNumber { get{} }
	public int LinePosition { get{} }
	public XmlSchemaObject SourceSchemaObject { get{} }
	public string Message { get{} }
	public System.Collections.IDictionary Data { get{} }
	public System.Exception InnerException { get{} }
	public System.Reflection.MethodBase TargetSite { get{} }
	public string StackTrace { get{} }
	public string HelpLink { get{} set{} }
	public string Source { get{} set{} }
}

