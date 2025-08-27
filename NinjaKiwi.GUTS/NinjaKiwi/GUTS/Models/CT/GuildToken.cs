namespace NinjaKiwi.GUTS.Models.CT;

internal class GuildToken
{
	[CompilerGenerated]
	private string <GuildKey>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	private TimeSpan <CreationTime>k__BackingField; //Field offset: 0x18

	private TimeSpan CreationTime
	{
		[CompilerGenerated]
		private get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 5
	}

	internal string GuildKey
	{
		[CompilerGenerated]
		internal get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 5
	}

	internal bool IsValid
	{
		internal get { } //Length: 276
	}

	private static TimeSpan Now
	{
		private get { } //Length: 91
	}

	internal GuildToken(string token) { }

	[CompilerGenerated]
	private TimeSpan get_CreationTime() { }

	[CompilerGenerated]
	internal string get_GuildKey() { }

	internal bool get_IsValid() { }

	private static TimeSpan get_Now() { }

	internal void Refresh(string guildKey) { }

	[CompilerGenerated]
	private void set_CreationTime(TimeSpan value) { }

	[CompilerGenerated]
	private void set_GuildKey(string value) { }

}

