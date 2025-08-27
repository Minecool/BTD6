namespace Assets.Scripts.Unity.UI_New.InGame;

public class RogueLeastCashHud : DynamicUiObject
{
	[SerializeField]
	private Image rewardIconImg; //Field offset: 0x20
	[SerializeField]
	private NK_TextMeshProUGUI cashSpentTxt; //Field offset: 0x28
	private int rewardIndex; //Field offset: 0x30

	private UnityToSimulation Bridge
	{
		private get { } //Length: 7
	}

	private LegendsDataModel LegendsData
	{
		private get { } //Length: 81
	}

	protected LocalizationManager Locs
	{
		 get { } //Length: 48
	}

	private RogueGameSaveData RogueSaveData
	{
		private get { } //Length: 227
	}

	public RogueLeastCashHud() { }

	private void AttachEvents() { }

	private UnityToSimulation get_Bridge() { }

	private LegendsDataModel get_LegendsData() { }

	protected LocalizationManager get_Locs() { }

	private RogueGameSaveData get_RogueSaveData() { }

	public virtual void OnGameEnd() { }

	public virtual void OnRestartGame() { }

	private void RemoveEvents() { }

	public void Setup() { }

	private void SimulationCashChanged() { }

	private void UpdateDisplay() { }

}

