namespace Assets.Scripts.Simulation.Towers.Behaviors.Attack.Behaviors;

public class NecromancerTargetTrackWithinRange : TargetTrack
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass20_0
	{
		public NecromancerTargetTrackWithinRange <>4__this; //Field offset: 0x10
		public Bloon firstForCurrentPath; //Field offset: 0x18

		public <>c__DisplayClass20_0() { }

		internal bool <GetTargets>b__0(PathSegment pathSegment) { }

		internal bool <GetTargets>b__1(PathSegment pathSegment) { }

		internal bool <GetTargets>b__2(PathSegment pathSegment) { }

	}

	public NecromancerTargetTrackWithinRangeModel necromancerTargetTrackWithinRangeModel; //Field offset: 0x90
	public IEnumerable<PathSegment> lastPathSegments; //Field offset: 0x98
	public IEnumerable<Target> smartTargets; //Field offset: 0xA0
	public Dictionary<Path, Single> lastPathSegmentDistanceForPaths; //Field offset: 0xA8
	public int currentPathIndex; //Field offset: 0xB0
	public int pathIndexToSet; //Field offset: 0xB4
	private List<Target> selectedPathSegments; //Field offset: 0xB8
	private readonly List<Path> pathsInRange; //Field offset: 0xC0
	private Entity targetImg; //Field offset: 0xC8
	private bool drawing; //Field offset: 0xD0

	public PathSegment SelectedPathSegment
	{
		 get { } //Length: 111
	}

	public NecromancerTargetTrackWithinRange() { }

	public virtual void ApplyTargetTypeData(Vector2 data) { }

	private void CheckSelectedPathSegment() { }

	public virtual void ClearTargetTypeData() { }

	public bool FilterBloon(Bloon bloon) { }

	public virtual void GeneratePoints() { }

	public PathSegment get_SelectedPathSegment() { }

	public virtual string GetName() { }

	public virtual void GetSaveMetaData(Dictionary<String, String> metaData) { }

	public virtual IEnumerable<Target> GetTargets() { }

	public virtual object GetTargetTypeCustomInputData() { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	public virtual void LateSetSaveMetaData(Dictionary<String, String> metaData) { }

	protected virtual void OnDestroy() { }

	public virtual void OnProjectilesCreated(List<Projectile> projectiles) { }

	private void Process(int elapsed) { }

	public virtual void SetUpAttack() { }

	public void StartDraw() { }

	public void StopDraw() { }

	public virtual bool TargetsTrack() { }

	public virtual void UpdatedModel(Model modelToUse) { }

}

