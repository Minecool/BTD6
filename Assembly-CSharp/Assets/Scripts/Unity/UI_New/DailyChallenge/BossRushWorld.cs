namespace Assets.Scripts.Unity.UI_New.DailyChallenge;

public class BossRushWorld : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass26_0
	{
		private struct <<InitializeTiles>g__InitializeTile|0>d : IAsyncStateMachine
		{
			public int <>1__state; //Field offset: 0x0
			public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
			public <>c__DisplayClass26_0 <>4__this; //Field offset: 0x20
			public int index; //Field offset: 0x28
			public PrefabReference statue; //Field offset: 0x30
			private BossRushTile <bossRushTile>5__2; //Field offset: 0x38
			private TaskAwaiter<GameObject> <>u__1; //Field offset: 0x40
			private TaskAwaiter <>u__2; //Field offset: 0x48

			private override void MoveNext() { }

			[DebuggerHidden]
			private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

		}

		public BossRushWorld <>4__this; //Field offset: 0x10
		public int currentTileIndex; //Field offset: 0x18

		public <>c__DisplayClass26_0() { }

		[AsyncStateMachine(typeof(<<InitializeTiles>g__InitializeTile|0>d))]
		internal Task <InitializeTiles>g__InitializeTile|0(int index, PrefabReference statue) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass51_0
	{
		public int index; //Field offset: 0x10

		public <>c__DisplayClass51_0() { }

		internal bool <GetTileScreenPosition>b__0(BossRushTile tile) { }

	}

	[CompilerGenerated]
	private struct <InitializeTiles>d__26 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public BossRushWorld <>4__this; //Field offset: 0x20
		public int currentTileIndex; //Field offset: 0x28
		public int stageCount; //Field offset: 0x2C
		public MapDetails[] mapsDetails; //Field offset: 0x30
		private TaskAwaiter <>u__1; //Field offset: 0x38

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <LoadBoss>d__34 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public BossType boss; //Field offset: 0x20
		public BossRushWorld <>4__this; //Field offset: 0x28
		public float healthProportion; //Field offset: 0x30
		private TaskAwaiter<GameObject> <>u__1; //Field offset: 0x38

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <LoadTeamIsland>d__33 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public BossRushWorld <>4__this; //Field offset: 0x20
		private TaskAwaiter <>u__1; //Field offset: 0x28

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <PlayBossDefeatedAnimation>d__36 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public BossRushWorld <>4__this; //Field offset: 0x20
		private TaskAwaiter <>u__1; //Field offset: 0x28

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <PlayBossSpawnAnimation>d__35 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public BossRushWorld <>4__this; //Field offset: 0x20
		private TaskAwaiter <>u__1; //Field offset: 0x28

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <PlayInitialLoadAnimation>d__27 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public bool hasWonEvent; //Field offset: 0x20
		public BossRushWorld <>4__this; //Field offset: 0x28
		private TaskAwaiter <>u__1; //Field offset: 0x30

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[SerializeField]
	private PrefabReference tilePrefab; //Field offset: 0x20
	[SerializeField]
	private Transform islandBaseContainer; //Field offset: 0x28
	[SerializeField]
	private PrefabReference phayzePrefab; //Field offset: 0x30
	[SerializeField]
	private PrefabReference bloonariusPrefab; //Field offset: 0x38
	[SerializeField]
	private PrefabReference dreadbloonPrefab; //Field offset: 0x40
	[SerializeField]
	private PrefabReference blastapopoulosPrefab; //Field offset: 0x48
	[SerializeField]
	private Transform bossContainer; //Field offset: 0x50
	[SerializeField]
	private Transform cameraCenterPos; //Field offset: 0x58
	[SerializeField]
	private Transform cameraCenterEventWonPos; //Field offset: 0x60
	private GameObject activeBossDisplay; //Field offset: 0x68
	private readonly List<BossRushTile> activeTiles; //Field offset: 0x70
	private Camera cam; //Field offset: 0x78
	[SerializeField]
	private float groundPlaneHeight; //Field offset: 0x80
	private CTBaseIsland baseIsland; //Field offset: 0x88
	private readonly List<Transform> tilePositions; //Field offset: 0x90
	[SerializeField]
	private Transform islandsCentre; //Field offset: 0x98
	[SerializeField]
	private float islandsRadius; //Field offset: 0xA0
	[SerializeField]
	private GameObject islandPositionTemplate; //Field offset: 0xA8
	[SerializeField]
	private float islandPositionAngleOffest; //Field offset: 0xB0
	[SerializeField]
	private float bossRushSpawnAnimationDelaySecs; //Field offset: 0xB4
	[SerializeField]
	private float initialLoadAnimationDelaySecs; //Field offset: 0xB8
	[SerializeField]
	private float bossDeathAnimationDelaySecs; //Field offset: 0xBC
	[SerializeField]
	private Vector3 tileFocusPositionDelta; //Field offset: 0xC0
	private BossRushWorldAudio bossAudio; //Field offset: 0xD0
	private readonly int damageStatesCount; //Field offset: 0xD8
	public bool inputEnabled; //Field offset: 0xDC
	private float clickTimer; //Field offset: 0xE0
	private Vector3 touchStartPos; //Field offset: 0xE4
	private bool isOverUI; //Field offset: 0xF0
	private float zoomAmount; //Field offset: 0xF4
	private bool wasTwoFinger; //Field offset: 0xF8
	private float zoomDelta; //Field offset: 0xFC
	[SerializeField]
	private ContestedTerritoryCameraRig camRig; //Field offset: 0x100
	[SerializeField]
	private float pinchSpeedMultiplier; //Field offset: 0x108
	[SerializeField]
	private float mouseWheelSmoothingMul; //Field offset: 0x10C

	public BossRushWorld() { }

	private void Awake() { }

	private void CreateTilePositions(int islandPositionCount) { }

	private Transform GetIslandPosition(int tileIndex, int currentTileIndex) { }

	private void GetMouseInput() { }

	public Vector3 GetTileScreenPosition(int index) { }

	public Vector3 GetTileViewportPosition(int index) { }

	private Vector3 GetWorldPosition() { }

	public void HideBoss() { }

	[AsyncStateMachine(typeof(<InitializeTiles>d__26))]
	public Task InitializeTiles(MapDetails[] mapsDetails, int currentTileIndex, int stageCount) { }

	[AsyncStateMachine(typeof(<LoadBoss>d__34))]
	public Task LoadBoss(BossType boss, float healthProportion) { }

	[AsyncStateMachine(typeof(<LoadTeamIsland>d__33))]
	private Task LoadTeamIsland() { }

	public void LoadTeamIslandAsync() { }

	[AsyncStateMachine(typeof(<PlayBossDefeatedAnimation>d__36))]
	public Task PlayBossDefeatedAnimation() { }

	[AsyncStateMachine(typeof(<PlayBossSpawnAnimation>d__35))]
	public Task PlayBossSpawnAnimation() { }

	[AsyncStateMachine(typeof(<PlayInitialLoadAnimation>d__27))]
	public Task PlayInitialLoadAnimation(bool hasWonEvent) { }

	private void PlaySound(int state = 0) { }

	public Task RefreshTiles(MapDetails[] mapsDetails, int currentTileIndex) { }

	public void TileSelected(int index) { }

	private void Update() { }

	public void UpdateBossDamageState(float healthProportion) { }

}

