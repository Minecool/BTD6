namespace Assets.Scripts.Simulation.Towers.Projectiles;

public abstract class ProjectileBehavior : EntityBehavior, IProjectileBehavior, IEntityBehavior
{
	public Projectile projectile; //Field offset: 0x60

	protected ProjectileBehavior() { }

	public override bool CantHitCamo() { }

	public override bool CantHitMoab() { }

	public virtual void Cleanup() { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	public override bool OnlyHitMoab() { }

}

