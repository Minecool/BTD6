namespace Assets.Scripts.Unity;

public class SkuSettings
{
	[CompilerGenerated]
	private struct <_Refresh>d__21 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public TimeSpan timeout; //Field offset: 0x20
		public bool waitForDataRefresh; //Field offset: 0x28
		private float <startTime>5__2; //Field offset: 0x2C
		private TaskAwaiter<String> <>u__1; //Field offset: 0x30
		private TaskAwaiter <>u__2; //Field offset: 0x38

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func<ServerMaintenanceEvent, Boolean> <>9__22_1; //Field offset: 0x8
		public static Func<String, Exception> <>9__22_0; //Field offset: 0x10
		public static Func<ServerMaintenanceEvent, DateTime> <>9__57_0; //Field offset: 0x18

		private static <>c() { }

		public <>c() { }

		internal DateTime <GetActiveOrNextServerMaintenanceEvent>b__57_0(ServerMaintenanceEvent x) { }

		internal Exception <ParseAndValidate>b__22_0(string error) { }

		internal bool <ParseAndValidate>b__22_1(ServerMaintenanceEvent x) { }

	}

	[CompilerGenerated]
	private sealed class <>c__39
	{
		public static readonly <>c__39<T> <>9; //Field offset: 0x0
		public static Func<T, DateTime> <>9__39_1; //Field offset: 0x0

		private static <>c__39`1() { }

		public <>c__39`1() { }

		internal DateTime <GetNextEvent>b__39_1(T x) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass22_0
	{
		public List<String> errors; //Field offset: 0x10

		public <>c__DisplayClass22_0() { }

		internal void <ParseAndValidate>b__2(object sender, ErrorEventArgs args) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass34_0
	{
		public string eventID; //Field offset: 0x0

		public <>c__DisplayClass34_0`1() { }

		internal bool <GetEvent>b__0(T e) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass35_0
	{
		public DateTime currentTime; //Field offset: 0x0

		public <>c__DisplayClass35_0`1() { }

		internal bool <GetActiveEvent>b__0(T e) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass36_0
	{
		public DateTime currentTime; //Field offset: 0x0

		public <>c__DisplayClass36_0`1() { }

		internal bool <HasActive>b__0(T e) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass37_0
	{
		public DateTime currentTime; //Field offset: 0x0

		public <>c__DisplayClass37_0`1() { }

		internal bool <GetActiveEvents>b__0(T e) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass38_0
	{
		public DateTime currentTime; //Field offset: 0x0
		public TimeSpan cooldownPeriod; //Field offset: 0x0

		public <>c__DisplayClass38_0`1() { }

		internal bool <GetEndedEvents>b__0(T e) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass39_0
	{
		public DateTime currentTime; //Field offset: 0x0

		public <>c__DisplayClass39_0`1() { }

		internal bool <GetNextEvent>b__0(T x) { }

	}

	[CompilerGenerated]
	private struct <DownloadOrLoadFromFile>d__30 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder<String> <>t__builder; //Field offset: 0x8
		public bool returnNullIfUnchanged; //Field offset: 0x20
		public Nullable<TimeSpan> timeoutOverride; //Field offset: 0x28
		private Task<String> <downloadTask>5__2; //Field offset: 0x38
		private TaskAwaiter<String> <>u__1; //Field offset: 0x40

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <GetCoopChallengeAsync>d__41 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder<DailyChallengeModel> <>t__builder; //Field offset: 0x8
		private TaskAwaiter<DailyChallengeModel> <>u__1; //Field offset: 0x20

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <GetDailyChallengeAsync>d__40 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder<DailyChallengeModel> <>t__builder; //Field offset: 0x8
		public ChallengeType chalType; //Field offset: 0x20
		public TimeSpan offset; //Field offset: 0x28
		private TaskAwaiter<DailyChallengeModel> <>u__1; //Field offset: 0x30

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <Initialise>d__13 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public InitialLoadingScreen initialLoadingScreen; //Field offset: 0x20
		private LocalizationManager <locs>5__2; //Field offset: 0x28
		private TimeSpan <retryDelay>5__3; //Field offset: 0x30
		private int <attempt>5__4; //Field offset: 0x38
		private object <>7__wrap4; //Field offset: 0x40
		private int <>7__wrap5; //Field offset: 0x48
		private TaskAwaiter<UpdateSettings> <>u__1; //Field offset: 0x50
		private TaskAwaiter<String> <>u__2; //Field offset: 0x58
		private string <cdnHostname>5__7; //Field offset: 0x60
		private TaskAwaiter<Boolean> <>u__3; //Field offset: 0x68
		private TaskAwaiter <>u__4; //Field offset: 0x70

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <Refresh>d__20 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public bool forceRefresh; //Field offset: 0x20
		public Nullable<TimeSpan> timeoutOverride; //Field offset: 0x28
		public bool waitForDataRefresh; //Field offset: 0x38
		public Nullable<CancellationToken> cancellationToken; //Field offset: 0x40
		private TaskAwaiter <>u__1; //Field offset: 0x50

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <RefreshEventsData>d__26 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		private TaskAwaiter <>u__1; //Field offset: 0x20

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	internal sealed class OnSkuSettingsChanged : MulticastDelegate
	{

		public OnSkuSettingsChanged(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(Sku skuSettings, AsyncCallback callback, object object) { }

		public override void EndInvoke(IAsyncResult result) { }

		public override void Invoke(Sku skuSettings) { }

	}

	private static Sku _instance; //Field offset: 0x0
	[CompilerGenerated]
	private static bool <IsForceUpdateEnabled>k__BackingField; //Field offset: 0x8
	[CompilerGenerated]
	private static bool <IsSoftUpdateEnabled>k__BackingField; //Field offset: 0x9
	private static bool isFirstLoad; //Field offset: 0xA
	private static TimeSpan lastRefreshTime; //Field offset: 0x10
	private static Task skuRefreshTask; //Field offset: 0x18
	[CompilerGenerated]
	private static readonly SkuSettingsHelper <SkuHelper>k__BackingField; //Field offset: 0x20

	public static bool CanBuyAccolades
	{
		 get { } //Length: 381
	}

	public static bool CanUseGiftCodes
	{
		 get { } //Length: 339
	}

	public private static Sku instance
	{
		 get { } //Length: 78
		private set { } //Length: 207
	}

	public private static bool IsForceUpdateEnabled
	{
		[CompilerGenerated]
		 get { } //Length: 79
		[CompilerGenerated]
		private set { } //Length: 84
	}

	public private static bool IsSoftUpdateEnabled
	{
		[CompilerGenerated]
		 get { } //Length: 79
		[CompilerGenerated]
		private set { } //Length: 84
	}

	private static DateTime LegendsChallengeZeroTime
	{
		private get { } //Length: 202
	}

	private static TimeSpan Now
	{
		private get { } //Length: 91
	}

	public static SkuSettingsHelper SkuHelper
	{
		[CompilerGenerated]
		 get { } //Length: 79
	}

	[AsyncStateMachine(typeof(<_Refresh>d__21))]
	private static Task _Refresh(bool waitForDataRefresh, TimeSpan timeout) { }

	private static SkuSettings() { }

	public SkuSettings() { }

	[CompilerGenerated]
	internal static bool <DisableSales>g__IsSaleIapId|23_1(string iapId) { }

	[CompilerGenerated]
	internal static bool <DisableSales>g__IsSaleItemEnabled|23_0(KeyValuePair<String, Boolean> iapId_isEnabled) { }

	public static void AddExtraQualitySettings(Sku skuSettings) { }

	private static bool CanFlaggedPlayersParticipate() { }

	public static bool CanShowPower(PowerModel powerModel) { }

	private static void DisableSales(BaseServerEvent[] baseServerEvents) { }

	[AsyncStateMachine(typeof(<DownloadOrLoadFromFile>d__30))]
	private static Task<String> DownloadOrLoadFromFile(bool returnNullIfUnchanged, Nullable<TimeSpan> timeoutOverride = null) { }

	public static bool get_CanBuyAccolades() { }

	public static bool get_CanUseGiftCodes() { }

	public static Sku get_instance() { }

	[CompilerGenerated]
	public static bool get_IsForceUpdateEnabled() { }

	[CompilerGenerated]
	public static bool get_IsSoftUpdateEnabled() { }

	private static DateTime get_LegendsChallengeZeroTime() { }

	private static TimeSpan get_Now() { }

	[CompilerGenerated]
	public static SkuSettingsHelper get_SkuHelper() { }

	public static T GetActiveEvent() { }

	public static IEnumerable<T> GetActiveEvents() { }

	public static ServerMaintenanceEvent GetActiveOrNextServerMaintenanceEvent() { }

	public static List<EventName> GetActiveSkins(int playerRank) { }

	[AsyncStateMachine(typeof(<GetCoopChallengeAsync>d__41))]
	public static Task<DailyChallengeModel> GetCoopChallengeAsync() { }

	public static int GetCostOfPower(string powerName, int baseCost) { }

	[AsyncStateMachine(typeof(<GetDailyChallengeAsync>d__40))]
	public static Task<DailyChallengeModel> GetDailyChallengeAsync(ChallengeType chalType, TimeSpan offset = null) { }

	private static Sku GetDefaultOfflineSku() { }

	public static IEnumerable<T> GetEndedEvents(TimeSpan cooldownPeriod = null) { }

	public static T GetEvent(string eventID, bool ignoreRestrictionCheck = false) { }

	public static int GetLegendsChallengeSeed() { }

	public static int GetMmCostOfSkin(string skinName, int baseCost) { }

	public static T GetNextEvent() { }

	public static bool HasActive() { }

	[AsyncStateMachine(typeof(<Initialise>d__13))]
	public static Task Initialise(InitialLoadingScreen initialLoadingScreen) { }

	private static bool IsDisabledByServerMaintenance(Type serverEventType) { }

	public static bool IsPowerIapInStore(PowerModel powerModel) { }

	private static bool IsRestricted() { }

	public static bool IsServerUnderMaintenance() { }

	public static void LoadDefaultOfflineSku() { }

	private static Sku ParseAndValidate(string json) { }

	[AsyncStateMachine(typeof(<Refresh>d__20))]
	public static Task Refresh(bool forceRefresh = false, Nullable<TimeSpan> timeoutOverride = null, bool waitForDataRefresh = true, Nullable<CancellationToken> cancellationToken = null) { }

	[AsyncStateMachine(typeof(<RefreshEventsData>d__26))]
	public static Task RefreshEventsData() { }

	private static void set_instance(Sku value) { }

	[CompilerGenerated]
	private static void set_IsForceUpdateEnabled(bool value) { }

	[CompilerGenerated]
	private static void set_IsSoftUpdateEnabled(bool value) { }

	private static void ValidateDailyRewards(Btd6Player player) { }

	private static void ValidateDailyRewards(Sku skuSettings, Btd6Player player) { }

}

