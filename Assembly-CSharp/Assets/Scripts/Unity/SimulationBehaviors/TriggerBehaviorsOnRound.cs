namespace Assets.Scripts.Unity.SimulationBehaviors;

public class TriggerBehaviorsOnRound : SimulationBehavior
{
	public Int32[] round; //Field offset: 0x18
	public String[] triggerIds; //Field offset: 0x20

	public virtual SimulationBehaviorModel Def
	{
		 get { } //Length: 105
	}

	public virtual string Type
	{
		 get { } //Length: 44
	}

	public TriggerBehaviorsOnRound() { }

	public TriggerBehaviorsOnRound(Int32[] round, String[] triggerIds) { }

	public virtual SimulationBehaviorModel get_Def() { }

	public virtual string get_Type() { }

}

