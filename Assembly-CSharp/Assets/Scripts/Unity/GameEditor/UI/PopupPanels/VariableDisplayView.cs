namespace Assets.Scripts.Unity.GameEditor.UI.PopupPanels;

public class VariableDisplayView : VariableView<VariableViewModel`1<IAssetReference>>
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass2_0
	{
		public VariableDisplayView <>4__this; //Field offset: 0x10
		public VariableViewModel<PrefabReference> prefabVM; //Field offset: 0x18

		public <>c__DisplayClass2_0() { }

		internal void <Bind>b__0() { }

	}

	[CompilerGenerated]
	private struct <ChangeDisplay>d__4 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncVoidMethodBuilder <>t__builder; //Field offset: 0x8
		public VariableViewModel<PrefabReference> prefabViewModel; //Field offset: 0x28
		public VariableDisplayView <>4__this; //Field offset: 0x30
		private TaskAwaiter<Entry<BTD6AssetFlags>> <>u__1; //Field offset: 0x38
		private TaskAwaiter <>u__2; //Field offset: 0x40

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <SetDisplay>d__5 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x0
		public VariableViewModel<T> viewModel; //Field offset: 0x0
		public VariableDisplayView <>4__this; //Field offset: 0x0
		private TaskAwaiter <>u__1; //Field offset: 0x0

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	public Image variableImage; //Field offset: 0x40
	public Button changeImageButton; //Field offset: 0x48

	public VariableDisplayView() { }

	public virtual void Bind(EntityViewModel eVM, object data) { }

	[AsyncStateMachine(typeof(<ChangeDisplay>d__4))]
	private void ChangeDisplay(VariableViewModel<PrefabReference> prefabViewModel) { }

	protected virtual void OnUpdateView() { }

	protected virtual void OnValueChanged() { }

	public virtual void Release() { }

	[AsyncStateMachine(typeof(<SetDisplay>d__5`1))]
	private Task SetDisplay(VariableViewModel<T> viewModel) { }

}

