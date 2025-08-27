namespace Assets.Scripts.Data.Behaviors.Weapons;

[CreateAssetMenu(fileName = "FireWhenAlternateWeaponIsReady", menuName = "BTD6/Behaviors/Weapons/FireWhenAlternateWeaponIsReady")]
public class FireWhenAlternateWeaponIsReady : WeaponBehavior
{
	public int weaponId; //Field offset: 0x30

	public virtual WeaponBehaviorModel Def
	{
		 get { } //Length: 104
	}

	public FireWhenAlternateWeaponIsReady() { }

	public virtual WeaponBehaviorModel get_Def() { }

}

