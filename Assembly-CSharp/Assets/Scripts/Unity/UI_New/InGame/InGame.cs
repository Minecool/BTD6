namespace Assets.Scripts.Unity.UI_New.InGame;

public class InGame : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Action<GameObject> <>9__167_2; //Field offset: 0x8
		public static Action<GameObject> <>9__167_3; //Field offset: 0x10
		public static Action<GameObject> <>9__167_6; //Field offset: 0x18
		public static Action<GameObject> <>9__167_7; //Field offset: 0x20
		public static Action<GameObject> <>9__167_4; //Field offset: 0x28
		public static Action<GameObject> <>9__172_0; //Field offset: 0x30
		public static Func<GeraldoStockItem, <>f__AnonymousType0`2<String, Int32>> <>9__185_0; //Field offset: 0x38
		public static Func<<>f__AnonymousType0`2<String, Int32>, Boolean> <>9__185_1; //Field offset: 0x40
		public static Func<<>f__AnonymousType0`2<String, Int32>, String> <>9__185_2; //Field offset: 0x48
		public static Func<<>f__AnonymousType0`2<String, Int32>, Int32> <>9__185_3; //Field offset: 0x50
		public static Func<TowerHistory, String> <>9__194_0; //Field offset: 0x58
		public static Func<TowerHistory, String> <>9__194_1; //Field offset: 0x60
		public static Func<TowerHistory, String> <>9__194_2; //Field offset: 0x68
		public static Func<TowerHistory, String> <>9__194_3; //Field offset: 0x70
		[TupleElementNames(new IL2CPP_TYPE_STRING[] {"menuName", "menuData"}])]
		public static Func<ValueTuple`2<String, Object>, Boolean> <>9__229_0; //Field offset: 0x78
		public static Func<SweepstakesStatsForTask, Boolean> <>9__381_1; //Field offset: 0x80
		public static Func<SweepstakesStatsForTask, Boolean> <>9__381_2; //Field offset: 0x88
		public static Func<MapEditorAreaData, Boolean> <>9__387_0; //Field offset: 0x90

		private static <>c() { }

		public <>c() { }

		internal bool <BossDefeated>b__381_1(SweepstakesStatsForTask x) { }

		internal bool <BossDefeated>b__381_2(SweepstakesStatsForTask x) { }

		internal string <CheckForCompletedAchievements>b__194_0(TowerHistory x) { }

		internal string <CheckForCompletedAchievements>b__194_1(TowerHistory x) { }

		internal string <CheckForCompletedAchievements>b__194_2(TowerHistory x) { }

		internal string <CheckForCompletedAchievements>b__194_3(TowerHistory x) { }

		internal bool <GetCustomMapModelWithVisibleLayers>b__387_0(MapEditorAreaData a) { }

		internal void <Initialise>b__167_2(GameObject uiObject) { }

		internal void <Initialise>b__167_3(GameObject uiObject) { }

		internal void <Initialise>b__167_4(GameObject uiObject) { }

		internal void <Initialise>b__167_6(GameObject uiObject) { }

		internal void <Initialise>b__167_7(GameObject uiObject) { }

		internal bool <ReturnToMainMenu>b__229_0(ValueTuple<String, Object> x) { }

		internal <>f__AnonymousType0<String, Int32> <RoundEnd>b__185_0(GeraldoStockItem x) { }

		internal bool <RoundEnd>b__185_1(<>f__AnonymousType0<String, Int32> x) { }

		internal string <RoundEnd>b__185_2(<>f__AnonymousType0<String, Int32> x) { }

		internal int <RoundEnd>b__185_3(<>f__AnonymousType0<String, Int32> x) { }

		internal void <StartTutorial>b__172_0(GameObject tutObj) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass167_0
	{
		public InGame <>4__this; //Field offset: 0x10
		public Btd6CoopGame coopGame; //Field offset: 0x18

		public <>c__DisplayClass167_0() { }

		internal void <Initialise>b__0(GameObject uiObject) { }

		internal void <Initialise>b__1(GameObject uiObject) { }

		internal void <Initialise>b__8(string reason) { }

		internal void <Initialise>b__9(IEnumerable<Task`1<Int32>> countdown, byte playerNumber) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass167_1
	{
		public Task drawMapTask; //Field offset: 0x10

		public <>c__DisplayClass167_1() { }

		internal bool <Initialise>b__5() { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass167_2
	{
		public byte playerNumber; //Field offset: 0x10

		public <>c__DisplayClass167_2() { }

		internal bool <Initialise>b__10(CoopPlayerInfo o) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass168_0
	{
		public string id; //Field offset: 0x10

		public <>c__DisplayClass168_0() { }

		internal bool <InstantiateUiObject>b__0(InGameMenuDef x) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass287_0
	{
		public int playerInputID; //Field offset: 0x10

		public <>c__DisplayClass287_0() { }

		internal bool <HandleHeroShorcutKey>b__0(TowerToSimulation x) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass291_0
	{
		public TowerToSimulation tower; //Field offset: 0x10

		public <>c__DisplayClass291_0() { }

		internal bool <TowerCreated>b__0(TowerDetailsModel x) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass348_0
	{
		public InGame <>4__this; //Field offset: 0x10
		public string name; //Field offset: 0x18
		public LocalizationManager loc; //Field offset: 0x20
		public ReturnCallback <>9__1; //Field offset: 0x28
		public ReturnCallback <>9__2; //Field offset: 0x30

		public <>c__DisplayClass348_0() { }

		internal void <OnSetNamedMonkeyName>b__0(bool noProfanity) { }

		internal void <OnSetNamedMonkeyName>b__1() { }

		internal void <OnSetNamedMonkeyName>b__2() { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass358_0
	{
		public InGame <>4__this; //Field offset: 0x10
		public bool pauseGame; //Field offset: 0x18
		public Action onEndCallback; //Field offset: 0x20

		public <>c__DisplayClass358_0() { }

		internal void <ShowEventPopup>b__0() { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass358_1
	{
		public bool clockStopped; //Field offset: 0x10
		public <>c__DisplayClass358_0 CS$<>8__locals1; //Field offset: 0x18

		public <>c__DisplayClass358_1() { }

		internal void <ShowEventPopup>g__resumeGame|1() { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass381_0
	{
		public InGame <>4__this; //Field offset: 0x10
		public int bossTier; //Field offset: 0x18
		public bool isShowingBossLeaderboardScore; //Field offset: 0x1C

		public <>c__DisplayClass381_0() { }

		internal void <BossDefeated>b__0() { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass381_1
	{
		private struct <<BossDefeated>g__WaitAndShowRewardsPopup|3>d : IAsyncStateMachine
		{
			public int <>1__state; //Field offset: 0x0
			public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
			public <>c__DisplayClass381_1 <>4__this; //Field offset: 0x20
			private TaskAwaiter <>u__1; //Field offset: 0x28

			private override void MoveNext() { }

			[DebuggerHidden]
			private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

		}

		public LootSet lootSet; //Field offset: 0x10
		public <>c__DisplayClass381_0 CS$<>8__locals1; //Field offset: 0x18

		public <>c__DisplayClass381_1() { }

		[AsyncStateMachine(typeof(<<BossDefeated>g__WaitAndShowRewardsPopup|3>d))]
		internal Task <BossDefeated>g__WaitAndShowRewardsPopup|3() { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass405_0
	{
		public List<String> winningTowerIds; //Field offset: 0x10

		public <>c__DisplayClass405_0() { }

		internal bool <OnTowerPollFinished>b__0(string x) { }

	}

	[CompilerGenerated]
	private struct <CheckForProfanity>d__350 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncVoidMethodBuilder <>t__builder; //Field offset: 0x8
		public ProfanityFinish callOnFinish; //Field offset: 0x28
		public string str; //Field offset: 0x30
		private ProfanityFinish <>7__wrap1; //Field offset: 0x38
		private TaskAwaiter<Boolean> <>u__1; //Field offset: 0x40

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private sealed class <Initialise>d__167 : IEnumerator<Object>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private object <>2__current; //Field offset: 0x18
		public InGame <>4__this; //Field offset: 0x20
		public Btd6CoopGame coopGame; //Field offset: 0x28
		private <>c__DisplayClass167_0 <>8__1; //Field offset: 0x30
		private <>c__DisplayClass167_1 <>8__2; //Field offset: 0x38
		private Enumerator<InGameMenuDef> <>7__wrap1; //Field offset: 0x40
		private DynamicUiObject[] <>7__wrap2; //Field offset: 0x58
		private int <>7__wrap3; //Field offset: 0x60
		private SimulationBehavior[] <>7__wrap4; //Field offset: 0x68
		private AsyncOperationHandle<GameObject> <handle>5__6; //Field offset: 0x70

		private override object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[DebuggerHidden]
			private get { } //Length: 5
		}

		private override object System.Collections.IEnumerator.Current
		{
			[DebuggerHidden]
			private get { } //Length: 5
		}

		[DebuggerHidden]
		public <Initialise>d__167(int <>1__state) { }

		private void <>m__Finally1() { }

		private override bool MoveNext() { }

		[DebuggerHidden]
		private override object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

		[DebuggerHidden]
		private override object System.Collections.IEnumerator.get_Current() { }

		[DebuggerHidden]
		private override void System.Collections.IEnumerator.Reset() { }

		[DebuggerHidden]
		private override void System.IDisposable.Dispose() { }

	}

	[CompilerGenerated]
	private sealed class <InstantiateUiObject>d__168 : IEnumerator<Object>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private object <>2__current; //Field offset: 0x18
		public string id; //Field offset: 0x20
		public InGame <>4__this; //Field offset: 0x28
		public Action<GameObject> onComplete; //Field offset: 0x30

		private override object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[DebuggerHidden]
			private get { } //Length: 5
		}

		private override object System.Collections.IEnumerator.Current
		{
			[DebuggerHidden]
			private get { } //Length: 5
		}

		[DebuggerHidden]
		public <InstantiateUiObject>d__168(int <>1__state) { }

		private override bool MoveNext() { }

		[DebuggerHidden]
		private override object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

		[DebuggerHidden]
		private override object System.Collections.IEnumerator.get_Current() { }

		[DebuggerHidden]
		private override void System.Collections.IEnumerator.Reset() { }

		[DebuggerHidden]
		private override void System.IDisposable.Dispose() { }

	}

	[CompilerGenerated]
	private sealed class <InstantiateUiObject>d__169 : IEnumerator<Object>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private object <>2__current; //Field offset: 0x18
		public InGameMenuDef menuDef; //Field offset: 0x20
		public Action<GameObject> onComplete; //Field offset: 0x28
		private AsyncOperationHandle<GameObject> <uiObjectHandle>5__2; //Field offset: 0x30

		private override object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[DebuggerHidden]
			private get { } //Length: 5
		}

		private override object System.Collections.IEnumerator.Current
		{
			[DebuggerHidden]
			private get { } //Length: 5
		}

		[DebuggerHidden]
		public <InstantiateUiObject>d__169(int <>1__state) { }

		private override bool MoveNext() { }

		[DebuggerHidden]
		private override object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

		[DebuggerHidden]
		private override object System.Collections.IEnumerator.get_Current() { }

		[DebuggerHidden]
		private override void System.Collections.IEnumerator.Reset() { }

		[DebuggerHidden]
		private override void System.IDisposable.Dispose() { }

	}

	[CompilerGenerated]
	private sealed class <ReturnToMainMenu>d__229 : IEnumerator<Object>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private object <>2__current; //Field offset: 0x18
		public InGame <>4__this; //Field offset: 0x20
		private bool <returnToLastOpenMenu>5__2; //Field offset: 0x28

		private override object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[DebuggerHidden]
			private get { } //Length: 5
		}

		private override object System.Collections.IEnumerator.Current
		{
			[DebuggerHidden]
			private get { } //Length: 5
		}

		[DebuggerHidden]
		public <ReturnToMainMenu>d__229(int <>1__state) { }

		private override bool MoveNext() { }

		[DebuggerHidden]
		private override object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

		[DebuggerHidden]
		private override object System.Collections.IEnumerator.get_Current() { }

		[DebuggerHidden]
		private override void System.Collections.IEnumerator.Reset() { }

		[DebuggerHidden]
		private override void System.IDisposable.Dispose() { }

	}

	[CompilerGenerated]
	private sealed class <SetupSceneMapEditorMode>d__178 : IEnumerator<Object>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private object <>2__current; //Field offset: 0x18
		public InGame <>4__this; //Field offset: 0x20

		private override object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[DebuggerHidden]
			private get { } //Length: 5
		}

		private override object System.Collections.IEnumerator.Current
		{
			[DebuggerHidden]
			private get { } //Length: 5
		}

		[DebuggerHidden]
		public <SetupSceneMapEditorMode>d__178(int <>1__state) { }

		private override bool MoveNext() { }

		[DebuggerHidden]
		private override object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

		[DebuggerHidden]
		private override object System.Collections.IEnumerator.get_Current() { }

		[DebuggerHidden]
		private override void System.Collections.IEnumerator.Reset() { }

		[DebuggerHidden]
		private override void System.IDisposable.Dispose() { }

	}

	[CompilerGenerated]
	private struct <ShowEventPopup>d__358 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncVoidMethodBuilder <>t__builder; //Field offset: 0x8
		public InGame <>4__this; //Field offset: 0x28
		public bool pauseGame; //Field offset: 0x30
		public Action onEndCallback; //Field offset: 0x38
		public bool overrideDisablePopups; //Field offset: 0x40
		public string eventChecker; //Field offset: 0x48
		public string eventName; //Field offset: 0x50
		public string title; //Field offset: 0x58
		public string body; //Field offset: 0x60
		public bool showEverytime; //Field offset: 0x68
		private <>c__DisplayClass358_0 <>8__1; //Field offset: 0x70
		public float delay; //Field offset: 0x78
		private <>c__DisplayClass358_1 <>8__2; //Field offset: 0x80
		public bool overrideCancelSelection; //Field offset: 0x88
		public bool showHintPopup; //Field offset: 0x89
		public int image; //Field offset: 0x8C
		private YieldAwaiter <>u__1; //Field offset: 0x90
		private float <counter>5__2; //Field offset: 0x94
		private float <delayFrames>5__3; //Field offset: 0x98

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private sealed class <ShowVictoryScreen>d__199 : IEnumerator<Object>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private object <>2__current; //Field offset: 0x18
		public InGame <>4__this; //Field offset: 0x20
		public LootSet victoryLoot; //Field offset: 0x28

		private override object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[DebuggerHidden]
			private get { } //Length: 5
		}

		private override object System.Collections.IEnumerator.Current
		{
			[DebuggerHidden]
			private get { } //Length: 5
		}

		[DebuggerHidden]
		public <ShowVictoryScreen>d__199(int <>1__state) { }

		private override bool MoveNext() { }

		[DebuggerHidden]
		private override object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

		[DebuggerHidden]
		private override object System.Collections.IEnumerator.get_Current() { }

		[DebuggerHidden]
		private override void System.Collections.IEnumerator.Reset() { }

		[DebuggerHidden]
		private override void System.IDisposable.Dispose() { }

	}

	internal sealed class BossLeaderboardScoreReached : MulticastDelegate
	{

		public BossLeaderboardScoreReached(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(LeaderboardScoreData score, LeaderboardType leaderboardType, bool isNewBest, AsyncCallback callback, object object) { }

		public override void EndInvoke(IAsyncResult result) { }

		public override void Invoke(LeaderboardScoreData score, LeaderboardType leaderboardType, bool isNewBest) { }

	}

	internal class InGameMenuDef
	{
		public string id; //Field offset: 0x10
		public PrefabReference prefab; //Field offset: 0x18
		public Transform layoutRect; //Field offset: 0x20
		public int layerIndex; //Field offset: 0x28
		public bool permanent; //Field offset: 0x2C
		[LongEnumFlags(typeof(RuntimePlatform), False)]
		public long platformMask; //Field offset: 0x30

		public InGameMenuDef() { }

	}

	internal enum IntendedPlayButtonAction
	{
		START_NEW_ROUND = 0,
		FAST_FORWARD_ON = 1,
		FAST_FORWARD_OFF = 2,
	}

	internal sealed class OnInitialised : MulticastDelegate
	{

		public OnInitialised(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(AsyncCallback callback, object object) { }

		public override void EndInvoke(IAsyncResult result) { }

		public override void Invoke() { }

	}

	internal sealed class OnQuitToMainMenu : MulticastDelegate
	{

		public OnQuitToMainMenu(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(AsyncCallback callback, object object) { }

		public override void EndInvoke(IAsyncResult result) { }

		public override void Invoke() { }

	}

	private sealed class ProfanityFinish : MulticastDelegate
	{

		public ProfanityFinish(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(bool result, AsyncCallback callback, object object) { }

		public override void EndInvoke(IAsyncResult result) { }

		public override void Invoke(bool result) { }

	}

	private static class RacePauseSettings
	{
		public static readonly TimeSpan penaltyCooldown; //Field offset: 0x0
		public static readonly TimeSpan timePenalty; //Field offset: 0x8
		public static readonly TimeSpan increasingTimePenalty; //Field offset: 0x10
		public static readonly TimeSpan maxTimePenalty; //Field offset: 0x18

		private static RacePauseSettings() { }

	}

	internal sealed class StartBoss : MulticastDelegate
	{

		public StartBoss(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(AsyncCallback callback, object object) { }

		public override void EndInvoke(IAsyncResult result) { }

		public override void Invoke() { }

	}

	internal sealed class UpdateUi : MulticastDelegate
	{

		public UpdateUi(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(AsyncCallback callback, object object) { }

		public override void EndInvoke(IAsyncResult result) { }

		public override void Invoke() { }

	}

	public static InGame instance; //Field offset: 0x0
	private static String[] disabledTowerIds; //Field offset: 0x8
	public Camera sceneCamera; //Field offset: 0x20
	public Hotkeys hotkeys; //Field offset: 0x28
	[CompilerGenerated]
	private bool <lockTowerPurchases>k__BackingField; //Field offset: 0x30
	[CompilerGenerated]
	private bool <lockHeroPurchases>k__BackingField; //Field offset: 0x31
	[CompilerGenerated]
	private bool <simLockHeroPurchases>k__BackingField; //Field offset: 0x32
	[CompilerGenerated]
	private bool <simLockTowerPurchases>k__BackingField; //Field offset: 0x33
	public bool lockTowerUpgrades; //Field offset: 0x34
	public bool lockPowerActivations; //Field offset: 0x35
	public bool lockAbilities; //Field offset: 0x36
	public bool disableHomeButton; //Field offset: 0x37
	private GraphicRaycaster gRay; //Field offset: 0x38
	private PointerEventData pe; //Field offset: 0x40
	private List<RaycastResult> raycastResults; //Field offset: 0x48
	public RectTransform fullScreenRect; //Field offset: 0x50
	public RectTransform uiRect; //Field offset: 0x58
	public RectTransform mapRect; //Field offset: 0x60
	private BloonMenu bloonMenu; //Field offset: 0x68
	private InputManager inputManager; //Field offset: 0x70
	public List<GameObject> sceneSelectionExclusionList; //Field offset: 0x78
	public RectTransform sceneMarker; //Field offset: 0x80
	public InGameListeners inGameListeners; //Field offset: 0x88
	public NK_TextMeshProUGUI roundHintTxt; //Field offset: 0x90
	public Animator roundHintAnimator; //Field offset: 0x98
	public Button roundHintButton; //Field offset: 0xA0
	public float roundHintAutoHideTime; //Field offset: 0xA8
	private float roundHintTimer; //Field offset: 0xAC
	public Slider timeScaleSlider; //Field offset: 0xB0
	[CompilerGenerated]
	private ActiveKnowledge <ActiveKnowledge>k__BackingField; //Field offset: 0xB8
	private UnityToSimulation bridge; //Field offset: 0xC0
	private bool initialised; //Field offset: 0xC8
	private bool matchStarted; //Field offset: 0xC9
	private bool matchWon; //Field offset: 0xCA
	private bool matchLost; //Field offset: 0xCB
	private bool waitingForVictoryScreen; //Field offset: 0xCC
	private bool popupShowing; //Field offset: 0xCD
	private int lastSetHealth; //Field offset: 0xD0
	private int lastSetCash; //Field offset: 0xD4
	private int lastSetRound; //Field offset: 0xD8
	private bool monkeyTeamsViolated; //Field offset: 0xDC
	private bool completedMonkeyTeams; //Field offset: 0xDD
	private Btd6CoopGame coopGame; //Field offset: 0xE0
	private File<MapSaveDataModel> mapSaveFile; //Field offset: 0xE8
	public bool mapEditorInSandboxMode; //Field offset: 0xF0
	private int highestRoundHintShown; //Field offset: 0xF4
	public HudController hudController; //Field offset: 0xF8
	private string selectedNamedMonkeyKey; //Field offset: 0x100
	public DebugTowerGroupPlacer debugTowerGroupPlacer; //Field offset: 0x108
	[CompilerGenerated]
	private UpdateUi OnUpdate; //Field offset: 0x110
	[CompilerGenerated]
	private Action OnCoopReconnectCompleted; //Field offset: 0x118
	[CompilerGenerated]
	private Action OnCheckpointSaveCreated; //Field offset: 0x120
	private BloonCauseOfDefeat causeOfDefeat; //Field offset: 0x128
	[CompilerGenerated]
	private CustomMapManagers <CustomMapManagers>k__BackingField; //Field offset: 0x130
	[CompilerGenerated]
	private MapEditorSceneController <MapEditorSceneController>k__BackingField; //Field offset: 0x138
	public List<InGameMenuDef> inGameMenuDefs; //Field offset: 0x140
	private int currentRoundId; //Field offset: 0x148
	public bool forcePlayerSaveEndOfRound; //Field offset: 0x14C
	public bool hasSentEndGameAnalytics; //Field offset: 0x14D
	private bool _reviewMapMode; //Field offset: 0x14E
	private bool quitting; //Field offset: 0x14F
	[CompilerGenerated]
	private int <GameId>k__BackingField; //Field offset: 0x150
	[CompilerGenerated]
	private int <AttemptId>k__BackingField; //Field offset: 0x154
	[CompilerGenerated]
	private int <ContinuesUsed>k__BackingField; //Field offset: 0x158
	private double stepTarget; //Field offset: 0x160
	private bool stoppedClockForMenuOpen; //Field offset: 0x168
	private int lastHeroShortcutKeyActivationFrame; //Field offset: 0x16C
	public bool playBtnDisabled; //Field offset: 0x170
	private Dictionary<String, Tuple`2<String, Int32>> firstTimeBloonTagLocs; //Field offset: 0x178
	public int goldenBloonsPopped; //Field offset: 0x180
	public int goldenBloonMMEarnt; //Field offset: 0x184
	[CompilerGenerated]
	private Nullable<LeaderboardScoreData> <PreviousBosssLeaderboardScore>k__BackingField; //Field offset: 0x188
	[CompilerGenerated]
	private List<Nullable`1<LeaderboardScoreData>> <SubmittedBosssLeaderboardScores>k__BackingField; //Field offset: 0x1A0
	private CancellationTokenSource customMapCancallationSource; //Field offset: 0x1A8
	private string tier5BossLoot; //Field offset: 0x1B0
	private DateTime lastPauseResumeTime; //Field offset: 0x1B8
	private KonFuze cooledDownPauseCount; //Field offset: 0x1C0
	private TimeSpan raceTimePenalty; //Field offset: 0x1C8

	public event Action OnCheckpointSaveCreated
	{
		[CompilerGenerated]
		 add { } //Length: 158
		[CompilerGenerated]
		 remove { } //Length: 158
	}

	public event Action OnCoopReconnectCompleted
	{
		[CompilerGenerated]
		 add { } //Length: 158
		[CompilerGenerated]
		 remove { } //Length: 158
	}

	public event UpdateUi OnUpdate
	{
		[CompilerGenerated]
		 add { } //Length: 158
		[CompilerGenerated]
		 remove { } //Length: 158
	}

	public ActiveKnowledge ActiveKnowledge
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 8
	}

	public AnalyticsEventGroup AnalyticsGroup
	{
		 get { } //Length: 206
	}

	public int AttemptId
	{
		[CompilerGenerated]
		 get { } //Length: 7
		[CompilerGenerated]
		 set { } //Length: 7
	}

	public BloonMenu BloonMenu
	{
		 get { } //Length: 5
	}

	public static UnityToSimulation Bridge
	{
		 get { } //Length: 149
	}

	public bool CanUseSaveFile
	{
		 get { } //Length: 408
	}

	public string ChallengeId
	{
		 get { } //Length: 333
	}

	public int ContinuesUsed
	{
		[CompilerGenerated]
		 get { } //Length: 7
		[CompilerGenerated]
		 set { } //Length: 7
	}

	public Nullable<TimeSpan> CoopAvgLatency
	{
		 get { } //Length: 155
	}

	public Nullable<TimeSpan> CoopLatencyVariance
	{
		 get { } //Length: 155
	}

	public string CoopLobbyId
	{
		 get { } //Length: 79
	}

	public Nullable<Int32> CoopPlayerCount
	{
		 get { } //Length: 195
	}

	public Dictionary<String, String> CurrentGameMetaData
	{
		 get { } //Length: 71
	}

	public private CustomMapManagers CustomMapManagers
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 8
	}

	private bool DisableHints
	{
		private get { } //Length: 204
	}

	private bool DisablePopups
	{
		private get { } //Length: 268
	}

	public bool DisableSaveFileIfNoCheckpointReached
	{
		 get { } //Length: 135
	}

	public private int GameId
	{
		[CompilerGenerated]
		 get { } //Length: 7
		[CompilerGenerated]
		private set { } //Length: 7
	}

	public GameType GameType
	{
		 get { } //Length: 68
	}

	public InputManager InputManager
	{
		 get { } //Length: 5
	}

	private bool IsActiveRace
	{
		private get { } //Length: 270
	}

	public bool IsApopalypse
	{
		 get { } //Length: 111
	}

	public bool IsChallengeMode
	{
		 get { } //Length: 265
	}

	public bool IsCoop
	{
		 get { } //Length: 12
	}

	public bool IsCustomMapPlayMode
	{
		 get { } //Length: 196
	}

	public bool IsEditingMap
	{
		 get { } //Length: 293
	}

	private bool IsFreePlay
	{
		private get { } //Length: 113
	}

	public bool IsHeroPurchasesLocked
	{
		 get { } //Length: 13
	}

	public bool IsMovieclipPlaying
	{
		 get { } //Length: 22
	}

	public bool IsOldTutorial
	{
		 get { } //Length: 69
	}

	public bool IsQuestPlayMode
	{
		 get { } //Length: 73
	}

	private bool IsRogueBossGame
	{
		private get { } //Length: 150
	}

	public bool IsTowerPurchasesLocked
	{
		 get { } //Length: 13
	}

	public bool IsTutorial
	{
		 get { } //Length: 132
	}

	private LegendsDataModel LegendsData
	{
		private get { } //Length: 81
	}

	public bool lockHeroPurchases
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		 set { } //Length: 4
	}

	public bool lockTowerPurchases
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		 set { } //Length: 86
	}

	public string MapDataSaveId
	{
		 get { } //Length: 369
	}

	public private MapEditorSceneController MapEditorSceneController
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 8
	}

	public bool MatchLost
	{
		 get { } //Length: 8
	}

	private DateTime Now
	{
		private get { } //Length: 7
	}

	private Btd6Player Player
	{
		private get { } //Length: 7
	}

	public private Nullable<LeaderboardScoreData> PreviousBosssLeaderboardScore
	{
		[CompilerGenerated]
		 get { } //Length: 27
		[CompilerGenerated]
		private set { } //Length: 24
	}

	public int Rcs
	{
		 get { } //Length: 448
	}

	public private bool ReviewMapMode
	{
		 get { } //Length: 8
		private set { } //Length: 444
	}

	private RogueGameSaveData RogueSaveData
	{
		private get { } //Length: 227
	}

	public bool SelectedCoopMode
	{
		 get { } //Length: 69
	}

	public string SelectedDifficulty
	{
		 get { } //Length: 69
	}

	private string SelectedHero
	{
		private get { } //Length: 81
	}

	public string SelectedMap
	{
		 get { } //Length: 69
	}

	public string SelectedMode
	{
		 get { } //Length: 69
	}

	public MapDifficulty SelectedTrackDifficulty
	{
		 get { } //Length: 243
	}

	public private bool simLockHeroPurchases
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 4
	}

	public private bool simLockTowerPurchases
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 4
	}

	public SubGameType SubGameType
	{
		 get { } //Length: 68
	}

	public private List<Nullable`1<LeaderboardScoreData>> SubmittedBosssLeaderboardScores
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 8
	}

	public int TileId
	{
		 get { } //Length: 171
	}

	private static Client TwitchClient
	{
		private get { } //Length: 54
	}

	public bool WaitingForVictoryScreen
	{
		 get { } //Length: 8
	}

	public InGame() { }

	[CompilerGenerated]
	private void <SetupSceneMapEditorMode>b__178_0(AsyncOperationHandle<GameObject> h) { }

	[CompilerGenerated]
	private void <StartMatchApop>b__254_0() { }

	[CompilerGenerated]
	private void <TryQuitToMenu>b__208_0() { }

	[CompilerGenerated]
	public void add_OnCheckpointSaveCreated(Action value) { }

	[CompilerGenerated]
	public void add_OnCoopReconnectCompleted(Action value) { }

	[CompilerGenerated]
	public void add_OnUpdate(UpdateUi value) { }

	private void AddCollectionEventRewards(LootSet victoryLoot) { }

	private void AddMonkeyMoneyRewards(LootSet victoryLoot) { }

	public bool AreStatsRecorded() { }

	private void Awake() { }

	private void BossDefeated(int bossTier) { }

	public bool CanEarnPlayerAndTowerXP() { }

	public bool CanEarnTowerXP() { }

	public bool CanPause() { }

	public void CashChanged() { }

	public void CheatSetCash() { }

	public void CheatSetHealth() { }

	public void CheatSetRound() { }

	private void CheckAndGiftInsta(int completedRound) { }

	private void CheckAndShowHintMessage() { }

	private void CheckFirstTimeBloons() { }

	public void CheckFirstTimeTriggers(int round) { }

	private void CheckForCompletedAchievements(bool justWon) { }

	public void CheckForMissedBossTierRewards(int lastBossTierDefeated) { }

	[AsyncStateMachine(typeof(<CheckForProfanity>d__350))]
	private void CheckForProfanity(string str, ProfanityFinish callOnFinish) { }

	public void CheckForQuestAndBind(bool bindListeners = true, bool isLoadingSave = false) { }

	public void CheckGameType() { }

	private void CheckMonkeyTeams(MapSaveDataModel mapSaveData) { }

	private void CheckOdysseyEditorWinScenario() { }

	private void CheckShortcutKeys() { }

	private void CleanUpAllCancellationTokens() { }

	public void CleanUpCustomMapCancellationToken() { }

	public bool ClockStopped() { }

	public bool CompletedMonkeyTeams() { }

	public void Continue() { }

	public void ContinueFromCheckpoint(bool canCreateMapSave, ref MapSaveDataModel saveData) { }

	public void CopyOrMoveProp(PropToSimulation prop, bool copyProp = false, bool overrideCursorModeFollowTouch = false) { }

	private MapSaveDataModel CreateCurrentMapSave(int highestCompletedRound, string mapSaveId) { }

	private void CreateMapSave(int completedRound, int highestCompletedRound) { }

	private void DeactivateEverything() { }

	public void DeleteAllBloons() { }

	public void DeleteAllTowers() { }

	private void DrainXpAndCheckLevelUp() { }

	public Task DrawCustomMapBackground(CancellationToken cancellationToken, bool useRedrawLayerMask = false) { }

	private void EndTrackAnalytics(EndMapState endMapState) { }

	public void ForceDefeat() { }

	[CompilerGenerated]
	public ActiveKnowledge get_ActiveKnowledge() { }

	public AnalyticsEventGroup get_AnalyticsGroup() { }

	[CompilerGenerated]
	public int get_AttemptId() { }

	public BloonMenu get_BloonMenu() { }

	public static UnityToSimulation get_Bridge() { }

	public bool get_CanUseSaveFile() { }

	public string get_ChallengeId() { }

	[CompilerGenerated]
	public int get_ContinuesUsed() { }

	public Nullable<TimeSpan> get_CoopAvgLatency() { }

	public Nullable<TimeSpan> get_CoopLatencyVariance() { }

	public string get_CoopLobbyId() { }

	public Nullable<Int32> get_CoopPlayerCount() { }

	public Dictionary<String, String> get_CurrentGameMetaData() { }

	[CompilerGenerated]
	public CustomMapManagers get_CustomMapManagers() { }

	private bool get_DisableHints() { }

	private bool get_DisablePopups() { }

	public bool get_DisableSaveFileIfNoCheckpointReached() { }

	[CompilerGenerated]
	public int get_GameId() { }

	public GameType get_GameType() { }

	public InputManager get_InputManager() { }

	private bool get_IsActiveRace() { }

	public bool get_IsApopalypse() { }

	public bool get_IsChallengeMode() { }

	public bool get_IsCoop() { }

	public bool get_IsCustomMapPlayMode() { }

	public bool get_IsEditingMap() { }

	private bool get_IsFreePlay() { }

	public bool get_IsHeroPurchasesLocked() { }

	public bool get_IsMovieclipPlaying() { }

	public bool get_IsOldTutorial() { }

	public bool get_IsQuestPlayMode() { }

	private bool get_IsRogueBossGame() { }

	public bool get_IsTowerPurchasesLocked() { }

	public bool get_IsTutorial() { }

	private LegendsDataModel get_LegendsData() { }

	[CompilerGenerated]
	public bool get_lockHeroPurchases() { }

	[CompilerGenerated]
	public bool get_lockTowerPurchases() { }

	public string get_MapDataSaveId() { }

	[CompilerGenerated]
	public MapEditorSceneController get_MapEditorSceneController() { }

	public bool get_MatchLost() { }

	private DateTime get_Now() { }

	private Btd6Player get_Player() { }

	[CompilerGenerated]
	public Nullable<LeaderboardScoreData> get_PreviousBosssLeaderboardScore() { }

	public int get_Rcs() { }

	public bool get_ReviewMapMode() { }

	private RogueGameSaveData get_RogueSaveData() { }

	public bool get_SelectedCoopMode() { }

	public string get_SelectedDifficulty() { }

	private string get_SelectedHero() { }

	public string get_SelectedMap() { }

	public string get_SelectedMode() { }

	public MapDifficulty get_SelectedTrackDifficulty() { }

	[CompilerGenerated]
	public bool get_simLockHeroPurchases() { }

	[CompilerGenerated]
	public bool get_simLockTowerPurchases() { }

	public SubGameType get_SubGameType() { }

	[CompilerGenerated]
	public List<Nullable`1<LeaderboardScoreData>> get_SubmittedBosssLeaderboardScores() { }

	public int get_TileId() { }

	private static Client get_TwitchClient() { }

	public bool get_WaitingForVictoryScreen() { }

	private string GetAnalyticEventId(GameType gameType) { }

	private string GetAnalyticMode(GameType gameType, string mapName) { }

	public LeaderboardScoreData GetBossLeaderboardScore(LeaderboardScoringType scoringType, BossEvent bossEvent) { }

	public BossScoreComponents GetBossScoreComponents() { }

	public string GetCheckpointAnalyticName(bool isRetryLastRound) { }

	public KonFuze GetCheckpointCost() { }

	public KonFuze GetContinueCost() { }

	private string GetContinueSaveId() { }

	public CustomInput GetCustomInput(PropToSimulation prop, string customInputId = null, string buttonId = null) { }

	public CustomInput GetCustomInput(TowerToSimulation tower, string customInputId = null, string buttonId = null) { }

	public static CustomInput GetCustomInputAbility(AbilityToSimulation ability, bool onAbilityActived = true) { }

	public CustomInput GetCustomInputAttacks(TowerToSimulation tower, string customInputId) { }

	public CustomInput GetCustomInputTargetType(TowerToSimulation tower) { }

	public static CustomInput GetCustomInputTowerBehavior(TowerToSimulation towerToSim, string buttonId) { }

	public CancellationToken GetCustomMapCancellationToken() { }

	public CustomMapModel GetCustomMapModelWithVisibleLayers(CustomMapModel customMapModel) { }

	public Options GetCustomMapRenderOptions(bool forceRenderOptionsForPlay = false) { }

	private SummaryScreenData GetDefeatSceneData(string defeatSceneName, int finalRound, List<BloonCoDData> bloonCoDList, KonFuze continueCost) { }

	private string GetDefeatSceneName() { }

	private int GetIncrementedGameId() { }

	private int GetInsta100Tier(MapDifficulty mapDifficulty, int completedRound) { }

	public MapSaveDataModel GetLastRoundMapSaveData() { }

	public int GetLatestCheckpointRound(int currRound) { }

	public int GetMonkeyTeamsMMReward() { }

	public GameObject GetObjectFromPointer() { }

	private string GetRoundHint() { }

	protected int GetStartRound() { }

	public Vector2 GetUIFromWorld(Vector2 worldPos, bool clamp = true) { }

	public Vector3 GetUnityWorldFromCursor() { }

	public LootSet GetVictoryLoot() { }

	private string GetVictorySceneName(GameType gameType, Btd6CoopGame coopGame) { }

	private SummaryScreenData GetVictoryScreenData(LootSet victoryLoot, string victorySceneName) { }

	public Vector2 GetWorldFromNormalizedUI(Vector2 uiPos) { }

	public Vector2 GetWorldFromPointer(Vector2 pointerPos) { }

	public Vector2 GetWorldFromUI(Vector2 uiPos) { }

	private void GoBackToCoopAfterRejoining() { }

	private bool HandleHeroShorcutKey() { }

	public bool HasCustomInput(TowerToSimulation tower, string customInputId, string buttonId) { }

	public bool HitScene(bool includeExclusions = false) { }

	public bool HitTestWorld(out RaycastHit hitInfo, int layerMask = 2147483647) { }

	public void HotkeysChanged() { }

	public void IncrementGameID(MapSaveDataModel mapSaveData) { }

	private void IncrementGamesPlayed() { }

	[IteratorStateMachine(typeof(<Initialise>d__167))]
	public IEnumerator Initialise(Btd6CoopGame coopGame) { }

	[IteratorStateMachine(typeof(<InstantiateUiObject>d__168))]
	public IEnumerator InstantiateUiObject(string id, Action<GameObject> onComplete = null) { }

	[IteratorStateMachine(typeof(<InstantiateUiObject>d__169))]
	private IEnumerator InstantiateUiObject(InGameMenuDef menuDef, Action<GameObject> onComplete = null) { }

	public bool IsBlockingHotkeys() { }

	public bool IsCreationMode() { }

	public bool IsCursorInWorld() { }

	public bool IsCursorInWorldIncludingUiElements() { }

	private bool IsFirstRound() { }

	public bool IsHeroBoostAllowed() { }

	public bool IsMapCompletionAndRewardsAllowed(bool isCoopMode) { }

	public bool IsMapEditorModeBlockingHotkeys() { }

	private bool IsOdyssey(DailyChallengeModel dcModel) { }

	public bool IsOdysseyFinalMapVictory() { }

	public bool IsQuestRetryFromCheckpointAvailable(out int cost, out int roundBracketSelected) { }

	public bool IsQuestRetryLastRoundAvailable(int round, out int cost, out int roundBracketSelected, bool retryFromCheckpointOnly = false) { }

	public bool IsRoundSeenAllowed() { }

	public bool IsUserPlayMode() { }

	public void LateRestart() { }

	public void Lose() { }

	private Vector2 NormalisedMapCursorPosition() { }

	private void OnAddMapAssetEventsTriggered(bool disableAmbientMapFx, PrefabReference[] fXPrefabs) { }

	public void OnApplicationPause(bool pauseStatus) { }

	public void OnCoopReturnHomeCallback() { }

	private void OnDestroy() { }

	public void OnLockHeroPurchasesChanged(bool value) { }

	public void OnLockTowerPurchasesChanged(bool value) { }

	public void OnReconnected() { }

	private void OnSetCash(int value) { }

	private void OnSetNamedMonkeyName(string name) { }

	public void OnSetRound(int value) { }

	private void OnSetSandboxHealth(int value) { }

	public void OnShowSummaryScreenClicked() { }

	public static void OnTowerPollFailed(Exception _) { }

	public static void OnTowerPollFinished(List<String> winningTowerIds) { }

	public void OnVictory() { }

	public bool OverrideOpenPauseMenu() { }

	private void PauseRace() { }

	private void Player_OnSaveCompleted(object sender, EventArgs e) { }

	public void PlayFastForwardClicked(IntendedPlayButtonAction intendedAction) { }

	public void PoppedGoldenBloon(int mmEarnt) { }

	public void QuickRestart() { }

	public void QuickSetCash() { }

	public void QuickSetHealth() { }

	public void Quit(bool afterWinOrLoss = false) { }

	public void QuitToMainMenu() { }

	public void QuitToMenuFromTutorial(bool isVitory) { }

	public void RecoveredFromDesync(MapSaveDataModel save) { }

	[CompilerGenerated]
	public void remove_OnCheckpointSaveCreated(Action value) { }

	[CompilerGenerated]
	public void remove_OnCoopReconnectCompleted(Action value) { }

	[CompilerGenerated]
	public void remove_OnUpdate(UpdateUi value) { }

	public void RemoveCurrentMapSave(bool canClearCheckpoints) { }

	private void ReopenSummaryScreen() { }

	private void ReportStartTrackAnalytics(bool isRestart, bool wasSaveOverwritten) { }

	private void ResetClock() { }

	private void ResetTwitchPoll() { }

	public void Restart() { }

	public void ResumeClock(bool allowTimePenalty = true) { }

	private void ResumeRace() { }

	public void RetrieveTopScoreAndPostAnalytics(EndMapState wonLostQuit) { }

	[IteratorStateMachine(typeof(<ReturnToMainMenu>d__229))]
	private IEnumerator ReturnToMainMenu() { }

	public void RoundEnd(int completedRound, int highestCompletedRound) { }

	private void RoundHintClicked() { }

	public void RoundStart(int roundArrayIndex) { }

	private void RunRestart() { }

	private Vector2 ScreenPosToCanvas(Vector2 screenPos) { }

	private Vector2 ScreenPosToUI(Vector2 screenPos) { }

	public void SellProp(PropToSimulation prop) { }

	public void SellTower(TowerToSimulation tower) { }

	[CompilerGenerated]
	public void set_ActiveKnowledge(ActiveKnowledge value) { }

	[CompilerGenerated]
	public void set_AttemptId(int value) { }

	[CompilerGenerated]
	public void set_ContinuesUsed(int value) { }

	[CompilerGenerated]
	private void set_CustomMapManagers(CustomMapManagers value) { }

	[CompilerGenerated]
	private void set_GameId(int value) { }

	[CompilerGenerated]
	public void set_lockHeroPurchases(bool value) { }

	[CompilerGenerated]
	public void set_lockTowerPurchases(bool value) { }

	[CompilerGenerated]
	private void set_MapEditorSceneController(MapEditorSceneController value) { }

	[CompilerGenerated]
	private void set_PreviousBosssLeaderboardScore(Nullable<LeaderboardScoreData> value) { }

	private void set_ReviewMapMode(bool value) { }

	[CompilerGenerated]
	private void set_simLockHeroPurchases(bool value) { }

	[CompilerGenerated]
	private void set_simLockTowerPurchases(bool value) { }

	[CompilerGenerated]
	private void set_SubmittedBosssLeaderboardScores(List<Nullable`1<LeaderboardScoreData>> value) { }

	public void SetBridge(UnityToSimulation bridge) { }

	public void SetMapSaveFile(MapSaveDataModel saveData) { }

	public void SetNamedMonkeyName(string value) { }

	private void SetRichPresenceStatus() { }

	[IteratorStateMachine(typeof(<SetupSceneMapEditorMode>d__178))]
	private IEnumerator SetupSceneMapEditorMode() { }

	[AsyncStateMachine(typeof(<ShowEventPopup>d__358))]
	public void ShowEventPopup(string eventName, int image, bool showEverytime = false, Action onEndCallback = null, float delay = 0.5, string eventChecker = "", string title = "", string body = "", bool pauseGame = true, bool overrideDisablePopups = false, bool showHintPopup = false, bool overrideCancelSelection = false) { }

	public void ShowPopupForCoopDeflation() { }

	public void ShowPurchasePowerUpScreen(PowerModel powerModel, bool showUpgrades) { }

	public void ShowUpgradeTree() { }

	public void ShowUpgradeTree(TowerModel towerModel, bool doubleTapTowerPanel = false) { }

	[IteratorStateMachine(typeof(<ShowVictoryScreen>d__199))]
	private IEnumerator ShowVictoryScreen(LootSet victoryLoot) { }

	private void StartBossGame() { }

	public void StartFreePlay() { }

	public void StartListeners() { }

	public void StartMapReview() { }

	public void StartMatch(MapSaveDataModel mapSaveData, bool wasSaveOverwritten) { }

	private void StartMatchApop() { }

	public void StartTutorial() { }

	public void StopClock(bool allowTimePenalty = true) { }

	public static void SubscribeToTowerPoll() { }

	public void TowerCreated(TowerToSimulation tower) { }

	public void TowerDestroyed(TowerToSimulation tower) { }

	public void TowerReleased(string towerId) { }

	public void TowerUpgraded(TowerToSimulation tower) { }

	public void TriggerCoopDisconnectDefeat(string reason) { }

	public void TryQuitToMenu(ReturnCallback cancelCallback) { }

	public void UnlocksChanged() { }

	public static void UnsubscribeFromTowerPoll() { }

	private void Update() { }

	private void UpdateGeraldoPlayerStatistics() { }

	public void UpdateLeaks(Bloon bloon, float livesBefore, float livesAfter) { }

	private void UpdatePlayerWinStats() { }

	private void UpdateProfileAnalytics(AnalyticsKonFuze change, bool isCoop) { }

	public void UpdateRoundForMap(int round, bool isSet) { }

	private void UpdateSimulation() { }

	public void UpgradesChanged() { }

	public void XpChanged() { }

}

