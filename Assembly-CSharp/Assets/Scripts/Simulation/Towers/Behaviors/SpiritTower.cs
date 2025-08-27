namespace Assets.Scripts.Simulation.Towers.Behaviors;

public class SpiritTower : TowerBehavior
{
	public SpiritTowerModel spiritTowerModel; //Field offset: 0x68
	public SpiritTowerMovement movementBehavior; //Field offset: 0x70

	public SpiritTower() { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	protected virtual void OnDestroy() { }

	public virtual void OnUpgraded(int pathUpgraded) { }

	public virtual void UpdatedModel(Model modelToUse) { }

}

