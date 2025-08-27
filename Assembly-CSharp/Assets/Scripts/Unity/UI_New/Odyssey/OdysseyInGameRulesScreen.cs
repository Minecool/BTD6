namespace Assets.Scripts.Unity.UI_New.Odyssey;

public class OdysseyInGameRulesScreen : GameMenu
{
	public NK_TextMeshProUGUI txtDifficultyModes; //Field offset: 0x48
	public NK_TextMeshProUGUI txtMapName; //Field offset: 0x50
	public NK_TextMeshProUGUI txtMapNumber; //Field offset: 0x58
	public NK_TextMeshProUGUI txtStartingCash; //Field offset: 0x60
	public NK_TextMeshProUGUI txtStartRoundDetails; //Field offset: 0x68
	public NK_TextMeshProUGUI leastCashOrTierLbl; //Field offset: 0x70
	public NK_TextMeshProUGUI leastCashOrTierTxt; //Field offset: 0x78
	public Image leastCashOrTierIcon; //Field offset: 0x80
	public Sprite leastCashSprite; //Field offset: 0x88
	public Sprite leastTiersSprite; //Field offset: 0x90
	public OdysseyMapPanel[] arrMaps; //Field offset: 0x98
	public Button clickBlock; //Field offset: 0xA0
	public Transform modifierContent; //Field offset: 0xA8
	public GameObject modifierPrefab; //Field offset: 0xB0
	public ModIconTheme modTheme; //Field offset: 0xB8
	private bool initialized; //Field offset: 0xC0
	private OdysseyData odysseyData; //Field offset: 0xC8
	private EmbarkedActiveOdyssey activeOdyssey; //Field offset: 0xD0
	private int mapIndexSelected; //Field offset: 0xD8

	public int MapIndexSelected
	{
		 set { } //Length: 283
	}

	public OdysseyInGameRulesScreen() { }

	public void DrawUi() { }

	private float GetMaxRestrictionValue(ChallengeModifiers challengeModifier) { }

	private float GetMinRestrictionValue(ChallengeModifiers challengeModifier) { }

	public bool IsMapCompletedForCurrentDifficulty(int mapIndex) { }

	public void NewMapSelected(OdysseyMapPanel panel) { }

	public void OnCloseClick() { }

	public virtual void Open(object menuData) { }

	public void set_MapIndexSelected(int value) { }

	public void ShowModIcons(DailyChallengeModel dcm) { }

}

