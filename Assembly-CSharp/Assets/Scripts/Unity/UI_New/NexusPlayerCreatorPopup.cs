namespace Assets.Scripts.Unity.UI_New;

public class NexusPlayerCreatorPopup : MonoBehaviour
{
	[CompilerGenerated]
	private struct <CopyUrlToClipboardAsync>d__9 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncVoidMethodBuilder <>t__builder; //Field offset: 0x8
		public NexusPlayerCreatorPopup <>4__this; //Field offset: 0x28
		private TaskAwaiter<String> <>u__1; //Field offset: 0x30
		private TaskAwaiter <>u__2; //Field offset: 0x38

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <OpenExternalBrowserAsync>d__8 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncVoidMethodBuilder <>t__builder; //Field offset: 0x8
		public NexusPlayerCreatorPopup <>4__this; //Field offset: 0x28
		private TaskAwaiter<String> <>u__1; //Field offset: 0x30

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <TryGetWebAuthUrl>d__10 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder<String> <>t__builder; //Field offset: 0x8
		public NexusPlayerCreatorPopup <>4__this; //Field offset: 0x20
		private TaskAwaiter<String> <>u__1; //Field offset: 0x28

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[SerializeField]
	private Button okButton; //Field offset: 0x20
	[SerializeField]
	private Image loadingSpinner; //Field offset: 0x28
	[SerializeField]
	private Button openBrowserButton; //Field offset: 0x30
	[SerializeField]
	private Button copyToClipboardBtn; //Field offset: 0x38
	[SerializeField]
	private Image copiedToClipboardTick; //Field offset: 0x40
	private AccoladesNotificationPanel accoladesNotificationPanel; //Field offset: 0x48

	public NexusPlayerCreatorPopup() { }

	private void Awake() { }

	[AsyncStateMachine(typeof(<CopyUrlToClipboardAsync>d__9))]
	private void CopyUrlToClipboardAsync() { }

	public void Init(AccoladesNotificationPanel accoladesNotificationPanel) { }

	private void IsLoadingUrl(bool isLoading) { }

	private void OnApplicationFocus(bool focus) { }

	[AsyncStateMachine(typeof(<OpenExternalBrowserAsync>d__8))]
	private void OpenExternalBrowserAsync() { }

	[AsyncStateMachine(typeof(<TryGetWebAuthUrl>d__10))]
	private Task<String> TryGetWebAuthUrl() { }

}

