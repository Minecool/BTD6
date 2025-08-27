namespace NinjaKiwi.GUTS.Models.Endpoints;

public class BossRushGuildStatus : IBossRushGuildStatus
{
	[CompilerGenerated]
	private ulong <CurrentStageScore>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	private Dictionary<String, UInt64> <PlayerTotalScores>k__BackingField; //Field offset: 0x18
	[CompilerGenerated]
	private ulong <GuildEntryId>k__BackingField; //Field offset: 0x20
	[CompilerGenerated]
	private byte <CurrentStage>k__BackingField; //Field offset: 0x28
	[CompilerGenerated]
	private Nullable<UInt64> <LatestScoreId>k__BackingField; //Field offset: 0x30

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

	public BossRushGuildStatus() { }

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
	public override void set_CurrentStage(byte value) { }

	[CompilerGenerated]
	public override void set_CurrentStageScore(ulong value) { }

	[CompilerGenerated]
	public override void set_GuildEntryId(ulong value) { }

	[CompilerGenerated]
	public override void set_LatestScoreId(Nullable<UInt64> value) { }

	[CompilerGenerated]
	public override void set_PlayerTotalScores(Dictionary<String, UInt64> value) { }

}

