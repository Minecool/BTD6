namespace Assets.Scripts.Unity.Towers.Weapons.Behaviors;

public class CritMultiplier : WeaponBehavior
{
	public CritMultiplier parent; //Field offset: 0x90
	public float damage; //Field offset: 0x98
	public string expDamage; //Field offset: 0xA0
	public float spacingLower; //Field offset: 0xA8
	public string expSpacingLower; //Field offset: 0xB0
	public float spacingUpper; //Field offset: 0xB8
	public string expSpacingUpper; //Field offset: 0xC0
	public string distributeToChildren; //Field offset: 0xC8
	public string expDistributeToChildren; //Field offset: 0xD0
	public GameObject display; //Field offset: 0xD8
	public GameObject expDisplay; //Field offset: 0xE0

	public virtual WeaponBehaviorModel Def
	{
		 get { } //Length: 451
	}

	public CritMultiplier() { }

	public virtual WeaponBehaviorModel get_Def() { }

}

