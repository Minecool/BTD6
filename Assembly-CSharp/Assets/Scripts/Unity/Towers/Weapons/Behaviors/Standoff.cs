namespace Assets.Scripts.Unity.Towers.Weapons.Behaviors;

public class Standoff : WeaponBehavior
{
	public Standoff parent; //Field offset: 0x90
	public float maxRateIncrease; //Field offset: 0x98
	public string expMaxRateIncrease; //Field offset: 0xA0
	public float rateDecreasePerBloon; //Field offset: 0xA8
	public string expRateDecreasePerBloon; //Field offset: 0xB0

	public virtual WeaponBehaviorModel Def
	{
		 get { } //Length: 136
	}

	public Standoff() { }

	public virtual WeaponBehaviorModel get_Def() { }

}

