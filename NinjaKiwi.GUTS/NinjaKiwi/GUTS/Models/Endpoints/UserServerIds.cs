namespace NinjaKiwi.GUTS.Models.Endpoints;

public class UserServerIds
{
	[CompilerGenerated]
	private ulong <GuildEntryId>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	private ulong <UserEntryId>k__BackingField; //Field offset: 0x18
	[CompilerGenerated]
	private int <CtInstanceId>k__BackingField; //Field offset: 0x20

	[JsonIgnore]
	public int CtGuildEntryId
	{
		 get { } //Length: 103
		 set { } //Length: 8
	}

	[JsonProperty("InstanceId")]
	public int CtInstanceId
	{
		[CompilerGenerated]
		 get { } //Length: 4
		[CompilerGenerated]
		 set { } //Length: 4
	}

	[JsonIgnore]
	public int CtUserEntryId
	{
		 get { } //Length: 103
		 set { } //Length: 8
	}

	public ulong GuildEntryId
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		 set { } //Length: 5
	}

	[JsonIgnore]
	public bool IsValidForCt
	{
		 get { } //Length: 45
	}

	public ulong UserEntryId
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		 set { } //Length: 5
	}

	public UserServerIds() { }

	public int get_CtGuildEntryId() { }

	[CompilerGenerated]
	public int get_CtInstanceId() { }

	public int get_CtUserEntryId() { }

	[CompilerGenerated]
	public ulong get_GuildEntryId() { }

	public bool get_IsValidForCt() { }

	[CompilerGenerated]
	public ulong get_UserEntryId() { }

	private static int GetValidInt(ulong value) { }

	public void set_CtGuildEntryId(int value) { }

	[CompilerGenerated]
	public void set_CtInstanceId(int value) { }

	public void set_CtUserEntryId(int value) { }

	[CompilerGenerated]
	public void set_GuildEntryId(ulong value) { }

	[CompilerGenerated]
	public void set_UserEntryId(ulong value) { }

}

