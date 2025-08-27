namespace Assets.Scripts.Unity.UI_New;

public class LeaderboardScreenData
{
	public readonly BaseServerEvent baseServerEvent; //Field offset: 0x10
	public readonly LeaderboardReward[][] rewards; //Field offset: 0x18
	public readonly LeaderboardType leaderboardScreenType; //Field offset: 0x20
	public Nullable<Int32> instanceId; //Field offset: 0x24
	[CompilerGenerated]
	private bool <IsMiniSelected>k__BackingField; //Field offset: 0x2C
	[CompilerGenerated]
	private bool <IsEliteSelected>k__BackingField; //Field offset: 0x2D
	[CompilerGenerated]
	private Nullable<Int32> <OpenAtPlayerCount>k__BackingField; //Field offset: 0x30
	[CompilerGenerated]
	private Dictionary<String, String[]> <LocalCtGuildPlayers>k__BackingField; //Field offset: 0x38
	[CompilerGenerated]
	private Nullable<LeaderboardType> <EliteLeaderboardScreenType>k__BackingField; //Field offset: 0x40

	public Nullable<LeaderboardType> EliteLeaderboardScreenType
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		 set { } //Length: 5
	}

	public bool IsEliteSelected
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		 set { } //Length: 4
	}

	public bool IsMiniSelected
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		 set { } //Length: 4
	}

	public Dictionary<String, String[]> LocalCtGuildPlayers
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		 set { } //Length: 5
	}

	public Nullable<Int32> OpenAtPlayerCount
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		 set { } //Length: 5
	}

	public LeaderboardScreenData(BaseServerEvent baseServerEvent, LeaderboardType leaderboardScreenType, LeaderboardReward[][] rewards, bool isElite, Nullable<Int32> instanceId = null) { }

	[CompilerGenerated]
	public Nullable<LeaderboardType> get_EliteLeaderboardScreenType() { }

	[CompilerGenerated]
	public bool get_IsEliteSelected() { }

	[CompilerGenerated]
	public bool get_IsMiniSelected() { }

	[CompilerGenerated]
	public Dictionary<String, String[]> get_LocalCtGuildPlayers() { }

	[CompilerGenerated]
	public Nullable<Int32> get_OpenAtPlayerCount() { }

	[CompilerGenerated]
	public void set_EliteLeaderboardScreenType(Nullable<LeaderboardType> value) { }

	[CompilerGenerated]
	public void set_IsEliteSelected(bool value) { }

	[CompilerGenerated]
	public void set_IsMiniSelected(bool value) { }

	[CompilerGenerated]
	public void set_LocalCtGuildPlayers(Dictionary<String, String[]> value) { }

	[CompilerGenerated]
	public void set_OpenAtPlayerCount(Nullable<Int32> value) { }

}

