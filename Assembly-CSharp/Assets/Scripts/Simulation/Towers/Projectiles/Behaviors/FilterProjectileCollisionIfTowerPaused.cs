namespace Assets.Scripts.Simulation.Towers.Projectiles.Behaviors;

public class FilterProjectileCollisionIfTowerPaused : ProjectileBehavior
{
	public FilterProjectileCollisionIfTowerPausedModel filterProjectileCollisionIfTowerPausedModel; //Field offset: 0x68
	private ICommonBehaviorProxy parentOwner; //Field offset: 0x70

	public FilterProjectileCollisionIfTowerPaused() { }

	public virtual bool FilterCollision(Bloon bloon) { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	protected virtual void OnDestroy() { }

	public virtual void UpdatedModel(Model modelToUse) { }

}

