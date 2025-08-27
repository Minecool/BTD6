namespace Assets.Scripts.Utils.Leaderboards;

public class LeaderboardData
{
	public readonly int id; //Field offset: 0x10
	public readonly string linkId; //Field offset: 0x18
	public readonly int groupSize; //Field offset: 0x20
	public readonly bool isMini; //Field offset: 0x24
	public readonly bool isElite; //Field offset: 0x25
	public readonly LeaderboardType leaderboardType; //Field offset: 0x28
	public readonly string eventId; //Field offset: 0x30
	public readonly bool isGuildLeaderboard; //Field offset: 0x38
	[CompilerGenerated]
	private GroupScoreModel <PlayersGroupData>k__BackingField; //Field offset: 0x40
	[CompilerGenerated]
	private int <Placing>k__BackingField; //Field offset: 0x48
	[CompilerGenerated]
	private int <TotalScores>k__BackingField; //Field offset: 0x4C
	[CompilerGenerated]
	private Task<List`1<GroupScoreModel>> <ScoresLoadTask>k__BackingField; //Field offset: 0x50

	public bool HasPlayerScore
	{
		 get { } //Length: 9
	}

	public int Placing
	{
		[CompilerGenerated]
		 get { } //Length: 4
		[CompilerGenerated]
		 set { } //Length: 4
	}

	public GroupScoreModel PlayersGroupData
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		 set { } //Length: 5
	}

	public Task<List`1<GroupScoreModel>> ScoresLoadTask
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		 set { } //Length: 5
	}

	public int TotalScores
	{
		[CompilerGenerated]
		 get { } //Length: 4
		[CompilerGenerated]
		 set { } //Length: 4
	}

	public LeaderboardData(int id, LeaderboardType leaderboardType, string linkId, int groupSize, bool isMini, bool isElite, string eventId) { }

	public bool get_HasPlayerScore() { }

	[CompilerGenerated]
	public int get_Placing() { }

	[CompilerGenerated]
	public GroupScoreModel get_PlayersGroupData() { }

	[CompilerGenerated]
	public Task<List`1<GroupScoreModel>> get_ScoresLoadTask() { }

	[CompilerGenerated]
	public int get_TotalScores() { }

	[CompilerGenerated]
	public void set_Placing(int value) { }

	[CompilerGenerated]
	public void set_PlayersGroupData(GroupScoreModel value) { }

	[CompilerGenerated]
	public void set_ScoresLoadTask(Task<List`1<GroupScoreModel>> value) { }

	[CompilerGenerated]
	public void set_TotalScores(int value) { }

}

