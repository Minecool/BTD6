namespace NinjaKiwi.GUTS.Models;

public class LeaderboardReward
{
	[CompilerGenerated]
	private readonly string <RawRewards>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	private readonly int <TeamTrophies>k__BackingField; //Field offset: 0x18
	[CompilerGenerated]
	private readonly string <TeamBadge>k__BackingField; //Field offset: 0x20
	[CompilerGenerated]
	private readonly int <Place>k__BackingField; //Field offset: 0x28
	[CompilerGenerated]
	private readonly float <Perc>k__BackingField; //Field offset: 0x2C

	public float Perc
	{
		[CompilerGenerated]
		 get { } //Length: 6
	}

	public int Place
	{
		[CompilerGenerated]
		 get { } //Length: 4
	}

	public string RawRewards
	{
		[CompilerGenerated]
		 get { } //Length: 5
	}

	public string TeamBadge
	{
		[CompilerGenerated]
		 get { } //Length: 5
	}

	public int TeamTrophies
	{
		[CompilerGenerated]
		 get { } //Length: 4
	}

	[JsonConstructor]
	public LeaderboardReward(string position, string Reward) { }

	[CompilerGenerated]
	public float get_Perc() { }

	[CompilerGenerated]
	public int get_Place() { }

	[CompilerGenerated]
	public string get_RawRewards() { }

	[CompilerGenerated]
	public string get_TeamBadge() { }

	[CompilerGenerated]
	public int get_TeamTrophies() { }

}

