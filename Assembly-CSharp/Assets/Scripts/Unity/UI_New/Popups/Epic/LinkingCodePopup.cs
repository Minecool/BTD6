namespace Assets.Scripts.Unity.UI_New.Popups.Epic;

public class LinkingCodePopup : BaseEpicAccountPopup
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static OnSharedToClipboard <>9__3_0; //Field offset: 0x8

		private static <>c() { }

		public <>c() { }

		internal void <CopyToClipboard>b__3_0() { }

	}

	[CompilerGenerated]
	private struct <Start>d__2 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncVoidMethodBuilder <>t__builder; //Field offset: 0x8
		public LinkingCodePopup <>4__this; //Field offset: 0x28
		private TaskAwaiter<String> <>u__1; //Field offset: 0x30

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	public TMP_Text codeText; //Field offset: 0x48
	public Button copyBtn; //Field offset: 0x50

	public LinkingCodePopup() { }

	private void CopyToClipboard() { }

	[AsyncStateMachine(typeof(<Start>d__2))]
	private void Start() { }

}

