namespace Assets.Scripts.Unity.UI_New.Popups;

public class LogoutPopup : Popup
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass3_0
	{
		public LiNKAccount playerLinkAccount; //Field offset: 0x10
		public LogoutPopup <>4__this; //Field offset: 0x18

		public <>c__DisplayClass3_0() { }

		internal void <Awake>b__0() { }

	}

	[CompilerGenerated]
	private struct <ShowCopiedTick>d__4 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncVoidMethodBuilder <>t__builder; //Field offset: 0x8
		public LogoutPopup <>4__this; //Field offset: 0x28
		private TaskAwaiter <>u__1; //Field offset: 0x30

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[SerializeField]
	private Button copyButton; //Field offset: 0x128
	[SerializeField]
	private GameObject ImageContainer; //Field offset: 0x130
	[SerializeField]
	private NK_TextMeshProUGUI userIdText; //Field offset: 0x138

	public LogoutPopup() { }

	public void Awake() { }

	[AsyncStateMachine(typeof(<ShowCopiedTick>d__4))]
	public void ShowCopiedTick() { }

}

