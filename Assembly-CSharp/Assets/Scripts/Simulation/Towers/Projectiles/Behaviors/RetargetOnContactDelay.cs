namespace Assets.Scripts.Simulation.Towers.Projectiles.Behaviors;

public class RetargetOnContactDelay : ProjectileBehavior
{
	public RetargetOnContactDelayModel retargetOnContactModel; //Field offset: 0x68
	private int currentBounceCount; //Field offset: 0x70
	public int delayStartedAt; //Field offset: 0x74
	public bool isInDelay; //Field offset: 0x78
	private TravelStrait travelStraight; //Field offset: 0x80
	private FollowPath followPath; //Field offset: 0x88
	private Instant instant; //Field offset: 0x90
	private BloonFilter bloonFilter; //Field offset: 0x98
	public List<Filter> filterList; //Field offset: 0xA0

	public RetargetOnContactDelay() { }

	[CompilerGenerated]
	private bool <Initialise>b__8_0(Bloon b) { }

	public virtual void Attatched() { }

	public virtual void Collide(Bloon bloon) { }

	private void CreateVisual(Vector3 from, Vector3 to) { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	protected virtual void OnDestroy() { }

	private void Process(int elapsed) { }

	private void Retarget() { }

	public virtual void UpdatedModel(Model modelToUse) { }

}

