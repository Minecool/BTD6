namespace Assets.Scripts.Simulation.Towers.Projectiles.Behaviors;

public class Damage : ProjectileBehavior
{
	public DamageModel damageModel; //Field offset: 0x68

	public Damage() { }

	public virtual void Collide(Bloon bloon) { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	public virtual void UpdatedModel(Model modelToUse) { }

}

