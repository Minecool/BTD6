namespace Assets.Scripts.Unity.UI_New.Teams;

public class GuildSearchFilters
{
	public const string kDefaultSearchFilters = "status:(OPEN) AND NOT full:true"; //Field offset: 0x0
	[CompilerGenerated]
	private bool <HideAutoJoinDisabled>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	private bool <HideFullTeams>k__BackingField; //Field offset: 0x11
	[CompilerGenerated]
	private bool <HidePrivate>k__BackingField; //Field offset: 0x12
	[CompilerGenerated]
	private GuildStance <Stance>k__BackingField; //Field offset: 0x13

	public bool HasDefaultValues
	{
		 get { } //Length: 29
	}

	public bool HideAutoJoinDisabled
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		 set { } //Length: 4
	}

	public bool HideFullTeams
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		 set { } //Length: 4
	}

	public bool HidePrivate
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		 set { } //Length: 4
	}

	public GuildStance Stance
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		 set { } //Length: 4
	}

	public GuildSearchFilters() { }

	public bool get_HasDefaultValues() { }

	[CompilerGenerated]
	public bool get_HideAutoJoinDisabled() { }

	[CompilerGenerated]
	public bool get_HideFullTeams() { }

	[CompilerGenerated]
	public bool get_HidePrivate() { }

	[CompilerGenerated]
	public GuildStance get_Stance() { }

	public string GetSearchQuery(int minSizeFilter, int maxSizeFilter) { }

	[CompilerGenerated]
	public void set_HideAutoJoinDisabled(bool value) { }

	[CompilerGenerated]
	public void set_HideFullTeams(bool value) { }

	[CompilerGenerated]
	public void set_HidePrivate(bool value) { }

	[CompilerGenerated]
	public void set_Stance(GuildStance value) { }

}

