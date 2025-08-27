namespace Assets.Scripts.Simulation.Towers.Filters;

public class FilterInvisible : Filter
{
	public FilterInvisibleModel filterInvisibleModel; //Field offset: 0x58

	public FilterInvisible() { }

	public virtual bool CantTargetCamo() { }

	public virtual bool FilterBloon(Bloon bloon, Projectile projectile) { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	public virtual void UpdatedModel(Model modelToUse) { }

}

