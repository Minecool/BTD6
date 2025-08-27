namespace Assets.Scripts.Models.Towers.Weapons.Behaviors;

[Implementation(typeof(HasUpgradeableProjectiles), False, False, new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {}])]
public class HasUpgradeableProjectilesModel : WeaponBehaviorModel
{
	public string upgradeIndicatorId; //Field offset: 0x30
	public ProjectileModel[] projectiles; //Field offset: 0x38

	public HasUpgradeableProjectilesModel(string name, string upgradeIndicatorId, ProjectileModel[] projectiles) { }

	public virtual Model Clone() { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

}

