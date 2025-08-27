namespace Assets.Scripts.Unity.UI_New.Popups;

public class CTEndedPopup : LeaderboardEventEndPopup
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func<ScoreModel, String> <>9__11_0; //Field offset: 0x8

		private static <>c() { }

		public <>c() { }

		internal string <LoadResults>b__11_0(ScoreModel x) { }

	}

	[CompilerGenerated]
	private struct <GetInstanceInfo>d__12 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		[TupleElementNames(new IL2CPP_TYPE_STRING[] {"guildId", "instanceId"}])]
		public AsyncTaskMethodBuilder<ValueTuple`2<String, Nullable`1<Int32>>> <>t__builder; //Field offset: 0x8
		public bool isDebug; //Field offset: 0x20
		public CTEndedPopup <>4__this; //Field offset: 0x28
		private string <guildId>5__2; //Field offset: 0x30
		private TaskAwaiter<SearchInstanceResponse> <>u__1; //Field offset: 0x38

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <LoadResults>d__11 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncVoidMethodBuilder <>t__builder; //Field offset: 0x8
		public CTEndedPopup <>4__this; //Field offset: 0x28
		public BaseServerEvent serverEvent; //Field offset: 0x30
		public bool isDebug; //Field offset: 0x38
		private CtEvent <ctEvent>5__2; //Field offset: 0x40
		private string <guildId>5__3; //Field offset: 0x48
		private Nullable<Int32> <instanceId>5__4; //Field offset: 0x50
		private LeaderboardReward[] <globalTeamRewards>5__5; //Field offset: 0x58
		private LeaderboardReward[] <globalPlayerRewards>5__6; //Field offset: 0x60
		private LeaderboardReward[] <localTeamRewards>5__7; //Field offset: 0x68
		private LeaderboardReward[] <localPlayerRewards>5__8; //Field offset: 0x70
		private CtLeaderboards <ctLeaderboards>5__9; //Field offset: 0x78
		private PlayerLeaderboardPlacing <globalPlacings>5__10; //Field offset: 0xB8
		private bool <canClaimRewards>5__11; //Field offset: 0xC0
		private TaskAwaiter<OnlineProfileModel> <>u__1; //Field offset: 0xC8
		private TaskAwaiter <>u__2; //Field offset: 0xD0
		[TupleElementNames(new IL2CPP_TYPE_STRING[] {"guildId", "instanceId"}])]
		private TaskAwaiter<ValueTuple`2<String, Nullable`1<Int32>>> <>u__3; //Field offset: 0xD8
		private TaskAwaiter<Btd6CtSettings> <>u__4; //Field offset: 0xE0
		private TaskAwaiter<CtLeaderboards> <>u__5; //Field offset: 0xE8
		private TaskAwaiter<List`1<LeaderboardData>> <>u__6; //Field offset: 0xF0
		private TaskAwaiter<IEnumerable`1<GuildModel>> <>u__7; //Field offset: 0xF8

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	public LeaderboardEventEndPopupPanel localResultPanel; //Field offset: 0x180
	public LeaderboardEventEndPopupPanel localMiniResultPanel; //Field offset: 0x188
	public Button nextBtn; //Field offset: 0x190
	public CTEventEndScorePanel mapScorePanelPrefab; //Field offset: 0x198
	public Transform scorePanelParent; //Field offset: 0x1A0
	public NK_TextMeshProUGUI tilesCapturedTxt; //Field offset: 0x1A8
	public NK_TextMeshProUGUI ctPointsTxt; //Field offset: 0x1B0
	public NK_TextMeshProUGUI teamTrophiesEarntTxt; //Field offset: 0x1B8
	public NK_TextMeshProUGUI relicsUnlockedTxt; //Field offset: 0x1C0
	public GameObject requiresCompetitiveObj; //Field offset: 0x1C8

	public CTEndedPopup() { }

	[AsyncStateMachine(typeof(<GetInstanceInfo>d__12))]
	private Task<ValueTuple`2<String, Nullable`1<Int32>>> GetInstanceInfo(bool isDebug) { }

	private void LoadPage1(CtEvent ctEvent, long playerScore, CtLeaderboards ctLeaderboards, string playersGuildId) { }

	[AsyncStateMachine(typeof(<LoadResults>d__11))]
	public virtual void LoadResults(BaseServerEvent serverEvent, bool isDebug) { }

	private void NextClicked() { }

	public void Start() { }

}

