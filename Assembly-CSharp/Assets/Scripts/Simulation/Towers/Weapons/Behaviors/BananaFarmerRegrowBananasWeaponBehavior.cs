namespace Assets.Scripts.Simulation.Towers.Weapons.Behaviors;

public class BananaFarmerRegrowBananasWeaponBehavior : WeaponBehavior
{
	public BananaFarmerRegrowBananasWeaponBehaviorModel bananaFarmerRegrowBananasWeaponBehavior; //Field offset: 0x68
	public int countTowardsRegrow; //Field offset: 0x70
	private Dictionary<ProjectileModel, ProjectileModel> projectileModelCache; //Field offset: 0x78

	public BananaFarmerRegrowBananasWeaponBehavior() { }

	public virtual ProjectileModel GetProjectile(ProjectileModel currentProjectileDef, bool doubleShot = false) { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	private bool IsProjectileValid(ProjectileModel projectileModel) { }

	protected virtual void OnDestroy() { }

	public virtual void UpdatedModel(Model modelToUse) { }

}

