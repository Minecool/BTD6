namespace Assets.Scripts.Unity.UI_New.ChallengeEditor;

public class ChallengeRulesScreen : GameMenu
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func<TowerData, Boolean> <>9__35_0; //Field offset: 0x8
		public static Func<TowerData, Boolean> <>9__35_1; //Field offset: 0x10

		private static <>c() { }

		public <>c() { }

		internal bool <DisplayTowers>b__35_0(TowerData x) { }

		internal bool <DisplayTowers>b__35_1(TowerData x) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass29_0
	{
		public CTRelicSelectableRulesMenu relicUI; //Field offset: 0x10
		public ChallengeRulesScreen <>4__this; //Field offset: 0x18

		public <>c__DisplayClass29_0() { }

		internal void <ShowRelics>b__0(BaseEventData _) { }

		internal void <ShowRelics>b__1(BaseEventData _) { }

	}

	public NK_TextMeshProUGUI maxMonkeysTxt; //Field offset: 0x48
	public NK_TextMeshProUGUI startingCashTxt; //Field offset: 0x50
	public NK_TextMeshProUGUI startingLivesTxt; //Field offset: 0x58
	public NK_TextMeshProUGUI startRoundTxt; //Field offset: 0x60
	public NK_TextMeshProUGUI endRoundTxt; //Field offset: 0x68
	public NK_TextMeshProUGUI leastCashOrTierLbl; //Field offset: 0x70
	public NK_TextMeshProUGUI leastCashOrTierTxt; //Field offset: 0x78
	public Image leastCashOrTierIcon; //Field offset: 0x80
	public Sprite leastCashSprite; //Field offset: 0x88
	public Sprite leastTiersSprite; //Field offset: 0x90
	public Transform towerContainer; //Field offset: 0x98
	public GameObject towerPrefab; //Field offset: 0xA0
	public GameObject anyHeroPrefab; //Field offset: 0xA8
	public GameObject heldRelicPrefab; //Field offset: 0xB0
	public Transform modifierContent; //Field offset: 0xB8
	public Transform gameRuleContent; //Field offset: 0xC0
	public Transform relicsContent; //Field offset: 0xC8
	public GameObject modifierPrefab; //Field offset: 0xD0
	public ModIconTheme modTheme; //Field offset: 0xD8
	public GameObject relicPopupObj; //Field offset: 0xE0
	public GameObject relicPopupArrowObj; //Field offset: 0xE8
	public TMP_Text relicPopupTitleTxt; //Field offset: 0xF0
	public TMP_Text relicPopupDecriptionTxt; //Field offset: 0xF8
	public GameObject relicPopupLockedObj; //Field offset: 0x100
	private DailyChallengeModel dcm; //Field offset: 0x108
	private readonly List<GameObject> towerDisplayList; //Field offset: 0x110

	public ChallengeRulesScreen() { }

	private void DisplayTowers() { }

	private float GetMaxRestrictionValue(ChallengeModifiers challengeModifier) { }

	private float GetMinRestrictionValue(ChallengeModifiers challengeModifier) { }

	private bool HasTowerCountsToShow(List<TowerData> towers) { }

	public void OnClose() { }

	public virtual void Open(object data) { }

	private void RelicMouseEnter(CTRelicSelectableRulesMenu clickedItem) { }

	private void RelicMouseExit(CTRelicSelectableRulesMenu clickedItem) { }

	private void SetUi() { }

	public void ShowModIcons(DailyChallengeModel dcm) { }

	public void ShowRelics() { }

}

