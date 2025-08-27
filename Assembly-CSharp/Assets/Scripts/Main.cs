namespace Assets.Scripts;

public class Main : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static SystemDetailValue <>9__14_0; //Field offset: 0x8
		public static SystemDetailValue <>9__14_1; //Field offset: 0x10
		public static SystemDetailValue <>9__14_2; //Field offset: 0x18
		public static Func<Exception, Boolean> <>9__23_2; //Field offset: 0x20
		public static Func<Exception, Boolean> <>9__23_3; //Field offset: 0x28
		public static Func<Exception, Boolean> <>9__25_0; //Field offset: 0x30
		public static Func<Task> <>9__31_3; //Field offset: 0x38
		public static Func<Task> <>9__31_4; //Field offset: 0x40
		public static Action<LiNKAccount> <>9__44_1; //Field offset: 0x48
		public static Action<LiNKAccount> <>9__44_2; //Field offset: 0x50
		public static Action<LiNKAccount> <>9__44_3; //Field offset: 0x58
		public static Action<LiNKAccount> <>9__44_4; //Field offset: 0x60
		public static Func<Byte, String> <>9__48_0; //Field offset: 0x68

		private static <>c() { }

		public <>c() { }

		internal string <GetSteamSessionTicket>b__48_0(byte b) { }

		internal Task <InitialLoadTasks>b__31_3() { }

		internal Task <InitialLoadTasks>b__31_4() { }

		internal bool <LoadingSequence>b__23_2(Exception x) { }

		internal bool <LoadingSequence>b__23_3(Exception x) { }

		internal void <LoadPlayer>b__44_1(LiNKAccount newAccount) { }

		internal void <LoadPlayer>b__44_2(LiNKAccount _) { }

		internal void <LoadPlayer>b__44_3(LiNKAccount _) { }

		internal void <LoadPlayer>b__44_4(LiNKAccount _) { }

		internal string <SetupErrorHandler>b__14_0() { }

		internal string <SetupErrorHandler>b__14_1() { }

		internal string <SetupErrorHandler>b__14_2() { }

		internal bool <ShowPlayerLoadingErrorPopup>b__25_0(Exception ex) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass23_0
	{
		public Task initialLoadTasks; //Field offset: 0x10
		public Task playerLoadTasks; //Field offset: 0x18

		public <>c__DisplayClass23_0() { }

		internal bool <LoadingSequence>b__0() { }

		internal bool <LoadingSequence>b__1() { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass25_0
	{
		public AggregateException aggregateException; //Field offset: 0x10

		public <>c__DisplayClass25_0() { }

		internal void <ShowPlayerLoadingErrorPopup>b__1() { }

		internal void <ShowPlayerLoadingErrorPopup>b__2() { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass27_0
	{
		public Task task; //Field offset: 0x10

		public <>c__DisplayClass27_0() { }

		internal bool <LoadLocs>b__0() { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass31_0
	{
		public InitialLoadingScreen loadingScreen; //Field offset: 0x10

		public <>c__DisplayClass31_0() { }

		internal Task <InitialLoadTasks>b__0() { }

		internal Task <InitialLoadTasks>b__1() { }

		internal Task <InitialLoadTasks>b__2() { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass37_0
	{
		public string modelName; //Field offset: 0x10
		public Func<String, Boolean> <>9__0; //Field offset: 0x18

		public <>c__DisplayClass37_0() { }

		internal bool <IsOutdatedDevice>b__0(string s) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass44_0
	{
		public Main <>4__this; //Field offset: 0x10
		public PlayerService playerService; //Field offset: 0x18

		public <>c__DisplayClass44_0() { }

		internal void <LoadPlayer>b__0(LiNKAccount _) { }

	}

	[CompilerGenerated]
	private struct <CheckForceOrSoftUpdate>d__38 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public VersionSettings versionSettings; //Field offset: 0x20
		public InitialLoadingScreen loadingScreen; //Field offset: 0x28
		private bool <isForceUpdateEnabled>5__2; //Field offset: 0x30
		private bool <isSoftUpdateEnabled>5__3; //Field offset: 0x31
		private bool <canShowUpdatePrompt>5__4; //Field offset: 0x32
		private TaskAwaiter<UpdatePromptClick> <>u__1; //Field offset: 0x38

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <CheckVersionAsync>d__36 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public InitialLoadingScreen loadingScreen; //Field offset: 0x20
		private TaskAwaiter <>u__1; //Field offset: 0x28

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <InitGameData>d__39 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public Main <>4__this; //Field offset: 0x20
		private TaskAwaiter<ScriptableObject> <>u__1; //Field offset: 0x28

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private sealed class <Initialize>d__22 : IEnumerator<Object>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private object <>2__current; //Field offset: 0x18
		public bool isFirstLoad; //Field offset: 0x20
		public Main <>4__this; //Field offset: 0x28
		public Action onLoadingComplete; //Field offset: 0x30

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
		public <Initialize>d__22(int <>1__state) { }

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
	private struct <InitialLoadTasks>d__31 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public InitialLoadingScreen loadingScreen; //Field offset: 0x20
		public bool isFirstLoad; //Field offset: 0x28
		public Main <>4__this; //Field offset: 0x30
		private <>c__DisplayClass31_0 <>8__1; //Field offset: 0x38
		private LocalizationManager <loc>5__2; //Field offset: 0x40
		private List<KeyValuePair`2<String, Func`1<Task>>> <tasks>5__3; //Field offset: 0x48
		private int <taskIdx>5__4; //Field offset: 0x50
		private Enumerator<KeyValuePair<String, Func`1<Task>>> <>7__wrap4; //Field offset: 0x58
		private TaskAwaiter <>u__1; //Field offset: 0x78

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <LoadFontsFromPlayerProfileLanguage>d__35 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		private TaskAwaiter <>u__1; //Field offset: 0x20

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <LoadGameData>d__40 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		private TaskAwaiter <>u__1; //Field offset: 0x20

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <LoadGlobalScene>d__41 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		private TaskAwaiter<SceneInstance> <>u__1; //Field offset: 0x20

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private sealed class <LoadingSequence>d__23 : IEnumerator<Object>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private object <>2__current; //Field offset: 0x18
		public bool isFirstLoad; //Field offset: 0x20
		public Main <>4__this; //Field offset: 0x28
		private <>c__DisplayClass23_0 <>8__1; //Field offset: 0x30
		public Action onFistLoadComplete; //Field offset: 0x38
		private AnimatedSceneLoader<InitialLoadingScreen> <loadingScene>5__2; //Field offset: 0x40
		private AnimatedSceneLoader<TitleScreen> <titleScene>5__3; //Field offset: 0x48
		private bool <debugForceTutorial>5__4; //Field offset: 0x50
		private TutorialType <forceTutorialType>5__5; //Field offset: 0x54
		private Btd6Player <player>5__6; //Field offset: 0x58
		private Task<ProfanityFilter> <profanityLoader>5__7; //Field offset: 0x60
		private AnimatedSceneLoader<GenericAnimatedScene> <splashScene>5__8; //Field offset: 0x68
		private AnimatedSceneLoader<GenericAnimatedScene> <arcadeSplash>5__9; //Field offset: 0x70

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
		public <LoadingSequence>d__23(int <>1__state) { }

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
	private sealed class <LoadLocs>d__27 : IEnumerator<Object>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private object <>2__current; //Field offset: 0x18
		public Main <>4__this; //Field offset: 0x20

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
		public <LoadLocs>d__27(int <>1__state) { }

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
	private struct <LoadPlayer>d__44 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public Main <>4__this; //Field offset: 0x20
		private <>c__DisplayClass44_0 <>8__1; //Field offset: 0x28
		private Btd6Player <player>5__2; //Field offset: 0x30
		private string <oldNoLinkId>5__3; //Field offset: 0x38
		private object <>7__wrap3; //Field offset: 0x40
		private int <>7__wrap4; //Field offset: 0x48
		private TaskAwaiter <>u__1; //Field offset: 0x50
		private TaskAwaiter<Boolean> <>u__2; //Field offset: 0x58

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <PlayerLoadTasks>d__34 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public Main <>4__this; //Field offset: 0x20
		private bool <isModdedGame>5__2; //Field offset: 0x28
		private bool <canSkipModdingPopup>5__3; //Field offset: 0x29
		private TaskAwaiter <>u__1; //Field offset: 0x30
		private TaskAwaiter<ModdingPopupChoice> <>u__2; //Field offset: 0x38

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <PreloadFriendsAndGuildsAsync>d__26 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncVoidMethodBuilder <>t__builder; //Field offset: 0x8
		private TaskAwaiter<Boolean> <>u__1; //Field offset: 0x28
		private TaskAwaiter<List`1<LiNKFriendData>> <>u__2; //Field offset: 0x30

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <UploadCrashLogs>d__32 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		private TaskAwaiter <>u__1; //Field offset: 0x20

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	private class GameIsReloadingFromScratchException : Exception
	{

		public GameIsReloadingFromScratchException() { }

	}

	[CompilerGenerated]
	private static Client <SteamworksClient>k__BackingField; //Field offset: 0x0
	public const int TargetFrameRate = 60; //Field offset: 0x0
	private static bool isFirstLoad; //Field offset: 0x8
	public static bool LoadPlayer_GameIsReloadingFromScratch; //Field offset: 0x9
	private static bool hasSeenModdingPopup; //Field offset: 0xA
	public static Action<Btd6Player> OnPlayerLoaded; //Field offset: 0x10
	public static bool resetExploitableDataOnStart; //Field offset: 0x18
	[SerializeField]
	private ScriptableObjectReference gameData; //Field offset: 0x20
	[SerializeField]
	private LocalizationManager localizationManager; //Field offset: 0x28
	[SerializeField]
	private NKAnalytics analyticsManager; //Field offset: 0x30
	[SerializeField]
	private Shader[] preloadShaders; //Field offset: 0x38
	public InputSystemController inputSystemControllerPrefab; //Field offset: 0x40

	public private static Client SteamworksClient
	{
		[CompilerGenerated]
		 get { } //Length: 78
		[CompilerGenerated]
		private set { } //Length: 84
	}

	private static Main() { }

	public Main() { }

	[CompilerGenerated]
	private void <Start>b__13_1() { }

	[CompilerGenerated]
	internal static void <Start>g__onFistLoadComplete|13_0() { }

	private void Awake() { }

	private void CheckDataIdMismatch(Btd6Player player) { }

	[AsyncStateMachine(typeof(<CheckForceOrSoftUpdate>d__38))]
	private static Task CheckForceOrSoftUpdate(VersionSettings versionSettings, InitialLoadingScreen loadingScreen) { }

	private void CheckResolution() { }

	[AsyncStateMachine(typeof(<CheckVersionAsync>d__36))]
	private static Task CheckVersionAsync(InitialLoadingScreen loadingScreen) { }

	[CompilerGenerated]
	public static Client get_SteamworksClient() { }

	public static string GetSteamSessionTicket() { }

	private AnimatedSceneLoader<TitleScreen> GetTitleScene() { }

	private void HandleException(string logString) { }

	[AsyncStateMachine(typeof(<InitGameData>d__39))]
	private Task InitGameData() { }

	[IteratorStateMachine(typeof(<Initialize>d__22))]
	private IEnumerator Initialize(bool isFirstLoad, Action onLoadingComplete) { }

	private void InitializeDeepLinkManager() { }

	private void InitializeSteamworksClient() { }

	[AsyncStateMachine(typeof(<InitialLoadTasks>d__31))]
	private Task InitialLoadTasks(InitialLoadingScreen loadingScreen, bool isFirstLoad) { }

	private static bool IsOutdatedDevice(VersionSettings versionSettings) { }

	[AsyncStateMachine(typeof(<LoadFontsFromPlayerProfileLanguage>d__35))]
	public static Task LoadFontsFromPlayerProfileLanguage() { }

	[AsyncStateMachine(typeof(<LoadGameData>d__40))]
	private Task LoadGameData() { }

	[AsyncStateMachine(typeof(<LoadGlobalScene>d__41))]
	private Task LoadGlobalScene() { }

	[IteratorStateMachine(typeof(<LoadingSequence>d__23))]
	private IEnumerator LoadingSequence(bool isFirstLoad, Action onFistLoadComplete) { }

	[IteratorStateMachine(typeof(<LoadLocs>d__27))]
	public IEnumerator LoadLocs() { }

	[AsyncStateMachine(typeof(<LoadPlayer>d__44))]
	private Task LoadPlayer() { }

	private static void LoadTutorial(Btd6Player player, bool debugForceTutorial, TutorialType forceTutorialType) { }

	private void OnAppDowngraded(Version from, Version to) { }

	private void OnAppFirstRunDetected() { }

	private void OnAppUpgraded(Version from, Version to) { }

	private void OneTimeLoadTasks() { }

	[AsyncStateMachine(typeof(<PlayerLoadTasks>d__34))]
	private Task PlayerLoadTasks() { }

	[AsyncStateMachine(typeof(<PreloadFriendsAndGuildsAsync>d__26))]
	private void PreloadFriendsAndGuildsAsync(LiNKAccount linkAccount = null) { }

	private void QuitIfRunningInProton() { }

	public static void ResetExploitableData(ProfileModel playerData) { }

	[CompilerGenerated]
	private static void set_SteamworksClient(Client value) { }

	private void SetupErrorHandler() { }

	private static void ShowPlayerLoadingErrorPopup(AggregateException aggregateException) { }

	private void Start() { }

	public static KeyValuePair<String, Func`1<Task>> TaskPair(string s, Func<Task> t) { }

	private void UpdateCheck() { }

	private void UpdateDisplayName(PlayerService playerService) { }

	[AsyncStateMachine(typeof(<UploadCrashLogs>d__32))]
	private Task UploadCrashLogs() { }

}

