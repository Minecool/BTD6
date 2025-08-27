namespace Assets.Scripts.Simulation.Towers.Filters;

public class FilterOutBloon : Filter
{
	public FilterOutBloonModel filterOutBloonModel; //Field offset: 0x58

	public FilterOutBloon() { }

	public virtual bool FilterBloon(Bloon bloon, Projectile projectile) { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	public virtual void UpdatedModel(Model modelToUse) { }

}

