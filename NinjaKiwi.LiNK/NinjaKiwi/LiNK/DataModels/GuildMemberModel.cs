namespace NinjaKiwi.LiNK.DataModels;

public class GuildMemberModel
{
	[DataMember(Name = "nkapiID")]
	public string nkapiID; //Field offset: 0x10
	[DataMember(Name = "permissions")]
	public GuildMembershipState permissions; //Field offset: 0x18

	public string LiNKID
	{
		 get { } //Length: 5
	}

	public GuildMemberModel() { }

	public string get_LiNKID() { }

}

