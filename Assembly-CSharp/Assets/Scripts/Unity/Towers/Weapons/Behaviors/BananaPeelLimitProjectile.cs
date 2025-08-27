namespace Assets.Scripts.Unity.Towers.Weapons.Behaviors;

public class BananaPeelLimitProjectile : WeaponBehavior
{
	public BananaPeelLimitProjectile parent; //Field offset: 0x90
	public Projectile projectile; //Field offset: 0x98
	public Projectile expProjectile; //Field offset: 0xA0
	public int bananasRequired; //Field offset: 0xA8
	public string expBananasRequired; //Field offset: 0xB0

	public virtual WeaponBehaviorModel Def
	{
		 get { } //Length: 159
	}

	public BananaPeelLimitProjectile() { }

	public virtual WeaponBehaviorModel get_Def() { }

}

