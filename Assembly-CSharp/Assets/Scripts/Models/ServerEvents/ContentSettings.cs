namespace Assets.Scripts.Models.ServerEvents;

public class ContentSettings : EnableFlag
{
	public TimeSpan creationTimeout; //Field offset: 0x18
	public SelectionType defaultPage; //Field offset: 0x20

	public ContentSettings() { }

}

