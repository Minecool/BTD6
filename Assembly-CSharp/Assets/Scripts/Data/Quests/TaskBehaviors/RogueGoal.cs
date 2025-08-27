namespace Assets.Scripts.Data.Quests.TaskBehaviors;

public class RogueGoal : QuestGoal
{
	public int uniqueTileWinsRequired; //Field offset: 0x20
	public Vector2Int uniqueTileCoordWinRequired; //Field offset: 0x24
	private HashSet<Vector2Int> completedTiles; //Field offset: 0x30

	public int Goal
	{
		 get { } //Length: 14
	}

	private bool IsUniqueTileWinValid
	{
		private get { } //Length: 19
	}

	public RogueGoal(HashSet<Vector2Int> rougeQuestData) { }

	public virtual bool DebugSetSaveData(QuestDetails questData, TaskData taskData, QuestTaskSaveData saveData, object data) { }

	public int get_Goal() { }

	private bool get_IsUniqueTileWinValid() { }

	public virtual long GetGoalAsLong() { }

	private int GetScore() { }

	public virtual bool GoalAchieved() { }

	public bool HasAchievedGoal() { }

	public virtual ChallengeGoalData SetData(QuestDetails questData, TaskData taskData, QuestTaskSaveData saveData) { }

}

