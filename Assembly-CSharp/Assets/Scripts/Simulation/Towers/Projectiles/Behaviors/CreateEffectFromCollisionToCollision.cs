namespace Assets.Scripts.Simulation.Towers.Projectiles.Behaviors;

public class CreateEffectFromCollisionToCollision : ProjectileBehavior
{
	private CreateEffectFromCollisionToCollisionModel createEffectModel; //Field offset: 0x68
	private Vector3 startPosition; //Field offset: 0x70

	public CreateEffectFromCollisionToCollision() { }

	public virtual void Collide(Bloon bloon) { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	public virtual void UpdatedModel(Model modelToUse) { }

}

