namespace Assets.Scripts.Unity.UI_New.Popups.Epic;

public class AgreePopup : BaseEpicAccountPopup
{
	[CompilerGenerated]
	private struct <Login>d__6 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public AgreePopup <>4__this; //Field offset: 0x20
		private PlayerService <playerService>5__2; //Field offset: 0x28
		private TaskAwaiter <>u__1; //Field offset: 0x30
		private TaskAwaiter<String> <>u__2; //Field offset: 0x38

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	public TMP_Text confirmText; //Field offset: 0x48
	public Button okBtn; //Field offset: 0x50
	private bool childAccount; //Field offset: 0x58

	public AgreePopup() { }

	[CompilerGenerated]
	private void <Start>b__3_0() { }

	[AsyncStateMachine(typeof(<Login>d__6))]
	private Task Login() { }

	public void SetChildAccount(bool childAccount) { }

	protected virtual void SetProcessing(bool processing) { }

	private void Start() { }

}

