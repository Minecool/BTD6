namespace Assets.Scripts.Simulation.Towers.Filters;

public class FilterIfAttackHasTarget : Filter
{
	public FilterIfAttackHasTargetModel filterIfAttackHasTargetModel; //Field offset: 0x58
	private Attack attack; //Field offset: 0x60

	public FilterIfAttackHasTarget() { }

	public virtual bool FilterBloon(Bloon bloon, Projectile projectile) { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	public virtual void UpdatedModel(Model modelToUse) { }

}

