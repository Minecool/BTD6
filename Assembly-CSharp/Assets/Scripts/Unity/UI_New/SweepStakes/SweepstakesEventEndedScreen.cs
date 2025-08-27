namespace Assets.Scripts.Unity.UI_New.SweepStakes;

public class SweepstakesEventEndedScreen : GameMenu
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func<Task, Boolean> <>9__18_0; //Field offset: 0x8

		private static <>c() { }

		public <>c() { }

		internal bool <LoadEventEndedUI>b__18_0(Task x) { }

	}

	[CompilerGenerated]
	private struct <GetWinnersAndLoadUi>d__16 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public SweepstakesEventEndedScreen <>4__this; //Field offset: 0x20
		public SweepstakesEvent sweepstakesEvent; //Field offset: 0x28
		private TaskAwaiter<SweepstakesWinnersResponse> <>u__1; //Field offset: 0x30

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <LoadEventEndedUI>d__18 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public SweepstakesEventEndedScreen <>4__this; //Field offset: 0x20
		public String[] winnerIds; //Field offset: 0x28
		private bool <playerIsAWinner>5__2; //Field offset: 0x30
		private Task<Dictionary`2<String, String>> <playerNamesTask>5__3; //Field offset: 0x38
		private List<Task> <bindingTasks>5__4; //Field offset: 0x40
		private int <maxActiveBindingTasks>5__5; //Field offset: 0x48
		private int <i>5__6; //Field offset: 0x4C
		private SweepstakesWinnerDisplay <playerDisplay>5__7; //Field offset: 0x50
		private YieldAwaiter <>u__1; //Field offset: 0x58

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <LoadRemotePrizeImage>d__15 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public SweepstakesEventEndedScreen <>4__this; //Field offset: 0x20
		public string imageString; //Field offset: 0x28
		private TaskAwaiter<Texture2D> <>u__1; //Field offset: 0x30

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <ShowPlayerStats>d__19 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public SweepstakesEventEndedScreen <>4__this; //Field offset: 0x20
		public string playerId; //Field offset: 0x28
		private TaskAwaiter<Btd6PlayerStats> <>u__1; //Field offset: 0x30

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[Header("Event Ending Values")]
	[SerializeField]
	private GameObject eventEndingObj; //Field offset: 0x48
	[SerializeField]
	private Image rewardEndingIcon; //Field offset: 0x50
	[Header("Event Ended Values")]
	[SerializeField]
	private GameObject eventEndedObj; //Field offset: 0x58
	[SerializeField]
	private GameObject winnersContainer; //Field offset: 0x60
	[SerializeField]
	private GameObject sweepStakesWinnerTemplate; //Field offset: 0x68
	[SerializeField]
	private NK_TextMeshProUGUI eventEndedText; //Field offset: 0x70
	[SerializeField]
	private Image rewardEndedIcon; //Field offset: 0x78
	[SerializeField]
	private NK_TextMeshProUGUI winnerText; //Field offset: 0x80
	[Header("Other")]
	[SerializeField]
	private GameObject loadingThrobber; //Field offset: 0x88
	[SerializeField]
	private int lowEndDeviceWinnerDisplayCap; //Field offset: 0x90
	private readonly List<SweepstakesWinnerDisplay> playerDisplays; //Field offset: 0x98

	public SweepstakesEventEndedScreen() { }

	protected virtual void Awake() { }

	[AsyncStateMachine(typeof(<GetWinnersAndLoadUi>d__16))]
	private Task GetWinnersAndLoadUi(SweepstakesEvent sweepstakesEvent) { }

	[AsyncStateMachine(typeof(<LoadEventEndedUI>d__18))]
	private Task LoadEventEndedUI(String[] winnerIds) { }

	private void LoadEventEndingUI() { }

	[AsyncStateMachine(typeof(<LoadRemotePrizeImage>d__15))]
	private Task LoadRemotePrizeImage(string imageString) { }

	public virtual void Open(object data) { }

	public virtual void ReClose() { }

	public virtual void ReOpen(object _) { }

	[AsyncStateMachine(typeof(<ShowPlayerStats>d__19))]
	public Task ShowPlayerStats(string playerId) { }

}

