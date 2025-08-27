namespace Assets.Scripts.Simulation.Towers.Behaviors;

public class GlobalRangeCircle : TowerBehavior
{
	public GlobalRangeCircleModel globalRangeCircleModel; //Field offset: 0x68
	private GlobalRangeMesh rangeMesh; //Field offset: 0x70

	public GlobalRangeCircle() { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	protected virtual void OnDestroy() { }

	public virtual void UpdatedModel(Model modelToUse) { }

}

