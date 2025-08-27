namespace Assets.Scripts.Unity.UI_New.ChallengeEditor;

public class PlayerContent
{
	[CompilerGenerated]
	private struct <_GetData>d__11 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder<IContentBrowserData> <>t__builder; //Field offset: 0x8
		public PlayerContent <>4__this; //Field offset: 0x20
		private TaskAwaiter<IContentBrowserData> <>u__1; //Field offset: 0x28

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <GetData>d__10 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder<IContentBrowserData> <>t__builder; //Field offset: 0x8
		public PlayerContent <>4__this; //Field offset: 0x20
		private TaskAwaiter<IContentBrowserData> <>u__1; //Field offset: 0x28

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	public PlayerContentInfo info; //Field offset: 0x10
	public WinRateDisplayType winRateDisplayType; //Field offset: 0x18
	[CompilerGenerated]
	private IContentBrowserData <ContentData>k__BackingField; //Field offset: 0x20
	[JsonIgnore]
	private Task<IContentBrowserData> downloadTask; //Field offset: 0x28
	private string _completionRate; //Field offset: 0x30
	private string _winRate; //Field offset: 0x38

	public string CompletionRate
	{
		 get { } //Length: 393
	}

	[JsonProperty("ChallengeData")]
	public private IContentBrowserData ContentData
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 5
	}

	public string Id
	{
		 get { } //Length: 27
	}

	public string WinRate
	{
		 get { } //Length: 369
	}

	[AsyncStateMachine(typeof(<_GetData>d__11))]
	private Task<IContentBrowserData> _GetData() { }

	public PlayerContent(PlayerContentInfo info) { }

	public string get_CompletionRate() { }

	[CompilerGenerated]
	public IContentBrowserData get_ContentData() { }

	public string get_Id() { }

	public string get_WinRate() { }

	[AsyncStateMachine(typeof(<GetData>d__10))]
	public Task<IContentBrowserData> GetData() { }

	public string GetDisplayWinRate(bool isAttempts) { }

	[CompilerGenerated]
	private void set_ContentData(IContentBrowserData value) { }

	public void SetRatesDirty() { }

}

