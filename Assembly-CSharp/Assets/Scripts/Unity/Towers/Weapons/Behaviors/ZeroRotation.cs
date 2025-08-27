namespace Assets.Scripts.Unity.Towers.Weapons.Behaviors;

public class ZeroRotation : WeaponBehavior
{
	public ZeroRotation parent; //Field offset: 0x90

	public virtual WeaponBehaviorModel Def
	{
		 get { } //Length: 88
	}

	public ZeroRotation() { }

	public virtual WeaponBehaviorModel get_Def() { }

}

