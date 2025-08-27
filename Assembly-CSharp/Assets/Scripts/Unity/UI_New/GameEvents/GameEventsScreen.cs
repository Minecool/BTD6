namespace Assets.Scripts.Unity.UI_New.GameEvents;

public class GameEventsScreen : GameMenu
{
	[CompilerGenerated]
	private sealed class <>c
	{
		private struct <<LoadCTPanel>b__52_0>d : IAsyncStateMachine
		{
			public int <>1__state; //Field offset: 0x0
			public AsyncTaskMethodBuilder<CtEvent> <>t__builder; //Field offset: 0x8
			private CtEvent <ctEvent>5__2; //Field offset: 0x20
			private TaskAwaiter<Boolean> <>u__1; //Field offset: 0x28
			private TaskAwaiter<Btd6CtSettings> <>u__2; //Field offset: 0x30

			private override void MoveNext() { }

			[DebuggerHidden]
			private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

		}

		private struct <<LoadOdysseyPanel>b__58_0>d : IAsyncStateMachine
		{
			public int <>1__state; //Field offset: 0x0
			public AsyncTaskMethodBuilder<OdysseyEvent> <>t__builder; //Field offset: 0x8
			private OdysseyEvent <odysseyEvent>5__2; //Field offset: 0x20
			private TaskAwaiter<OdysseyData> <>u__1; //Field offset: 0x28

			private override void MoveNext() { }

			[DebuggerHidden]
			private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

		}

		private struct <<LoadRacePanel>b__57_0>d : IAsyncStateMachine
		{
			public int <>1__state; //Field offset: 0x0
			public AsyncTaskMethodBuilder<RaceEvent> <>t__builder; //Field offset: 0x8
			private RaceEvent <raceEvent>5__2; //Field offset: 0x20
			private TaskAwaiter<Boolean> <>u__1; //Field offset: 0x28
			private TaskAwaiter<Race> <>u__2; //Field offset: 0x30

			private override void MoveNext() { }

			[DebuggerHidden]
			private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

		}

		public static readonly <>c <>9; //Field offset: 0x0
		public static Func<Func`1<Task>, Task> <>9__47_0; //Field offset: 0x8
		public static Func<GameEventPanel, Int32> <>9__48_0; //Field offset: 0x10
		public static Func<GenericEventPanel, Boolean> <>9__50_0; //Field offset: 0x18
		public static Func<GenericEventPanel, DateTime> <>9__50_1; //Field offset: 0x20
		public static Func<GenericEventPanel, Boolean> <>9__50_2; //Field offset: 0x28
		public static Func<GenericEventPanel, DateTime> <>9__50_3; //Field offset: 0x30
		public static Func<Task`1<CtEvent>> <>9__52_0; //Field offset: 0x38
		public static Func<Task`1<CollectablesEvent>> <>9__55_0; //Field offset: 0x40
		public static Func<SweepstakesEvent, DateTime> <>9__56_2; //Field offset: 0x48
		public static Func<Task`1<RaceEvent>> <>9__57_0; //Field offset: 0x50
		public static Func<Task`1<OdysseyEvent>> <>9__58_0; //Field offset: 0x58
		public static UnityAction <>9__64_0; //Field offset: 0x60
		public static Func<KeyValuePair`2<String, Boolean>, Boolean> <>9__66_0; //Field offset: 0x68
		public static Func<KeyValuePair`2<String, Boolean>, Boolean> <>9__66_3; //Field offset: 0x70
		public static Func<SweepstakesEvent, DateTime> <>9__78_0; //Field offset: 0x78

		private static <>c() { }

		public <>c() { }

		internal DateTime <CloseAndTransitionToEndedSweepstakesEvent>b__78_0(SweepstakesEvent x) { }

		internal Task<CollectablesEvent> <LoadCollectionEventPanel>b__55_0() { }

		[AsyncStateMachine(typeof(<<LoadCTPanel>b__52_0>d))]
		internal Task<CtEvent> <LoadCTPanel>b__52_0() { }

		internal void <LoadHeroSaleBanners>b__64_0() { }

		[AsyncStateMachine(typeof(<<LoadOdysseyPanel>b__58_0>d))]
		internal Task<OdysseyEvent> <LoadOdysseyPanel>b__58_0() { }

		internal Task <LoadPanels>b__47_0(Func<Task> t) { }

		[AsyncStateMachine(typeof(<<LoadRacePanel>b__57_0>d))]
		internal Task<RaceEvent> <LoadRacePanel>b__57_0() { }

		internal bool <LoadSalePanels>b__66_0(KeyValuePair<String, Boolean> x) { }

		internal bool <LoadSalePanels>b__66_3(KeyValuePair<String, Boolean> kvp) { }

		internal DateTime <LoadSweepStakesEventPanel>b__56_2(SweepstakesEvent x) { }

		internal int <SortFeaturedPanels>b__48_0(GameEventPanel p) { }

		internal bool <SortRotatingEventPanels>b__50_0(GenericEventPanel x) { }

		internal DateTime <SortRotatingEventPanels>b__50_1(GenericEventPanel panel) { }

		internal bool <SortRotatingEventPanels>b__50_2(GenericEventPanel x) { }

		internal DateTime <SortRotatingEventPanels>b__50_3(GenericEventPanel panel) { }

	}

	[CompilerGenerated]
	private sealed class <>c__59
	{
		public static readonly <>c__59<T> <>9; //Field offset: 0x0
		public static Func<T, DateTime> <>9__59_1; //Field offset: 0x0

		private static <>c__59`1() { }

