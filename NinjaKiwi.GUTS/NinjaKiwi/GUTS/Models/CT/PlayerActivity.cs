namespace NinjaKiwi.GUTS.Models.CT;

public class PlayerActivity
{
	[CompilerGenerated]
	private string <GuildId>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	private int <NodeId>k__BackingField; //Field offset: 0x18
	[CompilerGenerated]
	private NodeActivityType <NodeActivityType>k__BackingField; //Field offset: 0x1C
	[CompilerGenerated]
	private DateTime <StartedAt>k__BackingField; //Field offset: 0x20
	[CompilerGenerated]
	private string <UserId>k__BackingField; //Field offset: 0x28

	public string GuildId
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		 set { } //Length: 5
	}

	public NodeActivityType NodeActivityType
	{
		[CompilerGenerated]
		 get { } //Length: 4
		[CompilerGenerated]
		 set { } //Length: 4
	}

	public int NodeId
	{
		[CompilerGenerated]
		 get { } //Length: 4
		[CompilerGenerated]
		 set { } //Length: 4
	}

	public DateTime StartedAt
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		 set { } //Length: 5
	}

	[JsonIgnore]
	public string UserId
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		 set { } //Length: 5
	}

	public PlayerActivity(string guildId, int nodeId, NodeActivityType nodeActivityType, DateTime startedAt) { }

	[CompilerGenerated]
	public string get_GuildId() { }

	[CompilerGenerated]
	public NodeActivityType get_NodeActivityType() { }

	[CompilerGenerated]
	public int get_NodeId() { }

	[CompilerGenerated]
	public DateTime get_StartedAt() { }

	[CompilerGenerated]
	public string get_UserId() { }

	[CompilerGenerated]
	public void set_GuildId(string value) { }

	[CompilerGenerated]
	public void set_NodeActivityType(NodeActivityType value) { }

	[CompilerGenerated]
	public void set_NodeId(int value) { }

	[CompilerGenerated]
	public void set_StartedAt(DateTime value) { }

	[CompilerGenerated]
	public void set_UserId(string value) { }

}

