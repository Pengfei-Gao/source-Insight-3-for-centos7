public class ConstructorBuilder : System.Reflection.ConstructorInfo, System.Reflection.ICustomAttributeProvider, System.Runtime.InteropServices._MemberInfo, System.Runtime.InteropServices._MethodBase, System.Runtime.InteropServices._ConstructorInfo, System.Runtime.InteropServices._ConstructorBuilder
{

	// Methods
	public virtual string ToString() {}
	public virtual object Invoke(object obj, System.Reflection.BindingFlags invokeAttr, System.Reflection.Binder binder, object[] parameters, System.Globalization.CultureInfo culture) {}
	public virtual System.Reflection.ParameterInfo[] GetParameters() {}
	public virtual System.Reflection.MethodImplAttributes GetMethodImplementationFlags() {}
	public virtual object Invoke(System.Reflection.BindingFlags invokeAttr, System.Reflection.Binder binder, object[] parameters, System.Globalization.CultureInfo culture) {}
	public virtual object[] GetCustomAttributes(bool inherit) {}
	public virtual object[] GetCustomAttributes(Type attributeType, bool inherit) {}
	public virtual bool IsDefined(Type attributeType, bool inherit) {}
	public MethodToken GetToken() {}
	public ParameterBuilder DefineParameter(int iSequence, System.Reflection.ParameterAttributes attributes, string strParamName) {}
	public void SetSymCustomAttribute(string name, byte[] data) {}
	public ILGenerator GetILGenerator() {}
	public ILGenerator GetILGenerator(int streamSize) {}
	public void AddDeclarativeSecurity(System.Security.Permissions.SecurityAction action, System.Security.PermissionSet pset) {}
	public System.Reflection.Module GetModule() {}
	public void SetCustomAttribute(System.Reflection.ConstructorInfo con, byte[] binaryAttribute) {}
	public void SetCustomAttribute(CustomAttributeBuilder customBuilder) {}
	public void SetImplementationFlags(System.Reflection.MethodImplAttributes attributes) {}
	public object Invoke(object[] parameters) {}
	public virtual Type[] GetGenericArguments() {}
	public virtual object Invoke(object obj, object[] parameters) {}
	public virtual System.Reflection.MethodBody GetMethodBody() {}
	public Type GetType() {}
	public virtual bool Equals(object obj) {}
	public virtual int GetHashCode() {}

	// Properties
	public System.Reflection.Module Module { get{} }
	public Type ReflectedType { get{} }
	public Type DeclaringType { get{} }
	public string Name { get{} }
	public System.Reflection.MethodAttributes Attributes { get{} }
	public System.RuntimeMethodHandle MethodHandle { get{} }
	public System.Reflection.CallingConventions CallingConvention { get{} }
	public Type ReturnType { get{} }
	public string Signature { get{} }
	public bool InitLocals { get{} set{} }
	public System.Reflection.MemberTypes MemberType { get{} }
	public bool IsGenericMethodDefinition { get{} }
	public bool ContainsGenericParameters { get{} }
	public bool IsGenericMethod { get{} }
	public bool IsPublic { get{} }
	public bool IsPrivate { get{} }
	public bool IsFamily { get{} }
	public bool IsAssembly { get{} }
	public bool IsFamilyAndAssembly { get{} }
	public bool IsFamilyOrAssembly { get{} }
	public bool IsStatic { get{} }
	public bool IsFinal { get{} }
	public bool IsVirtual { get{} }
	public bool IsHideBySig { get{} }
	public bool IsAbstract { get{} }
	public bool IsSpecialName { get{} }
	public bool IsConstructor { get{} }
	public int MetadataToken { get{} }
}

