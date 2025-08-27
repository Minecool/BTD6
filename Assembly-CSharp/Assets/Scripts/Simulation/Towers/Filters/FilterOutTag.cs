namespace Assets.Scripts.Simulation.Towers.Filters;

public class FilterOutTag : Filter
{
	public FilterOutTagModel filterOutTagModel; //Field offset: 0x58

	public FilterOutTag() { }

	public virtual bool CantTargetMoab() { }

	public virtual bool FilterBloon(Bloon bloon, Projectile projectile) { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	public virtual void UpdatedModel(Model modelToUse) { }

}

