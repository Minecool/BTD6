namespace NinjaKiwi.GUTS.Models.Endpoints;

public class BossRushPlayerStatus : IBossRushPlayerStatus
{
	[CompilerGenerated]
	private List<SubmittedScore> <SubmittedScores>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	private ulong <UserEntryId>k__BackingField; //Field offset: 0x18

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

	public BossRushPlayerStatus() { }

	[CompilerGenerated]
	public override List<SubmittedScore> get_SubmittedScores() { }

	[CompilerGenerated]
	public override ulong get_UserEntryId() { }

	[CompilerGenerated]
	public override void set_SubmittedScores(List<SubmittedScore> value) { }

	[CompilerGenerated]
	public override void set_UserEntryId(ulong value) { }

}

