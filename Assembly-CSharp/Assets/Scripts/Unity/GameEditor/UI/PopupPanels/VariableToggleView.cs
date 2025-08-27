namespace Assets.Scripts.Unity.GameEditor.UI.PopupPanels;

public class VariableToggleView : VariableView<VariableViewModel`1<Boolean>>
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass1_0
	{
		public VariableViewModel<Boolean> boolVM; //Field offset: 0x10

		public <>c__DisplayClass1_0() { }

		internal void <Bind>b__0(bool value) { }

	}

	public Toggle variableValue; //Field offset: 0x40

	public VariableToggleView() { }

	public virtual void Bind(EntityViewModel eVM, object data) { }

	protected virtual void OnUpdateView() { }

	protected virtual void OnValueChanged() { }

	public virtual void Release() { }

}

