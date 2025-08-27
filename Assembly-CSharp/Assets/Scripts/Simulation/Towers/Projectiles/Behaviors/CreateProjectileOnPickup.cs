namespace Assets.Scripts.Simulation.Towers.Projectiles.Behaviors;

public class CreateProjectileOnPickup : ProjectileBehavior
{
	public CreateProjectileOnPickupModel createProjectileOnPickupModel; //Field offset: 0x68
	private Emission emission; //Field offset: 0x70

	public CreateProjectileOnPickup() { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	public virtual float Pickup(Tower towerPickingUp) { }

	public virtual void UpdatedModel(Model modelToUse) { }

}

