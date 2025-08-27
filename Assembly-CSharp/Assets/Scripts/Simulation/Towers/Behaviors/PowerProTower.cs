namespace Assets.Scripts.Simulation.Towers.Behaviors;

public class PowerProTower : TowerBehavior
{
	public PowerProTowerModel powerProTowerModel; //Field offset: 0x68

	public PowerProTower() { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	protected virtual void OnDestroy() { }

	public virtual void UpdatedModel(Model modelToUse) { }

}

