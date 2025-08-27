namespace Assets.Scripts.Simulation.Towers.Projectiles.Behaviors;

public class ProjectileBlockerCollisionRebound : ProjectileBehavior
{
	public ProjectileBlockerCollisionReboundModel projectileBlockerCollisionReboundModel; //Field offset: 0x68
	private Vector3 lastPosition; //Field offset: 0x70

	public ProjectileBlockerCollisionRebound() { }

	public virtual bool FilterMapCollision(MapBlocker blocker) { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	protected virtual void OnDestroy() { }

	private void Process(int elapsed) { }

	public virtual void SetStartPosition(Vector3 pos) { }

	public virtual void UpdatedModel(Model modelToUse) { }

}

