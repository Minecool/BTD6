namespace Assets.Scripts.Unity.GameEditor.UI.PopupPanels;

public class VariableInputfieldView : VariableView<VariableBaseViewModel>
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass1_0
	{
		public VariableViewModel<Single> <floatVM>5__2; //Field offset: 0x10
		public VariableViewModel<Int32> <intVM>5__3; //Field offset: 0x18
		public VariableViewModel<String> <stringVM>5__4; //Field offset: 0x20

		public <>c__DisplayClass1_0() { }

		internal void <Bind>b__0(string value) { }

		internal void <Bind>b__1(string value) { }

		internal void <Bind>b__2(string value) { }

	}

	public TMP_InputField variableValue; //Field offset: 0x40

	public VariableInputfieldView() { }

	public virtual void Bind(EntityViewModel eVM, object data) { }

	protected virtual void OnUpdateView() { }

	protected virtual void OnValueChanged() { }

	public virtual void Release() { }

}

