namespace Assets.Scripts.Unity.Towers.Weapons.Behaviors;

public class FireAlternateWeapon : WeaponBehavior
{
	public FireAlternateWeapon parent; //Field offset: 0x90
	public int weaponId; //Field offset: 0x98
	public string expWeaponId; //Field offset: 0xA0

	public virtual WeaponBehaviorModel Def
	{
		 get { } //Length: 107
	}

	public FireAlternateWeapon() { }

	public virtual WeaponBehaviorModel get_Def() { }

}

