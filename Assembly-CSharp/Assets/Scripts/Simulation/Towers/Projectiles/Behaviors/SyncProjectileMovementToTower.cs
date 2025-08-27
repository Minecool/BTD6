namespace Assets.Scripts.Simulation.Towers.Projectiles.Behaviors;

public class SyncProjectileMovementToTower : ProjectileBehavior
{
	private Tower tower; //Field offset: 0x68
	public SyncProjectileMovementToTowerModel syncMovementModel; //Field offset: 0x70

	public SyncProjectileMovementToTower() { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	public void Process(int elapsed) { }

	public virtual void UpdatedModel(Model modelToUse) { }

}

