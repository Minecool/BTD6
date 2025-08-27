namespace Assets.Scripts.Data.Behaviors.Simulations;

[CreateAssetMenu(fileName = "NewTriggerBehaviorsOnRound", menuName = "BTD6/Behaviors/Simulations/TriggerBehaviorsOnRound")]
public class TriggerBehaviorsOnRound : SimulationBehavior
{
	public Int32[] round; //Field offset: 0x30
	public String[] triggerIds; //Field offset: 0x38

	public virtual SimulationBehaviorModel Def
	{
		 get { } //Length: 105
	}

	public TriggerBehaviorsOnRound() { }

	public virtual SimulationBehaviorModel get_Def() { }

}

