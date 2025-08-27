namespace NinjaKiwi.LiNK.Endpoints;

[DataContract]
public class FriendsListResponse
{
	[DataMember(Name = "friendsList")]
	public List<FriendModel> friends; //Field offset: 0x10
	[DataMember(Name = "settings")]
	public Dictionary<String, FriendSetting> settings; //Field offset: 0x18
	[DataMember(Name = "friendsCode")]
	public string friendsCode; //Field offset: 0x20
	[DataMember(Name = "onlineStatus")]
	internal Dictionary<String, Boolean> onlineStatus; //Field offset: 0x28

	public FriendsListResponse() { }

}

