namespace Assets.Scripts.SimulationTests;

public static class SimulationTestUtilities
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass0_0
	{
		public MapEditorSceneController sceneController; //Field offset: 0x10

		public <>c__DisplayClass0_0() { }

		internal void <LoadEnvironmentForTest>b__0(AsyncOperationHandle<GameObject> h) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass3_0
	{
		public SimulationTestBlackboard bb; //Field offset: 0x10
		public string towerName; //Field offset: 0x18

		public <>c__DisplayClass3_0() { }

		internal bool <FindSimTower>b__0(TowerToSimulation t) { }

		internal bool <FindSimTower>b__1(TowerToSimulation t) { }

		internal bool <FindSimTower>b__2(TowerToSimulation t) { }

	}

	[CompilerGenerated]
	private struct <LoadEnvironmentForTest>d__0 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder<SimulationTestEnvironment> <>t__builder; //Field offset: 0x8
		public SimulationTest test; //Field offset: 0x20
		public DailyChallengeModel dcModel; //Field offset: 0x28
		private <>c__DisplayClass0_0 <>8__1; //Field offset: 0x30
		public GameType gameType; //Field offset: 0x38
		public bool goldenBloonActive; //Field offset: 0x3C
		public BossGameData bossGameData; //Field offset: 0x40
		public string eventId; //Field offset: 0x48
		public string hero; //Field offset: 0x50
		public bool doubleCash; //Field offset: 0x58
		private MapModel <mapModel>5__2; //Field offset: 0x60
		private string <mapName>5__3; //Field offset: 0x68
		private GameModel <gameModel>5__4; //Field offset: 0x70
		private RuntimeSceneScope <sceneScope>5__5; //Field offset: 0x78
		private Map <map>5__6; //Field offset: 0x80
		private CustomMapModel <customMapModel>5__7; //Field offset: 0x88
		private YieldAwaiter <>u__1; //Field offset: 0x90
		private CustomMapManagers <customMapManagers>5__8; //Field offset: 0x98
		private TaskAwaiter<GameObject> <>u__2; //Field offset: 0xA0
		private TaskAwaiter <>u__3; //Field offset: 0xA8
		private TaskAwaiter<GameModel> <>u__4; //Field offset: 0xB0
		private TaskAwaiter<BossDataModel> <>u__5; //Field offset: 0xB8

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}


	public static GameModel CreateGameModel(GameModel baseModel, MapModel mapModel, RoundSetModel roundSetModel, List<String> mods, ModModel dcmModModel, ActiveRelicKnowledge relicKnowledge, GameType gameType = 0, DailyChallengeModel dcModel = null) { }

	private static UnityToSimulation CreateSimulation(GameModel gameModel, MapModel mapModel, string hero, bool doubleCash) { }

	public static TowerToSimulation FindSimTower(string towerName, SimulationTestEnvironment env, SimulationTestBlackboard bb) { }

	[AsyncStateMachine(typeof(<LoadEnvironmentForTest>d__0))]
	public static Task<SimulationTestEnvironment> LoadEnvironmentForTest(SimulationTest test, DailyChallengeModel dcModel = null, BossGameData bossGameData = null, bool goldenBloonActive = false, GameType gameType = 0, string hero = "Quincy", bool doubleCash = false, string eventId = null) { }

	public static bool RandomPositionForTower(UnityToSimulation sim, TowerModel tower, out Vector2 position, int nAttempts = 100) { }

	public static TowerModel RandomTower(SimulationTestEnvironment env) { }

}

