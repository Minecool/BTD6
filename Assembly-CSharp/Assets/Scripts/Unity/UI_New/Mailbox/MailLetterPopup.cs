namespace Assets.Scripts.Unity.UI_New.Mailbox;

public class MailLetterPopup : Popup
{
	[CompilerGenerated]
	private struct <SetBannerAsync>d__3 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncVoidMethodBuilder <>t__builder; //Field offset: 0x8
		public string banner; //Field offset: 0x28
		public MailLetterPopup <>4__this; //Field offset: 0x30
		private TaskAwaiter<Texture2D> <>u__1; //Field offset: 0x38

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[SerializeField]
	private Image bannerImage; //Field offset: 0x128
	[SerializeField]
	private GameObject loadingObj; //Field offset: 0x130

	public MailLetterPopup() { }

	[CompilerGenerated]
	private void <Awake>b__2_0() { }

	protected override void Awake() { }

	[AsyncStateMachine(typeof(<SetBannerAsync>d__3))]
	public void SetBannerAsync(string banner) { }

}

