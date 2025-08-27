namespace Assets.Scripts.Unity.SimulationBehaviors;

public class TrackBloonDistanceTraveledOnRound : SimulationBehavior
{
	public Int32[] rounds; //Field offset: 0x18
	public String[] bloonNames; //Field offset: 0x20
	public String[] triggerIds; //Field offset: 0x28
	public Single[] percentDistance; //Field offset: 0x30

	public virtual SimulationBehaviorModel Def
	{
		 get { } //Length: 149
	}

	public virtual string Type
	{
		 get { } //Length: 44
	}

	public TrackBloonDistanceTraveledOnRound() { }

	public TrackBloonDistanceTraveledOnRound(Int32[] rounds, String[] bloonNames, String[] triggerIds, Single[] percentDistance) { }

	public virtual SimulationBehaviorModel get_Def() { }

	public virtual string get_Type() { }

}

