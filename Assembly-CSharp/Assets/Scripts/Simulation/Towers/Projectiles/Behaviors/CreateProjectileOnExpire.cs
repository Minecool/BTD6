namespace Assets.Scripts.Simulation.Towers.Projectiles.Behaviors;

public class CreateProjectileOnExpire : ProjectileBehavior
{
	private CreateProjectileOnExpireModel createProjectileOnExpireModel; //Field offset: 0x68
	private Emission emission; //Field offset: 0x70

	public CreateProjectileOnExpire() { }

	public virtual void Expired() { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	public virtual void UpdatedModel(Model modelToUse) { }

}

