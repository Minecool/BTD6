namespace Assets.Scripts.Simulation.Towers.Behaviors;

internal class PropRemoveableCost : TowerBehavior
{
	public PropRemoveableCostModel behaviorModel; //Field offset: 0x68

	public PropRemoveableCost() { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	public virtual void UpdatedModel(Model modelToUse) { }

}

