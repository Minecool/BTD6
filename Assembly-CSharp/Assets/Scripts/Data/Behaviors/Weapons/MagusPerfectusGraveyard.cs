namespace Assets.Scripts.Data.Behaviors.Weapons;

[CreateAssetMenu(fileName = "MagusPerfectusGraveyard", menuName = "BTD6/Behaviors/Weapons/MagusPerfectusGraveyard")]
public class MagusPerfectusGraveyard : WeaponBehavior
{
	public int graveyardManaChange; //Field offset: 0x30
	public int roundUntilManaDecay; //Field offset: 0x34

	public virtual WeaponBehaviorModel Def
	{
		 get { } //Length: 126
	}

	public MagusPerfectusGraveyard() { }

	public virtual WeaponBehaviorModel get_Def() { }

}

