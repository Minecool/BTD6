namespace Assets.Scripts.Models.Profile;

public class BossLeaderboardStanding
{
	public BossLeaderboardType id; //Field offset: 0x10
	public long bestScore; //Field offset: 0x18
	public string teamId; //Field offset: 0x20

	public BossLeaderboardStanding() { }

}

