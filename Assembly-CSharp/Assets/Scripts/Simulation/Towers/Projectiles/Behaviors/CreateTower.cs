namespace Assets.Scripts.Simulation.Towers.Projectiles.Behaviors;

public class CreateTower : ProjectileBehavior
{
	public CreateTowerModel createTowerModel; //Field offset: 0x68

	public CreateTower() { }

	public virtual void Exhausted() { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	public virtual void UpdatedModel(Model modelToUse) { }

}

