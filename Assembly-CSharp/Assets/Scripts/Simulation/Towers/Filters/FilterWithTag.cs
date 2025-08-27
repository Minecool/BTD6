namespace Assets.Scripts.Simulation.Towers.Filters;

public class FilterWithTag : Filter
{
	public FilterWithTagModel filterWithTagModel; //Field offset: 0x58

	public FilterWithTag() { }

	public virtual bool CantTargetMoab() { }

	public virtual bool FilterBloon(Bloon bloon, Projectile projectile) { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	public virtual bool OnlyTargetsMoab() { }

	public virtual void UpdatedModel(Model modelToUse) { }

}

