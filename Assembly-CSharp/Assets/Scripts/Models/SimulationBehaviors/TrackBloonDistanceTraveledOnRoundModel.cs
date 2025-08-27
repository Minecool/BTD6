namespace Assets.Scripts.Models.SimulationBehaviors;

[Implementation(typeof(TrackBloonDistanceTraveledOnRound), False, False, new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {}])]
public class TrackBloonDistanceTraveledOnRoundModel : SimulationBehaviorModel
{
	public Int32[] roundArr; //Field offset: 0x30
	public String[] bloonNameArr; //Field offset: 0x38
	public String[] triggerIdsArr; //Field offset: 0x40
	public Single[] percTraveledArr; //Field offset: 0x48

	public TrackBloonDistanceTraveledOnRoundModel(Int32[] roundArr, String[] bloonNameArr, String[] triggerIdsArr, Single[] percTraveledArr) { }

	public virtual Model Clone() { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

}

