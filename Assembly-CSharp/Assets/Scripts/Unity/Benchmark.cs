namespace Assets.Scripts.Unity;

public class Benchmark : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func<RootObjectReport, Boolean> <>9__36_1; //Field offset: 0x8
		public static Func<RootObjectReport, Int32> <>9__36_2; //Field offset: 0x10

		private static <>c() { }

		public <>c() { }

		internal bool <OnGUI>b__36_1(RootObjectReport report) { }

		internal int <OnGUI>b__36_2(RootObjectReport report) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass36_0
	{
		public Benchmark <>4__this; //Field offset: 0x10
		public int inputId; //Field offset: 0x18

		public <>c__DisplayClass36_0() { }

		internal bool <OnGUI>b__0(TowerToSimulation t) { }

	}

	[CompilerGenerated]
	private sealed class <CreateTowerInSeconds>d__37 : IEnumerator<Object>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private object <>2__current; //Field offset: 0x18
		public float delayInSeconds; //Field offset: 0x20
		public Benchmark <>4__this; //Field offset: 0x28
		public TowerModel model; //Field offset: 0x30
		public Vector2 location; //Field offset: 0x38

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
		public <CreateTowerInSeconds>d__37(int <>1__state) { }

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
	private sealed class <LoadSave>d__32 : IEnumerator<Object>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private object <>2__current; //Field offset: 0x18
		public Benchmark <>4__this; //Field offset: 0x20
		public MapSaveDataModel saveModel; //Field offset: 0x28
		private string <mapName>5__2; //Field offset: 0x30
		private MapLoader <mapLoader>5__3; //Field offset: 0x38

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
		public <LoadSave>d__32(int <>1__state) { }

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
	private sealed class <LoadScenario>d__29 : IEnumerator<Object>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private object <>2__current; //Field offset: 0x18
		public Benchmark <>4__this; //Field offset: 0x20
		public BenchmarkScenario scenario; //Field offset: 0x28
		private string <mapName>5__2; //Field offset: 0x30
		private MapLoader <mapLoader>5__3; //Field offset: 0x38

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
		public <LoadScenario>d__29(int <>1__state) { }

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
	private struct <Start>d__27 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncVoidMethodBuilder <>t__builder; //Field offset: 0x8
		public Benchmark <>4__this; //Field offset: 0x28
		private TaskAwaiter<Object> <>u__1; //Field offset: 0x30
		private TaskAwaiter <>u__2; //Field offset: 0x38
		private TaskAwaiter<GameModel> <>u__3; //Field offset: 0x40

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	internal static class GcControl
	{

		public static void GC_disable() { }

		public static void GC_enable() { }

		public static void GC_gcollect() { }

		public static long GC_get_free_bytes() { }

		public static long GC_get_heap_size() { }

	}

	private const string kLogTag = "[Benchmark]"; //Field offset: 0x0
	[SerializeField]
	private LocalizationManager localizationManager; //Field offset: 0x20
	[SerializeField]
	private GameData gameData; //Field offset: 0x28
	[SerializeField]
	private RoundSet roundSet; //Field offset: 0x30
	[SerializeField]
	private BenchmarkScenario[] scenarios; //Field offset: 0x38
	private UnityToSimulation Simulation; //Field offset: 0x40
	private GameModel GameModel; //Field offset: 0x48
	private bool guiEnabled; //Field offset: 0x50
	private bool isRunning; //Field offset: 0x51
	private bool fastForward; //Field offset: 0x52
	private bool sellTest; //Field offset: 0x53
	private Coroutine createTowerCoroutine; //Field offset: 0x58
	private int currentFrame; //Field offset: 0x60
	private int jumpToFrame; //Field offset: 0x64
	private int currentRound; //Field offset: 0x68
	private int roundsSimulated; //Field offset: 0x6C
	private int numberOfRounds; //Field offset: 0x70
	private bool jumpToEnd; //Field offset: 0x74
	private float timeTaken; //Field offset: 0x78
	private float peakFrameTime; //Field offset: 0x7C
	private long gcAllocated; //Field offset: 0x80
	private bool isGcDisabled; //Field offset: 0x88
	private bool loadedingScenario; //Field offset: 0x89
	private Vector2 scrollPosition; //Field offset: 0x8C
	private GameModel gameModelOrig; //Field offset: 0x98
	private PlayerService playerService; //Field offset: 0xA0

	public Benchmark() { }

	[IteratorStateMachine(typeof(<CreateTowerInSeconds>d__37))]
	private IEnumerator CreateTowerInSeconds(float delayInSeconds, TowerModel model, Vector2 location) { }

	private void EnableGC(bool enable) { }

	private long GCUsed() { }

	private void InitGameModel(GameModel gameModel, MapModel mapModel, RoundSetModel roundset, string mapDifficulty, string mode) { }

	private void InitSimulation(GameModel gameModel) { }

	[IteratorStateMachine(typeof(<LoadSave>d__32))]
	private IEnumerator LoadSave(MapSaveDataModel saveModel) { }

	[IteratorStateMachine(typeof(<LoadScenario>d__29))]
	private IEnumerator LoadScenario(BenchmarkScenario scenario) { }

	private void OnApplicationQuit() { }

	private void OnGUI() { }

	private void OnLateRoundEndSim(int roundNumber, int highestRoundCompleted) { }

	private void OnLostSim() { }

	private void Reset() { }

	private bool ShouldSimulate() { }

	[AsyncStateMachine(typeof(<Start>d__27))]
	private void Start() { }

	private void TriggerGC() { }

	private void Update() { }

}

