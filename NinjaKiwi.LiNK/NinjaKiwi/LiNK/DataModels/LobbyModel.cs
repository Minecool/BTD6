namespace NinjaKiwi.LiNK.DataModels;

[DataContract]
public class LobbyModel
{
	[DataMember(Name = "matchID")]
	public string id; //Field offset: 0x10
	[DataMember(Name = "matchName")]
	public string name; //Field offset: 0x18
	[DataMember(Name = "playerCount")]
	public int playerCount; //Field offset: 0x20
	[DataMember(Name = "maxPlayers")]
	public int maxPlayers; //Field offset: 0x24
	[DataMember(Name = "playerGlobalID")]
	public string playerGlobalID; //Field offset: 0x28
	[DataMember(Name = "playerLocalID")]
	public int playerLocalID; //Field offset: 0x30
	[CompilerGenerated]
	private RelayInfo <RelayInfo>k__BackingField; //Field offset: 0x38
	[CompilerGenerated]
	private JObject <Metadata>k__BackingField; //Field offset: 0x40

	public JObject Metadata
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		 set { } //Length: 5
	}

	[DataMember(Name = "metadata")]
	public JObject RawMetadata
	{
		 set { } //Length: 381
	}

	public RelayInfo RelayInfo
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		 set { } //Length: 5
	}

	public LobbyModel() { }

	[CompilerGenerated]
	public JObject get_Metadata() { }

	[CompilerGenerated]
	public RelayInfo get_RelayInfo() { }

	[CompilerGenerated]
	protected void set_Metadata(JObject value) { }

	public void set_RawMetadata(JObject value) { }

	[CompilerGenerated]
	protected void set_RelayInfo(RelayInfo value) { }

}

