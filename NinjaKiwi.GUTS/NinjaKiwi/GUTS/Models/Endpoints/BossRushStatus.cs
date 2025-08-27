namespace NinjaKiwi.GUTS.Models.Endpoints;

public class BossRushStatus : IBossRushPlayerStatus, IBossRushGuildStatus
{
	[CompilerGenerated]
	private List<SubmittedScore> <SubmittedScores>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	private ulong <CurrentStageScore>k__BackingField; //Field offset: 0x18
	[CompilerGenerated]
	private Dictionary<String, UInt64> <PlayerTotalScores>k__BackingField; //Field offset: 0x20
	[CompilerGenerated]
	private ulong <GuildEntryId>k__BackingField; //Field offset: 0x28
	[CompilerGenerated]
	private ulong <UserEntryId>k__BackingField; //Field offset: 0x30
	[CompilerGenerated]
	private byte <CurrentStage>k__BackingField; //Field offset: 0x38
	[CompilerGenerated]
	private Nullable<UInt64> <LatestScoreId>k__BackingField; //Field offset: 0x40

	public override byte CurrentStage
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		 set { } //Length: 4
	}

	public override ulong CurrentStageScore
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		 set { } //Length: 5
	}

	public override ulong GuildEntryId
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		 set { } //Length: 5
	}

	public override Nullable<UInt64> LatestScoreId
	{
		[CompilerGenerated]
		 get { } //Length: 11
		[CompilerGenerated]
		 set { } //Length: 8
	}

	public override Dictionary<String, UInt64> PlayerTotalScores
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		 set { } //Length: 5
	}

	public override List<SubmittedScore> SubmittedScores
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		 set { } //Length: 5
	}

	public override ulong UserEntryId
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		 set { } //Length: 5
	}

	public BossRushStatus() { }

	[CompilerGenerated]
	public override byte get_CurrentStage() { }

	[CompilerGenerated]
	public override ulong get_CurrentStageScore() { }

	[CompilerGenerated]
	public override ulong get_GuildEntryId() { }

	[CompilerGenerated]
	public override Nullable<UInt64> get_LatestScoreId() { }

	[CompilerGenerated]
	public override Dictionary<String, UInt64> get_PlayerTotalScores() { }

	[CompilerGenerated]
	public override List<SubmittedScore> get_SubmittedScores() { }

	[CompilerGenerated]
	public override ulong get_UserEntryId() { }

	[CompilerGenerated]
	public override void set_CurrentStage(byte value) { }

	[CompilerGenerated]
	public override void set_CurrentStageScore(ulong value) { }

	[CompilerGenerated]
	public override void set_GuildEntryId(ulong value) { }

	[CompilerGenerated]
	public override void set_LatestScoreId(Nullable<UInt64> value) { }

	[CompilerGenerated]
	public override void set_PlayerTotalScores(Dictionary<String, UInt64> value) { }

	[CompilerGenerated]
	public override void set_SubmittedScores(List<SubmittedScore> value) { }

	[CompilerGenerated]
	public override void set_UserEntryId(ulong value) { }

}

