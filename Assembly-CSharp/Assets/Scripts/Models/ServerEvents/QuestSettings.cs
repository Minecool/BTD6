namespace Assets.Scripts.Models.ServerEvents;

public class QuestSettings : EnableFlag
{
	[CompilerGenerated]
	private struct <GetSubQuestRewards>d__5 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder<LootSet> <>t__builder; //Field offset: 0x8
		public QuestSettings <>4__this; //Field offset: 0x20
		public QuestEvent questEvent; //Field offset: 0x28
		public int subQuestId; //Field offset: 0x30
		private LootSet <tierLoot>5__2; //Field offset: 0x38
		private TaskAwaiter<QuestDataModel> <>u__1; //Field offset: 0x40

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	public const string defaultRewardsKey = "default"; //Field offset: 0x0
	public QuestRewards rewards; //Field offset: 0x18
	public TimeSpan penaltyGraceTime; //Field offset: 0x20
	public Int32[] checkpointCosts; //Field offset: 0x28
	public int defaultRetryCost; //Field offset: 0x30

	public QuestSettings() { }

	[AsyncStateMachine(typeof(<GetSubQuestRewards>d__5))]
	public Task<LootSet> GetSubQuestRewards(QuestEvent questEvent, int subQuestId) { }

	private String[] GetSubQuestsRewards(QuestEvent questEvent) { }

}

