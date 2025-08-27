namespace Assets.Scripts.Unity.Towers.Weapons.Behaviors;

public class LeakDangerAttackSpeed : WeaponBehavior
{
	public LeakDangerAttackSpeed parent; //Field offset: 0x90
	public float maxRateIncreasePercent; //Field offset: 0x98
	public string expMaxRateIncreasePercent; //Field offset: 0xA0

	public virtual WeaponBehaviorModel Def
	{
		 get { } //Length: 109
	}

	public LeakDangerAttackSpeed() { }

	public virtual WeaponBehaviorModel get_Def() { }

}

