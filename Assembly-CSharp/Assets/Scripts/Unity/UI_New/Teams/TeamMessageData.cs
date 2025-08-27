namespace Assets.Scripts.Unity.UI_New.Teams;

public class TeamMessageData
{
	public const int kCurrentVersion = 1; //Field offset: 0x0
	[CompilerGenerated]
	private string <GuildId>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	private long <LatestMessageCreatedAtMs>k__BackingField; //Field offset: 0x18
	[CompilerGenerated]
	private List<GuildMessage> <Messages>k__BackingField; //Field offset: 0x20
	[CompilerGenerated]
	private DateTime <CreatedAt>k__BackingField; //Field offset: 0x28
	[CompilerGenerated]
	private int <DataVersion>k__BackingField; //Field offset: 0x30

	public DateTime CreatedAt
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		 set { } //Length: 5
	}

	public int DataVersion
	{
		[CompilerGenerated]
		 get { } //Length: 4
		[CompilerGenerated]
		 set { } //Length: 4
	}

	public string GuildId
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		 set { } //Length: 5
	}

	public long LatestMessageCreatedAtMs
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		 set { } //Length: 5
	}

	public List<GuildMessage> Messages
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		 set { } //Length: 5
	}

	public TeamMessageData() { }

	[CompilerGenerated]
	public DateTime get_CreatedAt() { }

	[CompilerGenerated]
	public int get_DataVersion() { }

	[CompilerGenerated]
	public string get_GuildId() { }

	[CompilerGenerated]
	public long get_LatestMessageCreatedAtMs() { }

	[CompilerGenerated]
	public List<GuildMessage> get_Messages() { }

	[CompilerGenerated]
	public void set_CreatedAt(DateTime value) { }

	[CompilerGenerated]
	public void set_DataVersion(int value) { }

	[CompilerGenerated]
	public void set_GuildId(string value) { }

	[CompilerGenerated]
	public void set_LatestMessageCreatedAtMs(long value) { }

	[CompilerGenerated]
	public void set_Messages(List<GuildMessage> value) { }

}

