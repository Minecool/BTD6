namespace NinjaKiwi.LiNK.DataModels;

[DataContract]
public class OauthTokensModel
{
	[DataMember(Name = "fb")]
	public string facebook; //Field offset: 0x10
	[DataMember(Name = "tw")]
	public string twitch; //Field offset: 0x18

	public OauthTokensModel() { }

}

