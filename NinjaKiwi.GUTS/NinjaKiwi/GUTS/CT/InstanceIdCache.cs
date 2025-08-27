namespace NinjaKiwi.GUTS.CT;

internal class InstanceIdCache
{
	[CompilerGenerated]
	private string <GuildId>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	private string <EventId>k__BackingField; //Field offset: 0x18
	[CompilerGenerated]
	private int <InstanceId>k__BackingField; //Field offset: 0x20

	public string EventId
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		 set { } //Length: 5
	}

	public string GuildId
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		 set { } //Length: 5
	}

	public int InstanceId
	{
		[CompilerGenerated]
		 get { } //Length: 4
		[CompilerGenerated]
		 set { } //Length: 4
	}

	public InstanceIdCache(string guildId, string eventId, int instanceId) { }

	[CompilerGenerated]
	public string get_EventId() { }

	[CompilerGenerated]
	public string get_GuildId() { }

	[CompilerGenerated]
	public int get_InstanceId() { }

	[CompilerGenerated]
	public void set_EventId(string value) { }

	[CompilerGenerated]
	public void set_GuildId(string value) { }

	[CompilerGenerated]
	public void set_InstanceId(int value) { }

}

