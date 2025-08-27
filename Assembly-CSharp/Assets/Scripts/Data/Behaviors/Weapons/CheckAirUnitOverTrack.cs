namespace Assets.Scripts.Data.Behaviors.Weapons;

[CreateAssetMenu(fileName = "CheckAirUnitOverTrack", menuName = "BTD6/Behaviors/Weapons/CheckAirUnitOverTrack")]
public class CheckAirUnitOverTrack : WeaponBehavior
{
	public float futureTime; //Field offset: 0x30

	public virtual WeaponBehaviorModel Def
	{
		 get { } //Length: 106
	}

	public CheckAirUnitOverTrack() { }

	public virtual WeaponBehaviorModel get_Def() { }

}

