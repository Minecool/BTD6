namespace Assets.Scripts.ContestedTerritory.Api;

[Extension]
public static class ContestedTerritoryApi
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func<ContestedTerritoryRelicType, Boolean> <>9__15_0; //Field offset: 0x8
		public static Predicate<PlayerActivity> <>9__50_0; //Field offset: 0x10
		public static Func<PlayerActivity, Boolean> <>9__64_0; //Field offset: 0x18
		public static Func<GuildInfo, Boolean> <>9__77_0; //Field offset: 0x20
		public static Func<GuildInfo, String> <>9__77_1; //Field offset: 0x28

		private static <>c() { }

		public <>c() { }

		internal bool <AddNameOfTeamsAsync>b__77_0(GuildInfo x) { }

		internal string <AddNameOfTeamsAsync>b__77_1(GuildInfo x) { }

		internal bool <CompletePlayerActivity>b__50_0(PlayerActivity x) { }

		internal bool <HasActivePlayers>b__64_0(PlayerActivity x) { }

		internal bool <set_CapturedRelics>b__15_0(ContestedTerritoryRelicType selectedRelic) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass15_0
	{
		public IEnumerable<ContestedTerritoryRelicType> lostRelics; //Field offset: 0x10

		public <>c__DisplayClass15_0() { }

		internal bool <set_CapturedRelics>b__1(ContestedTerritoryRelicType selectedRelic) { }

	}

	[CompilerGenerated]
	private struct <AddNameOfTeamsAsync>d__77 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder<CtApiActionResult> <>t__builder; //Field offset: 0x8
		public GuildInfo[] guildInfos; //Field offset: 0x20
		private TaskAwaiter<IEnumerable`1<GuildModel>> <>u__1; //Field offset: 0x28

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <ClaimGuildTicketAsync>d__55 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder<CtApiFunctionResult`1<TicketResponse>> <>t__builder; //Field offset: 0x8
		private TaskAwaiter<TicketResponse> <>u__1; //Field offset: 0x20

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <CompletePlayerActivity>d__50 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder<CtApiActionResult> <>t__builder; //Field offset: 0x8
		public int tileId; //Field offset: 0x20
		public bool isTileCaptured; //Field offset: 0x24
		private TaskAwaiter<EmptyResponse> <>u__1; //Field offset: 0x28

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <GetCapturedRelics>d__61 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder<IReadOnlyCollection`1<ContestedTerritoryRelicType>> <>t__builder; //Field offset: 0x8
		private TaskAwaiter<RelicsResponse> <>u__1; //Field offset: 0x20

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <GetDailyRelic>d__73 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder<TeamStoreRelic> <>t__builder; //Field offset: 0x8
		private ContestedTerritoryRelicType <relicType>5__2; //Field offset: 0x20
		private DateTime <expiresAt>5__3; //Field offset: 0x28
		private string <contributionId>5__4; //Field offset: 0x30
		private TaskAwaiter<Dictionary`2<String, TeamStoreItemContributions>> <>u__1; //Field offset: 0x38

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <GetEventRelics>d__74 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder<TeamStoreRelic[]> <>t__builder; //Field offset: 0x8
		private TimeSpan[] <unlockTimes>5__2; //Field offset: 0x20
		private int <eventRelicCount>5__3; //Field offset: 0x28
		private List<TeamStoreRelic> <teamStoreRelics>5__4; //Field offset: 0x30
		private int <i>5__5; //Field offset: 0x38
		private DateTime <unlocksAt>5__6; //Field offset: 0x40
		private ContestedTerritoryRelicType <relicType>5__7; //Field offset: 0x48
		private string <contributionId>5__8; //Field offset: 0x50
		private TeamStoreItemContributions <dailyRelicContributions>5__9; //Field offset: 0x58
		private TaskAwaiter<Dictionary`2<String, TeamStoreItemContributions>> <>u__1; //Field offset: 0x60

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <GetHasTeamsStoreChanged>d__75 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder<Boolean> <>t__builder; //Field offset: 0x8
		private TaskAwaiter<Dictionary`2<String, TeamStoreItemContributions>> <>u__1; //Field offset: 0x20
		private TaskAwaiter<IReadOnlyCollection`1<ContestedTerritoryRelicType>> <>u__2; //Field offset: 0x28

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <GetItemContributions>d__67 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder<Dictionary`2<String, TeamStoreItemContributions>> <>t__builder; //Field offset: 0x8
		private string <guildId>5__2; //Field offset: 0x20
		private TaskAwaiter<TrophyStoreBankData> <>u__1; //Field offset: 0x28
		private TaskAwaiter<Dictionary`2<String, TeamStoreItemContributions>> <>u__2; //Field offset: 0x30

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <GetLeaderboardMetadata>d__53 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		[TupleElementNames(new IL2CPP_TYPE_STRING[] {"playerMetadata", "guildMetadata"}])]
		public AsyncTaskMethodBuilder<ValueTuple`2<String, String>> <>t__builder; //Field offset: 0x8
		private MetadataBuilder <guildMetadata>5__2; //Field offset: 0x20
		private Dictionary<String, Int32> <guildBadges>5__3; //Field offset: 0x28
		private TaskAwaiter<Dictionary`2<String, Int32>> <>u__1; //Field offset: 0x30

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <GetStatusForPlayerAsync>d__59 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder<CtApiFunctionResult`1<StatusResponse>> <>t__builder; //Field offset: 0x8
		public bool canRegister; //Field offset: 0x20
		private TaskAwaiter<StatusResponse> <>u__1; //Field offset: 0x28

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <GetTicketStatusForPlayerAsync>d__54 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder<CtApiFunctionResult`1<TicketResponse>> <>t__builder; //Field offset: 0x8
		public bool ignoreLastCheck; //Field offset: 0x20
		private TaskAwaiter<TicketResponse> <>u__1; //Field offset: 0x28

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <PurchaseTicketAsync>d__56 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder<CtApiFunctionResult`1<TicketResponse>> <>t__builder; //Field offset: 0x8
		private TaskAwaiter<TicketResponse> <>u__1; //Field offset: 0x20

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <Refresh>d__62 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder<CtApiActionResult> <>t__builder; //Field offset: 0x8
		public bool canRegister; //Field offset: 0x20
		private TaskAwaiter<CtApiActionResult> <>u__1; //Field offset: 0x28
		private TaskAwaiter<CtApiFunctionResult`1<StatusResponse>> <>u__2; //Field offset: 0x30

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <RefreshInstanceActivity>d__49 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder<CtApiActionResult> <>t__builder; //Field offset: 0x8
		private TaskAwaiter<ActivityResponse> <>u__1; //Field offset: 0x20

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <RegisterPlayerActivityAsync>d__58 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncVoidMethodBuilder <>t__builder; //Field offset: 0x8
		public bool waitFirstInterval; //Field offset: 0x28
		public TimeSpan interval; //Field offset: 0x30
		public CancellationToken cancellationToken; //Field offset: 0x38
		public int tileId; //Field offset: 0x40
		private TaskAwaiter <>u__1; //Field offset: 0x48
		private int <>7__wrap1; //Field offset: 0x50
		private TaskAwaiter<EmptyResponse> <>u__2; //Field offset: 0x58

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <SetPlayerConfigAsync>d__60 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder<CtApiActionResult> <>t__builder; //Field offset: 0x8
		public bool canRegister; //Field offset: 0x20
		private TaskAwaiter<Boolean> <>u__1; //Field offset: 0x28

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <StartPlayingTile>d__65 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder<CtApiActionResult> <>t__builder; //Field offset: 0x8
		public int tileId; //Field offset: 0x20
		private TaskAwaiter<EmptyResponse> <>u__1; //Field offset: 0x28

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <UpdateTileStatus>d__57 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder<CtApiActionResult> <>t__builder; //Field offset: 0x8
		public ContestedTerritoryIslandTile tile; //Field offset: 0x20
		private TaskAwaiter<NodeStatusResponse> <>u__1; //Field offset: 0x28
		private TaskAwaiter <>u__2; //Field offset: 0x30

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	private static TimeSpan lastRefresh; //Field offset: 0x0
	public const string kLocalTeamMedalPrefix = "Local_"; //Field offset: 0x0
	public const string kGlobalTeamMedalPrefix = "Global_"; //Field offset: 0x0
	private static TimeSpan lastActivityRefresh; //Field offset: 0x8
	private static TimeSpan lastRelicVotesRefresh; //Field offset: 0x10
	private static TimeSpan lastItemContributionsRefresh; //Field offset: 0x18
	private static Nullable<DateTime> timeAtLastRefresh; //Field offset: 0x20
	private static readonly Dictionary<String, String> teamNames; //Field offset: 0x30
	private static CancellationTokenSource activityRegistrationCanceller; //Field offset: 0x38
	private static TimeSpan lastTicketCheckAt; //Field offset: 0x40
	private static IReadOnlyCollection<ContestedTerritoryRelicType> _capturedRelics; //Field offset: 0x48
	[CompilerGenerated]
	private static StatusResponse <status>k__BackingField; //Field offset: 0x50
	[CompilerGenerated]
	private static CtEvent <ctEvent>k__BackingField; //Field offset: 0x58
	private static Dictionary<Int32, List`1<PlayerActivity>> nodeActivities; //Field offset: 0x60
	[CompilerGenerated]
	private static bool <statusChangedSinceLastRefresh>k__BackingField; //Field offset: 0x68
	public static Action OnStatusRefreshed; //Field offset: 0x70
	public static Action OnTicketStatusRefreshed; //Field offset: 0x78
	private static Dictionary<String, TeamStoreItemContributions> itemContributions; //Field offset: 0x80
	private static TrophyStoreBankData bankData; //Field offset: 0x88
	private static ContestedTerritoryRelicType[] dailyRelics; //Field offset: 0x90
	private static ContestedTerritoryRelicType[] eventRelics; //Field offset: 0x98

	public static bool CanPlayCtTiles
	{
		 get { } //Length: 438
	}

	private static IReadOnlyCollection<ContestedTerritoryRelicType> CapturedRelics
	{
		private get { } //Length: 79
		private set { } //Length: 555
	}

	public private static CtEvent ctEvent
	{
		[CompilerGenerated]
		 get { } //Length: 79
		[CompilerGenerated]
		private set { } //Length: 85
	}

	public static ContestedTerritorySettings CtSkuSettings
	{
		 get { } //Length: 147
	}

	private static string DailyPowerIdPrefix
	{
		private get { } //Length: 44
	}

	public static string EventEndedText
	{
		 get { } //Length: 88
	}

	private static string GenericErrorText
	{
		private get { } //Length: 88
	}

	public static bool IsEventRunning
	{
		 get { } //Length: 313
	}

	private static TimeSpan Now
	{
		private get { } //Length: 91
	}

	private static Btd6Player Player
	{
		private get { } //Length: 7
	}

	public private static StatusResponse status
	{
		[CompilerGenerated]
		 get { } //Length: 79
		[CompilerGenerated]
		private set { } //Length: 85
	}

	public static bool statusChangedSinceLastRefresh
	{
		[CompilerGenerated]
		 get { } //Length: 79
		[CompilerGenerated]
		 set { } //Length: 84
	}

	public static List<String> TeamIds
	{
		 get { } //Length: 139
	}

	private static string TeamRelicIdPrefix
	{
		private get { } //Length: 44
	}

	private static ContestedTerritoryApi() { }

	[CompilerGenerated]
	internal static bool <Refresh>g__isRefreshRequired|62_0() { }

	[AsyncStateMachine(typeof(<AddNameOfTeamsAsync>d__77))]
	private static Task<CtApiActionResult> AddNameOfTeamsAsync(GuildInfo[] guildInfos) { }

	[AsyncStateMachine(typeof(<ClaimGuildTicketAsync>d__55))]
	public static Task<CtApiFunctionResult`1<TicketResponse>> ClaimGuildTicketAsync() { }

	[AsyncStateMachine(typeof(<CompletePlayerActivity>d__50))]
	public static Task<CtApiActionResult> CompletePlayerActivity(int tileId, bool isTileCaptured) { }

	public static bool get_CanPlayCtTiles() { }

	private static IReadOnlyCollection<ContestedTerritoryRelicType> get_CapturedRelics() { }

	[CompilerGenerated]
	public static CtEvent get_ctEvent() { }

	public static ContestedTerritorySettings get_CtSkuSettings() { }

	private static string get_DailyPowerIdPrefix() { }

	public static string get_EventEndedText() { }

	private static string get_GenericErrorText() { }

	public static bool get_IsEventRunning() { }

	private static TimeSpan get_Now() { }

	private static Btd6Player get_Player() { }

	[CompilerGenerated]
	public static StatusResponse get_status() { }

	[CompilerGenerated]
	public static bool get_statusChangedSinceLastRefresh() { }

	public static List<String> get_TeamIds() { }

	private static string get_TeamRelicIdPrefix() { }

	private static Task<TrophyStoreBankData> GetBankData() { }

	[AsyncStateMachine(typeof(<GetCapturedRelics>d__61))]
	public static Task<IReadOnlyCollection`1<ContestedTerritoryRelicType>> GetCapturedRelics() { }

	[AsyncStateMachine(typeof(<GetDailyRelic>d__73))]
	public static Task<TeamStoreRelic> GetDailyRelic() { }

	[AsyncStateMachine(typeof(<GetEventRelics>d__74))]
	public static Task<TeamStoreRelic[]> GetEventRelics() { }

	[AsyncStateMachine(typeof(<GetHasTeamsStoreChanged>d__75))]
	public static Task<Boolean> GetHasTeamsStoreChanged() { }

	[AsyncStateMachine(typeof(<GetItemContributions>d__67))]
	public static Task<Dictionary`2<String, TeamStoreItemContributions>> GetItemContributions() { }

	[AsyncStateMachine(typeof(<GetLeaderboardMetadata>d__53))]
	public static Task<ValueTuple`2<String, String>> GetLeaderboardMetadata() { }

	public static IEnumerable<PlayerActivity> GetPlayerActivityForTile(int tileId) { }

	[AsyncStateMachine(typeof(<GetStatusForPlayerAsync>d__59))]
	private static Task<CtApiFunctionResult`1<StatusResponse>> GetStatusForPlayerAsync(bool canRegister) { }

	public static string GetTeamName(string teamId) { }

	[AsyncStateMachine(typeof(<GetTicketStatusForPlayerAsync>d__54))]
	public static Task<CtApiFunctionResult`1<TicketResponse>> GetTicketStatusForPlayerAsync(bool ignoreLastCheck = false) { }

	[Extension]
	public static bool HasActivePlayers(IEnumerable<PlayerActivity> playerActivities) { }

	public static void Init(CtEvent ctEventIn) { }

	public static bool IsValidMapSave(MapSaveDataModel mapSave) { }

	[AsyncStateMachine(typeof(<PurchaseTicketAsync>d__56))]
	public static Task<CtApiFunctionResult`1<TicketResponse>> PurchaseTicketAsync() { }

	[AsyncStateMachine(typeof(<Refresh>d__62))]
	public static Task<CtApiActionResult> Refresh(bool canRegister = true) { }

	[AsyncStateMachine(typeof(<RefreshInstanceActivity>d__49))]
	public static Task<CtApiActionResult> RefreshInstanceActivity() { }

	public static void RefreshItemContributionsCache() { }

	[AsyncStateMachine(typeof(<RegisterPlayerActivityAsync>d__58))]
	private static void RegisterPlayerActivityAsync(int tileId, TimeSpan interval, CancellationToken cancellationToken, bool waitFirstInterval) { }

	public static void Reset() { }

	public static void ScoreSubmitted(SetScoreResponse response) { }

	private static void set_CapturedRelics(IReadOnlyCollection<ContestedTerritoryRelicType> value) { }

	[CompilerGenerated]
	private static void set_ctEvent(CtEvent value) { }

	[CompilerGenerated]
	private static void set_status(StatusResponse value) { }

	[CompilerGenerated]
	public static void set_statusChangedSinceLastRefresh(bool value) { }

	[AsyncStateMachine(typeof(<SetPlayerConfigAsync>d__60))]
	private static Task<CtApiActionResult> SetPlayerConfigAsync(bool canRegister) { }

	[AsyncStateMachine(typeof(<StartPlayingTile>d__65))]
	public static Task<CtApiActionResult> StartPlayingTile(int tileId) { }

	private static void UpdateTicketSaveData(TicketStatus ticketStatus) { }

	[AsyncStateMachine(typeof(<UpdateTileStatus>d__57))]
	public static Task<CtApiActionResult> UpdateTileStatus(ContestedTerritoryIslandTile tile) { }

}

