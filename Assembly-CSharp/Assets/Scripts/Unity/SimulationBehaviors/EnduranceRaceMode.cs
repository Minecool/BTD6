namespace Assets.Scripts.Unity.SimulationBehaviors;

public class EnduranceRaceMode : SimulationBehavior, IUISummaryScreenBehavior, IUIBehavior, IUIChallengeGoal
{
	public int timeInSeconds; //Field offset: 0x18
	public string summaryScreenDescriptionLoc; //Field offset: 0x20

	public double CovertTimeToChallengeTarget
	{
		 get { } //Length: 99
	}

	public virtual Model Model
	{
		 get { } //Length: 86
	}

	public override SubGameType SelectedScoreUI
	{
		 get { } //Length: 6
	}

	public virtual string Type
	{
		 get { } //Length: 44
	}

	public EnduranceRaceMode() { }

	public double get_CovertTimeToChallengeTarget() { }

	public virtual Model get_Model() { }

	public override SubGameType get_SelectedScoreUI() { }

	public virtual string get_Type() { }

	public override ChallengeGoalData OnCheckSetChallengeScore(ChallengeGoalData data) { }

	public override void OnDefeatScreen(T screen) { }

	public override void OnOpenSummaryScreen(T screen) { }

	public override void OnVictoryScreen(T screen) { }

	public override bool TryBindQuestUI(ScorePanelUI panel, ref ChallengeGoalData data) { }

}

