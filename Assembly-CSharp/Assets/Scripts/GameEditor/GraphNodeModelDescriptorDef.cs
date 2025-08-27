namespace Assets.Scripts.GameEditor;

public class GraphNodeModelDescriptorDef
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func<GraphNodeModelDescriptor, GraphNodeModelDescriptorDef> <>9__38_0; //Field offset: 0x8

		private static <>c() { }

		public <>c() { }

		internal GraphNodeModelDescriptorDef <InitailiseDefault>b__38_0(GraphNodeModelDescriptor x) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass42_0
	{
		public List<Type> allDerivedTypes; //Field offset: 0x10

		public <>c__DisplayClass42_0() { }

		internal bool <GetMostDerivedTypes>b__0(Type t) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass42_1
	{
		public Type t; //Field offset: 0x10

		public <>c__DisplayClass42_1() { }

		internal bool <GetMostDerivedTypes>b__1(Type d) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass43_0
	{
		public Type baseType; //Field offset: 0x10

		public <>c__DisplayClass43_0() { }

		internal bool <GetDerivedTypes>b__0(Type t) { }

	}

	[CompilerGenerated]
	private string <Name>k__BackingField; //Field offset: 0x10
	public string modelName; //Field offset: 0x18
	public string modelType; //Field offset: 0x20
	public List<GraphNodeModelDescriptorDef> childModels; //Field offset: 0x28
	public string behaviorModelType; //Field offset: 0x30
	public SpriteReference icon; //Field offset: 0x38
	[CompilerGenerated]
	private List<Type> <DerivedTypes>k__BackingField; //Field offset: 0x40
	[CompilerGenerated]
	private List<ParameterInfo> <Paramaters>k__BackingField; //Field offset: 0x48
	[CompilerGenerated]
	private bool <IsPrimitive>k__BackingField; //Field offset: 0x50
	[CompilerGenerated]
	private bool <IsEnum>k__BackingField; //Field offset: 0x51
	[CompilerGenerated]
	private bool <IsArray>k__BackingField; //Field offset: 0x52
	[Nullable(2)]
	private Type _type; //Field offset: 0x58
	private Nullable<Boolean> _hasDerivedTypes; //Field offset: 0x60

	public private List<Type> DerivedTypes
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 5
	}

	public bool HasDerivedTypes
	{
		 get { } //Length: 164
	}

	public private bool IsArray
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 4
	}

	public private bool IsEnum
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 4
	}

	public private bool IsPrimitive
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 4
	}

	public bool IsSkippableType
	{
		 get { } //Length: 20
	}

	public string Name
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		 set { } //Length: 5
	}

	public private List<ParameterInfo> Paramaters
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 5
	}

	[Nullable(1)]
	public Type Type
	{
		[NullableContext(1)]
		 get { } //Length: 139
	}

	public GraphNodeModelDescriptorDef(Type type) { }

	public GraphNodeModelDescriptorDef(ParameterInfo paramaterInfo) { }

	public GraphNodeModelDescriptorDef(GraphNodeModelDescriptor descriptor) { }

	[CompilerGenerated]
	public List<Type> get_DerivedTypes() { }

	public bool get_HasDerivedTypes() { }

	[CompilerGenerated]
	public bool get_IsArray() { }

	[CompilerGenerated]
	public bool get_IsEnum() { }

	[CompilerGenerated]
	public bool get_IsPrimitive() { }

	public bool get_IsSkippableType() { }

	[CompilerGenerated]
	public string get_Name() { }

	[CompilerGenerated]
	public List<ParameterInfo> get_Paramaters() { }

	[NullableContext(1)]
	public Type get_Type() { }

	private List<Type> GetDerivedTypes(Type baseType) { }

	private List<Type> GetMostDerivedTypes(Type baseType) { }

	private void Init() { }

	private void InitailiseDefault(GraphNodeModelDescriptor descriptor) { }

	[CompilerGenerated]
	private void set_DerivedTypes(List<Type> value) { }

	[CompilerGenerated]
	private void set_IsArray(bool value) { }

	[CompilerGenerated]
	private void set_IsEnum(bool value) { }

	[CompilerGenerated]
	private void set_IsPrimitive(bool value) { }

	[CompilerGenerated]
	public void set_Name(string value) { }

	[CompilerGenerated]
	private void set_Paramaters(List<ParameterInfo> value) { }

	private bool ShouldSkipType(Type type) { }

}

