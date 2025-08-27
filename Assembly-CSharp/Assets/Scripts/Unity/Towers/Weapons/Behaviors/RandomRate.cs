namespace Assets.Scripts.Unity.Towers.Weapons.Behaviors;

public class RandomRate : WeaponBehavior
{
	public RandomRate parent; //Field offset: 0x90
	public float rateOffset; //Field offset: 0x98
	public string expRateOffset; //Field offset: 0xA0

	public virtual WeaponBehaviorModel Def
	{
		 get { } //Length: 109
	}

	public RandomRate() { }

	public virtual WeaponBehaviorModel get_Def() { }

}

