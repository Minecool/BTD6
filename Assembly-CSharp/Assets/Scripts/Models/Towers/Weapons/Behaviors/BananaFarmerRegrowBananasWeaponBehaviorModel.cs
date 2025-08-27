namespace Assets.Scripts.Models.Towers.Weapons.Behaviors;

[Implementation(typeof(BananaFarmerRegrowBananasWeaponBehavior), False, False, new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {}])]
public class BananaFarmerRegrowBananasWeaponBehaviorModel : WeaponBehaviorModel
{
	public ProjectileModel regrowBananaPeelModel; //Field offset: 0x30
	public int regrowPerBanana; //Field offset: 0x38
	public CreateProjectileOnPickupModel createProjectileOnPickupModel; //Field offset: 0x40
	public CreateProjectileOnExpireModel createProjectileOnExpireModel; //Field offset: 0x48

	public BananaFarmerRegrowBananasWeaponBehaviorModel(string name, ProjectileModel regrowBananaPeelModel, int regrowPerBanana, CreateProjectileOnPickupModel createProjectileOnPickupModel, CreateProjectileOnExpireModel createProjectileOnExpireModel) { }

	public virtual Model Clone() { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

}

