namespace Assets.Scripts.Simulation.Towers.Filters;

public class FilterCollisionWhileMoving : Filter
{
	public FilterCollisionWhileMoving filterWithTagModel; //Field offset: 0x58
	public FollowPath followPath; //Field offset: 0x60

	public FilterCollisionWhileMoving() { }

	public virtual bool FilterBloon(Bloon bloon, Projectile projectile) { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	public virtual void UpdatedModel(Model modelToUse) { }

}

