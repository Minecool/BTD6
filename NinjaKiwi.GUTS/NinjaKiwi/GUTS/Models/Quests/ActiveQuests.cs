namespace NinjaKiwi.GUTS.Models.Quests;

public class ActiveQuests
{
	[CompilerGenerated]
	private List<ActiveQuest> <DailyQuests>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	private List<ActiveQuest> <WeeklyQuests>k__BackingField; //Field offset: 0x18
	[CompilerGenerated]
	private DateTime <DailyQuestStartTime>k__BackingField; //Field offset: 0x20
	[CompilerGenerated]
	private DateTime <WeeklyQuestStartTime>k__BackingField; //Field offset: 0x28

	public List<ActiveQuest> DailyQuests
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		 set { } //Length: 5
	}

	[JsonConverter(typeof(UnixDateTimeConverter))]
	[JsonProperty("DQST")]
	public DateTime DailyQuestStartTime
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		 set { } //Length: 5
	}

	public List<ActiveQuest> WeeklyQuests
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		 set { } //Length: 5
	}

	[JsonConverter(typeof(UnixDateTimeConverter))]
	[JsonProperty("WQST")]
	public DateTime WeeklyQuestStartTime
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		 set { } //Length: 5
	}

	[JsonConstructor]
	private ActiveQuests() { }

	public ActiveQuests(List<ActiveQuest> dailyQuests, List<ActiveQuest> weeklyQuests, DateTime dailyQuestStartTime, DateTime weeklyQuestStartTime) { }

	[CompilerGenerated]
	public List<ActiveQuest> get_DailyQuests() { }

	[CompilerGenerated]
	public DateTime get_DailyQuestStartTime() { }

	[CompilerGenerated]
	public List<ActiveQuest> get_WeeklyQuests() { }

	[CompilerGenerated]
	public DateTime get_WeeklyQuestStartTime() { }

	[CompilerGenerated]
	public void set_DailyQuests(List<ActiveQuest> value) { }

	[CompilerGenerated]
	public void set_DailyQuestStartTime(DateTime value) { }

	[CompilerGenerated]
	public void set_WeeklyQuests(List<ActiveQuest> value) { }

	[CompilerGenerated]
	public void set_WeeklyQuestStartTime(DateTime value) { }

}

