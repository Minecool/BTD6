namespace Assets.Scripts.Simulation.Towers.Filters;

public class FilterFrozenBloons : Filter
{
	public FilterFrozenBloonsModel filterMutatedTargetIfDamageIsTypeModel; //Field offset: 0x58

	public FilterFrozenBloons() { }

	public virtual bool FilterBloon(Bloon bloon, Projectile projectile) { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	public virtual void UpdatedModel(Model modelToUse) { }

}

