namespace Assets.Scripts.Unity.UI_New.Popups.Epic;

public class LoggedInPopup : BaseEpicAccountPopup
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass9_0
	{
		public string supportUrl; //Field offset: 0x10

		public <>c__DisplayClass9_0() { }

		internal void <UpdateSupportButton>b__0() { }

	}

	[CompilerGenerated]
	private struct <UpdateSupportButton>d__9 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public LoggedInPopup <>4__this; //Field offset: 0x20
		private string <shortcode>5__2; //Field offset: 0x28
		private TaskAwaiter<String> <>u__1; //Field offset: 0x30

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	public Button supportBtn; //Field offset: 0x48
	public Button linkingCodeBtn; //Field offset: 0x50
	public Button editNameButton; //Field offset: 0x58
	public TMP_Text loggedInName; //Field offset: 0x60
	public TMP_Text epicIdText; //Field offset: 0x68
	public TMP_Text userIdText; //Field offset: 0x70

	public LoggedInPopup() { }

	[CompilerGenerated]
	private void <Awake>b__7_0() { }

	[CompilerGenerated]
	private void <Awake>b__7_1() { }

	protected virtual void Awake() { }

	private void OnEnable() { }

	protected virtual void SetProcessing(bool processing) { }

	[AsyncStateMachine(typeof(<UpdateSupportButton>d__9))]
	private Task UpdateSupportButton() { }

}

