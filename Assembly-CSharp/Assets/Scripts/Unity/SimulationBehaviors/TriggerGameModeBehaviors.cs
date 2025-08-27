namespace Assets.Scripts.Unity.SimulationBehaviors;

public class TriggerGameModeBehaviors : SimulationBehavior
{
	public bool triggerInfinitHealthMode; //Field offset: 0x18
	public bool triggerInfinitRoundsMode; //Field offset: 0x19
	public bool showCurrentRoundNum; //Field offset: 0x1A

	public virtual Model Model
	{
		 get { } //Length: 131
	}

	public virtual string Type
	{
		 get { } //Length: 44
	}

	public TriggerGameModeBehaviors() { }

	public TriggerGameModeBehaviors(bool triggerInfinitHealthMode, bool triggerInfinitRoundsMode, bool showCurrentRoundNum) { }

	public virtual Model get_Model() { }

	public virtual string get_Type() { }

}

