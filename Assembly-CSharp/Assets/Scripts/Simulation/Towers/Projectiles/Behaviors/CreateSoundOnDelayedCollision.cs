namespace Assets.Scripts.Simulation.Towers.Projectiles.Behaviors;

public class CreateSoundOnDelayedCollision : ProjectileBehavior
{
	public CreateSoundOnDelayedCollisionModel createSoundOnDelayedCollisionModel; //Field offset: 0x68

	public CreateSoundOnDelayedCollision() { }

	public virtual void Collide(Bloon bloon) { }

	public virtual bool CollideMap(MapBlocker blocker) { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	private void PlayProjectileImpactSound() { }

	public virtual void UpdatedModel(Model modelToUse) { }

}

