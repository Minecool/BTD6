namespace Assets.Scripts.Unity.Towers.Weapons.Behaviors;

public class BerserkerBrew : WeaponBehavior
{
	public BerserkerBrew parent; //Field offset: 0x90
	public float damageUp; //Field offset: 0x98
	public string expDamageUp; //Field offset: 0xA0
	public float pierceUp; //Field offset: 0xA8
	public string expPierceUp; //Field offset: 0xB0
	public float rateUp; //Field offset: 0xB8
	public string expRateUp; //Field offset: 0xC0
	public float rangeUp; //Field offset: 0xC8
	public string expRangeUp; //Field offset: 0xD0

	public virtual WeaponBehaviorModel Def
	{
		 get { } //Length: 88
	}

	public BerserkerBrew() { }

	public virtual WeaponBehaviorModel get_Def() { }

}

