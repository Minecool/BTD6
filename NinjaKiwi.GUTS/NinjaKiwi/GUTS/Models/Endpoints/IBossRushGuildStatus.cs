namespace NinjaKiwi.GUTS.Models.Endpoints;

public interface IBossRushGuildStatus
{

	public byte CurrentStage
	{
		 get { } //Length: 0
		 set { } //Length: 0
	}

	public ulong CurrentStageScore
	{
		 get { } //Length: 0
		 set { } //Length: 0
	}

	public ulong GuildEntryId
	{
		 get { } //Length: 0
		 set { } //Length: 0
	}

	public Nullable<UInt64> LatestScoreId
	{
		 get { } //Length: 0
		 set { } //Length: 0
	}

	public Dictionary<String, UInt64> PlayerTotalScores
	{
		 get { } //Length: 0
		 set { } //Length: 0
	}

	public byte get_CurrentStage() { }

	public ulong get_CurrentStageScore() { }

	public ulong get_GuildEntryId() { }

	public Nullable<UInt64> get_LatestScoreId() { }

	public Dictionary<String, UInt64> get_PlayerTotalScores() { }

	public void set_CurrentStage(byte value) { }

	public void set_CurrentStageScore(ulong value) { }

	public void set_GuildEntryId(ulong value) { }

	public void set_LatestScoreId(Nullable<UInt64> value) { }

	public void set_PlayerTotalScores(Dictionary<String, UInt64> value) { }

}

