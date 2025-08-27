namespace Assets.Scripts.Simulation.Towers.Projectiles.Behaviors;

public class IgnoreCollisionAfterCollide : ProjectileBehavior
{
	public IgnoreCollisionAfterCollideModel ignoreCollisionAfterCollideModel; //Field offset: 0x68
	private int timeOfLastCollide; //Field offset: 0x70

	public IgnoreCollisionAfterCollide() { }

	public virtual void Collide(Bloon bloon) { }

	public virtual bool FilterCollision(Bloon bloon) { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	public virtual void UpdatedModel(Model modelToUse) { }

}

