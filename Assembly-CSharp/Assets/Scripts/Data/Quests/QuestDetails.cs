namespace Assets.Scripts.Data.Quests;

public class QuestDetails : ScriptableObject
{
	[CompilerGenerated]
	private sealed class <>c__17
	{
		public static readonly <>c__17<T> <>9; //Field offset: 0x0
		public static Func<QuestPartData, IEnumerable`1<TaskData>> <>9__17_0; //Field offset: 0x0

		private static <>c__17`1() { }

		public <>c__17`1() { }

		internal IEnumerable<TaskData> <TryGetTask>b__17_0(QuestPartData x) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass17_0
	{
		public string taskId; //Field offset: 0x0

		public <>c__DisplayClass17_0`1() { }

		internal bool <TryGetTask>b__1(TaskData x) { }

	}

	public string id; //Field offset: 0x18
	public string questTitleLoc; //Field offset: 0x20
	public string descriptionShortLoc; //Field offset: 0x28
	public string descriptionLongLoc; //Field offset: 0x30
	public QuestCategory questCategory; //Field offset: 0x38
	public PrefabReference worldScene; //Field offset: 0x40
	public PrefabReference titlePrefab; //Field offset: 0x48
	public SpriteReference iconPrefab; //Field offset: 0x50
	public int unlockLevel; //Field offset: 0x58
	public bool forceUseTalesQuestScreen; //Field offset: 0x5C
	[ExtendedDrawer]
	[ReorderableList("Part", True)]
	[SerializeField]
	private QuestPartDataContainer QuestPartDataContainer; //Field offset: 0x60

	public bool IsQuestLocked
	{
		 get { } //Length: 185
	}

	public IReadOnlyCollection<QuestPartData> QuestPartData
	{
		 get { } //Length: 27
	}

	public QuestDetails() { }

	public bool get_IsQuestLocked() { }

	public IReadOnlyCollection<QuestPartData> get_QuestPartData() { }

	public LootSet GetLootSet(int partIndex) { }

	private TaskData GetTaskDataForImport(int partIndex, int taskIndex) { }

	public bool HasClaimedQuestPartReward(int partIndex) { }

	public void ImportCustomMapModelData(int partIndex, int taskIndex, CustomMapModel data) { }

	public void ImportDcmData(int partIndex, int taskIndex, DailyChallengeModel data) { }

	public bool IsSpecialRewardsQuest(int partIndex) { }

	public bool IsSpotLightQuest(int partIndex) { }

	public List<LootData> Rewards(int partIndex) { }

	public IEnumerable<TaskData> Tasks(int partIndex) { }

	public bool TryGetAllPartTasks(int partIndex, out T[] taskData) { }

	public bool TryGetPartData(int partIndex, out QuestPartData dialogue) { }

	public bool TryGetQuestBehavior(int partIndex, out T behavior) { }

	public bool TryGetQuestDialogue(int partIndex, out T dialogue) { }

	public bool TryGetRewards(int partIndex, out List<T>& rewards) { }

	public bool TryGetTask(string taskId, out T taskData) { }

}

