namespace Assets.Scripts.Models.ServerEvents;

public abstract class BaseServerEvent
{
	public string id; //Field offset: 0x10
	[JsonConverter(typeof(UnixDateTimeConverter))]
	[JsonProperty("start")]
	public DateTime startDate; //Field offset: 0x18
	[JsonConverter(typeof(UnixDateTimeConverter))]
	[JsonProperty("end")]
	public DateTime endDate; //Field offset: 0x20

	protected BaseServerEvent() { }

}

