namespace Assets.Scripts.Simulation.Towers.Projectiles.Behaviors;

public class LinearTravel : ProjectileBehavior
{
	public LinearTravelModel linearTravelModel; //Field offset: 0x68
	private bool forcedCollision; //Field offset: 0x70

	public LinearTravel() { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	protected override void Process(int elapsed) { }

	public virtual void UpdatedModel(Model modelToUse) { }

}

