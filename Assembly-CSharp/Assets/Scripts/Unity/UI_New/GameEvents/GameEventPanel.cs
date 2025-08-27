namespace Assets.Scripts.Unity.UI_New.GameEvents;

public class GameEventPanel : MonoBehaviour
{
	[CompilerGenerated]
	private struct <_LoadImage>d__19 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder<Texture2D> <>t__builder; //Field offset: 0x8
		public string cacheKey; //Field offset: 0x20
		public CancellationToken cancellationToken; //Field offset: 0x28
		public string url; //Field offset: 0x30
		private Byte[] <imageBytes>5__2; //Field offset: 0x38
		private TaskAwaiter<ImageCache> <>u__1; //Field offset: 0x40
		[TupleElementNames(new IL2CPP_TYPE_STRING[] {"data", "etag"}])]
		private TaskAwaiter<ValueTuple`2<Byte[], String>> <>u__2; //Field offset: 0x48
		private TaskAwaiter <>u__3; //Field offset: 0x50

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <DownloadData>d__22 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		[TupleElementNames(new IL2CPP_TYPE_STRING[] {"data", "etag"}])]
		public AsyncTaskMethodBuilder<ValueTuple`2<Byte[], String>> <>t__builder; //Field offset: 0x8
		public Byte[] cachedData; //Field offset: 0x20
		public string cachedEtag; //Field offset: 0x28
		public string url; //Field offset: 0x30
		public CancellationToken cancellationToken; //Field offset: 0x38
		private bool <hasCache>5__2; //Field offset: 0x40
		private UnityWebRequest <webRequest>5__3; //Field offset: 0x48
		private UnityWebRequestAsyncOperation <request>5__4; //Field offset: 0x50
		private DateTime <startTime>5__5; //Field offset: 0x58
		private YieldAwaiter <>u__1; //Field offset: 0x60

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <LoadImage>d__18 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder<Texture2D> <>t__builder; //Field offset: 0x8
		public CancellationToken cancellationToken; //Field offset: 0x20
		public string url; //Field offset: 0x28
		public string cacheKey; //Field offset: 0x30
		private YieldAwaiter <>u__1; //Field offset: 0x38
		private TaskAwaiter<Texture2D> <>u__2; //Field offset: 0x40

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	private static StorageManager imageStorage; //Field offset: 0x0
	private const int kMaxImageLoads = 4; //Field offset: 0x0
	private static int loadImageCount; //Field offset: 0x8
	private static readonly TimeSpan MaxDownloadWaitTime; //Field offset: 0x10
	private static readonly TimeSpan ImageCacheTime; //Field offset: 0x18
	public int panelPriority; //Field offset: 0x20
	public GameObject noEventObj; //Field offset: 0x28
	public TextMeshProUGUI noEventTxt; //Field offset: 0x30
	public GameObject dateContainer; //Field offset: 0x38
	public TMP_Text date; //Field offset: 0x40
	public string panelID; //Field offset: 0x48
	protected GameEventsScreen parent; //Field offset: 0x50
	[CompilerGenerated]
	private bool <IsActive>k__BackingField; //Field offset: 0x58

	[HideInInspector]
	public private bool IsActive
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 4
	}

	[AsyncStateMachine(typeof(<_LoadImage>d__19))]
	private static Task<Texture2D> _LoadImage(string url, string cacheKey, CancellationToken cancellationToken) { }

	private static GameEventPanel() { }

	public GameEventPanel() { }

	protected Sprite CreateBannerSprite(Texture2D texture) { }

	[AsyncStateMachine(typeof(<DownloadData>d__22))]
	private static Task<ValueTuple`2<Byte[], String>> DownloadData(string url, CancellationToken cancellationToken, Byte[] cachedData = null, string cachedEtag = null) { }

	[CompilerGenerated]
	public bool get_IsActive() { }

	private static string GetFinalUrl(string imageSource) { }

	private static bool IsFullUrl(string toCheck) { }

	[AsyncStateMachine(typeof(<LoadImage>d__18))]
	public static Task<Texture2D> LoadImage(string url, string cacheKey, CancellationToken cancellationToken) { }

	public static Task<Texture2D> LoadImageFromCache(string imageSource, CancellationToken cancellationToken) { }

	public void ReportStatus() { }

	[CompilerGenerated]
	private void set_IsActive(bool value) { }

	public override void SetUnavailable(Nullable<DateTime> startTime, bool canShowNextEventTimer, string messageLocsKey) { }

	public void ToggleDisplay(bool on) { }

}

