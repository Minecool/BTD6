namespace Assets.Scripts.Unity.UI_New.Odyssey;

public class OdysseyIslandInfoPanelPopup : OdysseyPopup
{
	public NK_TextMeshProUGUI txtDifficultyModes; //Field offset: 0x48
	public NK_TextMeshProUGUI txtMapName; //Field offset: 0x50
	public NK_TextMeshProUGUI txtMapNumber; //Field offset: 0x58
	public NK_TextMeshProUGUI txtStartingCash; //Field offset: 0x60
	public NK_TextMeshProUGUI txtStartRoundDetails; //Field offset: 0x68
	public GameObject leastCashOrTierDetail; //Field offset: 0x70
	public NK_TextMeshProUGUI leastCashOrTierLbl; //Field offset: 0x78
	public NK_TextMeshProUGUI leastCashOrTierTxt; //Field offset: 0x80
	public Image leastCashOrTierIcon; //Field offset: 0x88
	public Sprite leastCashSprite; //Field offset: 0x90
	public Sprite leastTiersSprite; //Field offset: 0x98
	public Button editorEditBtn; //Field offset: 0xA0
	public Button editorReplayBtn; //Field offset: 0xA8
	public OdysseyMapPanel[] arrMaps; //Field offset: 0xB0
	public Transform modifierContent; //Field offset: 0xB8
	public GameObject modifierPrefab; //Field offset: 0xC0
	public ModIconTheme modTheme; //Field offset: 0xC8
	private bool initialized; //Field offset: 0xD0
	private int mapIndexSelected; //Field offset: 0xD4

	public int MapIndexSelected
	{
		 set { } //Length: 283
	}

	public OdysseyIslandInfoPanelPopup() { }

	[CompilerGenerated]
	private GameObject <Initialize>b__21_0() { }

	[CompilerGenerated]
	private void <UpdateEditorMode>b__25_0() { }

	[CompilerGenerated]
	private void <UpdateEditorMode>b__25_1() { }

	public void DrawUi() { }

	private float GetMaxRestrictionValue(ChallengeModifiers challengeModifier) { }

	private float GetMinRestrictionValue(ChallengeModifiers challengeModifier) { }

	public virtual void Initialize(OdysseyEventScreen odysseyEventScreen, object metaData) { }

	private void InitializeMaps(int mapIndexSelected) { }

	public bool IsMapCompletedOrHasSaveData() { }

	public void NewMapSelected(OdysseyMapPanel panel) { }

	public virtual void OnCloseClick() { }

	public virtual void OnDifficultyChanged() { }

	public void set_MapIndexSelected(int value) { }

	public void ShowModIcons(DailyChallengeModel dcm) { }

	private void UpdateEditorMode() { }

	private void UpdateMapSpecificData() { }

}

