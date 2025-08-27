namespace NinjaKiwi.LiNK.Client.Analytics;

public class IndexFileRegenEvent : AnalyticsEvent
{

	public virtual string Name
	{
		 get { } //Length: 44
	}

	public IndexFileRegenEvent(bool success) { }

	public virtual string get_Name() { }

}

