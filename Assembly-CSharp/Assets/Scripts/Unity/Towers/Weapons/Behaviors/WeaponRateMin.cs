namespace Assets.Scripts.Unity.Towers.Weapons.Behaviors;

public class WeaponRateMin : WeaponBehavior
{
	public WeaponRateMin parent; //Field offset: 0x90
	public float min; //Field offset: 0x98
	public string expMin; //Field offset: 0xA0

	public virtual WeaponBehaviorModel Def
	{
		 get { } //Length: 109
	}

	public WeaponRateMin() { }

	public virtual WeaponBehaviorModel get_Def() { }

}

