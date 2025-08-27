namespace Assets.Scripts.Simulation.Towers.Filters;

public class FilterAll : Filter
{
	public FilterAllModel filterAllModel; //Field offset: 0x58

	public FilterAll() { }

	public virtual bool FilterBloon(Bloon bloon, Projectile projectile) { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	public virtual void UpdatedModel(Model modelToUse) { }

}

