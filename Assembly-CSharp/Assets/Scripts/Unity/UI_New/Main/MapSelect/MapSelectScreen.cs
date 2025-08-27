namespace Assets.Scripts.Unity.UI_New.Main.MapSelect;

public class MapSelectScreen : GameMenu
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass8_0
	{
		public MapSelectScreen <>4__this; //Field offset: 0x10
		public Func<Task> buttonTask; //Field offset: 0x18

		public <>c__DisplayClass8_0() { }

		internal Task <InternetRequiredButtonClicked>b__0() { }

	}

	[CompilerGenerated]
	private struct <OpenMapBrowser>d__10 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public MapSelectScreen <>4__this; //Field offset: 0x20
		private TaskAwaiter<Boolean> <>u__1; //Field offset: 0x28

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <ProcessButtonClicked>d__9 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public MapSelectScreen <>4__this; //Field offset: 0x20
		public Func<Task> buttonTask; //Field offset: 0x28
		private TaskAwaiter<Boolean> <>u__1; //Field offset: 0x30
		private TaskAwaiter <>u__2; //Field offset: 0x38

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <ShowCommunityButton>d__7 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public MapSelectScreen <>4__this; //Field offset: 0x20
		private TaskAwaiter<Boolean> <>u__1; //Field offset: 0x28

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	private MapSelectTransition mapSelectTransition; //Field offset: 0x48
	[SerializeField]
	private Button communityButton; //Field offset: 0x50
	[SerializeField]
	private GameObject[] communityButtonPipObjects; //Field offset: 0x58
	public Action<String> MapSelectedAction; //Field offset: 0x60

	public MapSelectScreen() { }

	[CompilerGenerated]
	private void <ShowCommunityButton>b__7_0() { }

	public virtual void Close() { }

	private void InternetRequiredButtonClicked(Func<Task> buttonTask) { }

	public override void LoadMap(string mapId) { }

	public virtual void Open(object data) { }

	[AsyncStateMachine(typeof(<OpenMapBrowser>d__10))]
	private Task OpenMapBrowser() { }

	[AsyncStateMachine(typeof(<ProcessButtonClicked>d__9))]
	private Task ProcessButtonClicked(Func<Task> buttonTask) { }

	private void SetMapButtonsInteractable(bool interactable) { }

	[AsyncStateMachine(typeof(<ShowCommunityButton>d__7))]
	private Task ShowCommunityButton() { }

}

