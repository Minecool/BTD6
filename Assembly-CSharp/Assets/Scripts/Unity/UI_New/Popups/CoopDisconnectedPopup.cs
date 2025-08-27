namespace Assets.Scripts.Unity.UI_New.Popups;

public class CoopDisconnectedPopup : Popup
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass11_0
	{
		public CancellationTokenSource canceller; //Field offset: 0x10

		public <>c__DisplayClass11_0() { }

		internal void <OnRejoinClicked>b__0() { }

	}

	[CompilerGenerated]
	private struct <OnRejoinClicked>d__11 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncVoidMethodBuilder <>t__builder; //Field offset: 0x8
		public CoopDisconnectedPopup <>4__this; //Field offset: 0x28
		private <>c__DisplayClass11_0 <>8__1; //Field offset: 0x30
		private CancellationTokenSource <>7__wrap1; //Field offset: 0x38
		private TaskAwaiter <>u__1; //Field offset: 0x40

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	public NK_TextMeshProUGUI message; //Field offset: 0x128
	public Button closeButton; //Field offset: 0x130
	public Button giveUpButton; //Field offset: 0x138
	public Button rejoinButton; //Field offset: 0x140
	public GameObject rejoiningThrobber; //Field offset: 0x148
	public Func<CancellationToken, Task> rejoinFunc; //Field offset: 0x150
	public string lobbyId; //Field offset: 0x158
	public string fromMenu; //Field offset: 0x160
	private ReturnCallback closeAction; //Field offset: 0x168

	private static bool IsDebugBuild
	{
		private get { } //Length: 3
	}

	public CoopDisconnectedPopup() { }

	public void Awake() { }

	private static bool get_IsDebugBuild() { }

	public void OnCloseClicked() { }

	[AsyncStateMachine(typeof(<OnRejoinClicked>d__11))]
	public void OnRejoinClicked() { }

	public void QuitToMenu() { }

	public void SetCancelAction(ReturnCallback closeAction) { }

}

