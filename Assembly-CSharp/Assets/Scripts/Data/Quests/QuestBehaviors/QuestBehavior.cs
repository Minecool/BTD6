namespace Assets.Scripts.Data.Quests.QuestBehaviors;

public abstract class QuestBehavior
{

	protected QuestBehavior() { }

	public override void DebugClearDataTriggered() { }

	public override bool OnStartGameOverride(QuestScreen screen, QuestDetails questDetails, QuestPartData partData, TaskData taskData) { }

}

