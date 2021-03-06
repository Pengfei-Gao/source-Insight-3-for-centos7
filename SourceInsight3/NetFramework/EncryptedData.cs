public class EncryptedData : EncryptedType
{

	// Constructors
	public EncryptedData() {}

	// Methods
	public virtual void LoadXml(System.Xml.XmlElement value) {}
	public virtual System.Xml.XmlElement GetXml() {}
	public void AddProperty(EncryptionProperty ep) {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public string Id { get{} set{} }
	public string Type { get{} set{} }
	public string MimeType { get{} set{} }
	public string Encoding { get{} set{} }
	public KeyInfo KeyInfo { get{} set{} }
	public EncryptionMethod EncryptionMethod { get{} set{} }
	public EncryptionPropertyCollection EncryptionProperties { get{} }
	public CipherData CipherData { get{} set{} }
}

