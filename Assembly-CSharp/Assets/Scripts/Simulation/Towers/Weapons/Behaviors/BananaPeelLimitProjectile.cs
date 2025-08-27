namespace Assets.Scripts.Simulation.Towers.Weapons.Behaviors;

public class BananaPeelLimitProjectile : WeaponBehavior
{
	public BananaPeelLimitProjectileModel bananaPeelLimitProjectileModel; //Field offset: 0x68
	public int amountTowardsEmission; //Field offset: 0x70

	public BananaPeelLimitProjectile() { }

	public virtual bool FilterEmission() { }

	public virtual void GetSaveMetaData(Dictionary<String, String> metaData) { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	protected virtual void OnDestroy() { }

	public virtual void ProjectilesCreated(List<Projectile> projectiles) { }

	public virtual void SetSaveMetaData(Dictionary<String, String> metaData) { }

	public virtual void UpdatedModel(Model modelToUse) { }

}

