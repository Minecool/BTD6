namespace Assets.Scripts.Unity.Towers.Weapons.Behaviors;

public class CheckAirUnitOverTrack : WeaponBehavior
{
	public CheckAirUnitOverTrack parent; //Field offset: 0x90
	public float futureTime; //Field offset: 0x98
	public string expFutureTime; //Field offset: 0xA0

	public virtual WeaponBehaviorModel Def
	{
		 get { } //Length: 109
	}

	public CheckAirUnitOverTrack() { }

	public virtual WeaponBehaviorModel get_Def() { }

}

