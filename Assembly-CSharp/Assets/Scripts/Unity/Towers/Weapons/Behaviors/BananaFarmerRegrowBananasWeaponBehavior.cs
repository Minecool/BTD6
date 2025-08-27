namespace Assets.Scripts.Unity.Towers.Weapons.Behaviors;

public class BananaFarmerRegrowBananasWeaponBehavior : WeaponBehavior
{
	public BananaFarmerRegrowBananasWeaponBehavior parent; //Field offset: 0x90
	public Projectile regrowBanana; //Field offset: 0x98
	public Projectile expRegrowBanana; //Field offset: 0xA0
	public int regrowPerBanana; //Field offset: 0xA8
	public string expRegrowPerBanana; //Field offset: 0xB0

	public virtual WeaponBehaviorModel Def
	{
		 get { } //Length: 628
	}

	public BananaFarmerRegrowBananasWeaponBehavior() { }

	public virtual WeaponBehaviorModel get_Def() { }

}

