namespace Assets.Scripts.Models.Profile;

public class SweepstakesStats
{
	public string eventId; //Field offset: 0x10
	public KonFuze taskIndex; //Field offset: 0x18
	public DateTime currentTaskStartedAt; //Field offset: 0x20
	public bool hasOpenedEvent; //Field offset: 0x28
	public bool hasAcceptedTerms; //Field offset: 0x29
	public bool hasSeenReferallReward; //Field offset: 0x2A
	public List<SweepstakesStatsForTask> statsForTasks; //Field offset: 0x30
	private SweepstakesStatsForTask combinedStatsCache; //Field offset: 0x38

	[JsonConstructor]
	public SweepstakesStats() { }

	public SweepstakesStats(KonFuze taskIndex) { }

	public SweepstakesStatsForTask GetStatsAcrossAllTasks() { }

	public SweepstakesStatsForTask GetStatsForTaskIndex(int taskIndex) { }

	[OnDeserialized]
	public void Validate(StreamingContext context = null) { }

}

