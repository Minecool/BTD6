namespace Assets.Scripts.Unity.Towers.Weapons.Behaviors;

public class LimitProjectile : WeaponBehavior
{
	public LimitProjectile parent; //Field offset: 0x90
	public Projectile projectile; //Field offset: 0x98
	public Projectile expProjectile; //Field offset: 0xA0
	public int limit; //Field offset: 0xA8
	public string expLimit; //Field offset: 0xB0
	public float delay; //Field offset: 0xB8
	public string expDelay; //Field offset: 0xC0
	public bool limitByDestroyedPriorProjectile; //Field offset: 0xC8
	public string expLimitByDestroyedPriorProjectile; //Field offset: 0xD0
	public bool globalForPlayer; //Field offset: 0xD8
	public string expGlobalForPlayer; //Field offset: 0xE0

	public virtual WeaponBehaviorModel Def
	{
		 get { } //Length: 245
	}

	public LimitProjectile() { }

	public virtual WeaponBehaviorModel get_Def() { }

}

