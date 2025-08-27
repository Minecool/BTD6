namespace Assets.Scripts.Data.Quests.TaskBehaviors;

public class ChallengeGoal : QuestGoal
{
	public int goldDifficultyScore; //Field offset: 0x20
	public int silverDifficultyScore; //Field offset: 0x24
	public int bronzeDifficultyScore; //Field offset: 0x28

	public ChallengeGoal() { }

	public virtual bool DebugSetSaveData(QuestDetails questData, TaskData taskData, QuestTaskSaveData saveData, object data) { }

	public virtual long GetGoalAsLong() { }

	public virtual bool GoalAchieved() { }

	public virtual ChallengeGoalData SetData(QuestDetails questData, TaskData taskData, QuestTaskSaveData saveData) { }

}

