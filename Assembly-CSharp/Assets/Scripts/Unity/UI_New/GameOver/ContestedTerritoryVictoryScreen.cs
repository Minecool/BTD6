namespace Assets.Scripts.Unity.UI_New.GameOver;

public class ContestedTerritoryVictoryScreen : SummaryScreen
{
	[CompilerGenerated]
	private struct <Open>d__25 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncVoidMethodBuilder <>t__builder; //Field offset: 0x8
		public ContestedTerritoryVictoryScreen <>4__this; //Field offset: 0x28
		public object menuData; //Field offset: 0x30
		private CtEvent <ctEvent>5__2; //Field offset: 0x38
		private int <playerScore>5__3; //Field offset: 0x40
		private ContestedTerritoryIslandTile <tile>5__4; //Field offset: 0x48
		private SetScoreResponse <setScoreResponse>5__5; //Field offset: 0x50
		[TupleElementNames(new IL2CPP_TYPE_STRING[] {"playerMetadata", "guildMetadata"}])]
		private TaskAwaiter<ValueTuple`2<String, String>> <>u__1; //Field offset: 0x58
		private TaskAwaiter<SetScoreResponse> <>u__2; //Field offset: 0x60
		private TaskAwaiter<LootSet> <>u__3; //Field offset: 0x68

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <PlayAgainClicked>d__29 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncVoidMethodBuilder <>t__builder; //Field offset: 0x8
		public ContestedTerritoryVictoryScreen <>4__this; //Field offset: 0x28
		private TaskAwaiter<StartTileGameResponse> <>u__1; //Field offset: 0x30

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <SubmitScore>d__28 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder<SetScoreResponse> <>t__builder; //Field offset: 0x8
		public CtEvent ctEvent; //Field offset: 0x20
		public ContestedTerritoryVictoryScreen <>4__this; //Field offset: 0x28
		public ContestedTerritoryIslandTile tile; //Field offset: 0x30
		public int score; //Field offset: 0x38
		public string playerMetadata; //Field offset: 0x40
		public string guildMetadata; //Field offset: 0x48
		private SetScoreResponse <setScoreResponse>5__2; //Field offset: 0x50
		private int <>7__wrap2; //Field offset: 0x58
		private TaskAwaiter<Boolean> <>u__1; //Field offset: 0x60
		private int <gameId>5__4; //Field offset: 0x68
		private TaskAwaiter <>u__2; //Field offset: 0x70
		private TaskAwaiter<SetScoreResponse> <>u__3; //Field offset: 0x78

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <TrySubmitReplay>d__27 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public int tileId; //Field offset: 0x20
		public Replay replay; //Field offset: 0x28
		public BaseServerEvent _event; //Field offset: 0x30
		public bool rethrow; //Field offset: 0x38
		private TaskAwaiter <>u__1; //Field offset: 0x40

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	public TMP_Text tileCapturedOrNotLbl; //Field offset: 0x110
	public TMP_Text ticketUsedOrNotLbl; //Field offset: 0x118
	public GameObject ticketUsedObj; //Field offset: 0x120
	public GameObject capturedObj; //Field offset: 0x128
	public GameObject notCapturedObj; //Field offset: 0x130
	public GameObject capturedRelicObj; //Field offset: 0x138
	public GameObject capturedBannerObj; //Field offset: 0x140
	public TMP_Text yourScoreTxt; //Field offset: 0x148
	public Color yourScoreCapturedColor; //Field offset: 0x150
	public Color yourScoreNotCapturedColor; //Field offset: 0x160
	public TMP_Text theirScoreTxt; //Field offset: 0x170
	public GameObject ticketIconObj; //Field offset: 0x178
	public GameObject teamTicketIconObj; //Field offset: 0x180
	public LootPanel lootPanel; //Field offset: 0x188
	public GameObject loadWheelObj; //Field offset: 0x190
	public Button playAgainBtn; //Field offset: 0x198
	public AudioClip victorySound; //Field offset: 0x1A0
	public Button nextBtn; //Field offset: 0x1A8
	public SinglePlayerStatsPanel singlePlayerStatsPanel; //Field offset: 0x1B0
	private readonly List<CalloutUiData> coopCalloutUiData; //Field offset: 0x1B8
	private CalloutManager calloutManager; //Field offset: 0x1C0
	private int tileId; //Field offset: 0x1C8

	protected virtual bool IsVictoryScreen
	{
		 get { } //Length: 3
	}

	public ContestedTerritoryVictoryScreen() { }

	[CompilerGenerated]
	[DebuggerHidden]
	private void <>n__0(object menuData) { }

	protected virtual void Awake() { }

	protected virtual void ButtonsInteractive(bool canInteract) { }

	protected virtual bool get_IsVictoryScreen() { }

	private int GetPlayerScore() { }

	public void InitialisePlayerStatsPanel() { }

	[AsyncStateMachine(typeof(<Open>d__25))]
	public virtual void Open(object menuData) { }

	[AsyncStateMachine(typeof(<PlayAgainClicked>d__29))]
	private void PlayAgainClicked() { }

	[AsyncStateMachine(typeof(<SubmitScore>d__28))]
	private Task<SetScoreResponse> SubmitScore(CtEvent ctEvent, ContestedTerritoryIslandTile tile, int score, string playerMetadata, string guildMetadata) { }

	[AsyncStateMachine(typeof(<TrySubmitReplay>d__27))]
	private static Task TrySubmitReplay(Replay replay, BaseServerEvent _event, int tileId, bool rethrow) { }

}

