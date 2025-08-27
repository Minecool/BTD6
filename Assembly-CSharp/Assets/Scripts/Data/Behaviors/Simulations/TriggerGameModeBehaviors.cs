namespace Assets.Scripts.Data.Behaviors.Simulations;

[CreateAssetMenu(fileName = "NewTriggerGameModeBehaviors", menuName = "BTD6/Behaviors/Simulations/TriggerGameModeBehaviors")]
public class TriggerGameModeBehaviors : SimulationBehavior
{
	public bool triggerInfinitHealthMode; //Field offset: 0x30
	public bool triggerInfinitRoundsMode; //Field offset: 0x31
	public bool showCurrentRoundNum; //Field offset: 0x32

	public virtual SimulationBehaviorModel Def
	{
		 get { } //Length: 131
	}

	public TriggerGameModeBehaviors() { }

	public virtual SimulationBehaviorModel get_Def() { }

}

