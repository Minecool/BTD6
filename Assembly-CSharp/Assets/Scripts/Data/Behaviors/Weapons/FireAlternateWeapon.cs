namespace Assets.Scripts.Data.Behaviors.Weapons;

[CreateAssetMenu(fileName = "FireAlternateWeapon", menuName = "BTD6/Behaviors/Weapons/FireAlternateWeapon")]
public class FireAlternateWeapon : WeaponBehavior
{
	public int weaponId; //Field offset: 0x30

	public virtual WeaponBehaviorModel Def
	{
		 get { } //Length: 104
	}

	public FireAlternateWeapon() { }

	public virtual WeaponBehaviorModel get_Def() { }

}

