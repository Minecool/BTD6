namespace Assets.Scripts.Unity.UI_New.BossBloons;

public class BossRushEventEndPopup : Popup
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func<BaseLoot, Boolean> <>9__10_0; //Field offset: 0x8
		public static Func<BaseLoot, Boolean> <>9__10_1; //Field offset: 0x10

		private static <>c() { }

		public <>c() { }

		internal bool <LoadRewards>b__10_0(BaseLoot x) { }

		internal bool <LoadRewards>b__10_1(BaseLoot x) { }

	}

	[CompilerGenerated]
	private struct <ClaimTeamTrophies>d__11 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public string eventId; //Field offset: 0x20
		public BossRushEventEndPopup <>4__this; //Field offset: 0x28
		private int <>7__wrap1; //Field offset: 0x30
		private TaskAwaiter<BossRushTeamTrophyClaimResponse> <>u__1; //Field offset: 0x38
		private TaskAwaiter<Boolean> <>u__2; //Field offset: 0x40
		private TaskAwaiter <>u__3; //Field offset: 0x48

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <LoadRewards>d__10 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public bool isDebug; //Field offset: 0x20
		public BossRushEvent bossRushEvent; //Field offset: 0x28
		public BossRushSettings settings; //Field offset: 0x30
		public BossRushEventEndPopup <>4__this; //Field offset: 0x38
		public int defeatedBossIndex; //Field offset: 0x40
		public BossRushSaveData bossRushSaveData; //Field offset: 0x48
		private bool <canSaveChanges>5__2; //Field offset: 0x50
		private TaskAwaiter <>u__1; //Field offset: 0x58

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <TryLoadRewardsAsync>d__9 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncVoidMethodBuilder <>t__builder; //Field offset: 0x8
		public BossRushEventEndPopup <>4__this; //Field offset: 0x28
		public BossRushEvent bossRushEvent; //Field offset: 0x30
		public BossRushSettings settings; //Field offset: 0x38
		public int defeatedBossIndex; //Field offset: 0x40
		public BossRushSaveData bossRushSaveData; //Field offset: 0x48
		public bool isDebug; //Field offset: 0x50
		private TaskAwaiter <>u__1; //Field offset: 0x58

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[SerializeField]
	private BossRushStagePanelDisplay[] stages; //Field offset: 0x128
	[SerializeField]
	private Button claimButton; //Field offset: 0x130
	[SerializeField]
	private Button okButton; //Field offset: 0x138
	[SerializeField]
	private LootPanel rewardsPanel; //Field offset: 0x140
	[SerializeField]
	private Image loadingSpinner; //Field offset: 0x148
	[SerializeField]
	private GameObject claimedObj; //Field offset: 0x150
	[SerializeField]
	private NK_TextMeshProUGUI subtitleTxt; //Field offset: 0x158
	private LootSet aggregatedLoot; //Field offset: 0x160

	public BossRushEventEndPopup() { }

	[CompilerGenerated]
	private void <Awake>b__8_0() { }

	private void Awake() { }

	private void ClaimClicked() { }

	[AsyncStateMachine(typeof(<ClaimTeamTrophies>d__11))]
	private Task ClaimTeamTrophies(string eventId) { }

	[AsyncStateMachine(typeof(<LoadRewards>d__10))]
	private Task LoadRewards(BossRushEvent bossRushEvent, BossRushSettings settings, int defeatedBossIndex, BossRushSaveData bossRushSaveData, bool isDebug) { }

	private static void MergeRewards(LootSet targetLootSet, LootSet additionalLootSet) { }

	[AsyncStateMachine(typeof(<TryLoadRewardsAsync>d__9))]
	public void TryLoadRewardsAsync(BossRushEvent bossRushEvent, BossRushSettings settings, int defeatedBossIndex, BossRushSaveData bossRushSaveData, bool isDebug) { }

}

