public class COMFieldInfo : System.Reflection.FieldInfo, System.Reflection.ICustomAttributeProvider, System.Runtime.InteropServices._MemberInfo, System.Runtime.InteropServices._FieldInfo, MemberInfoInitializer
{

	// Constructors
	public COMFieldInfo() {}

	// Methods
	public virtual object GetValue(object obj) {}
	public virtual void Initialize(string name, COMMemberInfo dispatch) {}
	public virtual COMMemberInfo GetCOMMemberInfo() {}
	public virtual void SetValue(object obj, object value, System.Reflection.BindingFlags invokeAttr, System.Reflection.Binder binder, System.Globalization.CultureInfo culture) {}
	public virtual object[] GetCustomAttributes(Type t, bool inherit) {}
	public virtual object[] GetCustomAttributes(bool inherit) {}
	public virtual bool IsDefined(Type t, bool inherit) {}
	public virtual Type[] GetRequiredCustomModifiers() {}
	public virtual Type[] GetOptionalCustomModifiers() {}
	public virtual void SetValueDirect(System.TypedReference obj, object value) {}
	public virtual object GetValueDirect(System.TypedReference obj) {}
	public virtual object GetRawConstantValue() {}
	public virtual void SetValue(object obj, object value) {}
	public Type GetType() {}
	public virtual string ToString() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public System.Reflection.FieldAttributes Attributes { get{} }
	public Type DeclaringType { get{} }
	public System.RuntimeFieldHandle FieldHandle { get{} }
	public Type FieldType { get{} }
	public System.Reflection.MemberTypes MemberType { get{} }
	public string Name { get{} }
	public Type ReflectedType { get{} }
	public bool IsPublic { get{} }
	public bool IsPrivate { get{} }
	public bool IsFamily { get{} }
	public bool IsAssembly { get{} }
	public bool IsFamilyAndAssembly { get{} }
	public bool IsFamilyOrAssembly { get{} }
	public bool IsStatic { get{} }
	public bool IsInitOnly { get{} }
	public bool IsLiteral { get{} }
	public bool IsNotSerialized { get{} }
	public bool IsSpecialName { get{} }
	public bool IsPinvokeImpl { get{} }
	public int MetadataToken { get{} }
	public System.Reflection.Module Module { get{} }
}

