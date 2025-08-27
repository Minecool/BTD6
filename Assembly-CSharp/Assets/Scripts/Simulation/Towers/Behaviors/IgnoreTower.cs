namespace Assets.Scripts.Simulation.Towers.Behaviors;

internal class IgnoreTower : TowerBehavior
{
	public IgnoreTowerModel ignoreTowerModel; //Field offset: 0x68

	public IgnoreTower() { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	protected virtual void OnDestroy() { }

	public virtual void UpdatedModel(Model modelToUse) { }

}

