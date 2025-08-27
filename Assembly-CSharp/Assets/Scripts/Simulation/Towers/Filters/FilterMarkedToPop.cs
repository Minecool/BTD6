namespace Assets.Scripts.Simulation.Towers.Filters;

public class FilterMarkedToPop : Filter
{
	public FilterMarkedToPopModel filterMarkedToPopModel; //Field offset: 0x58
	private readonly HashSet<ObjectId> lineageToFilter; //Field offset: 0x60

	public FilterMarkedToPop() { }

	public void AddLineage(Bloon bloon) { }

	public void ClearLineage() { }

	public virtual bool FilterBloon(Bloon bloon, Projectile projectile) { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	public virtual void UpdatedModel(Model modelToUse) { }

}

