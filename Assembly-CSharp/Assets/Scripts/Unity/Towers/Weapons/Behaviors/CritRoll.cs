namespace Assets.Scripts.Unity.Towers.Weapons.Behaviors;

public class CritRoll : WeaponBehavior
{
	public CritRoll parent; //Field offset: 0x90
	public float damageAdditive; //Field offset: 0x98
	public string expDamageAdditive; //Field offset: 0xA0
	public float damageMultiplier; //Field offset: 0xA8
	public string expDamageMultiplier; //Field offset: 0xB0
	public float chance; //Field offset: 0xB8
	public string expChance; //Field offset: 0xC0
	public GameObject display; //Field offset: 0xC8
	public GameObject expDisplay; //Field offset: 0xD0

	public virtual WeaponBehaviorModel Def
	{
		 get { } //Length: 233
	}

	public CritRoll() { }

	public virtual WeaponBehaviorModel get_Def() { }

}

