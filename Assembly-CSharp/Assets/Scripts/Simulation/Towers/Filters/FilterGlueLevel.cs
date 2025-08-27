namespace Assets.Scripts.Simulation.Towers.Filters;

public class FilterGlueLevel : Filter
{
	public FilterGlueLevelModel glueModel; //Field offset: 0x58

	public FilterGlueLevel() { }

	public virtual bool FilterBloon(Bloon bloon, Projectile projectile) { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	public virtual void UpdatedModel(Model modelToUse) { }

}

