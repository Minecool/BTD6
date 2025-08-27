namespace NinjaKiwi.LiNK.Client.Analytics;

public abstract class AnalyticsEvent : WWWForm
{

	public abstract string Name
	{
		 get { } //Length: 0
	}

	protected AnalyticsEvent() { }

	public AnalyticsEvent Add(string name, int value) { }

	public AnalyticsEvent Add(string name, string value) { }

	public abstract string get_Name() { }

}

