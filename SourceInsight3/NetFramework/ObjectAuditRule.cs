public class ObjectAuditRule : AuditRule
{

	// Methods
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public System.Guid ObjectType { get{} }
	public System.Guid InheritedObjectType { get{} }
	public ObjectAceFlags ObjectFlags { get{} }
	public AuditFlags AuditFlags { get{} }
	public System.Security.Principal.IdentityReference IdentityReference { get{} }
	public bool IsInherited { get{} }
	public InheritanceFlags InheritanceFlags { get{} }
	public PropagationFlags PropagationFlags { get{} }
}

