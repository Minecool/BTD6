namespace Assets.Scripts.Data.Quests.TaskBehaviors;

public abstract class QuestGoal : TaskBehavior
{
	protected QuestTaskSaveData saveData; //Field offset: 0x10
	protected ChallengeGoalData goalData; //Field offset: 0x18

	protected QuestGoal() { }

	public abstract bool DebugSetSaveData(QuestDetails questData, TaskData taskData, QuestTaskSaveData saveData, object data) { }

	public abstract long GetGoalAsLong() { }

	public abstract bool GoalAchieved() { }

	public abstract ChallengeGoalData SetData(QuestDetails questData, TaskData taskData, QuestTaskSaveData saveData) { }

}

