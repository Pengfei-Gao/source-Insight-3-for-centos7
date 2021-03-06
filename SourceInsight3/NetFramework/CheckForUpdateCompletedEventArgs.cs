public class CheckForUpdateCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs
{

	// Methods
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public bool UpdateAvailable { get{} }
	public System.Version AvailableVersion { get{} }
	public bool IsUpdateRequired { get{} }
	public System.Version MinimumRequiredVersion { get{} }
	public long UpdateSizeBytes { get{} }
	public bool Cancelled { get{} }
	public System.Exception Error { get{} }
	public object UserState { get{} }
}

