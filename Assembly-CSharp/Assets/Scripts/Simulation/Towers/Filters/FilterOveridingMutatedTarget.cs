namespace Assets.Scripts.Simulation.Towers.Filters;

public class FilterOveridingMutatedTarget : Filter
{
	public FilterOveridingMutatedTargetModel filterOveridingMutatedTargetModel; //Field offset: 0x58

	public FilterOveridingMutatedTarget() { }

	public virtual bool FilterBloon(Bloon bloon, Projectile projectile) { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	public virtual void UpdatedModel(Model modelToUse) { }

}

