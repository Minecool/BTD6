namespace NinjaKiwi.GUTS.Models.BCS;

public class WalletLeaderboardReward
{
	[CompilerGenerated]
	[Nullable(new IL2CPP_TYPE_U1[] {2, 1}])]
	private readonly WalletRewardGroup[] <Rewards>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	private readonly int <Place>k__BackingField; //Field offset: 0x18
	[CompilerGenerated]
	private readonly float <Perc>k__BackingField; //Field offset: 0x1C

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

	[Nullable(new IL2CPP_TYPE_U1[] {2, 1}])]
	public WalletRewardGroup[] Rewards
	{
		[CompilerGenerated]
		 get { } //Length: 5
	}

	[JsonConstructor]
	[NullableContext(1)]
	public WalletLeaderboardReward(string position, WalletRewardGroup[] rewards) { }

	[CompilerGenerated]
	public float get_Perc() { }

	[CompilerGenerated]
	public int get_Place() { }

	[CompilerGenerated]
	public WalletRewardGroup[] get_Rewards() { }

}

