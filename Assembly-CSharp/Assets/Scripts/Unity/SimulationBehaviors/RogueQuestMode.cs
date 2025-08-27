namespace Assets.Scripts.Unity.SimulationBehaviors;

public class RogueQuestMode : SimulationBehavior, IUISummaryScreenBehavior, IUIBehavior, IUIChallengeGoal
{
	[CompilerGenerated]
	private sealed class <>c__5
	{
		public static readonly <>c__5<T> <>9; //Field offset: 0x0
		[TupleElementNames(new IL2CPP_TYPE_STRING[] {"menuName", "menuData"}])]
		public static Predicate<ValueTuple`2<String, Object>> <>9__5_0; //Field offset: 0x0

		private static <>c__5`1() { }

		public <>c__5`1() { }

		internal bool <OnVictoryScreen>b__5_0(ValueTuple<String, Object> x) { }

	}


	public virtual Model Model
	{
		 get { } //Length: 68
	}

	public override SubGameType SelectedScoreUI
	{
		 get { } //Length: 6
	}

	public virtual string Type
	{
		 get { } //Length: 44
	}

	public RogueQuestMode() { }

	public virtual Model get_Model() { }

	public override SubGameType get_SelectedScoreUI() { }

	public virtual string get_Type() { }

	public override ChallengeGoalData OnCheckSetChallengeScore(ChallengeGoalData data) { }

	public override void OnDefeatScreen(T screen) { }

	public override void OnOpenSummaryScreen(T screen) { }

	public virtual void OnResetQuestTriggered() { }

	public override void OnVictoryScreen(T screen) { }

	public void TrackRougeSaveData() { }

	public override bool TryBindQuestUI(ScorePanelUI panel, ref ChallengeGoalData data) { }

	public bool TryGetQuestDetailsAndSaveData(out QuestDetails questDetails, out TaskData taskData, out QuestTaskSaveData taskSaveData) { }

}

