namespace Assets.Scripts.Simulation.Towers.Projectiles.Behaviors;

public class Knockback : ProjectileBehavior
{
	public KnockbackModel knockbackModel; //Field offset: 0x68

	public Knockback() { }

	public virtual void Collide(Bloon bloon) { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	public virtual void UpdatedModel(Model modelToUse) { }

}

