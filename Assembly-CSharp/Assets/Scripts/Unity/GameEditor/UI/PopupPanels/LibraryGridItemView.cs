namespace Assets.Scripts.Unity.GameEditor.UI.PopupPanels;

public class LibraryGridItemView : LibraryItemView<LibraryGridItemViewModel>
{
	[CompilerGenerated]
	private struct <SetDisplay>d__2 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public LibraryGridItemView <>4__this; //Field offset: 0x20
		private TaskAwaiter <>u__1; //Field offset: 0x28

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	public Image icon; //Field offset: 0x40

	public LibraryGridItemView() { }

	public virtual void Initialise(CustomPrefabModelData data) { }

	[AsyncStateMachine(typeof(<SetDisplay>d__2))]
	private Task SetDisplay() { }

}

