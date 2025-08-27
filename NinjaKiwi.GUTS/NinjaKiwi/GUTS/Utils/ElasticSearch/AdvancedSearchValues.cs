namespace NinjaKiwi.GUTS.Utils.ElasticSearch;

public class AdvancedSearchValues
{
	public static readonly AdvancedSearchValues Default; //Field offset: 0x0
	public bool last24Hours; //Field offset: 0x10
	public bool lastWeek; //Field offset: 0x11
	public bool lastMonth; //Field offset: 0x12
	public bool allTime; //Field offset: 0x13
	public bool includeOldVersions; //Field offset: 0x14
	public bool hideCompleted; //Field offset: 0x15
	public float minRoundsSlider; //Field offset: 0x18
	public float maxRoundsSlider; //Field offset: 0x1C
	public int maxIdFilterCount; //Field offset: 0x20
	public List<String> completedIds; //Field offset: 0x28
	public int highestCompatibleVersion; //Field offset: 0x30
	public int lowestCompatibleVersion; //Field offset: 0x34
	public int maxRoundsMaxValue; //Field offset: 0x38
	public int minRoundsMinValue; //Field offset: 0x3C
	public Func<DateTimeOffset> GetServerTime; //Field offset: 0x40

	private static AdvancedSearchValues() { }

	public AdvancedSearchValues() { }

	public AdvSearchTimeSpan GetTimeSpan() { }

}

