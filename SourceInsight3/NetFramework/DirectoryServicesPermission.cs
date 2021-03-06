public class DirectoryServicesPermission : System.Security.Permissions.ResourcePermissionBase, System.Security.IPermission, System.Security.ISecurityEncodable, System.Security.IStackWalk, System.Security.Permissions.IUnrestrictedPermission
{

	// Constructors
	public DirectoryServicesPermission() {}
	public DirectoryServicesPermission(System.Security.Permissions.PermissionState state) {}
	public DirectoryServicesPermission(DirectoryServicesPermissionAccess permissionAccess, string path) {}
	public DirectoryServicesPermission(DirectoryServicesPermissionEntry[] permissionAccessEntries) {}

	// Methods
	public virtual System.Security.IPermission Copy() {}
	public virtual void FromXml(System.Security.SecurityElement securityElement) {}
	public virtual System.Security.IPermission Intersect(System.Security.IPermission target) {}
	public virtual bool IsSubsetOf(System.Security.IPermission target) {}
	public virtual bool IsUnrestricted() {}
	public virtual System.Security.SecurityElement ToXml() {}
	public virtual System.Security.IPermission Union(System.Security.IPermission target) {}
	public virtual void Assert() {}
	public virtual void Demand() {}
	public virtual void Deny() {}
	public virtual void PermitOnly() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}
	public Type GetType() {}

	// Properties
	public DirectoryServicesPermissionEntryCollection PermissionEntries { get{} }
}

