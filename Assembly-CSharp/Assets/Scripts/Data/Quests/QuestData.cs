namespace Assets.Scripts.Data.Quests;

public class QuestData : ScriptableObject
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass10_0
	{
		public string towerId; //Field offset: 0x10

		public <>c__DisplayClass10_0() { }

		internal bool <TryGetTowerUnlockData>b__0(TowerUnlockQuest x) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass8_0
	{
		public string id; //Field offset: 0x10

		public <>c__DisplayClass8_0() { }

		internal bool <GetCharacterData>b__0(QuestCharacter o) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass9_0
	{
		public string questId; //Field offset: 0x10

		public <>c__DisplayClass9_0() { }

		internal bool <TryGetQuestData>b__0(QuestDetails x) { }

	}

	[CompilerGenerated]
	private struct <LoadQuestDataAsync>d__12 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public QuestData <>4__this; //Field offset: 0x20
		private List<QuestCharacter> <questCharacter>5__2; //Field offset: 0x28
		private List<QuestDetails> <QuestDetails>5__3; //Field offset: 0x30
		private TaskAwaiter<IList`1<QuestCharacter>> <>u__1; //Field offset: 0x38
		private TaskAwaiter<IList`1<QuestDetails>> <>u__2; //Field offset: 0x40

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	public PrefabReference questDialoguePrefab; //Field offset: 0x18
	private List<QuestCharacter> characters; //Field offset: 0x20
	private List<QuestDetails> quests; //Field offset: 0x28
	[ReorderableList("items", True)]
	[SerializeField]
	private TowerQuestContainer TowerUnlockQuestsContainer; //Field offset: 0x30

	public IList<QuestDetails> Quests
	{
		 get { } //Length: 5
	}

	public IList<TowerUnlockQuest> TowerUnlockQuests
	{
		 get { } //Length: 27
	}

	public QuestData() { }

	public IList<QuestDetails> get_Quests() { }

	public IList<TowerUnlockQuest> get_TowerUnlockQuests() { }

	public QuestCharacter GetCharacterData(string id) { }

	[AsyncStateMachine(typeof(<LoadQuestDataAsync>d__12))]
	public Task LoadQuestDataAsync() { }

	public bool TryGetQuestData(string questId, out QuestDetails questDetails) { }

	public bool TryGetQuestTaskData(string questId, string taskId, out TaskData taskData, out QuestDetails questData) { }

	public bool TryGetTowerUnlockData(string towerId, out TowerUnlockQuest towerUnlockQuest) { }

}

