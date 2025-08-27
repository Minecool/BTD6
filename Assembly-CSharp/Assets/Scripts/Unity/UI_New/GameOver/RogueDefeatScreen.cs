namespace Assets.Scripts.Unity.UI_New.GameOver;

public class RogueDefeatScreen : SummaryScreen
{
	[SerializeField]
	private Image bossIcon; //Field offset: 0x110
	[SerializeField]
	private TMP_Text title; //Field offset: 0x118
	[SerializeField]
	private TMP_Text finalRoundTxt; //Field offset: 0x120
	[SerializeField]
	private AudioClip defeatSound; //Field offset: 0x128
	[SerializeField]
	private GameObject heartObj; //Field offset: 0x130
	[SerializeField]
	private Button continueBtn; //Field offset: 0x138
	[SerializeField]
	private Button retryLastRoundBtn; //Field offset: 0x140
	[SerializeField]
	private TextMeshProUGUI continueCostTxt; //Field offset: 0x148
	private KonFuze continuePrice; //Field offset: 0x150
	public BloonCauseDeathDisplay bloonCauseDeathDisplayPrefab; //Field offset: 0x158
	public GameObject bloonCoDContainer; //Field offset: 0x160
	private readonly List<BloonCauseDeathDisplay> bloonCauseDeathDisplayList; //Field offset: 0x168
	protected MapSaveDataModel retryMapSave; //Field offset: 0x170

	protected virtual bool IsVictoryScreen
	{
		 get { } //Length: 3
	}

	public RogueDefeatScreen() { }

	protected virtual void Awake() { }

	protected virtual void ButtonsInteractive(bool canInteract) { }

	private void ContinueClicked() { }

	protected virtual bool get_IsVictoryScreen() { }

	public virtual void Open(object menuData) { }

	private void RunContinue() { }

}

