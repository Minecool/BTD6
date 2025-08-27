namespace NinjaKiwi.LiNK.DataModels;

[DataContract]
public class FriendModel
{
	[DataMember(Name = "nkapiID")]
	public readonly string liNKID; //Field offset: 0x10
	[DataMember(Name = "status")]
	public readonly FriendStatus status; //Field offset: 0x18
	[DataMember(Name = "displayName")]
	public readonly string displayName; //Field offset: 0x20
	public bool isOnline; //Field offset: 0x28
	[DataMember(Name = "gameState")]
	public readonly Dictionary<String, Dictionary`2<String, Object>> GameState; //Field offset: 0x30

	public FriendModel() { }

}

