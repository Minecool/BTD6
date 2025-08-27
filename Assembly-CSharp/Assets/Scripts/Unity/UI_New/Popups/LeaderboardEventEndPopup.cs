namespace Assets.Scripts.Unity.UI_New.Popups;

public class LeaderboardEventEndPopup : Popup
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func<Task, Boolean> <>9__19_0; //Field offset: 0x8
		public static Predicate<BaseLoot> <>9__21_0; //Field offset: 0x10
		public static Predicate<BaseLoot> <>9__21_1; //Field offset: 0x18
		public static Func<BaseLoot, Boolean> <>9__24_0; //Field offset: 0x20
		public static Func<BaseLoot, Boolean> <>9__26_0; //Field offset: 0x28
		public static Func<BaseLoot, Boolean> <>9__26_1; //Field offset: 0x30
		public static Func<BaseLoot, Boolean> <>9__26_2; //Field offset: 0x38
		public static Func<BaseLoot, Boolean> <>9__26_3; //Field offset: 0x40
		public static Func<BaseLoot, Boolean> <>9__26_4; //Field offset: 0x48
		public static Func<BaseLoot, Boolean> <>9__26_5; //Field offset: 0x50

		private static <>c() { }

		public <>c() { }

		internal bool <ClaimRewards>b__26_0(BaseLoot x) { }

		internal bool <ClaimRewards>b__26_1(BaseLoot x) { }

		internal bool <ClaimRewards>b__26_2(BaseLoot x) { }

		internal bool <ClaimRewards>b__26_3(BaseLoot x) { }

		internal bool <ClaimRewards>b__26_4(BaseLoot x) { }

		internal bool <ClaimRewards>b__26_5(BaseLoot x) { }

		internal bool <DoRewardAnalytics>b__24_0(BaseLoot x) { }

		internal bool <GetLeaderboards>b__19_0(Task x) { }

		internal bool <LoadUiAndApplyRewards>b__21_0(BaseLoot x) { }

		internal bool <LoadUiAndApplyRewards>b__21_1(BaseLoot x) { }

	}

	[CompilerGenerated]
	private struct <CheckEndTime>d__16 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public DateTime endTime; //Field offset: 0x20
		private TaskAwaiter<DateTime> <>u__1; //Field offset: 0x28

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <GetLeaderboards>d__19 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder<List`1<LeaderboardData>> <>t__builder; //Field offset: 0x8
		public LeaderboardType leaderboardType; //Field offset: 0x20
		public LeaderboardEventEndPopup <>4__this; //Field offset: 0x28
		public Nullable<Int32> instanceId; //Field offset: 0x30
		public string guildIdOverride; //Field offset: 0x38
		public Nullable<LeaderboardType> eliteLeaderboardTypeOverride; //Field offset: 0x40
		private int <requiredLeaderboardCount>5__2; //Field offset: 0x48
		private List<Task> <loadingTasks>5__3; //Field offset: 0x50
		private List<LeaderboardData> <leaderboards>5__4; //Field offset: 0x58
		private int <i>5__5; //Field offset: 0x60
		private YieldAwaiter <>u__1; //Field offset: 0x64
		private TaskAwaiter <>u__2; //Field offset: 0x68

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	private const uint kMaxSimultaneousDownloads = 2; //Field offset: 0x0
	public NK_TextMeshProUGUI bestTimeTxt; //Field offset: 0x128
	public NK_TextMeshProUGUI bestScoreTxt; //Field offset: 0x130
	public LeaderboardEventEndPopupPanel globalResultPanel; //Field offset: 0x138
	public LeaderboardEventEndPopupPanel miniResultPanel; //Field offset: 0x140
	public Image loadingImg; //Field offset: 0x148
	public Button claimBtn; //Field offset: 0x150
	public NK_TextMeshProUGUI claimBtnTxt; //Field offset: 0x158
	protected bool preventClose; //Field offset: 0x160
	protected BaseServerEvent serverEvent; //Field offset: 0x168
	protected LeaderboardType leaderboardType; //Field offset: 0x170
	private LootSet mergedRewards; //Field offset: 0x178

	protected Btd6Player Player
	{
		 get { } //Length: 7
	}

	public LeaderboardEventEndPopup() { }

	[AsyncStateMachine(typeof(<CheckEndTime>d__16))]
	protected Task CheckEndTime(DateTime endTime) { }

	protected void ClaimClicked() { }

	protected void ClaimRewards(LeaderboardType leaderboardType) { }

	protected void DisplayScore(PlayerLeaderboardPlacing placing, NK_TextMeshProUGUI bestTimeBannerTxt, NK_TextMeshProUGUI bestScoreBannerTxt) { }

	private void DoRewardAnalytics(LootSet lootSet, bool isMini, bool isElite, bool isLocal) { }

	protected void Failed() { }

	protected LeaderboardData GenerateLeaderboard(LeaderboardType leaderboardType, int index, string eventId, Nullable<Int32> instanceId, string guildIdOverride = null, Nullable<LeaderboardType> eliteLeaderboardTypeOverride = null) { }

	protected Btd6Player get_Player() { }

	[AsyncStateMachine(typeof(<GetLeaderboards>d__19))]
	protected Task<List`1<LeaderboardData>> GetLeaderboards(LeaderboardType leaderboardType, Nullable<Int32> instanceId, string guildIdOverride = null, Nullable<LeaderboardType> eliteLeaderboardTypeOverride = null) { }

	protected static LeaderboardReward[] GetRewards(Dictionary<String, LeaderboardReward[]> allRewards, string rewardsKey) { }

	public override void LoadResults(BaseServerEvent serverEvent, bool isDebug) { }

	protected bool LoadUiAndApplyRewards(PlayerLeaderboardPlacing placing, LeaderboardEventEndPopupPanel globalResultPanel, LeaderboardEventEndPopupPanel miniResultPanel, LeaderboardReward[] rewards, LeaderboardReward[] rewardsMini, bool isElite = false, bool isLocalCT = false, bool canEarnLeaderboardBadges = true) { }

	private void MergeRewards(LootSet lootSet) { }

	protected void SetClaimButton(bool canClaim) { }

	public void Start() { }

}

