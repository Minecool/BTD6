namespace Assets.Scripts.Unity.UI_New.Main.UpdateScreen;

public class UpdateAnnouncementScreen : GameMenu
{
	[CompilerGenerated]
	private struct <BindImage>d__9 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncVoidMethodBuilder <>t__builder; //Field offset: 0x8
		public string banner; //Field offset: 0x28
		public UpdateAnnouncementScreen <>4__this; //Field offset: 0x30
		private TaskAwaiter<Texture2D> <>u__1; //Field offset: 0x38

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	public Image mainImage; //Field offset: 0x48
	public NK_TextMeshProUGUI titleText; //Field offset: 0x50
	public NK_TextMeshProUGUI descriptionText; //Field offset: 0x58
	public GameObject fullPatchNotes; //Field offset: 0x60
	private CancellationTokenSource screenCts; //Field offset: 0x68
	private CancellationToken screenCanceller; //Field offset: 0x70

	public UpdateAnnouncementScreen() { }

	protected virtual void Awake() { }

	[AsyncStateMachine(typeof(<BindImage>d__9))]
	private void BindImage(string banner) { }

	private string GetLocalizedText(Dictionary<String, String> locs) { }

	public void OnClose() { }

	private void OnDestroy() { }

	public void OnFullPatchNotesClicked() { }

	public virtual void Open(object data) { }

}

