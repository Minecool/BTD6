namespace Assets.Scripts.Unity.Towers.Weapons.Behaviors;

public class HasUpgradeableProjectiles : WeaponBehavior
{
	public AddDisplayObject upgradeIndicators; //Field offset: 0x90
	public Projectile baseProjectile; //Field offset: 0x98
	public Projectile firstUpgradeProjectile; //Field offset: 0xA0
	public Projectile secondUpgradeProjectile; //Field offset: 0xA8

	public virtual WeaponBehaviorModel Def
	{
		 get { } //Length: 449
	}

	public HasUpgradeableProjectiles() { }

	public virtual WeaponBehaviorModel get_Def() { }

}

