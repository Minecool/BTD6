namespace Assets.Scripts.Data.Quests.InGame;

public class DialogueInGameOnTrigger : DialogueDataTaskInGame
{

	public DialogueInGameOnTrigger() { }

	public virtual void Bind(bool isLoadedSave) { }

	public void OnDialogueTrigger(String[] dialogueIds, int round) { }

	public virtual void Unbind() { }

}

