namespace NinjaKiwi.GUTS.Models.CT;

public class InstanceActivity
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func<PlayerActivity, DateTime> <>9__9_0; //Field offset: 0x8

		private static <>c() { }

		public <>c() { }

		internal DateTime <get_MostRecentSubmissionTime>b__9_0(PlayerActivity y) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass10_0
	{
		public DateTime dateFilter; //Field offset: 0x10
		public Func<KeyValuePair`2<String, PlayerActivity>, Boolean> <>9__0; //Field offset: 0x18

		public <>c__DisplayClass10_0() { }

		internal bool <GetNodeActivePlayers>b__0(KeyValuePair<String, PlayerActivity> x) { }

	}

	[CompilerGenerated]
	private Dictionary<String, PlayerActivity> <ActivePlayers>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	private List<PlayerActivity> <RecentCaptures>k__BackingField; //Field offset: 0x18

	public Dictionary<String, PlayerActivity> ActivePlayers
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		 set { } //Length: 5
	}

	[JsonIgnore]
	public DateTime MostRecentSubmissionTime
	{
		 get { } //Length: 312
	}

	public List<PlayerActivity> RecentCaptures
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		 set { } //Length: 5
	}

	public InstanceActivity() { }

	[CompilerGenerated]
	public Dictionary<String, PlayerActivity> get_ActivePlayers() { }

	public DateTime get_MostRecentSubmissionTime() { }

	[CompilerGenerated]
	public List<PlayerActivity> get_RecentCaptures() { }

	public Dictionary<Int32, List`1<PlayerActivity>> GetNodeActivePlayers(DateTime now, TimeSpan activityLife, string playerId) { }

	[CompilerGenerated]
	public void set_ActivePlayers(Dictionary<String, PlayerActivity> value) { }

	[CompilerGenerated]
	public void set_RecentCaptures(List<PlayerActivity> value) { }

}

