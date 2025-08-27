namespace Assets.Scripts.Unity.UI_New.Popups;

public class BossEndedPopup : LeaderboardEventEndPopup
{
	[CompilerGenerated]
	private struct <LoadResults>d__7 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncVoidMethodBuilder <>t__builder; //Field offset: 0x8
		public BossEndedPopup <>4__this; //Field offset: 0x28
		public BaseServerEvent serverEvent; //Field offset: 0x30
		private BossEvent <bossEvent>5__2; //Field offset: 0x38
		private LeaderboardReward[] <rewards>5__3; //Field offset: 0x40
		private LeaderboardReward[] <rewardsMini>5__4; //Field offset: 0x48
		private LeaderboardReward[] <rewardsElite>5__5; //Field offset: 0x50
		private LeaderboardReward[] <rewardsEliteMini>5__6; //Field offset: 0x58
		private bool <canClaimRewards>5__7; //Field offset: 0x60
		private TaskAwaiter <>u__1; //Field offset: 0x68
		private TaskAwaiter<BossDataModel> <>u__2; //Field offset: 0x70
		private TaskAwaiter<List`1<LeaderboardData>> <>u__3; //Field offset: 0x78

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[SerializeField]
	private LeaderboardEventEndPopupPanel eliteResultPanel; //Field offset: 0x180
	[SerializeField]
	private LeaderboardEventEndPopupPanel eliteMiniResultPanel; //Field offset: 0x188
	[SerializeField]
	private GameObject noEliteScoreObj; //Field offset: 0x190
	[SerializeField]
	private BossLeaderboardScorePanel scorePanel; //Field offset: 0x198
	[SerializeField]
	private BossLeaderboardScorePanel eliteScorePanel; //Field offset: 0x1A0
	private LeaderboardType eliteLeaderboardType; //Field offset: 0x1A8

	public BossEndedPopup() { }

	private void DisplayBossScore(PlayerLeaderboardPlacing placing, BossLeaderboardScorePanel scorePanel, LeaderboardType leaderboardType) { }

	[AsyncStateMachine(typeof(<LoadResults>d__7))]
	public virtual void LoadResults(BaseServerEvent serverEvent, bool isDebug) { }

	public void Start() { }

}

