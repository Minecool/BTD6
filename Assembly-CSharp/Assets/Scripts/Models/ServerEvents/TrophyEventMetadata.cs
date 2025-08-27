namespace Assets.Scripts.Models.ServerEvents;

public class TrophyEventMetadata : IEventMetadata
{
	public String[] onSale; //Field offset: 0x10
	public String[] featured; //Field offset: 0x18
	public String[] enabled; //Field offset: 0x20

	public TrophyEventMetadata() { }

}

