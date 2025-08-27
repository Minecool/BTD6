namespace Assets.Scripts.Simulation.Towers.Weapons.Behaviors;

public class ClearProjectileHitList : WeaponBehavior
{
	public ClearProjectileHitListModel clearProjectileHitListModel; //Field offset: 0x68
	private List<ObjectId> collisionList; //Field offset: 0x70
	private List<Projectile> projectileList; //Field offset: 0x78
	private float lastClear; //Field offset: 0x80

	public ClearProjectileHitList() { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	protected virtual void OnDestroy() { }

	public void Process(int elapsed) { }

	private void ProjectileDestroyed(RootObject projectile) { }

	public virtual void ProjectilesCreated(List<Projectile> projectiles) { }

	public virtual void UpdatedModel(Model modelToUse) { }

}

