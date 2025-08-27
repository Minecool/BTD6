namespace Assets.Scripts.Unity.Towers.Weapons.Behaviors;

public class ResetRateOnInitialise : WeaponBehavior
{
	public Weapon weapon; //Field offset: 0x90
	public Weapon expWeapon; //Field offset: 0x98

	public virtual WeaponBehaviorModel Def
	{
		 get { } //Length: 128
	}

	public ResetRateOnInitialise() { }

	public virtual WeaponBehaviorModel get_Def() { }

}

