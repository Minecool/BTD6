namespace Assets.Scripts.Simulation.Towers.Behaviors;

public class RotateToDefaultPositionTower : TowerBehavior
{
	public RotateToDefaultPositionTowerModel modl; //Field offset: 0x68

	public RotateToDefaultPositionTower() { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	public virtual void OnUpgraded(int pathUpgraded) { }

	public virtual void UpdatedModel(Model modelToUse) { }

}

