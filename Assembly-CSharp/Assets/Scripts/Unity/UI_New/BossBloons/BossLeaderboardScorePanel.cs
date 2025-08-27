namespace Assets.Scripts.Unity.UI_New.BossBloons;

public class BossLeaderboardScorePanel : MonoBehaviour
{
	[SerializeField]
	private GameObject bestScoreBackgroundObj; //Field offset: 0x20
	[SerializeField]
	private GameObject newBestScoreBackgroundObj; //Field offset: 0x28
	[SerializeField]
	private GameObject leastTiersIcon; //Field offset: 0x30
	[SerializeField]
	private GameObject leastCashIcon; //Field offset: 0x38
	[SerializeField]
	private GameObject timeTieBreakObj; //Field offset: 0x40
	[SerializeField]
	private NK_TextMeshProUGUI timeTieBreakTxt; //Field offset: 0x48
	[SerializeField]
	private NK_TextMeshProUGUI timeScoreTxt; //Field offset: 0x50
	[SerializeField]
	private NK_TextMeshProUGUI scoreTxt; //Field offset: 0x58
	[SerializeField]
	private NK_TextMeshProUGUI bossTierScoreTxt; //Field offset: 0x60

	public BossLeaderboardScorePanel() { }

	private void Awake() { }

	private void ResetDisplay() { }

	public void SetEmptyBossScore(LeaderboardType leaderboardType) { }

	public void SetScore(BossScoreComponents scoreComponents, LeaderboardType leaderboardType, Nullable<Boolean> isNewBestScore = null) { }

	public void SetScore(LeaderboardScoreData leaderboardScore, LeaderboardType leaderboardType, Nullable<Boolean> isNewBestScore = null) { }

}

