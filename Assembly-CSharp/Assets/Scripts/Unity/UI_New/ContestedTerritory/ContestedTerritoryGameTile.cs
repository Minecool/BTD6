namespace Assets.Scripts.Unity.UI_New.ContestedTerritory;

public class ContestedTerritoryGameTile
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func<DecorativeTile, Boolean> <>9__26_1; //Field offset: 0x8
		public static Func<DecorativeTile, Single> <>9__26_2; //Field offset: 0x10
		public static Func<PlayerActivity, String> <>9__40_0; //Field offset: 0x18
		public static Func<IGrouping`2<String, PlayerActivity>, Boolean> <>9__40_1; //Field offset: 0x20

		private static <>c() { }

		public <>c() { }

		internal bool <AddIslandTileDecorationOverlayAsync>b__26_1(DecorativeTile x) { }

		internal float <AddIslandTileDecorationOverlayAsync>b__26_2(DecorativeTile x) { }

		internal string <BuildBattleStateTeamList>b__40_0(PlayerActivity x) { }

		internal bool <BuildBattleStateTeamList>b__40_1(IGrouping<String, PlayerActivity> x) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass26_0
	{
		public EventName currentEvent; //Field offset: 0x10

		public <>c__DisplayClass26_0() { }

		internal bool <AddIslandTileDecorationOverlayAsync>b__0(DecorativeTile x) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass44_0
	{
		public CtTileChildType type; //Field offset: 0x10

		public <>c__DisplayClass44_0() { }

		internal bool <RemoveTileChild>b__0(ContestedTerritoryTileChild x) { }

	}

	[CompilerGenerated]
	private struct <AddBossDecoration>d__27 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public ContestedTerritoryGameTile <>4__this; //Field offset: 0x20
		private TaskAwaiter<GameObject> <>u__1; //Field offset: 0x28

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <AddIslandTileDecorationOverlayAsync>d__26 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder<Boolean> <>t__builder; //Field offset: 0x8
		public EventName currentEvent; //Field offset: 0x20
		public ContestedTerritoryGameTile <>4__this; //Field offset: 0x28
		public DecorativeTiles decorativeTiles; //Field offset: 0x30
		private IEnumerator<DecorativeTile> <>7__wrap1; //Field offset: 0x38
		private TaskAwaiter<GameObject> <>u__1; //Field offset: 0x40

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <Build>d__23 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder<Boolean> <>t__builder; //Field offset: 0x8
		public ContestedTerritoryGameTile <>4__this; //Field offset: 0x20
		public EventName currentEvent; //Field offset: 0x28
		private TaskAwaiter <>u__1; //Field offset: 0x30
		private DecorativeTiles <decorativeTiles>5__2; //Field offset: 0x38
		private TaskAwaiter<Boolean> <>u__2; //Field offset: 0x40
		private TaskAwaiter<GameObject> <>u__3; //Field offset: 0x48

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <BuildBaseGameObject>d__25 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public PrefabReference prefab; //Field offset: 0x20
		public ContestedTerritoryGameTile <>4__this; //Field offset: 0x28
		private TaskAwaiter<GameObject> <>u__1; //Field offset: 0x30

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <BuildTeamBaseIsland>d__29 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder<Boolean> <>t__builder; //Field offset: 0x8
		public ContestedTerritoryGameTile <>4__this; //Field offset: 0x20
		public EventName eventName; //Field offset: 0x28
		private GameObject <teamPrefab>5__2; //Field offset: 0x30
		private TaskAwaiter<GameObject> <>u__1; //Field offset: 0x38
		private TaskAwaiter <>u__2; //Field offset: 0x40

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <CreateBattleStateBanner>d__41 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder<GameObject> <>t__builder; //Field offset: 0x8
		public ContestedTerritoryGameTile <>4__this; //Field offset: 0x20
		public List<String> teamIds; //Field offset: 0x28
		private TaskAwaiter<GameObject> <>u__1; //Field offset: 0x30

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <RenderTileBattleState>d__39 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncVoidMethodBuilder <>t__builder; //Field offset: 0x8
		public ContestedTerritoryGameTile <>4__this; //Field offset: 0x28
		public bool isAccessibleToTeam; //Field offset: 0x30
		private IEnumerable<PlayerActivity> <playerActivity>5__2; //Field offset: 0x38
		private TaskAwaiter<GameObject> <>u__1; //Field offset: 0x40

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <SetIslandTileTypeAssetAsync>d__28 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder<Boolean> <>t__builder; //Field offset: 0x8
		public ContestedTerritoryGameTile <>4__this; //Field offset: 0x20
		public EventName eventName; //Field offset: 0x28
		private TaskAwaiter<Boolean> <>u__1; //Field offset: 0x30

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <SyncMarker>d__32 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public ContestedTerritoryGameTile <>4__this; //Field offset: 0x20
		private TaskAwaiter<GameObject> <>u__1; //Field offset: 0x28

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <SyncShield>d__42 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public ContestedTerritoryGameTile <>4__this; //Field offset: 0x20
		private TaskAwaiter<GameObject> <>u__1; //Field offset: 0x28

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <SyncStaleDisplay>d__33 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public ContestedTerritoryGameTile <>4__this; //Field offset: 0x20
		private TaskAwaiter<GameObject> <>u__1; //Field offset: 0x28

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <SyncToIslandTile>d__30 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public ContestedTerritoryGameTile <>4__this; //Field offset: 0x20
		public bool isAnimated; //Field offset: 0x28
		private TaskAwaiter <>u__1; //Field offset: 0x30
		private TaskAwaiter<Boolean> <>u__2; //Field offset: 0x38

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	private const string AnimatorYours = "Yours"; //Field offset: 0x0
	private const string AnimatorClaimed = "Claimed"; //Field offset: 0x0
	private const string AnimatorSelect = "Select"; //Field offset: 0x0
	private const string AnimatorAttackable = "Attackable"; //Field offset: 0x0
	private const string AnimatorLongRangeAttackable = "LongRangeAttackable"; //Field offset: 0x0
	private readonly int id; //Field offset: 0x10
	private readonly GameObject parent; //Field offset: 0x18
	private readonly ContestedTerritoryIslandTile islandTile; //Field offset: 0x20
	private readonly Random randomiser; //Field offset: 0x28
	private readonly Vector3 worldPosition; //Field offset: 0x30
	private readonly float worldRotation; //Field offset: 0x3C
	private readonly TeamDetail teamDetails; //Field offset: 0x40
	private Material originalMaterial; //Field offset: 0x48
	private Animator animator; //Field offset: 0x50
	public GameObject gameObject; //Field offset: 0x58
	public GameObject animationLayer; //Field offset: 0x60

	private ContestedTerritoryData Data
	{
		private get { } //Length: 71
	}

	private bool IsAccessibleToTeam
	{
		private get { } //Length: 199
	}

	public bool IsNull
	{
		 get { } //Length: 144
	}

	public ContestedTerritoryGameTile(int id, GameObject parent, float rotation) { }

	[CompilerGenerated]
	private bool <Build>b__23_0(DecorativeTiles x) { }

	[CompilerGenerated]
	private bool <get_IsAccessibleToTeam>b__17_0(ContestedTerritoryIslandTile x) { }

	[AsyncStateMachine(typeof(<AddBossDecoration>d__27))]
	private Task AddBossDecoration() { }

	[AsyncStateMachine(typeof(<AddIslandTileDecorationOverlayAsync>d__26))]
	private Task<Boolean> AddIslandTileDecorationOverlayAsync(DecorativeTiles decorativeTiles, EventName currentEvent) { }

	private void AddTileChildMarker(GameObject gameObject, CtTileChildType type) { }

	[AsyncStateMachine(typeof(<Build>d__23))]
	public Task<Boolean> Build(EventName currentEvent) { }

	[AsyncStateMachine(typeof(<BuildBaseGameObject>d__25))]
	private Task BuildBaseGameObject(PrefabReference prefab) { }

	private List<String> BuildBattleStateTeamList(IEnumerable<PlayerActivity> playerActivity) { }

	[AsyncStateMachine(typeof(<BuildTeamBaseIsland>d__29))]
	private Task<Boolean> BuildTeamBaseIsland(EventName eventName) { }

	[AsyncStateMachine(typeof(<CreateBattleStateBanner>d__41))]
	private Task<GameObject> CreateBattleStateBanner(List<String> teamIds) { }

	private void DisplayTileHighlighting(bool isAnimated) { }

	private ContestedTerritoryData get_Data() { }

	private bool get_IsAccessibleToTeam() { }

	public bool get_IsNull() { }

	private MaterialReference GetHomeTileMaterial(TeamDetail team) { }

	private void RemoveTileChild(CtTileChildType type) { }

	[AsyncStateMachine(typeof(<RenderTileBattleState>d__39))]
	private void RenderTileBattleState(bool isAccessibleToTeam) { }

	private void RenderTileOwner(bool isAnimated) { }

	[AsyncStateMachine(typeof(<SetIslandTileTypeAssetAsync>d__28))]
	private Task<Boolean> SetIslandTileTypeAssetAsync(EventName eventName) { }

	private bool SetTileAttackableState() { }

	private void SetTileLongRangeAttackableState(bool tileIsRegularAttackable) { }

	public void ShowAsSelected(bool isSelected) { }

	public void SyncForNeighbour() { }

	[AsyncStateMachine(typeof(<SyncMarker>d__32))]
	public Task SyncMarker() { }

	[AsyncStateMachine(typeof(<SyncShield>d__42))]
	private Task SyncShield() { }

	[AsyncStateMachine(typeof(<SyncStaleDisplay>d__33))]
	private Task SyncStaleDisplay() { }

	[AsyncStateMachine(typeof(<SyncToIslandTile>d__30))]
	public Task SyncToIslandTile(bool isAnimated) { }

}

