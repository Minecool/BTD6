namespace Assets.Scripts.Unity.UI_New.DailyChallenge;

public class BossRushScoreDisplay : MonoBehaviour
{
	[SerializeField]
	private TextMeshProUGUI scoreTxt; //Field offset: 0x20
	[SerializeField]
	private TextMeshProUGUI improvedScoreTxt; //Field offset: 0x28
	[SerializeField]
	private GameObject submittedObj; //Field offset: 0x30
	[HideInInspector]
	public int score; //Field offset: 0x38

	public BossRushScoreDisplay() { }

	public void PlaySubmitAnim(bool isNewScore, bool isImprovedScore, int improvedAmount) { }

	public void SetEmpty() { }

	public void SetScore(int score) { }

}

