namespace Assets.Scripts.Simulation.Track;

public class Map : RootBehavior
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Predicate<AreaModel> <>9__33_0; //Field offset: 0x8
		public static Comparison<Area> <>9__33_1; //Field offset: 0x10
		public static Predicate<BlockerModel> <>9__33_2; //Field offset: 0x18
		public static Func<RegenRemovable, Boolean> <>9__41_0; //Field offset: 0x20
		public static Func<RegenRemovable, String> <>9__41_1; //Field offset: 0x28

		private static <>c() { }

		public <>c() { }

		internal bool <CreateMap>b__33_0(AreaModel x) { }

		internal int <CreateMap>b__33_1(Area a, Area b) { }

		internal bool <CreateMap>b__33_2(BlockerModel x) { }

		internal bool <GetSaveData>b__41_0(RegenRemovable x) { }

		internal string <GetSaveData>b__41_1(RegenRemovable x) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass111_0
	{
		public RegenRemovable regenRemovable; //Field offset: 0x10

		public <>c__DisplayClass111_0() { }

		internal bool <GetSelection>b__0(Area x) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass38_0
	{
		public MapEditorAreaDataModel mapEditorAreaModelData; //Field offset: 0x10

		public <>c__DisplayClass38_0() { }

		internal bool <GatherCustomMapRemovables>b__0(AreaModel x) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass49_0
	{
		public Removeable r; //Field offset: 0x10

		public <>c__DisplayClass49_0() { }

		internal bool <SetActiveRemovables>b__0(MapEvent x) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass54_0
	{
		public Removeable removeable; //Field offset: 0x10

		public <>c__DisplayClass54_0() { }

		internal bool <DestroyRemoveableForcePostAction>b__0(MapEvent x) { }

	}

	internal struct BlockerWall
	{
		public Vector3 point; //Field offset: 0x0
		public Vector3 endPoint; //Field offset: 0xC
		public int side; //Field offset: 0x18
		public bool internalAngle; //Field offset: 0x1C

	}

	public MapModel mapModel; //Field offset: 0x58
	[CompilerGenerated]
	private List<MapBlocker> <blockers>k__BackingField; //Field offset: 0x60
	private List<Area> areas; //Field offset: 0x68
	private List<BlockerZone> blockerZones; //Field offset: 0x70
	private List<MapGizmo> gizmos; //Field offset: 0x78
	private List<MapEvent> mapEvents; //Field offset: 0x80
	private List<SimulationBehavior> simBehaviors; //Field offset: 0x88
	public PathManager pathManager; //Field offset: 0x90
	public Spawner spawner; //Field offset: 0x98
	private ObjectId nextFreeAreaID; //Field offset: 0xA0
	public Dictionary<ObjectId, List`1<Tower>> areaTowers; //Field offset: 0xA8
	private Dictionary<ObjectId, List`1<AirUnit>> groundedAirUnits; //Field offset: 0xB0
	public float mapWideBloonSpeed; //Field offset: 0xB8
	public bool wasLoadedWithActiveRegenRemovable; //Field offset: 0xBC
	[CompilerGenerated]
	private Action<Removeable> OnRemoveableSold; //Field offset: 0xC0
	[CompilerGenerated]
	private Action<String> OnInteractableClicked; //Field offset: 0xC8
	[CompilerGenerated]
	private Action OnAreasChanged; //Field offset: 0xD0
	private CoopAreaLayoutModel coopLayoutModelToUse; //Field offset: 0xD8
	public bool usedARemoveable; //Field offset: 0xE0
	private LockList<Area> mapAreas; //Field offset: 0xE8

	public event Action OnAreasChanged
	{
		[CompilerGenerated]
		 add { } //Length: 158
		[CompilerGenerated]
		 remove { } //Length: 158
	}

	public event Action<String> OnInteractableClicked
	{
		[CompilerGenerated]
		 add { } //Length: 174
		[CompilerGenerated]
		 remove { } //Length: 174
	}

	public event Action<Removeable> OnRemoveableSold
	{
		[CompilerGenerated]
		 add { } //Length: 174
		[CompilerGenerated]
		 remove { } //Length: 174
	}

	public int AreaCount
	{
		 get { } //Length: 60
	}

	public List<Area> Areas
	{
		 get { } //Length: 5
	}

	public private List<MapBlocker> blockers
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 5
	}

	public Map() { }

	[CompilerGenerated]
	public void add_OnAreasChanged(Action value) { }

	[CompilerGenerated]
	public void add_OnInteractableClicked(Action<String> value) { }

	[CompilerGenerated]
	public void add_OnRemoveableSold(Action<Removeable> value) { }

	public BlockerZone AddBlockerZone(Vector3 position, float radius, bool inverse = false) { }

	public void AreasChanged() { }

	public bool BlockedByBlockerZone(AABB aabb, Vector2 center, float radius) { }

	public void BlockersChanged() { }

	private bool CanHaveTowerSize(AreaModel areaModel, TowerModel towerModel) { }

	public bool CanPlace(Vector2 at, TowerModel tm, Tower forExistingTower = null, CanPlaceReturnData canPlaceReturnData = null, bool checkTowerOverlaps = true, bool ignoreInputBlockers = false) { }

	public bool CanPlaceProp(Vector2 at, PropModel pm, CanPlaceReturnData canPlaceReturnData = null, bool checkEntityOverlaps = true, bool ignoreInputBlockers = false) { }

	public void ChangePathActiveness(string pathName, bool isActive) { }

	public void ChangePathHiddeness(string pathName, bool isHidden) { }

	public override bool CheckCoopPlacement(Vector2 at, TowerModel tm, InputManager im) { }

	public bool CheckForStackedTowers(Removeable removeable) { }

	public void CheckMapEventTriggers(bool loadSave) { }

	public Area CreateArea(AreaModel areaModel, bool destroyTowersInsideArea = false) { }

	public void CreateAreaFromExistingModel(string areaName) { }

	public List<Area> CreateAreas(List<AreaModel> areaModels, bool destroyTowersInsideArea = false) { }

	private List<BlockerModel> CreateBlockerModel(AreaModel areaModel) { }

	public void CreateBlockers(List<BlockerModel> blockersToAdd) { }

	public List<BlockerModel> CreateBlockers(Area area) { }

	private void CreateMap(MapModel mapModel) { }

	public Area CreatePropArea(AreaModel areaModel, bool destroyTowersInsideArea = true) { }

	public void DeInit() { }

	public void DestroyArea(Area area, bool forceDestroyTowers = false) { }

	public void DestroyArea(string areaName) { }

	public void DestroyAreas(List<Area> areas) { }

	public List<MapBlocker> DestroyBlockers(Area area) { }

	private void DestroyRemoveable(Removeable removeable) { }

	public void DestroyRemoveableForcePostAction(Removeable removeable) { }

	public bool DoesAreaExist(string areaName) { }

	public void EndTowerMovementOnArea(Area area) { }

	public void FindAndDestroyTowersIfInInvalidLocations(Area area) { }

	public bool FindBlockerIntersection(Vector3 a, Vector3 b, out Vector2 result) { }

	public void GatherCustomMapRemovables(List<AreaModel> areaModels) { }

	public int get_AreaCount() { }

	public List<Area> get_Areas() { }

	[CompilerGenerated]
	public List<MapBlocker> get_blockers() { }

	private List<String> GetActiveRemovables() { }

	public Area GetAreaAtPoint(Vector2 at, Area ignoreArea = null, bool ignoreInputBlocking = false, bool ignoreBlockingAreas = false) { }

	public List<Area> GetAreas() { }

	public List<Area> GetAreasLinkedToRemovable(Removeable removeable) { }

	public Area GetAreaWithID(ObjectId areaID) { }

	public void GetBlockerWallsInRange(Vector3 point, float range, List<BlockerWall> blockerWallsOut) { }

	public List<AreaIndicator> GetCoopPlayerIndicators() { }

	private List<MapGizmoSaveData> GetGizmoSaveData() { }

	public MapEvent GetMapEvent(string mapEventName) { }

	public List<MapEvent> GetMapEvents() { }

	private Dictionary<String, MapEventSaveData> GetMapEventSaveData() { }

	public Vector2 GetPointWithinMap(Vector2 point, float border = 0) { }

	public void GetSaveData(MapSaveDataModel mapData) { }

	public CoopAreaLayoutModel GetSelectedCoopLayoutModel() { }

	public ISelectable GetSelection(Vector2 at, float selectionRadius) { }

	private void GetSimBehaviorSaveData(Dictionary<String, String> metaData) { }

	public float GetTerrainHeight(Vector2 at, bool ignoreInputBlocking = false, bool ignoreBlockingAreas = false) { }

	public List<Vector3> GetTrackEndPoints(float offSet, bool ignoreBossPaths, bool excludeInvulnerable = false) { }

	public bool GetTrackStartPoint(float offSet, out Vector3 point) { }

	public void Init() { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	private Area InsertArea(AreaModel areaModel) { }

	public void InteractableClicked(string interactableName) { }

	public bool IsBlockerIntersecting(Vector3Boxed a, Vector3Boxed b) { }

	public bool IsFreeForAll() { }

	private bool IsPlaceableInAreaType(Vector2 at, IPlaceableEntity pe, AreaType areaType, bool forExistingTower) { }

	public bool IsPointOnCustomPath(Vector2 location, float radius = 5) { }

	public bool IsPointOnMap(Vector2 point, float border = 0) { }

	public bool IsTargetLineClear(Vector3 a, Vector3 b) { }

	private void LoadGizmoSaveData(List<MapGizmoSaveData> sd) { }

	private void LoadMapEventSaveData(Dictionary<String, MapEventSaveData> sd) { }

	public bool MapHasRemoveables() { }

	public void MatchReady() { }

	public void MoveArea(Area areaToMove, Vector2 moveBy, bool updateThrowCache, bool dontMoveTowers = false) { }

	public void OnLoadedCustomMapRemovablesTriggered() { }

	private bool OverlapsOtherEntity(AABB aabb, Vector2 center, float radius, Vector3 otherPos, float otherModelRadius, FootprintModel otherModelFootprint) { }

	[CompilerGenerated]
	public void remove_OnAreasChanged(Action value) { }

	[CompilerGenerated]
	public void remove_OnInteractableClicked(Action<String> value) { }

	[CompilerGenerated]
	public void remove_OnRemoveableSold(Action<Removeable> value) { }

	public void RemoveBlockerZone(BlockerZone zone) { }

	public void RemoveTowersOnArea(Area area) { }

	public void RotateArea(Area areaToRotate, float rotation, bool updateThrowCache, bool dontRotateTowers = false) { }

	public void RotateAreaAroundPivot(Area areaToRotate, Vector2 pivotPoint, float rotation, bool updateThrowCache, bool dontRotateTowers = false) { }

	public bool SellRegenRemovable(RegenRemovable regenRemovable, int inputId = -1) { }

	public bool SellRemoveable(Removeable removeable, int inputId = -1, bool ignoreCost = false) { }

	[CompilerGenerated]
	private void set_blockers(List<MapBlocker> value) { }

	private void SetActiveRegenRemovables(List<String> activeRegenRemovables) { }

	private void SetActiveRemovables(List<String> activeRemovables) { }

	public void SetMapEventActive(string mapEventName, bool active) { }

	public void SetNumberPlayers(int numPlayers) { }

	public void SetSaveData(MapSaveDataModel mapData) { }

	private void SetSimBehaviorSaveData(Dictionary<String, String> metaData) { }

	public void SetUpSpawnersWithNewCustomPaths(Spawner spawner, List<PathModel> pathModels) { }

	public ObjectId TakeNextFreeAreaID() { }

	public void ToggleAreaVisibility(int layerId, bool isVisible) { }

	public void TogglePathSplitter(bool setActive) { }

	private void TowerAreaChanged(Tower tower, ObjectId previousAreaID, ObjectId areaID) { }

	public ObjectId TryToGroundAirUnit(AirUnit airUnit) { }

	public void UngroundAirUnit(AirUnit airUnit) { }

	public void UpdateActivePaths() { }

	public virtual void UpdatedModel(Model modelToUse) { }

	private void UpdatePathPointsAfterRemovingRemovable(Removeable removeable) { }

	public bool WrapLineAroundMapEdge(Vector2 pointA, Vector2 pointB, out Vector2 modifiedPointB) { }

	private Vector2 WrapLineAroundMapEdgeIntersect(float distanceBetweenAandB, Vector2 intersection, Vector2 targetToPursuitDirection, Vector2 pursuitTargetPosition, Vector2 directionOfFirstLine, Vector2 directionOfSecondLine) { }

	private bool ZoneAllowsPlacement(Vector2 at, IPlaceableEntity pe, AreaType areaType) { }

}

