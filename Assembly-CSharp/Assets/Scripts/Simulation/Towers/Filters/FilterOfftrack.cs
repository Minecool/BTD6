namespace Assets.Scripts.Simulation.Towers.Filters;

public class FilterOfftrack : Filter
{
	public FilterOfftrackModel filterOfftrackModel; //Field offset: 0x58

	public FilterOfftrack() { }

	public virtual bool FilterBloon(Bloon bloon, Projectile projectile) { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	public virtual void UpdatedModel(Model modelToUse) { }

}

