namespace Assets.Scripts.Unity.SimulationBehaviors;

public interface IUIChallengeGoal : IUIBehavior
{
	internal class ChallengeGoalData
	{
		public long score; //Field offset: 0x10
		public long scoreToBeat; //Field offset: 0x18
		public bool enableScorePanel; //Field offset: 0x20
		public string descriptionLoc; //Field offset: 0x28
		public string scoreToBeatTxt; //Field offset: 0x30
		public string yourScoreTxt; //Field offset: 0x38
		public QuestTaskSaveData saveData; //Field offset: 0x40

		public ChallengeGoalData(QuestTaskSaveData saveData) { }

	}


	public SubGameType SelectedScoreUI
	{
		 get { } //Length: 0
	}

	public SubGameType get_SelectedScoreUI() { }

	public ChallengeGoalData OnCheckSetChallengeScore(ChallengeGoalData data) { }

	public bool TryBindQuestUI(ScorePanelUI panel, ref ChallengeGoalData data) { }

}

