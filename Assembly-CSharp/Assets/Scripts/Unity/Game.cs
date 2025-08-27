namespace Assets.Scripts.Unity;

public class Game : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func<ModModel, IEnumerable`1<MutatorModModel>> <>9__64_2; //Field offset: 0x8
		public static ReturnCallback <>9__74_0; //Field offset: 0x10

		private static <>c() { }

		public <>c() { }

		internal IEnumerable<MutatorModModel> <GetMonkeyMoneyReward>b__64_2(ModModel m) { }

		internal void <ShowLoginWebView>b__74_0() { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass64_0
	{
		public string difficulty; //Field offset: 0x10
		public string mode; //Field offset: 0x18

		public <>c__DisplayClass64_0() { }

		internal bool <GetMonkeyMoneyReward>b__0(ModModel m) { }

		internal int <GetMonkeyMoneyReward>b__1(ModModel m) { }

	}

	[CompilerGenerated]
	private struct <LoadGameModel>d__50 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public Game <>4__this; //Field offset: 0x20
		private TaskAwaiter<GameModel> <>u__1; //Field offset: 0x28
		private TaskAwaiter <>u__2; //Field offset: 0x30

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <LoadWebview>d__75 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncVoidMethodBuilder <>t__builder; //Field offset: 0x8
		private TaskAwaiter <>u__1; //Field offset: 0x28

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <LogOutAndReloadFromScratch>d__52 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncVoidMethodBuilder <>t__builder; //Field offset: 0x8
		public Game <>4__this; //Field offset: 0x28
		private TaskAwaiter <>u__1; //Field offset: 0x30

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <SetupAchievements>d__47 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public Game <>4__this; //Field offset: 0x20
		private ProfileModel <playerData>5__2; //Field offset: 0x28
		private TaskAwaiter<DailyChallengeModel> <>u__1; //Field offset: 0x30

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <ShowLoginWebView>d__74 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncVoidMethodBuilder <>t__builder; //Field offset: 0x8
		public Game <>4__this; //Field offset: 0x28
		private List<String> <blockedHostnames>5__2; //Field offset: 0x30
		private TaskAwaiter<List`1<String>> <>u__1; //Field offset: 0x38

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	internal sealed class UpdateGame : MulticastDelegate
	{

		public UpdateGame(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(AsyncCallback callback, object object) { }

		public override void EndInvoke(IAsyncResult result) { }

		public override void Invoke() { }

	}

	public static Game instance; //Field offset: 0x0
	private const string kShortCodeCacheKey = "playerShortCode"; //Field offset: 0x0
	private static Version _version; //Field offset: 0x8
	private static bool _isOfflineMode; //Field offset: 0x10
	public GameModel model; //Field offset: 0x20
	public AudioSource audioSource; //Field offset: 0x28
	public GameObject prototypeObjects; //Field offset: 0x30
	public GameObject displayObjects; //Field offset: 0x38
	public AudioFactory audioFactory; //Field offset: 0x40
	public Camera sceneCamera; //Field offset: 0x48
	public GameObject coopLayouts; //Field offset: 0x50
	private PlayerService _playerService; //Field offset: 0x58
	public AchievementManager achievementManager; //Field offset: 0x60
	public Scene scene; //Field offset: 0x68
	public TowerGoalUnlockManager towerGoalUnlockManager; //Field offset: 0x70
	public QuestTrackerManager questTrackerManager; //Field offset: 0x78
	public RogueLegendsManager legendsManager; //Field offset: 0x80
	public SweepstakesDataHelper sweepstakesDataHelper; //Field offset: 0x88
	public PowersProDataHelper powersProDataHelper; //Field offset: 0x90
	[CompilerGenerated]
	private GameEditorManager <GameEditorManager>k__BackingField; //Field offset: 0x98
	[CompilerGenerated]
	private UpdateGame OnUpdate; //Field offset: 0xA0

	public event UpdateGame OnUpdate
	{
		[CompilerGenerated]
		 add { } //Length: 158
		[CompilerGenerated]
		 remove { } //Length: 158
	}

	public AnalyticsManager analyticsManager
	{
		 get { } //Length: 223
	}

	public static bool CanUseTrophyStore
	{
		 get { } //Length: 237
	}

	public static bool DisableNudgeMode
	{
		 get { } //Length: 56
	}

	public static bool DragAndDrop
	{
		 get { } //Length: 144
	}

	public static bool DropAndLock
	{
		 get { } //Length: 144
	}

	private static string DropAndLockKey
	{
		private get { } //Length: 135
	}

	public private GameEditorManager GameEditorManager
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 8
	}

	public private static bool IsOfflineMode
	{
		 get { } //Length: 55
		private set { } //Length: 65
	}

	public static string LiNKDisplayName
	{
		 get { } //Length: 94
	}

	private static string MapSaveDataPath
	{
		private get { } //Length: 163
	}

	public static Btd6Player Player
	{
		 get { } //Length: 231
	}

	public PlayerService playerService
	{
		 get { } //Length: 160
	}

	public static Version Version
	{
		 get { } //Length: 184
	}

	public Game() { }

	[CompilerGenerated]
	public void add_OnUpdate(UpdateGame value) { }

	private void Awake() { }

	public void CheckMapDataAndSave() { }

	public static void DeleteBackupMapSave() { }

	private static void DestroyActiveScenes() { }

	public static void EnableOfflineMode() { }

	public AnalyticsManager get_analyticsManager() { }

	public static bool get_CanUseTrophyStore() { }

	public static bool get_DisableNudgeMode() { }

	public static bool get_DragAndDrop() { }

	public static bool get_DropAndLock() { }

	private static string get_DropAndLockKey() { }

	[CompilerGenerated]
	public GameEditorManager get_GameEditorManager() { }

	public static bool get_IsOfflineMode() { }

	public static string get_LiNKDisplayName() { }

	private static string get_MapSaveDataPath() { }

	public static Btd6Player get_Player() { }

	public PlayerService get_playerService() { }

	public static Version get_Version() { }

	public CoopAreaLayout[] GetCoopAreaLayoutsForDivision(CoopDivision division) { }

	public static string GetLocalizedDisplayPlayerId() { }

	public static string GetLocalizedDisplayVersion() { }

	public int GetMonkeyMoneyReward(string map, string difficulty, string mode, GameModel useModel, bool outsideGame, bool coopMode) { }

	public int GetOdysseyMMReward(string map, string trackDifficulty, string mode, GameModel useModel) { }

	[AsyncStateMachine(typeof(<LoadGameModel>d__50))]
	public Task LoadGameModel() { }

	public static File<MapSaveDataModel> LoadMapSave() { }

	[AsyncStateMachine(typeof(<LoadWebview>d__75))]
	private void LoadWebview() { }

	[AsyncStateMachine(typeof(<LogOutAndReloadFromScratch>d__52))]
	public void LogOutAndReloadFromScratch() { }

	private void OnDestroy() { }

	public static void ReloadTheWholeGameFromScratch() { }

	[CompilerGenerated]
	public void remove_OnUpdate(UpdateGame value) { }

	[CompilerGenerated]
	private void set_GameEditorManager(GameEditorManager value) { }

	private static void set_IsOfflineMode(bool value) { }

	[AsyncStateMachine(typeof(<SetupAchievements>d__47))]
	public Task SetupAchievements() { }

	private void SetUpCameras() { }

	private void SetUpRendering() { }

	[AsyncStateMachine(typeof(<ShowLoginWebView>d__74))]
	public void ShowLoginWebView() { }

	public void StartAnalytics() { }

	private static void TryDeleteFile(string filePath) { }

	public static bool TryGetPlayerShortCode(out string playerShortCode) { }

	private static void UnhandledExceptionHandler(object sender, UnhandledExceptionEventArgs args) { }

	private void Update() { }

	public static void UpdateShortCodeCache(string shortCode) { }

}

