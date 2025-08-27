namespace Assets.Scripts.Models.Towers.Weapons.Behaviors;

[Implementation(typeof(CheckAirUnitOverTrack), False, False, new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {}])]
public class CheckAirUnitOverTrackModel : WeaponBehaviorModel
{
	[SerializeField]
	private float futureTime; //Field offset: 0x30
	public int futureTimeFrames; //Field offset: 0x34

	public CheckAirUnitOverTrackModel(string name, float futureTime) { }

	public virtual Model Clone() { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

}

