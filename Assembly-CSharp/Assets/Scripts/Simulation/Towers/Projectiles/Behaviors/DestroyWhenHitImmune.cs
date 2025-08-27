namespace Assets.Scripts.Simulation.Towers.Projectiles.Behaviors;

public class DestroyWhenHitImmune : ProjectileBehavior
{
	public DestroyWhenHitImmuneModel destroyWhenHitImmuneModel; //Field offset: 0x68

	public DestroyWhenHitImmune() { }

	public virtual bool CanBeDepleted() { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	public virtual void UpdatedModel(Model modelToUse) { }

}

