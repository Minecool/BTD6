namespace Assets.Scripts.Unity.UI_New.Main.UpdateScreen;

public class UpdateAnnouncementScreen : GameMenu
{
	[CompilerGenerated]
	private struct <BindImage>d__16 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public string banner; //Field offset: 0x20
		public UpdateAnnouncementScreen <>4__this; //Field offset: 0x28
		private TaskAwaiter<Texture2D> <>u__1; //Field offset: 0x30

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[SerializeField]
	private Image mainImage; //Field offset: 0x48
	[SerializeField]
	private NK_TextMeshProUGUI titleText; //Field offset: 0x50
	[SerializeField]
	private NK_TextMeshProUGUI descriptionText; //Field offset: 0x58
	[SerializeField]
	private NK_TextMeshProUGUI fullPatchNotesUrl; //Field offset: 0x60
	[SerializeField]
	private Button fullPatchNotesBtn; //Field offset: 0x68
	[SerializeField]
	private Button okBtn; //Field offset: 0x70
	[SerializeField]
	private GameObject fullPatchNotes; //Field offset: 0x78
	[SerializeField]
	private GameObject patchNotesMonkey; //Field offset: 0x80
	[SerializeField]
	private GameObject imageFadeGo; //Field offset: 0x88
	private CancellationTokenSource screenCts; //Field offset: 0x90
	private CancellationToken screenCanceller; //Field offset: 0x98

	private static string FullPatchnotesUrl
	{
		private get { } //Length: 150
	}

	public UpdateAnnouncementScreen() { }

	protected virtual void Awake() { }

	[AsyncStateMachine(typeof(<BindImage>d__16))]
	private Task BindImage(string banner) { }

	private static string get_FullPatchnotesUrl() { }

	private void OnDestroy() { }

	public virtual void Open(object data) { }

	private void OpenFullPatchNotes() { }

	public static void OpenPatchNotes(int majorVersion) { }

}

