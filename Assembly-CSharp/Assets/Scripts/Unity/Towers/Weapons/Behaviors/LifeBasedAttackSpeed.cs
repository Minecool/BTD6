namespace Assets.Scripts.Unity.Towers.Weapons.Behaviors;

public class LifeBasedAttackSpeed : WeaponBehavior
{
	public LifeBasedAttackSpeed parent; //Field offset: 0x90
	public float ratePerLife; //Field offset: 0x98
	public string expRatePerLife; //Field offset: 0xA0
	public int lifeCap; //Field offset: 0xA8
	public string expLifeCap; //Field offset: 0xB0
	public float baseRateIncrease; //Field offset: 0xB8
	public string expBaseRateIncrease; //Field offset: 0xC0
	public string saveId; //Field offset: 0xC8
	public string expSaveId; //Field offset: 0xD0

	public virtual WeaponBehaviorModel Def
	{
		 get { } //Length: 220
	}

	public LifeBasedAttackSpeed() { }

	public virtual WeaponBehaviorModel get_Def() { }

}

