namespace Assets.Scripts.Unity.UI_New.InGame;

public class RogueHudUI : DynamicUiObject
{
	private static readonly String[] tierKeys; //Field offset: 0x0
	[SerializeField]
	private GameObject damageCountObj; //Field offset: 0x20
	[SerializeField]
	private NK_TextMeshProUGUI damageCountTxt; //Field offset: 0x28
	[SerializeField]
	private NK_TextMeshProUGUI newRewardTxt; //Field offset: 0x30
	[SerializeField]
	private Animator newScoreAnimator; //Field offset: 0x38
	[SerializeField]
	private Image newRewardIcon; //Field offset: 0x40
	private int nextScoreIndex; //Field offset: 0x48

	private LegendsDataModel LegendsData
	{
		private get { } //Length: 81
	}

	private RogueGameSaveData RogueSaveData
	{
		private get { } //Length: 227
	}

	private static RogueHudUI() { }

	public RogueHudUI() { }

	private void AttachEvents() { }

	private void Awake() { }

	private void CheckGoals(int score) { }

	private LegendsDataModel get_LegendsData() { }

	private RogueGameSaveData get_RogueSaveData() { }

	public virtual void OnGameEnd() { }

	public virtual void OnRestartGame() { }

	private void OnRushKill(int amount) { }

	private void OnUpdateEndlessRoundsMode(bool enduranceMode, long data) { }

	private void RemoveEvents() { }

	public void Setup() { }

}

