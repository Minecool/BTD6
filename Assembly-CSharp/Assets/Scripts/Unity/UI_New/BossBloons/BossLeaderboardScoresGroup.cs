namespace Assets.Scripts.Unity.UI_New.BossBloons;

public class BossLeaderboardScoresGroup : MonoBehaviour
{
	[SerializeField]
	private BossLeaderboardScorePanel bestScorePanel; //Field offset: 0x20
	[SerializeField]
	private BossLeaderboardScorePanel currentScorePanel; //Field offset: 0x28

	public BossLeaderboardScoresGroup() { }

	private void Awake() { }

	public void ShowScores(LeaderboardType leaderboardType, BossScoreComponents currentScore, BossScoreComponents previousScore) { }

	public void ShowScores(LeaderboardType leaderboardType, LeaderboardScoreData currentScore, Nullable<LeaderboardScoreData> previousScore) { }

}

