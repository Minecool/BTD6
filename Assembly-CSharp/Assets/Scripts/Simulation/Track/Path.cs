namespace Assets.Scripts.Simulation.Track;

public class Path : IPath
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Comparison<BloonTargetProxy> <>9__27_0; //Field offset: 0x8
		public static Comparison<BloonTargetProxy> <>9__27_1; //Field offset: 0x10
		public static Comparison<BloonTargetProxy> <>9__27_2; //Field offset: 0x18

		private static <>c() { }

		public <>c() { }

		internal int <Init>b__27_0(BloonTargetProxy a, BloonTargetProxy b) { }

		internal int <Init>b__27_1(BloonTargetProxy a, BloonTargetProxy b) { }

		internal int <Init>b__27_2(BloonTargetProxy a, BloonTargetProxy b) { }

	}

	private static readonly float CacheDistance; //Field offset: 0x0
	public static readonly float MaxSegmentSize; //Field offset: 0x4
	public PathSegment[] segments; //Field offset: 0x10
	public PathModel def; //Field offset: 0x18
	public bool isActive; //Field offset: 0x20
	public bool isHidden; //Field offset: 0x21
	public float spawnDist; //Field offset: 0x24
	public float leakDist; //Field offset: 0x28
	public Splitter entryRouter; //Field offset: 0x30
	public Splitter exitRouter; //Field offset: 0x38
	public readonly LockList<Bloon> bloonsList; //Field offset: 0x40
	public bool hasBloons; //Field offset: 0x48
	public bool hasOfftrackBloons; //Field offset: 0x49
	public bool hasMoabs; //Field offset: 0x4A
	public bool onlyHasMoabs; //Field offset: 0x4B
	public bool onlyHasCamo; //Field offset: 0x4C
	public bool hideTrackArrows; //Field offset: 0x4D
	public Dictionary<Int32, BloonTargetProxy> targets; //Field offset: 0x50
	public Dictionary<Int32, Comparison`1<BloonTargetProxy>> targetCompare; //Field offset: 0x58
	private float maximumDistanceUntilLeak; //Field offset: 0x60
	private float maximumDistanceUntilSpawn; //Field offset: 0x64
	private BloonTargetProxy bestFirstAll; //Field offset: 0x68
	private BloonTargetProxy bestLastAll; //Field offset: 0x78
	private BloonTargetProxy bestStrongAll; //Field offset: 0x88
	private BloonTargetProxy bestFirstNonMoab; //Field offset: 0x98
	private BloonTargetProxy bestLastNonMoab; //Field offset: 0xA8
	private BloonTargetProxy bestStrongNonMoab; //Field offset: 0xB8
	private BloonTargetProxy bestFirstNonCamo; //Field offset: 0xC8
	private BloonTargetProxy bestLastNonCamo; //Field offset: 0xD8
	private BloonTargetProxy bestStrongNonCamo; //Field offset: 0xE8
	private BloonTargetProxy bestFirstNonMoabNonCamo; //Field offset: 0xF8
	private BloonTargetProxy bestLastNonMoabNonCamo; //Field offset: 0x108
	private BloonTargetProxy bestStrongNonMoabNonCamo; //Field offset: 0x118
	private QuickPointInfo[] pointInfos; //Field offset: 0x128
	private float totalPathLength; //Field offset: 0x130

	public override float Length
	{
		 get { } //Length: 9
	}

	public float MaxDistUntilLeak
	{
		 get { } //Length: 125
	}

	public float MaxDistUntilSpawn
	{
		 get { } //Length: 30
	}

	public float MaxDistUntilSpawnFromPathEnd
	{
		 get { } //Length: 129
	}

	private static Path() { }

	public Path(Simulation sim, PathModel def) { }

	public void AddBloon(Bloon bloon) { }

	private void CalcPointInfo(PointInfo[] points) { }

	public PointInfo DistanceToExtraPointInfoBloon(int pointIndex, float distance) { }

	public Path DistanceToPath(ref float distance, BloonModel bloonModel = null) { }

	public Path DistanceToPathTowardsDestinationPath(ref float distance, Path destPath) { }

	public override Vector3 DistanceToPoint(float distance) { }

	public QuickPointInfo DistanceToPointInfo(float distance) { }

	public QuickPointInfo DistanceToPointInfoBloon(float distance, BloonModel bloonModel) { }

	public Vector3 DistanceToPointSTL(ref float distance) { }

	public Vector3 DistanceToPointWithinFullPath(float distance) { }

	public float DistanceToRotation(float distance) { }

	public override Vector3 DistanceToTrajectory(float distance) { }

	private void FindBestBloon(BloonTargetProxy compareBloon) { }

	public override void FindDistanceSegmentsInCircle(float x, float y, float radius, List<DistanceBracket> list) { }

	public override void FindIntersections(float aX, float aY, float bX, float bY, List<Vector2> list) { }

	public override float FindPathMax() { }

	public override float get_Length() { }

	public float get_MaxDistUntilLeak() { }

	public float get_MaxDistUntilSpawn() { }

	public float get_MaxDistUntilSpawnFromPathEnd() { }

	public float GetEndDistanceExcludeInvulnerable() { }

	public List<Path> GetLeakPaths() { }

	public void Init() { }

	public void InitEntryExits(PathManager pathManager) { }

	public bool IsBloonInSegment(Bloon bloon) { }

	public bool IsEndOfMap(float distance, bool fromLeakDist = false) { }

	public bool IsInBoundsOfPath(float distance) { }

	public bool IsOnPath(Bloon bloon) { }

	public override bool IsPointInside(float x, float y) { }

	private bool IsPointOnMap(Vector3 point) { }

	public static bool IsSegmentInRange(PathSegment segment, Vector2 centre, float radius, bool onlyTargetsBloons = false, bool onlyTargetsMoabs = false, bool segmentMustHaveBloons = false) { }

	public bool IsStartOfMap(float distance, bool fromSpawnDist = false) { }

	public void ModPathPointInfo(string forID, Nullable<Single> bloonHeightOffset, Nullable<Single> moabHeightOffset, Nullable<Single> bloonScale, Nullable<Single> moabScale, Nullable<Boolean> bloonsInvulnerable, Nullable<Boolean> moabsInvulnerable) { }

	public void Process() { }

	public void Reset() { }

	public void UpdateActivePaths() { }

	private void UpdateBloonTags(Bloon bloon) { }

}

