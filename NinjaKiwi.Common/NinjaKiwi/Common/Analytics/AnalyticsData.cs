namespace NinjaKiwi.Common.Analytics;

public class AnalyticsData
{
	[CompilerGenerated]
	private readonly string <EventName>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	private readonly Dictionary<String, String> <EventData>k__BackingField; //Field offset: 0x18

	public Dictionary<String, String> EventData
	{
		[CompilerGenerated]
		 get { } //Length: 5
	}

	public string EventName
	{
		[CompilerGenerated]
		 get { } //Length: 5
	}

	public AnalyticsData(string eventName) { }

	public AnalyticsData AddPair(string parameterName, T parameterValue) { }

	[CompilerGenerated]
	public Dictionary<String, String> get_EventData() { }

	[CompilerGenerated]
	public string get_EventName() { }

}

