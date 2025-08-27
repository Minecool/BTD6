namespace NinjaKiwi.LiNK.DataModels;

public class PubSubChannelModel
{
	public string channel; //Field offset: 0x10
	public int accessLevelRequired; //Field offset: 0x18
	public PubSubMessageModel[] messages; //Field offset: 0x20
	public long latestMessageCreatedAt; //Field offset: 0x28
	public long serverTime; //Field offset: 0x30
	public int messagesHiddenByLimit; //Field offset: 0x38

	public PubSubChannelModel() { }

}

