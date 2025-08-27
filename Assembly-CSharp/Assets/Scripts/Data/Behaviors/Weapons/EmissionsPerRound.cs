namespace Assets.Scripts.Data.Behaviors.Weapons;

[CreateAssetMenu(fileName = "EmissionsPerRound", menuName = "BTD6/Behaviors/Weapons/EmissionsPerRound")]
public class EmissionsPerRound : WeaponBehavior
{
	public float count; //Field offset: 0x30

	public virtual WeaponBehaviorModel Def
	{
		 get { } //Length: 108
	}

	public EmissionsPerRound() { }

	public virtual WeaponBehaviorModel get_Def() { }

}

