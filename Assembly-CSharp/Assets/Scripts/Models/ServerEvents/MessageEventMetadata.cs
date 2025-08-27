namespace Assets.Scripts.Models.ServerEvents;

public class MessageEventMetadata : IEventMetadata
{
	public string type; //Field offset: 0x10
	public string banner; //Field offset: 0x18
	public Dictionary<String, String> title; //Field offset: 0x20
	public Dictionary<String, String> description; //Field offset: 0x28

	public MessageEventMetadata() { }

}

