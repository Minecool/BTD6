namespace Assets.Scripts.Simulation.Towers.Projectiles.Behaviors;

public class TrackTarget : ProjectileBehavior
{
	public const int searchDelayFrames = 5; //Field offset: 0x0
	public TrackTargetModel trackTargetModel; //Field offset: 0x68
	public int lastElapsed; //Field offset: 0x70
	public int lastTargetSearchElapsed; //Field offset: 0x74
	public float turnRatePerFrame; //Field offset: 0x78
	private Filter disableFilterForTargetAquire; //Field offset: 0x80
	private TravelStrait travelStraight; //Field offset: 0x88
	private BloonFilter bloonFilter; //Field offset: 0x90

	public TrackTarget() { }

	public virtual void Attatched() { }

	protected override void CalculateDirection(int deltaFrames) { }

	public virtual void Collide(Bloon bloon) { }

	protected float GetAngleBetweenDirectionAndTarget(Vector3 targetLocation) { }

	private void GetNewTarget() { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	protected bool IsBloonValid(Bloon bloon) { }

	private bool IsTargetInSeekAngleRange(Vector3 targetLocation) { }

	protected virtual void OnDestroy() { }

	public void Process(int elapsed) { }

	public virtual void UpdatedModel(Model modelToUse) { }

}

