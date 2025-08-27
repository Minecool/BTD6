namespace NinjaKiwi.LiNK.Client.Analytics;

public class DataCorruptionEvent : AnalyticsEvent
{

	public virtual string Name
	{
		 get { } //Length: 44
	}

	public DataCorruptionEvent(string fileName, string extension) { }

	public virtual string get_Name() { }

}

