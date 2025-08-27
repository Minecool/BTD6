namespace Assets.Scripts.Unity.Towers.Weapons.Behaviors;

public class RandomSpeedOffset : WeaponBehavior
{
	public RandomSpeedOffset parent; //Field offset: 0x90
	public int minOffset; //Field offset: 0x98
	public string expMinOffset; //Field offset: 0xA0
	public int maxOffset; //Field offset: 0xA8
	public string expMaxOffset; //Field offset: 0xB0

	public virtual WeaponBehaviorModel Def
	{
		 get { } //Length: 132
	}

	public RandomSpeedOffset() { }

	public virtual WeaponBehaviorModel get_Def() { }

}

