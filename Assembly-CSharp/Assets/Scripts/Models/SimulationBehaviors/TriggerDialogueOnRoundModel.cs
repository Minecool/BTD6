namespace Assets.Scripts.Models.SimulationBehaviors;

[Implementation(typeof(TriggerDialogueOnRound), False, False, new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {}])]
public class TriggerDialogueOnRoundModel : SimulationBehaviorModel
{
	[SerializeReference]
	public DialogueData dialogueData; //Field offset: 0x30
	public bool saveSeen; //Field offset: 0x38
	public int round; //Field offset: 0x3C

	public TriggerDialogueOnRoundModel(DialogueData dialogueData, int round, bool saveSeen) { }

	public virtual Model Clone() { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

}

