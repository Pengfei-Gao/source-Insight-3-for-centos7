public class RoleProviderCollection : System.Configuration.Provider.ProviderCollection, System.Collections.ICollection, System.Collections.IEnumerable
{

	// Constructors
	public RoleProviderCollection() {}

	// Methods
	public virtual void Add(System.Configuration.Provider.ProviderBase provider) {}
	public void CopyTo(RoleProvider[] array, int index) {}
	public void Remove(string name) {}
	public virtual System.Collections.IEnumerator GetEnumerator() {}
	public void SetReadOnly() {}
	public void Clear() {}
	public void CopyTo(System.Configuration.Provider.ProviderBase[] array, int index) {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public RoleProvider Item { get{} }
	public System.Configuration.Provider.ProviderBase Item { get{} }
	public int Count { get{} }
	public bool IsSynchronized { get{} }
	public object SyncRoot { get{} }
}

