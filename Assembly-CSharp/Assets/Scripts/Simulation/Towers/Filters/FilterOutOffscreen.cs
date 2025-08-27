namespace Assets.Scripts.Simulation.Towers.Filters;

public class FilterOutOffscreen : Filter
{
	public FilterOutOffscreenModel filterOutOffscreenModel; //Field offset: 0x58

	public FilterOutOffscreen() { }

	public virtual bool FilterBloon(Bloon bloon, Projectile projectile) { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	public virtual void UpdatedModel(Model modelToUse) { }

}

