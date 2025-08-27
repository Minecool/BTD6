namespace Assets.Scripts.Simulation.Towers.Filters;

public class FilterAllExceptTarget : Filter
{
	public FilterAllExceptTargetModel filterAllExceptTargetModel; //Field offset: 0x58

	public FilterAllExceptTarget() { }

	public virtual bool FilterBloon(Bloon bloon, Projectile projectile) { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	public virtual void UpdatedModel(Model modelToUse) { }

}

