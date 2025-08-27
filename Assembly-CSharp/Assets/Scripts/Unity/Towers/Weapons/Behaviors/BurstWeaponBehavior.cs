namespace Assets.Scripts.Unity.Towers.Weapons.Behaviors;

public class BurstWeaponBehavior : WeaponBehavior
{
	public BurstWeaponBehavior parent; //Field offset: 0x90
	public float interval; //Field offset: 0x98
	public string expInterval; //Field offset: 0xA0
	public int count; //Field offset: 0xA8
	public string expCount; //Field offset: 0xB0
	public bool alwaysEmptyClip; //Field offset: 0xB8
	public string expAlwaysEmptyClip; //Field offset: 0xC0

	public virtual WeaponBehaviorModel Def
	{
		 get { } //Length: 155
	}

	public BurstWeaponBehavior() { }

	public virtual WeaponBehaviorModel get_Def() { }

}

