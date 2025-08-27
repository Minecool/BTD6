namespace NinjaKiwi.GUTS.Models.Quests;

public class QuestSettings
{
	[CompilerGenerated]
	private bool <IsEnabled>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	private QuestTypeSettings <Daily>k__BackingField; //Field offset: 0x18
	[CompilerGenerated]
	private QuestTypeSettings <Weekly>k__BackingField; //Field offset: 0x20
	[CompilerGenerated]
	private Dictionary<String, RandomRewards> <RandomRewards>k__BackingField; //Field offset: 0x28
	[CompilerGenerated]
	private TimeSpan <DailyUtcOffset>k__BackingField; //Field offset: 0x30
	[CompilerGenerated]
	private bool <CanStagingInfiniteReroll>k__BackingField; //Field offset: 0x38

	public bool CanStagingInfiniteReroll
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		 set { } //Length: 4
	}

	public QuestTypeSettings Daily
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		 set { } //Length: 5
	}

	public TimeSpan DailyUtcOffset
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		 set { } //Length: 5
	}

	public bool IsEnabled
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		 set { } //Length: 4
	}

	public Dictionary<String, RandomRewards> RandomRewards
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		 set { } //Length: 5
	}

	public QuestTypeSettings Weekly
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		 set { } //Length: 5
	}

	public QuestSettings() { }

	[CompilerGenerated]
	public bool get_CanStagingInfiniteReroll() { }

	[CompilerGenerated]
	public QuestTypeSettings get_Daily() { }

	[CompilerGenerated]
	public TimeSpan get_DailyUtcOffset() { }

	[CompilerGenerated]
	public bool get_IsEnabled() { }

	[CompilerGenerated]
	public Dictionary<String, RandomRewards> get_RandomRewards() { }

	[CompilerGenerated]
	public QuestTypeSettings get_Weekly() { }

	public QuestDetails GetQuestDetails(string questId) { }

	[OnDeserialized]
	public void OnDeserialized(StreamingContext context = null) { }

	[CompilerGenerated]
	public void set_CanStagingInfiniteReroll(bool value) { }

	[CompilerGenerated]
	public void set_Daily(QuestTypeSettings value) { }

	[CompilerGenerated]
	public void set_DailyUtcOffset(TimeSpan value) { }

	[CompilerGenerated]
	public void set_IsEnabled(bool value) { }

	[CompilerGenerated]
	public void set_RandomRewards(Dictionary<String, RandomRewards> value) { }

	[CompilerGenerated]
	public void set_Weekly(QuestTypeSettings value) { }

}

