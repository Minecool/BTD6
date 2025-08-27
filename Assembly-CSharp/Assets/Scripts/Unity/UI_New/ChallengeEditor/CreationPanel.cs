namespace Assets.Scripts.Unity.UI_New.ChallengeEditor;

public class CreationPanel : MonoBehaviour
{
	[CompilerGenerated]
	private struct <Init>d__10 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public CreationPanel <>4__this; //Field offset: 0x20
		public ICreatorModelWrapper _modelWrapper; //Field offset: 0x28
		public ContentType _contentType; //Field offset: 0x30
		private TaskAwaiter <>u__1; //Field offset: 0x38

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <LoadMapThumbnailAsync>d__13 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public CreationPanel <>4__this; //Field offset: 0x20
		public CustomMapModel customMapModel; //Field offset: 0x28
		public string creationId; //Field offset: 0x30
		private CancellationToken <cancellationToken>5__2; //Field offset: 0x38
		private TaskAwaiter<Texture2D> <>u__1; //Field offset: 0x40

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[SerializeField]
	private TMP_Text titleTxt; //Field offset: 0x20
	[SerializeField]
	private Image mapLoadingSpinner; //Field offset: 0x28
	[SerializeField]
	private Image mapImg; //Field offset: 0x30
	[SerializeField]
	private Button playButton; //Field offset: 0x38
	[SerializeField]
	private Button deleteButton; //Field offset: 0x40
	[SerializeField]
	private GameObject sharedIcon; //Field offset: 0x48
	private ContentType contentType; //Field offset: 0x50
	private ICreatorModelWrapper modelWrapper; //Field offset: 0x58
	private CancellationTokenSource thumbnailCts; //Field offset: 0x60

	public CreationPanel() { }

	[CompilerGenerated]
	private void <OnDeleteButtonClicked>b__12_0() { }

	[AsyncStateMachine(typeof(<Init>d__10))]
	public Task Init(ICreatorModelWrapper _modelWrapper, ContentType _contentType) { }

	[AsyncStateMachine(typeof(<LoadMapThumbnailAsync>d__13))]
	private Task LoadMapThumbnailAsync(string creationId, CustomMapModel customMapModel) { }

	private void OnDeleteButtonClicked() { }

	protected void OnDestroy() { }

	private void OnPlayButtonClicked() { }

}

