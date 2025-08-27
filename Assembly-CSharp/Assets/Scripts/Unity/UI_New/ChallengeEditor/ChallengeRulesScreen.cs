namespace Assets.Scripts.Unity.UI_New.ChallengeEditor;

public class ChallengeRulesScreen : GameMenu
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func<TowerData, Boolean> <>9__25_0; //Field offset: 0x8
		public static Func<TowerData, Boolean> <>9__25_1; //Field offset: 0x10

		private static <>c() { }

		public <>c() { }

		internal bool <DisplayTowers>b__25_0(TowerData x) { }

		internal bool <DisplayTowers>b__25_1(TowerData x) { }

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
	public Transform modifierContent; //Field offset: 0xB0
	public Transform gameRuleContent; //Field offset: 0xB8
	public GameObject modifierPrefab; //Field offset: 0xC0
	public ModIconTheme modTheme; //Field offset: 0xC8
	private DailyChallengeModel dcm; //Field offset: 0xD0
	private readonly List<GameObject> towerDisplayList; //Field offset: 0xD8

	public ChallengeRulesScreen() { }

	private void DisplayTowers() { }

	private float GetMaxRestrictionValue(ChallengeModifiers challengeModifier) { }

	private float GetMinRestrictionValue(ChallengeModifiers challengeModifier) { }

	private bool HasTowerCountsToShow(List<TowerData> towers) { }

	public void OnClose() { }

	public virtual void Open(object data) { }

	private void SetUi() { }

	public void ShowModIcons(DailyChallengeModel dcm) { }

}

