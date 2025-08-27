namespace Assets.Scripts.Unity.UI_New.Popups.Epic;

public class EpicAccountPopup : Popup
{
	[CompilerGenerated]
	private struct <CancelClicked>d__11 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncVoidMethodBuilder <>t__builder; //Field offset: 0x8
		public EpicAccountPopup <>4__this; //Field offset: 0x28
		private YieldAwaiter <>u__1; //Field offset: 0x30

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	private MonoBehaviour activePopup; //Field offset: 0x128
	public MainAccountPopup mainAccountPopup; //Field offset: 0x130
	public AgeConfirmPopup ageConfirmPopup; //Field offset: 0x138
	public LoggedInPopup loggedInPopup; //Field offset: 0x140
	public AgreePopup agreePopup; //Field offset: 0x148
	public LinkingCodePopup linkingCodePopup; //Field offset: 0x150
	public ConfirmNamePopup editNamePopup; //Field offset: 0x158
	public Button closeButton; //Field offset: 0x160
	[HideInInspector]
	public bool processing; //Field offset: 0x168
	public Action createdAccountCallback; //Field offset: 0x170
	public int childAccountAge; //Field offset: 0x178

	public EpicAccountPopup() { }

	[CompilerGenerated]
	[DebuggerHidden]
	private void <>n__0() { }

	[CompilerGenerated]
	private void <Awake>b__13_0() { }

	private void Awake() { }

	[AsyncStateMachine(typeof(<CancelClicked>d__11))]
	public virtual void CancelClicked() { }

	public void SetActiveContent(MonoBehaviour popup) { }

}

