namespace Assets.Scripts.Simulation.Towers.Behaviors;

public class RectangleFootprint : TowerBehavior
{
	public RectangleFootprintModel rectangleFootprintModel; //Field offset: 0x68

	public RectangleFootprint() { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	public virtual void UpdatedModel(Model modelToUse) { }

}

