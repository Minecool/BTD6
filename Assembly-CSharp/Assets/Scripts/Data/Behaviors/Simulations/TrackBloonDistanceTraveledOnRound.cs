namespace Assets.Scripts.Data.Behaviors.Simulations;

[CreateAssetMenu(fileName = "NewTrackBloonDistanceTraveledOnRound", menuName = "BTD6/Behaviors/Simulations/TrackBloonDistanceTraveledOnRound")]
public class TrackBloonDistanceTraveledOnRound : SimulationBehavior
{
	public Int32[] rounds; //Field offset: 0x30
	public String[] bloonNames; //Field offset: 0x38
	public String[] triggerIds; //Field offset: 0x40
	public Single[] percentDistance; //Field offset: 0x48

	public virtual SimulationBehaviorModel Def
	{
		 get { } //Length: 149
	}

	public TrackBloonDistanceTraveledOnRound() { }

	public virtual SimulationBehaviorModel get_Def() { }

}

