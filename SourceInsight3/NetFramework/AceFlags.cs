public class AceFlags : System.Enum, System.IComparable, System.IFormattable, System.IConvertible
{

	// Methods
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}
	public virtual string ToString() {}
	public virtual string ToString(string format, System.IFormatProvider provider) {}
	public virtual int CompareTo(object target) {}
	public virtual string ToString(System.IFormatProvider provider) {}
	public virtual System.TypeCode GetTypeCode() {}
	public string ToString(string format) {}
	public Type GetType() {}

	// Fields
	public byte value__;
	public AceFlags None;
	public AceFlags ObjectInherit;
	public AceFlags ContainerInherit;
	public AceFlags NoPropagateInherit;
	public AceFlags InheritOnly;
	public AceFlags Inherited;
	public AceFlags SuccessfulAccess;
	public AceFlags FailedAccess;
	public AceFlags InheritanceFlags;
	public AceFlags AuditFlags;
}

