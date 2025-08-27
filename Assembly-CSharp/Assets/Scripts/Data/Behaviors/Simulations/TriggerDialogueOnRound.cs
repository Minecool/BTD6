namespace Assets.Scripts.Data.Behaviors.Simulations;

[CreateAssetMenu(fileName = "NewTriggerDialogueOnRound", menuName = "BTD6/Behaviors/Simulations/TriggerDialogueOnRound")]
public class TriggerDialogueOnRound : SimulationBehavior
{
	public bool saveSeen; //Field offset: 0x30
	public int round; //Field offset: 0x34
	public DialogueData dialogue; //Field offset: 0x38

	public virtual SimulationBehaviorModel Def
	{
		 get { } //Length: 128
	}

	public TriggerDialogueOnRound() { }

	public virtual SimulationBehaviorModel get_Def() { }

}

