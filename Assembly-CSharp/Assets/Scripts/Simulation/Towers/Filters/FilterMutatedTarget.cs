namespace Assets.Scripts.Simulation.Towers.Filters;

public class FilterMutatedTarget : Filter
{
	public FilterMutatedTargetModel filterMutatedTargetModel; //Field offset: 0x58

	public FilterMutatedTarget() { }

	public virtual bool FilterBloon(Bloon bloon, Projectile projectile) { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	public virtual void UpdatedModel(Model modelToUse) { }

}

