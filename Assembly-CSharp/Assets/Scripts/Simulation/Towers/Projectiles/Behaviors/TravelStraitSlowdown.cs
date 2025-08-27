namespace Assets.Scripts.Simulation.Towers.Projectiles.Behaviors;

public class TravelStraitSlowdown : TravelStrait
{
	public TravelStraitSlowdownModel travelStraightSlowdownModel; //Field offset: 0x78
	private float distanceTraveled; //Field offset: 0x80
	public float startingSpeedFrames; //Field offset: 0x84
	public float minimumSpeedFrames; //Field offset: 0x88
	private int currentPierceReduction; //Field offset: 0x8C

	public TravelStraitSlowdown() { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	protected virtual void Process(int elapsed) { }

	public virtual void UpdatedModel(Model modelToUse) { }

}

