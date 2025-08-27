namespace NinjaKiwi.LiNK.Endpoints;

[DataContract]
public class GuildAndScore
{
	[DataMember(Name = "guild")]
	public GuildModel guild; //Field offset: 0x10
	[DataMember(Name = "score")]
	public long score; //Field offset: 0x18

	public GuildAndScore() { }

}

