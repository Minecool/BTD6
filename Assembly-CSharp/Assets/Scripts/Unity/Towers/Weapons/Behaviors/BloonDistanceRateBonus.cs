namespace Assets.Scripts.Unity.Towers.Weapons.Behaviors;

public class BloonDistanceRateBonus : WeaponBehavior
{
	public BloonDistanceRateBonus parent; //Field offset: 0x90
	public float rateBonusPerRange; //Field offset: 0x98
	public string expRateBonusPerRange; //Field offset: 0xA0
	public int rangeMax; //Field offset: 0xA8
	public string expRangeMax; //Field offset: 0xB0

	public virtual WeaponBehaviorModel Def
	{
		 get { } //Length: 134
	}

	public BloonDistanceRateBonus() { }

	public virtual WeaponBehaviorModel get_Def() { }

}

