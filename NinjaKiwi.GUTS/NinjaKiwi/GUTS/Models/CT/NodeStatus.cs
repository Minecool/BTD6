namespace NinjaKiwi.GUTS.Models.CT;

public class NodeStatus
{
	[CompilerGenerated]
	private string <GuildId>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	private string <UserId>k__BackingField; //Field offset: 0x18
	[CompilerGenerated]
	private DateTime <CapturedAt>k__BackingField; //Field offset: 0x20
	[CompilerGenerated]
	private int <Score>k__BackingField; //Field offset: 0x28
	[CompilerGenerated]
	private ScoringType <ScoringType>k__BackingField; //Field offset: 0x2C
	[JsonIgnore]
	private Nullable<Int32> _currentScore; //Field offset: 0x30
	[JsonIgnore]
	private DateTime _scoreValidUntil; //Field offset: 0x38
	[JsonIgnore]
	private Nullable<DateTime> _nextDegradeAt; //Field offset: 0x40
	[JsonIgnore]
	private Nullable<DateTime> _fullDegradeAt; //Field offset: 0x50

	public DateTime CapturedAt
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

	public int Score
	{
		[CompilerGenerated]
		 get { } //Length: 4
		[CompilerGenerated]
		 set { } //Length: 4
	}

	public ScoringType ScoringType
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		 set { } //Length: 4
	}

	public string UserId
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		 set { } //Length: 5
	}

	public NodeStatus(string guildId, string userId, DateTime capturedAt, int score, ScoringType scoringType) { }

	private Nullable<DateTime> CalculateFullDegradeAt(Nullable<CtTileType> ctTileType) { }

	private Nullable<DateTime> CalculateNextDegradeAt(Nullable<CtTileType> ctTileType) { }

	[CompilerGenerated]
	public DateTime get_CapturedAt() { }

	[CompilerGenerated]
	public string get_GuildId() { }

	[CompilerGenerated]
	public int get_Score() { }

	[CompilerGenerated]
	public ScoringType get_ScoringType() { }

	[CompilerGenerated]
	public string get_UserId() { }

	public int GetCurrentScore(Nullable<CtTileType> ctTileType) { }

	public Nullable<DateTime> GetFullDegradeAt(Nullable<CtTileType> ctTileType) { }

	public Nullable<DateTime> GetNextDegradeAt(Nullable<CtTileType> ctTileType) { }

	[CompilerGenerated]
	public void set_CapturedAt(DateTime value) { }

	[CompilerGenerated]
	public void set_GuildId(string value) { }

	[CompilerGenerated]
	public void set_Score(int value) { }

	[CompilerGenerated]
	public void set_ScoringType(ScoringType value) { }

	[CompilerGenerated]
	public void set_UserId(string value) { }

}

