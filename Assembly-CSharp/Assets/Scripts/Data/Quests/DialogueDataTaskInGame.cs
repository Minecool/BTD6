namespace Assets.Scripts.Data.Quests;

public abstract class DialogueDataTaskInGame : DialogueDataTask
{

	protected InGame InGame
	{
		 get { } //Length: 54
	}

	public DialogueDataTaskInGame() { }

	public abstract void Bind(bool isLoadedSave) { }

	protected InGame get_InGame() { }

	protected void TriggerDialogueEvent() { }

	public abstract void Unbind() { }

}

