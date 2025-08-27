namespace NinjaKiwi.GUTS.Models.Endpoints;

public interface IBossRushPlayerStatus
{

	public List<SubmittedScore> SubmittedScores
	{
		 get { } //Length: 0
		 set { } //Length: 0
	}

	public ulong UserEntryId
	{
		 get { } //Length: 0
		 set { } //Length: 0
	}

	public List<SubmittedScore> get_SubmittedScores() { }

	public ulong get_UserEntryId() { }

	public void set_SubmittedScores(List<SubmittedScore> value) { }

	public void set_UserEntryId(ulong value) { }

}