		public <>c__59`1() { }

		internal DateTime <LoadRotatingEventPanel>b__59_1(T endedEvent) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass53_0
	{
		public BossEvent bossEvent; //Field offset: 0x10
		public GameEventsScreen <>4__this; //Field offset: 0x18

		public <>c__DisplayClass53_0() { }

		internal Task<BossEvent> <LoadBossPanel>b__0() { }

		internal void <LoadBossPanel>b__1() { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass54_0
	{
		public BossRushEvent bossRushEvent; //Field offset: 0x10
		public GameEventsScreen <>4__this; //Field offset: 0x18

		public <>c__DisplayClass54_0() { }

		internal Task<BossRushEvent> <LoadBossRushPanel>b__0() { }

		internal void <LoadBossRushPanel>b__1() { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass56_0
	{
		public SweepstakesEvent sweepStakesEvent; //Field offset: 0x10
		public Func<Task> openSweepstakeMenuTask; //Field offset: 0x18

		public <>c__DisplayClass56_0() { }

		internal Task<SweepstakesEvent> <LoadSweepStakesEventPanel>b__0() { }

		internal void <LoadSweepStakesEventPanel>b__1() { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass59_0
	{
		public GameEventsScreen <>4__this; //Field offset: 0x0
		public T gameEvent; //Field offset: 0x0
		public GenericEventPanel newFeaturedPanel; //Field offset: 0x0

		public <>c__DisplayClass59_0`1() { }

