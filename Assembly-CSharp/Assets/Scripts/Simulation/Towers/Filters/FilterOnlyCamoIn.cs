namespace Assets.Scripts.Simulation.Towers.Filters;

public class FilterOnlyCamoIn : Filter
{
	public FilterOnlyCamoInModel filterCamoModel; //Field offset: 0x58

	public FilterOnlyCamoIn() { }

	public virtual bool CantTargetCamo() { }

	public virtual bool FilterBloon(Bloon bloon, Projectile projectile) { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	public virtual void UpdatedModel(Model modelToUse) { }

}

