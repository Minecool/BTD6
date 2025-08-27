namespace Assets.Scripts.Unity.Towers.Weapons.Behaviors;

public class FireFromAirUnit : WeaponBehavior
{
	public FireFromAirUnit parent; //Field offset: 0x90

	public virtual WeaponBehaviorModel Def
	{
		 get { } //Length: 88
	}

	public FireFromAirUnit() { }

	public virtual WeaponBehaviorModel get_Def() { }

}

