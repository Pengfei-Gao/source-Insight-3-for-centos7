public class ListViewVirtualItemsSelectionRangeChangedEventHandler : System.MulticastDelegate, System.ICloneable, System.Runtime.Serialization.ISerializable
{

	// Constructors
	public ListViewVirtualItemsSelectionRangeChangedEventHandler(object object, System.IntPtr method) {}

	// Methods
	public virtual void Invoke(object sender, ListViewVirtualItemsSelectionRangeChangedEventArgs e) {}
	public virtual System.IAsyncResult BeginInvoke(object sender, ListViewVirtualItemsSelectionRangeChangedEventArgs e, System.AsyncCallback callback, object object) {}
	public virtual void EndInvoke(System.IAsyncResult result) {}
	public virtual void GetObjectData(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) {}
	public virtual bool Equals(object obj) {}
	public virtual System.Delegate[] GetInvocationList() {}
	public virtual int GetHashCode() {}
	public object DynamicInvoke(object[] args) {}
	public virtual object Clone() {}
	public Type GetType() {}
	public virtual string ToString() {}

	// Properties
	public System.Reflection.MethodInfo Method { get{} }
	public object Target { get{} }
}

