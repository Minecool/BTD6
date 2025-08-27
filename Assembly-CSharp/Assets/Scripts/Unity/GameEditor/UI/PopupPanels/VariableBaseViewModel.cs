namespace Assets.Scripts.Unity.GameEditor.UI.PopupPanels;

public abstract class VariableBaseViewModel : IVariableViewModel
{
	[CompilerGenerated]
	private string <VariableName>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	private string <Name>k__BackingField; //Field offset: 0x18
	[CompilerGenerated]
	private readonly bool <IsNonRemoveable>k__BackingField; //Field offset: 0x20
	[CompilerGenerated]
	private readonly FieldInfo <_propertyInfo>k__BackingField; //Field offset: 0x28
	[CompilerGenerated]
	private Type <Type>k__BackingField; //Field offset: 0x30
	[CompilerGenerated]
	private object <UntypedValue>k__BackingField; //Field offset: 0x38
	private string _prefabName; //Field offset: 0x40
	public Action OnValueChanged; //Field offset: 0x48

	public FieldInfo _propertyInfo
	{
		[CompilerGenerated]
		 get { } //Length: 5
	}

	public bool IsArray
	{
		 get { } //Length: 56
	}

	public bool IsNonRemoveable
	{
		[CompilerGenerated]
		 get { } //Length: 5
	}

	public bool IsVariableList
	{
		 get { } //Length: 159
	}

	public string Name
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		 set { } //Length: 5
	}

	public override string PrefabName
	{
		 get { } //Length: 117
	}

	public override Type Type
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		 set { } //Length: 5
	}

	public override object UntypedValue
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		 set { } //Length: 5
	}

	public override string VariableName
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		 set { } //Length: 5
	}

	protected VariableBaseViewModel(FieldInfo propertyInfo, bool isNonRemoveable = false) { }

	[CompilerGenerated]
	public FieldInfo get__propertyInfo() { }

	public bool get_IsArray() { }

	[CompilerGenerated]
	public bool get_IsNonRemoveable() { }

	public bool get_IsVariableList() { }

	[CompilerGenerated]
	public string get_Name() { }

	public override string get_PrefabName() { }

	[CompilerGenerated]
	public override Type get_Type() { }

	[CompilerGenerated]
	public override object get_UntypedValue() { }

	[CompilerGenerated]
	public override string get_VariableName() { }

	public abstract object GetValue() { }

	public abstract void Initialise() { }

	[CompilerGenerated]
	public void set_Name(string value) { }

	[CompilerGenerated]
	public void set_Type(Type value) { }

	[CompilerGenerated]
	public override void set_UntypedValue(object value) { }

	[CompilerGenerated]
	public void set_VariableName(string value) { }

	public abstract void SetValue(object value) { }

}

