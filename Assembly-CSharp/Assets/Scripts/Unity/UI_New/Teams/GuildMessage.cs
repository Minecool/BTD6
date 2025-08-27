namespace Assets.Scripts.Unity.UI_New.Teams;

public class GuildMessage
{
	[JsonIgnore]
	public const string kGuildMessageTypeKey = "GuildMessage"; //Field offset: 0x0
	[JsonIgnore]
	public const string kMetaDataKey = "MetaData"; //Field offset: 0x0
	[CompilerGenerated]
	private string <Id>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	private GuildMessageType <GuildMessageType>k__BackingField; //Field offset: 0x18
	[CompilerGenerated]
	private string <Sender>k__BackingField; //Field offset: 0x20
	[CompilerGenerated]
	private DateTime <CreatedAt>k__BackingField; //Field offset: 0x28
	[CompilerGenerated]
	private string <Data>k__BackingField; //Field offset: 0x30

	public DateTime CreatedAt
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		 set { } //Length: 5
	}

	public string Data
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		 set { } //Length: 5
	}

	public GuildMessageType GuildMessageType
	{
		[CompilerGenerated]
		 get { } //Length: 4
		[CompilerGenerated]
		 set { } //Length: 4
	}

	public string Id
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		 set { } //Length: 5
	}

	public string Sender
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		 set { } //Length: 5
	}

	public GuildMessage() { }

	[CompilerGenerated]
	public DateTime get_CreatedAt() { }

	[CompilerGenerated]
	public string get_Data() { }

	[CompilerGenerated]
	public GuildMessageType get_GuildMessageType() { }

	[CompilerGenerated]
	public string get_Id() { }

	[CompilerGenerated]
	public string get_Sender() { }

	[CompilerGenerated]
	public void set_CreatedAt(DateTime value) { }

	[CompilerGenerated]
	public void set_Data(string value) { }

	[CompilerGenerated]
	public void set_GuildMessageType(GuildMessageType value) { }

	[CompilerGenerated]
	public void set_Id(string value) { }

	[CompilerGenerated]
	public void set_Sender(string value) { }

	public static bool TryConstruct(PubSubMessageModel pubSubMessageModel, out GuildMessage guildMessage) { }

}

