namespace Assets.Scripts.Simulation.Towers.Projectiles.Behaviors;

public class TravelCurvy : TravelStrait
{
	public TravelCurvyModel travelCurvyModel; //Field offset: 0x78
	private bool incrementing; //Field offset: 0x80
	private Nullable<Single> initialAngle; //Field offset: 0x84
	private float angleMin; //Field offset: 0x8C
	private float angleMax; //Field offset: 0x90
	private TrackTarget trackTarget; //Field offset: 0x98

	public TravelCurvy() { }

	public virtual void Attatched() { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	protected virtual void Process(int elapsed) { }

	public virtual void UpdatedModel(Model modelToUse) { }

}

