public class FormsAuthenticationModule : System.Web.IHttpModule
{

	// Constructors
	public FormsAuthenticationModule() {}

	// Methods
	public virtual void Dispose() {}
	public virtual void Init(System.Web.HttpApplication app) {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Events
	public event System.Web.Security.FormsAuthenticationEventHandler Authenticate;
}

