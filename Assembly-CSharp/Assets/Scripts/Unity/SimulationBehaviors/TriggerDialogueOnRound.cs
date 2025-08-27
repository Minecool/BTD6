namespace Assets.Scripts.Unity.SimulationBehaviors;

public class TriggerDialogueOnRound : SimulationBehavior
{
	public DialogueData dialogue; //Field offset: 0x18
	public bool saveSeen; //Field offset: 0x20
	public int round; //Field offset: 0x24

	public virtual Model Model
	{
		 get { } //Length: 128
	}

	public virtual string Type
	{
		 get { } //Length: 44
	}

	public TriggerDialogueOnRound() { }

	public TriggerDialogueOnRound(DialogueData dialogue, int round, bool saveSeen) { }

	public virtual Model get_Model() { }

	public virtual string get_Type() { }

}

