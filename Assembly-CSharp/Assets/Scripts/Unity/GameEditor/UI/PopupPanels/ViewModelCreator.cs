namespace Assets.Scripts.Unity.GameEditor.UI.PopupPanels;

public class ViewModelCreator
{
	private readonly object _behaviorInstance; //Field offset: 0x10
	private readonly List<VariableBaseViewModel> _variableViewModels; //Field offset: 0x18
	private readonly List<VariableBaseViewModel> _behaviorViewModels; //Field offset: 0x20
	private readonly Dictionary<Type, Action`1<FieldInfo>> _typeHandlers; //Field offset: 0x28
	[CompilerGenerated]
	private bool <IsLeafNode>k__BackingField; //Field offset: 0x30

	public private bool IsLeafNode
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 4
	}

	public ViewModelCreator(object behaviorInstance, List<VariableBaseViewModel> variableViewModels, List<VariableBaseViewModel> behaviorViewModels) { }

	[CompilerGenerated]
	private void <.ctor>b__8_0(FieldInfo field) { }

	[CompilerGenerated]
	private void <.ctor>b__8_1(FieldInfo field) { }

	[CompilerGenerated]
	private void <.ctor>b__8_10(FieldInfo field) { }

	[CompilerGenerated]
	private void <.ctor>b__8_11(FieldInfo field) { }

	[CompilerGenerated]
	private void <.ctor>b__8_12(FieldInfo field) { }

	[CompilerGenerated]
	private void <.ctor>b__8_13(FieldInfo field) { }

	[CompilerGenerated]
	private void <.ctor>b__8_14(FieldInfo field) { }

	[CompilerGenerated]
	private void <.ctor>b__8_15(FieldInfo field) { }

	[CompilerGenerated]
	private void <.ctor>b__8_16(FieldInfo field) { }

	[CompilerGenerated]
	private void <.ctor>b__8_2(FieldInfo field) { }

	[CompilerGenerated]
	private void <.ctor>b__8_3(FieldInfo field) { }

	[CompilerGenerated]
	private void <.ctor>b__8_4(FieldInfo field) { }

	[CompilerGenerated]
	private void <.ctor>b__8_5(FieldInfo field) { }

	[CompilerGenerated]
	private void <.ctor>b__8_6(FieldInfo field) { }

	[CompilerGenerated]
	private void <.ctor>b__8_7(FieldInfo field) { }

	[CompilerGenerated]
	private void <.ctor>b__8_8(FieldInfo field) { }

	[CompilerGenerated]
	private void <.ctor>b__8_9(FieldInfo field) { }

	private void AddArrayViewModel(FieldInfo field) { }

	private void AddVariableBehaviorViewModel(FieldInfo field) { }

	private void AddVariableViewModel(FieldInfo fieldInfo) { }

	[CompilerGenerated]
	public bool get_IsLeafNode() { }

	private void InvokeAddVariableBehaviorViewModel(FieldInfo field) { }

	public void ProcessFields(IEnumerable<FieldInfo> fields) { }

	[CompilerGenerated]
	private void set_IsLeafNode(bool value) { }

}

