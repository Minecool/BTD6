namespace Assets.Scripts.Unity.GameEditor.UI.PopupPanels;

public class BehaviorComponentView : ComponentView<BehaviorViewModel>
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass4_0
	{
		public VariableBaseViewModel variableVM; //Field offset: 0x10
		public BehaviorComponentView <>4__this; //Field offset: 0x18

		public <>c__DisplayClass4_0() { }

		internal void <PopulateVariables>b__0(AsyncOperationHandle<GameObject> h) { }

	}

	public Transform variablesTransform; //Field offset: 0x40

	public BehaviorComponentView() { }

	public virtual void Bind(EntityViewModel eVM, object data) { }

	protected virtual void ClearContainers() { }

	public virtual void OnShowView() { }

	private void PopulateVariables() { }

	public virtual void Release() { }

}

