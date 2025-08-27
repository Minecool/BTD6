namespace Assets.Scripts.Unity.UI_New;

public class LeaderboardPlayerPanel : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func<BadgeInfo, Int32> <>9__77_0; //Field offset: 0x8

		private static <>c() { }

		public <>c() { }

		internal int <ShowPlayersMedals>b__77_0(BadgeInfo o) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass71_0
	{
		public LeaderboardPlayerPanel <>4__this; //Field offset: 0x10
		public string userOrGuildId; //Field offset: 0x18

		public <>c__DisplayClass71_0() { }

		internal void <Initialise>b__0() { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass78_0
	{
		public LeaderboardPlayerPanel <>4__this; //Field offset: 0x10
		public string userOrGuildId; //Field offset: 0x18
		public CancellationToken token; //Field offset: 0x20

		public <>c__DisplayClass78_0() { }

		internal Task <OnClickPlayerStats>b__0() { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass80_0
	{
		public string guildId; //Field offset: 0x10

		public <>c__DisplayClass80_0() { }

		internal bool <LoadPlayerAvatarAndBanner>b__0(GuildInfo x) { }

	}

	[CompilerGenerated]
	private struct <GetGuildMetadata>d__85 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder<GuildMetadata> <>t__builder; //Field offset: 0x8
		public string guildId; //Field offset: 0x20
		private TaskAwaiter<GuildMetadata> <>u__1; //Field offset: 0x28

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <GetPlayerStats>d__84 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder<Btd6PlayerStats> <>t__builder; //Field offset: 0x8
		public string playerId; //Field offset: 0x20
		private TaskAwaiter<Btd6PlayerStats> <>u__1; //Field offset: 0x28

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <LoadPlayerAvatarAndBanner>d__80 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public LeaderboardPlayerPanel <>4__this; //Field offset: 0x20
		public string userOrGuildId; //Field offset: 0x28
		public CancellationToken cancellationToken; //Field offset: 0x30
		private Image <bannerImg>5__2; //Field offset: 0x38
		private Task<GuildMetadata> <guildMetaTask>5__3; //Field offset: 0x40
		private TaskAwaiter <>u__1; //Field offset: 0x48
		private Task<Btd6PlayerStats> <playerStatsTask>5__4; //Field offset: 0x50

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <OnClickPlayerStatsAsync>d__79 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public LeaderboardPlayerPanel <>4__this; //Field offset: 0x20
		public string userOrGuildId; //Field offset: 0x28
		public CancellationToken token; //Field offset: 0x30
		private TaskAwaiter<GuildModel> <>u__1; //Field offset: 0x38
		private TaskAwaiter<Btd6PlayerStats> <>u__2; //Field offset: 0x40

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <SetDisplayName>d__75 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public LeaderboardPlayerPanel <>4__this; //Field offset: 0x20
		public string userOrGuildId; //Field offset: 0x28
		public CancellationToken cancellationToken; //Field offset: 0x30
		private TaskAwaiter<GuildModel> <>u__1; //Field offset: 0x38
		private TaskAwaiter<String> <>u__2; //Field offset: 0x40

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	private struct BadgeInfo
	{
		[CompilerGenerated]
		private readonly LeaderboardBadgeType <Type>k__BackingField; //Field offset: 0x0
		[CompilerGenerated]
		private readonly int <Count>k__BackingField; //Field offset: 0x4

		public int Count
		{
			[CompilerGenerated]
			[IsReadOnly]
			 get { } //Length: 4
		}

		public int SortOrder
		{
			 get { } //Length: 9
		}

		public LeaderboardBadgeType Type
		{
			[CompilerGenerated]
			[IsReadOnly]
			 get { } //Length: 3
		}

		public BadgeInfo(LeaderboardBadgeType type, int count) { }

		[CompilerGenerated]
		[IsReadOnly]
		public int get_Count() { }

		public int get_SortOrder() { }

		[CompilerGenerated]
		[IsReadOnly]
		public LeaderboardBadgeType get_Type() { }

		public int GetSpriteIndex(bool isCtEvent, bool isTeam, bool isGlobal) { }

	}

	private const int defaultDelayInMs = 8; //Field offset: 0x0
	[Header("Player Info")]
	[SerializeField]
	private NK_TextMeshProUGUI rankTxt; //Field offset: 0x20
	[SerializeField]
	private NK_TextMeshProUGUI nameTxt; //Field offset: 0x28
	[SerializeField]
	private NK_TextMeshProUGUI medalRankTxt; //Field offset: 0x30
	[SerializeField]
	private Image avatarImg; //Field offset: 0x38
	[SerializeField]
	private Image avatarBannerImg; //Field offset: 0x40
	[SerializeField]
	private Image avatarBannerImgShort; //Field offset: 0x48
	[SerializeField]
	private Image guildAvatarFrame; //Field offset: 0x50
	[SerializeField]
	private Image guildAvatarIcon; //Field offset: 0x58
	[SerializeField]
	private Image guildBannerImg; //Field offset: 0x60
	[SerializeField]
	private GameObject frame; //Field offset: 0x68
	[SerializeField]
	private GameObject frameGold; //Field offset: 0x70
	[SerializeField]
	private GameObject frameShort; //Field offset: 0x78
	[SerializeField]
	private GameObject frameGoldShort; //Field offset: 0x80
	[Header("Score")]
	[SerializeField]
	private GameObject bossScoreContainer; //Field offset: 0x88
	[SerializeField]
	private NK_TextMeshProUGUI boss_bossTiersScoreTxt; //Field offset: 0x90
	[SerializeField]
	private NK_TextMeshProUGUI boss_tiersScoreTxt; //Field offset: 0x98
	[SerializeField]
	private NK_TextMeshProUGUI boss_cashScoreTxt; //Field offset: 0xA0
	[SerializeField]
	private NK_TextMeshProUGUI boss_timeScoreTxt; //Field offset: 0xA8
	[SerializeField]
	private NK_TextMeshProUGUI boss_timeTieBreakerTxt; //Field offset: 0xB0
	[SerializeField]
	private GameObject ctScoreContainer; //Field offset: 0xB8
	[SerializeField]
	private NK_TextMeshProUGUI ct_scoreTxt; //Field offset: 0xC0
	[SerializeField]
	private GameObject genericScoreContainer; //Field offset: 0xC8
	[SerializeField]
	private NK_TextMeshProUGUI generic_timeScoreTxt; //Field offset: 0xD0
	[Header("Badges")]
	[SerializeField]
	private GameObject badgesContainer; //Field offset: 0xD8
	[SerializeField]
	private GameObject badgesEvent1; //Field offset: 0xE0
	[SerializeField]
	private GameObject badgesEvent2; //Field offset: 0xE8
	[SerializeField]
	private GameObject badgesEvent3; //Field offset: 0xF0
	[SerializeField]
	private GameObject medalReward; //Field offset: 0xF8
	[Header("Panels")]
	[SerializeField]
	private GameObject playerPanel; //Field offset: 0x100
	[SerializeField]
	private GameObject loadingPlayerPanel; //Field offset: 0x108
	[SerializeField]
	private GameObject goldPlayerBackground; //Field offset: 0x110
	[SerializeField]
	private GameObject goldPlayerBackgroundShort; //Field offset: 0x118
	[SerializeField]
	private GameObject backgroundPanel; //Field offset: 0x120
	[SerializeField]
	private GameObject ctPanel; //Field offset: 0x128
	[SerializeField]
	private Image ctPanelImage; //Field offset: 0x130
	[SerializeField]
	private GameObject backgroundPanelShort; //Field offset: 0x138
	[SerializeField]
	private GameObject customBanner; //Field offset: 0x140
	[SerializeField]
	private GameObject customBannerShort; //Field offset: 0x148
	[Header("Replays")]
	[SerializeField]
	public Button validateButton; //Field offset: 0x150
	[SerializeField]
	private GameObject validIndicator; //Field offset: 0x158
	[SerializeField]
	private GameObject invalidIndicator; //Field offset: 0x160
	[SerializeField]
	public Button replayButton; //Field offset: 0x168
	[SerializeField]
	public Button statsButton; //Field offset: 0x170
	[SerializeField]
	private GameObject statsLoadingSpinner; //Field offset: 0x178
	public Action ButtonClicked; //Field offset: 0x180
	public Action ButtonComplete; //Field offset: 0x188
	private LeaderboardScreenData menuData; //Field offset: 0x190
	private CancellationTokenSource loadCanceller; //Field offset: 0x198
	private bool requiresReset; //Field offset: 0x1A0
	private bool isLongPanel; //Field offset: 0x1A1
	private bool isMyPanel; //Field offset: 0x1A2
	private bool isGuildPanel; //Field offset: 0x1A3
	private int selectedIndex; //Field offset: 0x1A4
	private LeaderboardType leaderboardType; //Field offset: 0x1A8

	private GameObject ActiveBackground
	{
		private get { } //Length: 56
	}

	private GameObject ActiveCustomBanner
	{
		private get { } //Length: 25
	}

	private GameObject ActiveFrame
	{
		private get { } //Length: 47
	}

	private GameObject BossCashScoreObj
	{
		private get { } //Length: 77
	}

	private GameObject BossTiersScoreObj
	{
		private get { } //Length: 77
	}

	private GameObject BossTimeScoreObj
	{
		private get { } //Length: 77
	}

	public Task DefaultWaitTime
	{
		 get { } //Length: 67
	}

	private bool IsCtEvent
	{
		private get { } //Length: 13
	}

	public LeaderboardPlayerPanel() { }

	private void DisplayScores(long score) { }

	private GameObject get_ActiveBackground() { }

	private GameObject get_ActiveCustomBanner() { }

	private GameObject get_ActiveFrame() { }

	private GameObject get_BossCashScoreObj() { }

	private GameObject get_BossTiersScoreObj() { }

	private GameObject get_BossTimeScoreObj() { }

	public Task get_DefaultWaitTime() { }

	private bool get_IsCtEvent() { }

	[AsyncStateMachine(typeof(<GetGuildMetadata>d__85))]
	private Task<GuildMetadata> GetGuildMetadata(string guildId) { }

	[AsyncStateMachine(typeof(<GetPlayerStats>d__84))]
	private Task<Btd6PlayerStats> GetPlayerStats(string playerId) { }

	public void Initialise(string userOrGuildId, string metadataString, long rawScore, int placing, SpriteReference[] medalSprites, bool canShowMedals, bool isLongPanel, LeaderboardScreenData menuData, int selectedIndex, bool isGuildPanel, LeaderboardType leaderboardType) { }

	[AsyncStateMachine(typeof(<LoadPlayerAvatarAndBanner>d__80))]
	public Task LoadPlayerAvatarAndBanner(string userOrGuildId, CancellationToken cancellationToken) { }

	public void OnClickPlayerStats(string userOrGuildId, CancellationToken token) { }

	[AsyncStateMachine(typeof(<OnClickPlayerStatsAsync>d__79))]
	public Task OnClickPlayerStatsAsync(string userOrGuildId, CancellationToken token) { }

	public void OnDestroy() { }

	public void ResetPanel() { }

	private void SetAvatarBanner(ProfileBanners banners, string bannerId, Image bannerImg) { }

	private void SetAvatarSprite(ProfileAvatars avatars, string avatarId, Image image) { }

	[AsyncStateMachine(typeof(<SetDisplayName>d__75))]
	private Task SetDisplayName(string userOrGuildId, CancellationToken cancellationToken) { }

	private void ShowPlayersMedals(string medalData, SpriteReference[] medalSprites) { }

	private static bool TryGetLocalCtPlayerGuildId(Dictionary<String, String[]> localCtGuildPlayers, string playerId, out string playerGuildId) { }

	private bool TryGetMedalData(MetadataBuilder metadata, int selectedIndex, out string medalData) { }

}

