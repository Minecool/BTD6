namespace Assets.Scripts.Simulation.Towers.Projectiles.Behaviors;

public class ProjectileFilter : ProjectileBehavior
{
	public ProjectileFilterModel projectileFilterModel; //Field offset: 0x68
	public List<Filter> filters; //Field offset: 0x70

	public ProjectileFilter() { }

	public virtual bool CantHitCamo() { }

	public virtual bool CantHitMoab() { }

	public virtual bool FilterCollision(Bloon bloon) { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	protected virtual void OnDestroy() { }

	public virtual bool OnlyHitMoab() { }

	public virtual void UpdatedModel(Model modelToUse) { }

}

