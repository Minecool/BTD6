namespace Assets.Scripts.Unity.Towers.Weapons.Behaviors;

public class MagusPerfectusGraveyard : WeaponBehavior
{
	private WeaponBehaviorModel def; //Field offset: 0x90
	public int graveyardManaChange; //Field offset: 0x98
	public int roundUntilManaDecay; //Field offset: 0x9C

	public virtual WeaponBehaviorModel Def
	{
		 get { } //Length: 177
	}

	public MagusPerfectusGraveyard() { }

	public virtual WeaponBehaviorModel get_Def() { }

}

