namespace NinjaKiwi.LiNK.DataModels;

[DataContract]
public class LiNKAccountModel
{
	[DataMember(Name = "user")]
	public UserModel user; //Field offset: 0x10
	[DataMember(Name = "session")]
	public SessionModel session; //Field offset: 0x18

	public LiNKAccountModel() { }

}

