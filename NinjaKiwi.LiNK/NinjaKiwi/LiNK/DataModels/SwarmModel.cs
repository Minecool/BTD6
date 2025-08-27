namespace NinjaKiwi.LiNK.DataModels;

[DataContract]
public class SwarmModel
{
	[DataMember(Name = "ip")]
	public string ip; //Field offset: 0x10
	[DataMember(Name = "port")]
	public int port; //Field offset: 0x18
	[DataMember(Name = "hostname")]
	public string hostname; //Field offset: 0x20
	[DataMember(Name = "matchUUID")]
	public string matchUUID; //Field offset: 0x28
	[DataMember(Name = "maxPlayers")]
	public int maxPlayers; //Field offset: 0x30
	[DataMember(Name = "currentPlayers")]
	public int currentPlayers; //Field offset: 0x34
	[DataMember(Name = "acceptingPlayers")]
	public bool acceptingPlayers; //Field offset: 0x38
	[DataMember(Name = "gameMode")]
	public string gameMode; //Field offset: 0x40
	internal bool isValid; //Field offset: 0x48

	public SwarmModel() { }

	[OnDeserialized]
	internal void OnDeserialised(StreamingContext streamingContext) { }

	[OnError]
	internal void OnError(StreamingContext context, ErrorContext errorContext) { }

}

