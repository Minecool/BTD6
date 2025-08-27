namespace Assets.Scripts.Unity.Towers.Weapons.Behaviors;

public class FireWhenAlternateWeaponIsReady : WeaponBehavior
{
	public FireWhenAlternateWeaponIsReady parent; //Field offset: 0x90
	public int weaponId; //Field offset: 0x98
	public string expWeaponId; //Field offset: 0xA0

	public virtual WeaponBehaviorModel Def
	{
		 get { } //Length: 107
	}

	public FireWhenAlternateWeaponIsReady() { }

	public virtual WeaponBehaviorModel get_Def() { }

}

