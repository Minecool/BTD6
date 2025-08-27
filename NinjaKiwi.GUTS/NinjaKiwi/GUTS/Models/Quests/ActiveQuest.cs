namespace NinjaKiwi.GUTS.Models.Quests;

public class ActiveQuest
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func<KeyValuePair`2<String, Dictionary`2<String, Int32>>, IEnumerable`1<KeyValuePair`2<String, Int32>>> <>9__19_0; //Field offset: 0x8
		public static Func<KeyValuePair`2<String, Int32>, String> <>9__19_1; //Field offset: 0x10
		public static Func<KeyValuePair`2<String, Int32>, Int32> <>9__19_2; //Field offset: 0x18

		private static <>c() { }

		public <>c() { }

		internal IEnumerable<KeyValuePair`2<String, Int32>> <GetActiveQuestStatus>b__19_0(KeyValuePair<String, Dictionary`2<String, Int32>> x) { }

		internal string <GetActiveQuestStatus>b__19_1(KeyValuePair<String, Int32> x) { }

		internal int <GetActiveQuestStatus>b__19_2(KeyValuePair<String, Int32> z) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass20_0
	{
		public String[] statKeys; //Field offset: 0x10

		public <>c__DisplayClass20_0() { }

		internal long <GetCurrentScore>b__0(KeyValuePair<String, Int64> statProgress) { }

	}

	[CompilerGenerated]
	private string <Id>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	private long <StartStatScore>k__BackingField; //Field offset: 0x18
	[CompilerGenerated]
	private DateTime <StartTime>k__BackingField; //Field offset: 0x20
	[CompilerGenerated]
	private bool <HasClaimedRewards>k__BackingField; //Field offset: 0x28

	public bool HasClaimedRewards
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		 set { } //Length: 4
	}

	public string Id
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		 set { } //Length: 5
	}

	public long StartStatScore
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		 set { } //Length: 5
	}

	[JsonConverter(typeof(UnixDateTimeConverter))]
	public DateTime StartTime
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		 set { } //Length: 5
	}

	[JsonConstructor]
	private ActiveQuest() { }

	public ActiveQuest(string id, long startStatScore, DateTime startTime, bool hasClaimedRewards) { }

	public bool CanReroll(ActiveQuests activeQuests, DateTime now, bool isDailyQuest, QuestSettings questSettings, bool isStaging) { }

	[CompilerGenerated]
	public bool get_HasClaimedRewards() { }

	[CompilerGenerated]
	public string get_Id() { }

	[CompilerGenerated]
	public long get_StartStatScore() { }

	[CompilerGenerated]
	public DateTime get_StartTime() { }

	public ActiveQuestStatus GetActiveQuestStatus(Dictionary<String, Int64> playerStats, ActiveQuests activeQuests, QuestSettings questSettings, DateTime now, bool isDailyQuest) { }

	private int GetCurrentScore(Dictionary<String, Int64> playerStats, String[] statKeys) { }

	private static float GetProgress(int requiredStatIncrement, int currentScore) { }

	[CompilerGenerated]
	public void set_HasClaimedRewards(bool value) { }

	[CompilerGenerated]
	public void set_Id(string value) { }

	[CompilerGenerated]
	public void set_StartStatScore(long value) { }

	[CompilerGenerated]
	public void set_StartTime(DateTime value) { }

}

