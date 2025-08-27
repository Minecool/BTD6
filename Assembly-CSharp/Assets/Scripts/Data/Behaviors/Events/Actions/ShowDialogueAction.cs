namespace Assets.Scripts.Data.Behaviors.Events.Actions;

public class ShowDialogueAction : HudModifier
{
	[SerializeField]
	public DialogueDataAction dialogueToShow; //Field offset: 0x28

	public virtual Model Model
	{
		 get { } //Length: 90
	}

	public ShowDialogueAction() { }

	public virtual Model get_Model() { }

}

