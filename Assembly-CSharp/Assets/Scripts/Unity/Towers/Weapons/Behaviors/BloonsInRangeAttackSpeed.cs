namespace Assets.Scripts.Unity.Towers.Weapons.Behaviors;

public class BloonsInRangeAttackSpeed : WeaponBehavior
{
	public BloonsInRangeAttackSpeed parent; //Field offset: 0x90
	public float rateIncreasePerStack; //Field offset: 0x98
	public string expRateIncreasePerStack; //Field offset: 0xA0
	public int bloonsPerStack; //Field offset: 0xA8
	public string expBloonsPerStack; //Field offset: 0xB0
	public int maxStacks; //Field offset: 0xB8
	public string expMaxStacks; //Field offset: 0xC0

	public virtual WeaponBehaviorModel Def
	{
		 get { } //Length: 154
	}

	public BloonsInRangeAttackSpeed() { }

	public virtual WeaponBehaviorModel get_Def() { }

}

