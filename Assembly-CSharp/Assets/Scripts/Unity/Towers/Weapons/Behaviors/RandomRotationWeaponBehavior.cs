namespace Assets.Scripts.Unity.Towers.Weapons.Behaviors;

public class RandomRotationWeaponBehavior : WeaponBehavior
{
	public RandomRotationWeaponBehavior parent; //Field offset: 0x90

	public virtual WeaponBehaviorModel Def
	{
		 get { } //Length: 88
	}

	public RandomRotationWeaponBehavior() { }

	public virtual WeaponBehaviorModel get_Def() { }

}

