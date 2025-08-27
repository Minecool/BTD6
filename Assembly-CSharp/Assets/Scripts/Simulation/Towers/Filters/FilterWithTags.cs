namespace Assets.Scripts.Simulation.Towers.Filters;

public class FilterWithTags : Filter
{
	public FilterWithTagsModel filterWithTagsModel; //Field offset: 0x58

	public FilterWithTags() { }

	public virtual bool CantTargetMoab() { }

	public virtual bool FilterBloon(Bloon bloon, Projectile projectile) { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	public virtual void UpdatedModel(Model modelToUse) { }

}

