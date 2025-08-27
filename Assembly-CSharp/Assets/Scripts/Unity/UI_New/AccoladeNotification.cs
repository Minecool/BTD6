namespace Assets.Scripts.Unity.UI_New;

public class AccoladeNotification : MonoBehaviour
{
	[CompilerGenerated]
	private struct <BindAsync>d__15 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public AccoladeNotification <>4__this; //Field offset: 0x20
		public AccoladeTransaction accoladeTransaction; //Field offset: 0x28
		public Task<Dictionary`2<String, String>> userNamesTask; //Field offset: 0x30
		public long latestSeenAccoladeTransactionId; //Field offset: 0x38
		private string <contentName>5__2; //Field offset: 0x40
		private TaskAwaiter<ReceivedAccoladeCache> <>u__1; //Field offset: 0x48
		private TaskAwaiter<PlayerContentInfo> <>u__2; //Field offset: 0x50
		private TaskAwaiter<Dictionary`2<String, String>> <>u__3; //Field offset: 0x58

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <RefreshDisplayName>d__18 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public Task<Dictionary`2<String, String>> userNamesTask; //Field offset: 0x20
		public AccoladeNotification <>4__this; //Field offset: 0x28
		public string fromUserId; //Field offset: 0x30
		public string cachedName; //Field offset: 0x38
		public long accoladeTransactionId; //Field offset: 0x40
		public string contentName; //Field offset: 0x48
		private TaskAwaiter<Dictionary`2<String, String>> <>u__1; //Field offset: 0x50

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <TransitionToContentPlayScreenAsync>d__17 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public AccoladeNotification <>4__this; //Field offset: 0x20
		private PlayerContentInfo <contentInfo>5__2; //Field offset: 0x28
		private TaskAwaiter<PlayerContentInfo> <>u__1; //Field offset: 0x30
		private PlayerContent <playerContent>5__3; //Field offset: 0x38
		private TaskAwaiter<IContentBrowserData> <>u__2; //Field offset: 0x40

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	private static class AccoladeNotificationStorage
	{
		[CompilerGenerated]
		private struct <TryGetReceivedAccoladeCache>d__3 : IAsyncStateMachine
		{
			public int <>1__state; //Field offset: 0x0
			public AsyncTaskMethodBuilder<ReceivedAccoladeCache> <>t__builder; //Field offset: 0x8
			public long id; //Field offset: 0x20
			private TaskAwaiter<ReceivedAccoladeCache> <>u__1; //Field offset: 0x28

			private override void MoveNext() { }

			[DebuggerHidden]
			private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

		}

		private static readonly StorageManager storageManager; //Field offset: 0x0

		private static AccoladeNotificationStorage() { }

		private static string Decode(Byte[] data) { }

		private static string GetKey(long id) { }

		public static Task SetReceivedAccoladeCache(long id, string fromPlayerName, string contentName) { }

		[AsyncStateMachine(typeof(<TryGetReceivedAccoladeCache>d__3))]
		public static Task<ReceivedAccoladeCache> TryGetReceivedAccoladeCache(long id) { }

	}

	internal sealed class OpeningContent : MulticastDelegate
	{

		public OpeningContent(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(AsyncCallback callback, object object) { }

		public override void EndInvoke(IAsyncResult result) { }

		public override void Invoke() { }

	}

	private class ReceivedAccoladeCache
	{
		[CompilerGenerated]
		private string <FromPlayerName>k__BackingField; //Field offset: 0x10
		[CompilerGenerated]
		private string <ContentName>k__BackingField; //Field offset: 0x18

		public string ContentName
		{
			[CompilerGenerated]
			 get { } //Length: 5
			[CompilerGenerated]
			 set { } //Length: 5
		}

		public string FromPlayerName
		{
			[CompilerGenerated]
			 get { } //Length: 5
			[CompilerGenerated]
			 set { } //Length: 5
		}

		public ReceivedAccoladeCache() { }

		[CompilerGenerated]
		public string get_ContentName() { }

		[CompilerGenerated]
		public string get_FromPlayerName() { }

		[CompilerGenerated]
		public void set_ContentName(string value) { }

		[CompilerGenerated]
		public void set_FromPlayerName(string value) { }

	}

	internal sealed class SetContentButtonInteractable : MulticastDelegate
	{

		public SetContentButtonInteractable(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(bool isInteractable, AsyncCallback callback, object object) { }

		public override void EndInvoke(IAsyncResult result) { }

		public override void Invoke(bool isInteractable) { }

	}

	[SerializeField]
	private NK_TextMeshProUGUI playerNameTxt; //Field offset: 0x20
	[SerializeField]
	private NK_TextMeshProUGUI challengeNameTxt; //Field offset: 0x28
	[SerializeField]
	private NK_TextMeshProUGUI dateTxt; //Field offset: 0x30
	[SerializeField]
	private Button openContentButton; //Field offset: 0x38
	[SerializeField]
	private Image contentOpeningSpinner; //Field offset: 0x40
	[SerializeField]
	private GameObject newBannerObj; //Field offset: 0x48
	[SerializeField]
	private Image contentTypeImg; //Field offset: 0x50
	[SerializeField]
	private AccoladeDisplay accoladeDisplay; //Field offset: 0x58
	[SerializeField]
	private Sprite[] contentIconSprites; //Field offset: 0x60
	private AccoladeTransaction accoladeTransactionInfo; //Field offset: 0x68

	public AccoladeNotification() { }

	private void Awake() { }

	[AsyncStateMachine(typeof(<BindAsync>d__15))]
	public Task BindAsync(AccoladeTransaction accoladeTransaction, Task<Dictionary`2<String, String>> userNamesTask, long latestSeenAccoladeTransactionId) { }

	private void DisableOpenButton(bool isInteractable) { }

	private void OnClickContentPlayButton() { }

	[AsyncStateMachine(typeof(<RefreshDisplayName>d__18))]
	private Task RefreshDisplayName(Task<Dictionary`2<String, String>> userNamesTask, string fromUserId, string cachedName, long accoladeTransactionId, string contentName) { }

	private void ResetOpenButtons() { }

	[AsyncStateMachine(typeof(<TransitionToContentPlayScreenAsync>d__17))]
	private Task TransitionToContentPlayScreenAsync() { }

}

