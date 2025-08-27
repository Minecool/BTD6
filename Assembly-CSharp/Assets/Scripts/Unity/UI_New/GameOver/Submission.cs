namespace Assets.Scripts.Unity.UI_New.GameOver;

public class Submission
{
	public LeaderboardType leaderboardType; //Field offset: 0x10
	public string leaderboardId; //Field offset: 0x18
	public ulong score; //Field offset: 0x20
	public string metadata; //Field offset: 0x28
	public bool isMini; //Field offset: 0x30
	public bool isElite; //Field offset: 0x31
	public int teamSize; //Field offset: 0x34
	public string teamId; //Field offset: 0x38
	public Nullable<Single> sha; //Field offset: 0x40

	public Submission() { }

}

