namespace Assets.Scripts.Simulation.Towers.Filters;

public class FilterWithChance : Filter
{
	public FilterWithChanceModel filterWithChanceModel; //Field offset: 0x58

	public FilterWithChance() { }

	public virtual bool FilterBloon(Bloon bloon, Projectile projectile) { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	public virtual void UpdatedModel(Model modelToUse) { }

}

