namespace Assets.Scripts.Unity.Towers.Weapons.Behaviors;

public class EmissionsPerRound : WeaponBehavior
{
	public EmissionsPerRound parent; //Field offset: 0x90
	public float count; //Field offset: 0x98
	public string expCount; //Field offset: 0xA0

	public virtual WeaponBehaviorModel Def
	{
		 get { } //Length: 111
	}

	public EmissionsPerRound() { }

	public virtual WeaponBehaviorModel get_Def() { }

}

