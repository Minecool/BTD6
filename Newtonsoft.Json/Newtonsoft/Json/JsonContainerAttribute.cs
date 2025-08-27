namespace Newtonsoft.Json;

[AttributeUsage(1028, AllowMultiple = False)]
[Nullable(0)]
[NullableContext(2)]
public abstract class JsonContainerAttribute : Attribute
{
	[CompilerGenerated]
	private Type <ItemConverterType>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	[Nullable(new IL2CPP_TYPE_U1[] {2, 1}])]
	private Object[] <ItemConverterParameters>k__BackingField; //Field offset: 0x18
	[CompilerGenerated]
	private NamingStrategy <NamingStrategyInstance>k__BackingField; //Field offset: 0x20
	internal Nullable<Boolean> _isReference; //Field offset: 0x28
	internal Nullable<Boolean> _itemIsReference; //Field offset: 0x2A
	internal Nullable<ReferenceLoopHandling> _itemReferenceLoopHandling; //Field offset: 0x2C
	internal Nullable<TypeNameHandling> _itemTypeNameHandling; //Field offset: 0x34
	private Type _namingStrategyType; //Field offset: 0x40
	[Nullable(new IL2CPP_TYPE_U1[] {2, 1}])]
	private Object[] _namingStrategyParameters; //Field offset: 0x48

	[Nullable(new IL2CPP_TYPE_U1[] {2, 1}])]
	public Object[] ItemConverterParameters
	{
		[CompilerGenerated]
		 get { } //Length: 5
	}

	public Type ItemConverterType
	{
		[CompilerGenerated]
		 get { } //Length: 5
	}

	internal NamingStrategy NamingStrategyInstance
	{
		[CompilerGenerated]
		internal get { } //Length: 5
		[CompilerGenerated]
		internal set { } //Length: 5
	}

	[Nullable(new IL2CPP_TYPE_U1[] {2, 1}])]
	public Object[] NamingStrategyParameters
	{
		 get { } //Length: 5
	}

	public Type NamingStrategyType
	{
		 get { } //Length: 5
	}

	[CompilerGenerated]
	public Object[] get_ItemConverterParameters() { }

	[CompilerGenerated]
	public Type get_ItemConverterType() { }

	[CompilerGenerated]
	internal NamingStrategy get_NamingStrategyInstance() { }

	public Object[] get_NamingStrategyParameters() { }

	public Type get_NamingStrategyType() { }

	[CompilerGenerated]
	internal void set_NamingStrategyInstance(NamingStrategy value) { }

}

