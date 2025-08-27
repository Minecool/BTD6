namespace Assets.Scripts.Unity.Towers.Weapons.Behaviors;

public class AlternateProjectile : WeaponBehavior
{
	public AlternateProjectile parent; //Field offset: 0x90
	public Projectile projectile; //Field offset: 0x98
	public Projectile expProjectile; //Field offset: 0xA0
	public Emission alternateEmission; //Field offset: 0xA8
	public Emission expAlternateEmission; //Field offset: 0xB0
	public int interval; //Field offset: 0xB8
	public string expInterval; //Field offset: 0xC0
	public int alternateAnimation; //Field offset: 0xC8
	public string expAlternateAnimation; //Field offset: 0xD0

	public virtual WeaponBehaviorModel Def
	{
		 get { } //Length: 299
	}

	public AlternateProjectile() { }

	public virtual WeaponBehaviorModel get_Def() { }

}

