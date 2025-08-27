namespace Assets.Scripts.Simulation.Towers.Filters;

public class FilterMoab : Filter
{
	public FilterMoabModel filterModel; //Field offset: 0x58

	public FilterMoab() { }

	public virtual bool CantTargetMoab() { }

	public virtual bool FilterBloon(Bloon bloon, Projectile projectile) { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	public virtual bool OnlyTargetsMoab() { }

	public virtual void UpdatedModel(Model modelToUse) { }

}

