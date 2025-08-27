namespace Assets.Scripts.Data.Quests;

public class TutorialQuestData
{
	public QuestDetails quest; //Field offset: 0x10
	public DialogueData incompleteDialogue; //Field offset: 0x18
	public DialogueData completedDialogue; //Field offset: 0x20
	public readonly string PipId; //Field offset: 0x28

	public bool HasCompletedAllStages
	{
		 get { } //Length: 84
	}

	public bool HasCompletedFirstStage
	{
		 get { } //Length: 94
	}

	public bool HasSeenCompletedMessaging
	{
		 get { } //Length: 55
	}

	public bool ShouldShowPip
	{
		 get { } //Length: 129
	}

	public TutorialQuestData() { }

	public bool get_HasCompletedAllStages() { }

	public bool get_HasCompletedFirstStage() { }

	public bool get_HasSeenCompletedMessaging() { }

	public bool get_ShouldShowPip() { }

}

