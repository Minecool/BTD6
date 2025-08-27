namespace Assets.Scripts.Simulation.Towers.Projectiles.Behaviors;

public class CreateEffectFollowProjectile : ProjectileBehavior
{
	private CreateEffectFollowProjectileModel createEffectFollowProjectileModel; //Field offset: 0x68

	public CreateEffectFollowProjectile() { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	public virtual void UpdatedModel(Model modelToUse) { }

}

