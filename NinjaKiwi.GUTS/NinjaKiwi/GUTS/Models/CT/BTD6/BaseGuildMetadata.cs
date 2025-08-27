namespace NinjaKiwi.GUTS.Models.CT.BTD6;

public class BaseGuildMetadata
{
	[JsonConverter(typeof(StringEnumConverter))]
	public GuildStance stance; //Field offset: 0x10

	public BaseGuildMetadata() { }

}

