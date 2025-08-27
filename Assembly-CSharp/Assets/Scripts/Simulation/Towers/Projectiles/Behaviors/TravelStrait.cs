namespace Assets.Scripts.Simulation.Towers.Projectiles.Behaviors;

public class TravelStrait : ProjectileBehavior
{
	public TravelStraitModel travelStraitModel; //Field offset: 0x68
	public float speedFrames; //Field offset: 0x70

	public TravelStrait() { }

	public float GetRemainingDistance() { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	protected override void Process(int elapsed) { }

	public virtual void UpdatedModel(Model modelToUse) { }

}