		internal void <LoadRotatingEventPanel>b__0() { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass64_0
	{
		public HeroSaleEvent heroSaleEvent; //Field offset: 0x10
		public GenericEventPanel panel; //Field offset: 0x18
		public GameEventsScreen <>4__this; //Field offset: 0x20

		public <>c__DisplayClass64_0() { }

		internal void <LoadHeroSaleBanners>b__1() { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass65_0
	{
		public GameEventsScreen <>4__this; //Field offset: 0x10
		public GenericEventPanel cbPanel; //Field offset: 0x18

		public <>c__DisplayClass65_0() { }

		internal void <AddContentBrowserPanel>b__0() { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass66_0
	{
		public IapEvent saleEvent; //Field offset: 0x10
		public GameEventsScreen <>4__this; //Field offset: 0x18

		public <>c__DisplayClass66_0() { }

		internal void <LoadSalePanels>b__1() { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass66_1
	{
		public GenericEventPanel panel; //Field offset: 0x10
		public <>c__DisplayClass66_0 CS$<>8__locals1; //Field offset: 0x18

		public <>c__DisplayClass66_1() { }

		internal void <LoadSalePanels>b__2() { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass67_0
	{
		public BannerEvent bannerEvent; //Field offset: 0x10
		public string banner; //Field offset: 0x18
		public GenericEventPanel panel; //Field offset: 0x20
		public GameEventsScreen <>4__this; //Field offset: 0x28

		public <>c__DisplayClass67_0() { }

		internal void <LoadBannerEvents>b__0() { }

		internal void <LoadBannerEvents>b__1() { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass68_0
	{
		public GameEventsScreen <>4__this; //Field offset: 0x10
		public CrossPromoInfo crossPromoInfo; //Field offset: 0x18
		public GenericEventPanel crossPromoPanel; //Field offset: 0x20

		public <>c__DisplayClass68_0() { }

		internal void <AddCrossPromoBanner>b__0() { }

		internal void <AddCrossPromoBanner>b__1() { }

		internal void <AddCrossPromoBanner>b__2() { }

	}

	[CompilerGenerated]
	private struct <AddContentBrowserPanel>d__65 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public GameEventsScreen <>4__this; //Field offset: 0x20
		private <>c__DisplayClass65_0 <>8__1; //Field offset: 0x28
		private TaskAwaiter<Boolean> <>u__1; //Field offset: 0x30

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <AddCrossPromoBanner>d__68 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public GameEventsScreen <>4__this; //Field offset: 0x20
		private <>c__DisplayClass68_0 <>8__1; //Field offset: 0x28
		private TaskAwaiter<CrossPromoInfo> <>u__1; //Field offset: 0x30

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <CloseAndTransistionToBossScreenAsync>d__71 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public GameEventsScreen <>4__this; //Field offset: 0x20
		private BossEvent <bossEvent>5__2; //Field offset: 0x28
		private TaskAwaiter<Boolean> <>u__1; //Field offset: 0x30

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <CloseAndTransistionToChallengeBrowserAsync>d__75 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public GameEventsScreen <>4__this; //Field offset: 0x20
		private TaskAwaiter<Boolean> <>u__1; //Field offset: 0x28

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <CloseAndTransistionToRaceScreenAsync>d__70 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public GameEventsScreen <>4__this; //Field offset: 0x20
		private TaskAwaiter<Boolean> <>u__1; //Field offset: 0x28

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <CloseAndTransistionToTeamEventScreenAsync>d__72 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public GameEventsScreen <>4__this; //Field offset: 0x20
		private TaskAwaiter<Boolean> <>u__1; //Field offset: 0x28

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <CloseAndTransitionToEndedSweepstakesEvent>d__78 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public GameEventsScreen <>4__this; //Field offset: 0x20
		private TaskAwaiter<Boolean> <>u__1; //Field offset: 0x28

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <CloseAndTransitionToSweepstakesEvent>d__77 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public GameEventsScreen <>4__this; //Field offset: 0x20
		private TaskAwaiter<Boolean> <>u__1; //Field offset: 0x28

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <LoadAdvancedChallengePanel>d__61 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public GameEventsScreen <>4__this; //Field offset: 0x20
		private TaskAwaiter<DailyChallengeModel> <>u__1; //Field offset: 0x28

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <LoadBossPanel>d__53 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public GameEventsScreen <>4__this; //Field offset: 0x20
		private <>c__DisplayClass53_0 <>8__1; //Field offset: 0x28
		private BossDataModel <bossEventData>5__2; //Field offset: 0x30
		private TaskAwaiter<Boolean> <>u__1; //Field offset: 0x38
		private TaskAwaiter<BossDataModel> <>u__2; //Field offset: 0x40
		private TaskAwaiter <>u__3; //Field offset: 0x48

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <LoadBossRushPanel>d__54 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public GameEventsScreen <>4__this; //Field offset: 0x20
		private <>c__DisplayClass54_0 <>8__1; //Field offset: 0x28
		private TaskAwaiter<Boolean> <>u__1; //Field offset: 0x30
		private TaskAwaiter <>u__2; //Field offset: 0x38

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <LoadCollectionEventPanel>d__55 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public GameEventsScreen <>4__this; //Field offset: 0x20
		private TaskAwaiter <>u__1; //Field offset: 0x28

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <LoadCoopDcPanel>d__62 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public GameEventsScreen <>4__this; //Field offset: 0x20
		private DailyChallengeModel <coopDcm>5__2; //Field offset: 0x28
		private TaskAwaiter<Boolean> <>u__1; //Field offset: 0x30
		private TaskAwaiter<DailyChallengeModel> <>u__2; //Field offset: 0x38

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <LoadDailyChallengePanel>d__60 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public GameEventsScreen <>4__this; //Field offset: 0x20
		private TaskAwaiter<DailyChallengeModel> <>u__1; //Field offset: 0x28

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <LoadPanels>d__47 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public GameEventsScreen <>4__this; //Field offset: 0x20
		private List<Func`1<Task>> <panelLoadTasks>5__2; //Field offset: 0x28
		private TaskAwaiter<Boolean> <>u__1; //Field offset: 0x30
		private TaskAwaiter <>u__2; //Field offset: 0x38

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <LoadRotatingEventPanel>d__59 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x0
		public GameEventsScreen <>4__this; //Field offset: 0x0
		public bool requiresLogin; //Field offset: 0x0
		public GenericEventPanel eventPanel; //Field offset: 0x0
		public int unlockRank; //Field offset: 0x0
		public Func<Task`1<T>> getSkuEvent; //Field offset: 0x0
		private <>c__DisplayClass59_0<T> <>8__1; //Field offset: 0x0
		public UnityAction onClick; //Field offset: 0x0
		public GenericEventPanel featuredBannerPrefab; //Field offset: 0x0
		public string banner; //Field offset: 0x0
		public int bannerPriority; //Field offset: 0x0
		public Nullable<TimeSpan> eventFrequency; //Field offset: 0x0
		private TaskAwaiter<T> <>u__1; //Field offset: 0x0

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <LoadSweepStakesEventPanel>d__56 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public GameEventsScreen <>4__this; //Field offset: 0x20
		private <>c__DisplayClass56_0 <>8__1; //Field offset: 0x28
		private bool <canShowEndedEvent>5__2; //Field offset: 0x30
		private TaskAwaiter<Boolean> <>u__1; //Field offset: 0x38
		private TaskAwaiter <>u__2; //Field offset: 0x40

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[SerializeField]
	private GenericEventPanel genericPanelPrefab; //Field offset: 0x48
	[SerializeField]
	private GenericEventPanel challengeBrowserPrefab; //Field offset: 0x50
	[SerializeField]
	private GenericEventPanel raceEventBannerPrefab; //Field offset: 0x58
	[SerializeField]
	private GenericEventPanel ctEventBannerPrefab; //Field offset: 0x60
	[SerializeField]
	private GenericEventPanel bossEventBannerPrefab; //Field offset: 0x68
	[SerializeField]
	private GenericEventPanel odysseyEventBannerPrefab; //Field offset: 0x70
	[SerializeField]
	private GenericEventPanel bossRushBannerPrefab; //Field offset: 0x78
	[SerializeField]
	private GenericEventPanel sweepstakesBannerPrefab; //Field offset: 0x80
	[SerializeField]
	private GenericEventPanel raceEventPanel; //Field offset: 0x88
	[SerializeField]
	private GenericEventPanel odysseyEventPanel; //Field offset: 0x90
	[SerializeField]
	private GenericEventPanel ctEventPanel; //Field offset: 0x98
	[SerializeField]
	private GenericEventPanel bossEventPanel; //Field offset: 0xA0
	[SerializeField]
	private GenericEventPanel bossRushEventPanel; //Field offset: 0xA8
	[SerializeField]
	private GenericEventPanel collectionEventPanel; //Field offset: 0xB0
	[SerializeField]
	private GenericEventPanel sweepStakesEventPanel; //Field offset: 0xB8
	[SerializeField]
	private DailyChallengePanel dailyChallengePanel; //Field offset: 0xC0
	[SerializeField]
	private DailyChallengePanel advancedChallengePanel; //Field offset: 0xC8
	[SerializeField]
	private DailyChallengePanel coopChallengePanel; //Field offset: 0xD0
	[SerializeField]
	private SlideshowInfoPanel featuredPanelSlides; //Field offset: 0xD8
	[SerializeField]
	private Transform featuredContainer; //Field offset: 0xE0
	[SerializeField]
	private Transform rotatingEventsContainer; //Field offset: 0xE8
	[SerializeField]
	private Button bossChallengeBtn; //Field offset: 0xF0
	[SerializeField]
	private SpriteReference[] collectionEventIcons; //Field offset: 0xF8
	[SerializeField]
	private SpriteReference[] collectionEventBackgrounds; //Field offset: 0x100
	private readonly List<GameEventPanel> featuredPanels; //Field offset: 0x108
	private DateTime nextRefreshTime; //Field offset: 0x110
	private bool isLoadingPanels; //Field offset: 0x118
	private bool sortPanelsOnUpdate; //Field offset: 0x119
	private CancellationTokenSource screenCts; //Field offset: 0x120
	[CompilerGenerated]
	private CancellationToken <ScreenCanceller>k__BackingField; //Field offset: 0x128

	private AnalyticsManager Analytics
	{
		private get { } //Length: 54
	}

	public IReadOnlyCollection<SpriteReference> CollectionEventBackgrounds
	{
		 get { } //Length: 8
	}

	public IReadOnlyCollection<SpriteReference> CollectionEventIcons
	{
		 get { } //Length: 8
	}

	private NewsPanel PanelPriority
	{
		private get { } //Length: 147
	}

	public private CancellationToken ScreenCanceller
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 8
	}

	public GameEventsScreen() { }

	[CompilerGenerated]
	private void <LoadCollectionEventPanel>b__55_1() { }

	[CompilerGenerated]
	private void <LoadCTPanel>b__52_1() { }

	[CompilerGenerated]
	private void <LoadOdysseyPanel>b__58_1() { }

	[CompilerGenerated]
	private void <LoadRacePanel>b__57_1() { }

	[AsyncStateMachine(typeof(<AddContentBrowserPanel>d__65))]
	private Task AddContentBrowserPanel() { }

	[AsyncStateMachine(typeof(<AddCrossPromoBanner>d__68))]
	private Task AddCrossPromoBanner() { }

	private void AddFeaturedPanel(GameEventPanel panel, DateTime endTime) { }

	protected virtual void Awake() { }

	[AsyncStateMachine(typeof(<CloseAndTransistionToBossScreenAsync>d__71))]
	private Task CloseAndTransistionToBossScreenAsync() { }

	private void CloseAndTransistionToChallengeBrowser() { }

	[AsyncStateMachine(typeof(<CloseAndTransistionToChallengeBrowserAsync>d__75))]
	private Task CloseAndTransistionToChallengeBrowserAsync() { }

	private void CloseAndTransistionToCollectionEvent() { }

	public void CloseAndTransistionToDCScreen(DailyChallengeModel dcm) { }

	private void CloseAndTransistionToOdysseyScreen() { }

	[AsyncStateMachine(typeof(<CloseAndTransistionToRaceScreenAsync>d__70))]
	private Task CloseAndTransistionToRaceScreenAsync() { }

	[AsyncStateMachine(typeof(<CloseAndTransistionToTeamEventScreenAsync>d__72))]
	private Task CloseAndTransistionToTeamEventScreenAsync() { }

	private void CloseAndTransitionToBossChallenge() { }

	[AsyncStateMachine(typeof(<CloseAndTransitionToEndedSweepstakesEvent>d__78))]
	private Task CloseAndTransitionToEndedSweepstakesEvent() { }

	[AsyncStateMachine(typeof(<CloseAndTransitionToSweepstakesEvent>d__77))]
	private Task CloseAndTransitionToSweepstakesEvent() { }

	public void FeaturedPanelViewed(GameObject panel, string from, int index) { }

	private static bool FilterBanners(T evt) { }

	private void GamepadSelectFirstButton() { }

	private AnalyticsManager get_Analytics() { }

	public IReadOnlyCollection<SpriteReference> get_CollectionEventBackgrounds() { }

	public IReadOnlyCollection<SpriteReference> get_CollectionEventIcons() { }

	private NewsPanel get_PanelPriority() { }

	[CompilerGenerated]
	public CancellationToken get_ScreenCanceller() { }

	[AsyncStateMachine(typeof(<LoadAdvancedChallengePanel>d__61))]
	private Task LoadAdvancedChallengePanel() { }

	private void LoadBannerEvents() { }

	[AsyncStateMachine(typeof(<LoadBossPanel>d__53))]
	private Task LoadBossPanel() { }

	[AsyncStateMachine(typeof(<LoadBossRushPanel>d__54))]
	private Task LoadBossRushPanel() { }

	[AsyncStateMachine(typeof(<LoadCollectionEventPanel>d__55))]
	private Task LoadCollectionEventPanel() { }

	[AsyncStateMachine(typeof(<LoadCoopDcPanel>d__62))]
	private Task LoadCoopDcPanel() { }

	private Task LoadCTPanel() { }

	[AsyncStateMachine(typeof(<LoadDailyChallengePanel>d__60))]
	private Task LoadDailyChallengePanel() { }

	private void LoadHeroSaleBanners() { }

	private Task LoadOdysseyPanel() { }

	[AsyncStateMachine(typeof(<LoadPanels>d__47))]
	private Task LoadPanels() { }

	private Task LoadRacePanel() { }

	[AsyncStateMachine(typeof(<LoadRotatingEventPanel>d__59`1))]
	private Task LoadRotatingEventPanel(GenericEventPanel eventPanel, int unlockRank, Func<Task`1<T>> getSkuEvent, Nullable<TimeSpan> eventFrequency, UnityAction onClick, GenericEventPanel featuredBannerPrefab = null, string banner = null, int bannerPriority = -1, bool requiresLogin = false) { }

	private void LoadSalePanels() { }

	[AsyncStateMachine(typeof(<LoadSweepStakesEventPanel>d__56))]
	private Task LoadSweepStakesEventPanel() { }

	private void OnDestroy() { }

	public virtual void Open(object data) { }

	[CompilerGenerated]
	private void set_ScreenCanceller(CancellationToken value) { }

	private void SetRefreshTime(DateTime endTime) { }

	private void SortFeaturedPanels(bool forceNow = false) { }

	private void SortRotatingEventPanels() { }

	public void Update() { }

	private void UpdateNavigation() { }

}

