namespace Assets.Scripts.Simulation.Towers.Behaviors;

public class CircleFootprint : TowerBehavior
{
	public CircleFootprintModel circleFootprintModel; //Field offset: 0x68

	public CircleFootprint() { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	public virtual void UpdatedModel(Model modelToUse) { }

}

