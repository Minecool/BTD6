namespace NinjaKiwi.LiNK.DataModels;

[DataContract]
public class RelayDetails
{
	[DataMember(Name = "ip")]
	public string ip; //Field offset: 0x10
	[DataMember(Name = "port")]
	public int port; //Field offset: 0x18
	[DataMember(Name = "region")]
	public string region; //Field offset: 0x20
	[DataMember(Name = "expiresAt")]
	public long expiresAt; //Field offset: 0x28
	[DataMember(Name = "load")]
	public int load; //Field offset: 0x30
	[DataMember(Name = "draining")]
	public bool draining; //Field offset: 0x34
	[DataMember(Name = "dnsResolved")]
	public bool dnsResolved; //Field offset: 0x35
	[DataMember(Name = "isBackup")]
	public bool isBackup; //Field offset: 0x36
	[DataMember(Name = "redisSetKey")]
	public string redisSetKey; //Field offset: 0x38
	[DataMember(Name = "redisRelayKey")]
	public string redisRelayKey; //Field offset: 0x40
	[DataMember(Name = "loaded")]
	public bool loaded; //Field offset: 0x48
	[CompilerGenerated]
	private JObject <Metadata>k__BackingField; //Field offset: 0x50
	[CompilerGenerated]
	private Version <BinaryVersion>k__BackingField; //Field offset: 0x58
	[CompilerGenerated]
	private int <PlayerCount>k__BackingField; //Field offset: 0x60
	[CompilerGenerated]
	private string <HostName>k__BackingField; //Field offset: 0x68

	public Version BinaryVersion
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		 set { } //Length: 5
	}

	public string HostName
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		 set { } //Length: 5
	}

	public JObject Metadata
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		 set { } //Length: 5
	}

	public int PlayerCount
	{
		[CompilerGenerated]
		 get { } //Length: 4
		[CompilerGenerated]
		 set { } //Length: 4
	}

	[DataMember(Name = "metadata")]
	public string RawMetadata
	{
		 set { } //Length: 474
	}

	public RelayDetails() { }

	[CompilerGenerated]
	public Version get_BinaryVersion() { }

	[CompilerGenerated]
	public string get_HostName() { }

	[CompilerGenerated]
	public JObject get_Metadata() { }

	[CompilerGenerated]
	public int get_PlayerCount() { }

	[CompilerGenerated]
	protected void set_BinaryVersion(Version value) { }

	[CompilerGenerated]
	protected void set_HostName(string value) { }

	[CompilerGenerated]
	protected void set_Metadata(JObject value) { }

	[CompilerGenerated]
	protected void set_PlayerCount(int value) { }

	public void set_RawMetadata(string value) { }

}

