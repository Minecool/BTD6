namespace Assets.Scripts.Unity.UI_New.Coop;

public class CoopQuickMatchScreen : GameMenu
{
	[CompilerGenerated]
	private struct <OnGoAsync>d__17 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public CoopQuickMatchScreen <>4__this; //Field offset: 0x20
		private CancellationTokenSource <canceller>5__2; //Field offset: 0x28
		private TaskAwaiter<Boolean> <>u__1; //Field offset: 0x30
		private TaskAwaiter<LobbyConnection> <>u__2; //Field offset: 0x38

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	public GameObject btnCustomStandard; //Field offset: 0x48
	public GameObject btnMediumGame; //Field offset: 0x50
	public GameObject btnLongGame; //Field offset: 0x58
	public NK_TextMeshProUGUI trackTxt; //Field offset: 0x60
	public NK_TextMeshProUGUI dificultyTxt; //Field offset: 0x68
	public NK_TextMeshProUGUI modeTxt; //Field offset: 0x70
	public Animator lookingForGame; //Field offset: 0x78
	public GameObject objGo; //Field offset: 0x80
	[CompilerGenerated]
	private Action CancelEvent; //Field offset: 0x88
	private BucketName QuickMatchSelection; //Field offset: 0x90

	private event Action CancelEvent
	{
		[CompilerGenerated]
		private add { } //Length: 162
		[CompilerGenerated]
		private remove { } //Length: 162
	}

	public CoopQuickMatchScreen() { }

	[CompilerGenerated]
	private void add_CancelEvent(Action value) { }

	public virtual void Close() { }

	private String[] convertArrayToLocs(string appendTxtToKey, String[] array) { }

	private string FormatPlayerText(Int32[] values) { }

	public void OnGo() { }

	[AsyncStateMachine(typeof(<OnGoAsync>d__17))]
	public Task OnGoAsync() { }

	public void OnSwitchButtonClicked(int value) { }

	public virtual void Open(object data) { }

	public virtual bool OverrideClose() { }

	[CompilerGenerated]
	private void remove_CancelEvent(Action value) { }

	private void SetUiSearchingState(bool searching) { }

}

