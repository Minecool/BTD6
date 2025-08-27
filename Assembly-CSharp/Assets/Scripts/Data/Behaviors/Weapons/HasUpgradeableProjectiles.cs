namespace Assets.Scripts.Data.Behaviors.Weapons;

[CreateAssetMenu(fileName = "HasUpgradeableProjectiles", menuName = "BTD6/Behaviors/Weapons/HasUpgradeableProjectiles")]
public class HasUpgradeableProjectiles : WeaponBehavior
{
	public AddDisplayObject upgradeIndicators; //Field offset: 0x30
	public Projectile baseProjectile; //Field offset: 0x38
	public Projectile firstUpgradeProjectile; //Field offset: 0x40
	public Projectile secondUpgradeProjectile; //Field offset: 0x48

	public virtual WeaponBehaviorModel Def
	{
		 get { } //Length: 478
	}

	public HasUpgradeableProjectiles() { }

	public virtual WeaponBehaviorModel get_Def() { }

}

