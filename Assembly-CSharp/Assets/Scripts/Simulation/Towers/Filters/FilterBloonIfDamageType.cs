namespace Assets.Scripts.Simulation.Towers.Filters;

public class FilterBloonIfDamageType : Filter
{
	public FilterBloonIfDamageTypeModel filterBloonIfDamageTypeModel; //Field offset: 0x58

	public FilterBloonIfDamageType() { }

	public virtual void AfterAttached(Projectile projectile) { }

	public virtual bool FilterBloon(Bloon bloon, Projectile projectile) { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	public virtual void UpdatedModel(Model modelToUse) { }

}

