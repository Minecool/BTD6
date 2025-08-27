namespace Assets.Scripts.Simulation.Towers.Filters;

public class FilterInvisibleSubIntel : FilterInvisible
{
	public FilterInvisibleSubIntelModel modl; //Field offset: 0x60

	public FilterInvisibleSubIntel() { }

	public virtual bool CantTargetCamo() { }

	public virtual bool FilterBloon(Bloon bloon, Projectile projectile) { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	public virtual void UpdatedModel(Model modelToUse) { }

}

