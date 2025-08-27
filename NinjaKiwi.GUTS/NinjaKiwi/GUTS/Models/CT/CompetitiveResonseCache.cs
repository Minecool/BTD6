namespace NinjaKiwi.GUTS.Models.CT;

public class CompetitiveResonseCache
{
	[CompilerGenerated]
	private readonly string <GuildId>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	private readonly string <EventId>k__BackingField; //Field offset: 0x18
	[CompilerGenerated]
	private readonly CompetitiveResponse <CompetitiveResponse>k__BackingField; //Field offset: 0x20
	[CompilerGenerated]
	private readonly DateTime <CacheTime>k__BackingField; //Field offset: 0x28

	public DateTime CacheTime
	{
		[CompilerGenerated]
		 get { } //Length: 5
	}

	public CompetitiveResponse CompetitiveResponse
	{
		[CompilerGenerated]
		 get { } //Length: 5
	}

	public string EventId
	{
		[CompilerGenerated]
		 get { } //Length: 5
	}

	public string GuildId
	{
		[CompilerGenerated]
		 get { } //Length: 5
	}

	public CompetitiveResonseCache(string guildId, string eventId, CompetitiveResponse competitiveResponse) { }

	[CompilerGenerated]
	public DateTime get_CacheTime() { }

	[CompilerGenerated]
	public CompetitiveResponse get_CompetitiveResponse() { }

	[CompilerGenerated]
	public string get_EventId() { }

	[CompilerGenerated]
	public string get_GuildId() { }

	public bool IsValid(string eventId) { }

}

