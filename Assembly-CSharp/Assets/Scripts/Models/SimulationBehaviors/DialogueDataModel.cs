namespace Assets.Scripts.Models.SimulationBehaviors;

public class DialogueDataModel : SimulationBehaviorModel
{
	public string dialogueId; //Field offset: 0x30
	public bool disableBackgroundTint; //Field offset: 0x38
	public bool disableSimulationPause; //Field offset: 0x39
	public DialogueType dialogueType; //Field offset: 0x3C
	[SerializeField]
	public List<QuestDialogueAnimData> dialogue; //Field offset: 0x40

	public DialogueDataModel(string dialogueId, List<QuestDialogueAnimData> dialogue, DialogueType dialogueType, bool disableBackgroundTint, bool disableSimulationPause) { }

	public virtual Model Clone() { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

}

