namespace Assets.Scripts.Unity.Towers.Weapons.Behaviors;

public class JungleVineLimitProjectile : WeaponBehavior
{
	public JungleVineLimitProjectile parent; //Field offset: 0x90
	public int limit; //Field offset: 0x98
	public string expLimit; //Field offset: 0xA0
	public float delay; //Field offset: 0xA8
	public string expDelay; //Field offset: 0xB0

	public virtual WeaponBehaviorModel Def
	{
		 get { } //Length: 144
	}

	public JungleVineLimitProjectile() { }

	public virtual WeaponBehaviorModel get_Def() { }

}

