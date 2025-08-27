namespace NinjaKiwi.LiNK.DataModels;

public class RankModel
{
	public string leaderboardID; //Field offset: 0x10
	public string userID; //Field offset: 0x18
	public int rank; //Field offset: 0x20
	public int total; //Field offset: 0x24
	public long score; //Field offset: 0x28

	public RankModel() { }

}

