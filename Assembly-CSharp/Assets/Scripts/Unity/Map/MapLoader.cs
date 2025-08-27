namespace Assets.Scripts.Unity.Map;

public class MapLoader
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func<Removeable, RemoveableModel> <>9__26_0; //Field offset: 0x8
		public static Func<RegenRemovable, RegenRemovableModel> <>9__26_1; //Field offset: 0x10
		public static Func<Path, PathModel> <>9__30_0; //Field offset: 0x18
		public static Func<MapEvent, MapEventModel> <>9__33_0; //Field offset: 0x20

		private static <>c() { }

		public <>c() { }

		internal MapEventModel <GatherMapEventsTriggersAndActions>b__33_0(MapEvent x) { }

		internal PathModel <GatherMapPaths>b__30_0(Path x) { }

		internal RemoveableModel <GatherMapRemoveablesData>b__26_0(Removeable x) { }

		internal RegenRemovableModel <GatherMapRemoveablesData>b__26_1(RegenRemovable x) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass42_0
	{
		public Vector3 position; //Field offset: 0x10

		public <>c__DisplayClass42_0() { }

		internal void <AddAsset>b__0(AsyncOperationHandle<GameObject> h) { }

	}

	[CompilerGenerated]
	private sealed class <LoadScene>d__22 : IEnumerator<Object>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private object <>2__current; //Field offset: 0x18
		public MapLoader <>4__this; //Field offset: 0x20

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
		public <LoadScene>d__22(int <>1__state) { }

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

	public const string AmbientMapFxTag = "AmbientMapFxToggle"; //Field offset: 0x0
	private AsyncOperationHandle<SceneInstance> loadOperation; //Field offset: 0x10
	private Map currentMap; //Field offset: 0x28
	private MapDifficulty currentMapDifficulty; //Field offset: 0x30
	private CoopDivision coopMapDivisionType; //Field offset: 0x34
	private string currentMapName; //Field offset: 0x38
	private AreaModel baseAreaModel; //Field offset: 0x40
	private PathSpawnerModel pathSpawnerModel; //Field offset: 0x48
	private List<PathModel> paths; //Field offset: 0x50
	private List<AreaModel> areas; //Field offset: 0x58
	private List<MapEventModel> events; //Field offset: 0x60
	private List<BlockerModel> blockersList; //Field offset: 0x68
	private List<Removeable> unityRemoveables; //Field offset: 0x70
	private List<RemoveableModel> removeableModels; //Field offset: 0x78
	private List<CoopAreaLayoutModel> coopAreaLayoutList; //Field offset: 0x80
	private List<RegenRemovableModel> regenRemovableModels; //Field offset: 0x88
	private MapGizmoModel[] gizmos; //Field offset: 0x90
	private float mapWideBloonSpeed; //Field offset: 0x98
	private List<SimulationBehaviorModel> simBehaviorModels; //Field offset: 0xA0
	private GameObject bossAmbientFx; //Field offset: 0xA8
	private GameObject[] inactiveMapAmbientFx; //Field offset: 0xB0

	public MapLoader(string mapName = null, Map map = null) { }

	[CompilerGenerated]
	private void <AddBossAmbientFx>b__44_0(AsyncOperationHandle<GameObject> h) { }

	public void AddAsset(PrefabReference asset, Vector3 position) { }

	public void AddBossAmbientFx(PrefabReference asset) { }

	private void CheckAndLoadHolidaySkins() { }

	private void CheckDeviceQuality() { }

	private void CleanUp() { }

	public void ClearBossAmbientFx() { }

	public void ClearMap() { }

	private void GatherCoopDivisionType(CoopDivision coopDivisionType) { }

	private void GatherMapAnimationsAndInitialise() { }

	private void GatherMapAreasAndBlockers() { }

	private void GatherMapBaseArea(CustomMapModel customMapModel) { }

	private void GatherMapBloonPathSpawners(CustomMapModel customMapModel) { }

	private void GatherMapCustomPaths(CustomMapModel customMapModel) { }

	private void GatherMapDefaultUnityActionStates() { }

	private void GatherMapEventsTriggersAndActions() { }

	private void GatherMapGizmos() { }

	private void GatherMapMods() { }

	private void GatherMapPaths() { }

	private void GatherMapRemoveablesData(CustomMapModel customMapModel) { }

	private void GatherMapSimulationBehaviors() { }

	public Map GetCurrentMap() { }

	public MapModel Load(CoopDivision coopDivisionType = 5, CustomMapModel customMapModel = null) { }

	[IteratorStateMachine(typeof(<LoadScene>d__22))]
	public IEnumerator LoadScene() { }

	public void OnReset() { }

	public void SetStartRound(int startRound) { }

	private void SupportLegacyRemoveables(List<Removeable> removeables, List<MapEventModel> events) { }

	public void ToggleAllAmbientFx(bool active) { }

	public void UpdateRound(int round, bool isSet) { }

}

