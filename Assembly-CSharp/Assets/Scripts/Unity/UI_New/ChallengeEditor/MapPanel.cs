namespace Assets.Scripts.Unity.UI_New.ChallengeEditor;

public class MapPanel : ContentBrowserPanel
{
	[CompilerGenerated]
	private struct <LoadMapThumbnailAsync>d__8 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public MapPanel <>4__this; //Field offset: 0x20
		public PlayerContent playerContent; //Field offset: 0x28
		private CancellationToken <cancellationToken>5__2; //Field offset: 0x30
		private YieldAwaiter <>u__1; //Field offset: 0x38
		private Texture2D <img>5__3; //Field offset: 0x40
		private TaskAwaiter<IContentBrowserData> <>u__2; //Field offset: 0x48
		private TaskAwaiter<Texture2D> <>u__3; //Field offset: 0x50

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[SerializeField]
	private Image mapLoadingSpinner; //Field offset: 0xE0
	[SerializeField]
	private GameObject submissionPending; //Field offset: 0xE8
	[SerializeField]
	private GameObject submissionRejected; //Field offset: 0xF0
	[SerializeField]
	private GameObject submissionAutoAccepted; //Field offset: 0xF8
	[SerializeField]
	private GameObject submissionHumanAccepted; //Field offset: 0x100
	private CancellationTokenSource thumbnailCts; //Field offset: 0x108

	public MapPanel() { }

	public virtual void Init(PlayerContent playerContent, BrowserBase browser) { }

	[AsyncStateMachine(typeof(<LoadMapThumbnailAsync>d__8))]
	private Task LoadMapThumbnailAsync(PlayerContent playerContent) { }

	private void OnDestroy() { }

	public virtual void OpenPlayScene(IContentBrowserData _) { }

}

