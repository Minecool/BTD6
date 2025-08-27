namespace Assets.Scripts.Unity.UI_New.Upgrade;

public class UpgradeScreen : GameMenu
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func<Model, Boolean> <>9__85_0; //Field offset: 0x8

		private static <>c() { }

		public <>c() { }

		internal bool <PopulatePath>b__85_0(Model x) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass74_0
	{
		public UpgradeScreen <>4__this; //Field offset: 0x10
		public StoreItem storeItem; //Field offset: 0x18

		public <>c__DisplayClass74_0() { }

		internal void <SetIapButtons>b__0() { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass92_0
	{
		public TowerModel tower; //Field offset: 0x10

		public <>c__DisplayClass92_0() { }

		internal bool <IsTowerInvalid>b__0(TowerData x) { }

	}

	public SelectedUpgrade selectedUpgrade; //Field offset: 0x48
	public NK_TextMeshProUGUI xpToSpend; //Field offset: 0x50
	public NK_TextMeshProUGUI towerTitle; //Field offset: 0x58
	public NK_TextMeshProUGUI towerDescription; //Field offset: 0x60
	public NK_TextMeshProUGUI towerTitleParagon; //Field offset: 0x68
	public NK_TextMeshProUGUI towerDescriptionParagon; //Field offset: 0x70
	public NK_TextMeshProUGUI caveat; //Field offset: 0x78
	public GameObject path1Container; //Field offset: 0x80
	public GameObject path2Container; //Field offset: 0x88
	public GameObject path3Container; //Field offset: 0x90
	public GameObject prevArrow; //Field offset: 0x98
	public GameObject nextArrow; //Field offset: 0xA0
	public GameObject upgradePrefab; //Field offset: 0xA8
	private UpgradeDetails[] path1Upgrades; //Field offset: 0xB0
	private UpgradeDetails[] path2Upgrades; //Field offset: 0xB8
	private UpgradeDetails[] path3Upgrades; //Field offset: 0xC0
	private bool initialized; //Field offset: 0xC8
	private List<String> seenUpgrades; //Field offset: 0xD0
	private int currentIndex; //Field offset: 0xD8
	private bool hasTower; //Field offset: 0xDC
	private UpgradePopup upgradePopup; //Field offset: 0xE0
	private UpgradePopup upgradePopupLeft; //Field offset: 0xE8
	private UpgradeDetails selectedDetails; //Field offset: 0xF0
	public UpgradePopup upgradePopupPrefab; //Field offset: 0xF8
	public UpgradePopup upgradePopupLeftPrefab; //Field offset: 0x100
	public TowerProductButton purchaseTowerXP; //Field offset: 0x108
	public TowerProductButton purchaseAllTowerUpgrades; //Field offset: 0x110
	public TowerProductButton purchaseAllTowerUpgradesIncludingParagon; //Field offset: 0x118
	public TowerProductButton purchaseParagonTowerUpgrades; //Field offset: 0x120
	public Material fastUIMaterial; //Field offset: 0x128
	public Material grayscaleUIMaterial; //Field offset: 0x130
	public TowerContainerSpritesAsset towerContainerSprites; //Field offset: 0x138
	public AudioClip towerLevelUpSound; //Field offset: 0x140
	public AudioClip paragonLevelUpSound; //Field offset: 0x148
	public AudioClip click3Sound; //Field offset: 0x150
	public AudioClip returnSound; //Field offset: 0x158
	public AudioClip return2Sound; //Field offset: 0x160
	public Color backgroundColour; //Field offset: 0x168
	public Color backgroundParagonColour; //Field offset: 0x178
	public GameObject paragonPanel; //Field offset: 0x188
	public GameObject paragonTitlePanel; //Field offset: 0x190
	public GameObject paragonBackgroundLockedPanel; //Field offset: 0x198
	public Animator paragonAnim; //Field offset: 0x1A0
	public Sprite paragonTglOn; //Field offset: 0x1A8
	public Sprite paragonTglOff; //Field offset: 0x1B0
	public UpgradeDetails paragonUpgradeDetails; //Field offset: 0x1B8
	public Button gamepadInfoButton; //Field offset: 0x1C0
	public GameObject towerGiftUnlockObject; //Field offset: 0x1C8
	public Image goalProgressBarImage; //Field offset: 0x1D0
	public NK_TextMeshProUGUI goalProgressText; //Field offset: 0x1D8
	public GameObject isCurrentGoalObject; //Field offset: 0x1E0
	public GameObject isCollectableObject; //Field offset: 0x1E8
	public GameObject noPopsForGoalObject; //Field offset: 0x1F0
	public Button towerGiftGoButton; //Field offset: 0x1F8
	public Button towerGiftGetNowButton; //Field offset: 0x200
	public GameObject unlockedObject; //Field offset: 0x208
	[SerializeField]
	private GameObject levelLockedObject; //Field offset: 0x210
	private TowerSet towerSet; //Field offset: 0x218
	private string currTowerId; //Field offset: 0x220
	private bool gamepadInfoMode; //Field offset: 0x228

	private QuestTrackerManager QuestTrackerManager
	{
		private get { } //Length: 68
	}

	public UpgradeScreen() { }

	[CompilerGenerated]
	private GameObject <Open>b__62_0() { }

	[CompilerGenerated]
	private void <Open>b__62_1() { }

	public void AcquireUpgrade(BaseEventData eventData) { }

	private List<AbilityModel> AddBeastHandlerAbilities(List<AbilityModel> abilityList, BeastHandlerLeashModel leashModel) { }

	private UpgradeDetails BuildUpgradeButton(GameObject prefab, GameObject parent) { }

	public virtual void Close() { }

	public UpgradeDetails CompareDetails(UpgradeDetails current, UpgradeDetails next, string currentUpgradeID, string upgradeID = "") { }

	public void ConfirmUpgradeAll() { }

	private void GamepadSelectedObjectChanged(GameObject x) { }

	private QuestTrackerManager get_QuestTrackerManager() { }

	private UpgradeModel GetParagonUpgradeModel(string baseId) { }

	public float GetUpgradeAllCost() { }

	private UpgradeModel GetUpgradeModel(UpgradePathModel model) { }

	public void HidePopup() { }

	public bool IsParagonPurchased() { }

	private bool IsTowerInvalid(TowerModel tower) { }

	public void LockTower() { }

	public void NextTower() { }

	public void OnFinishPurchase() { }

	private void OnPurchaseFailedCallback() { }

	public void OnStartPurchase() { }

	private void OnTowerGiftGetNowButton(StoreItem storeItem) { }

	private void OnTowerGiftGoButton() { }

	public virtual void Open(object menuData) { }

	public void PopulateParagon(TowerModel tower) { }

	private void PopulatePath(TowerModel tower, int pathIndex, UpgradeDetails[] pathUpgrades) { }

	private void PopulatePaths(TowerModel towerModel, bool selectNext, string initialSelection = "") { }

	public void PrevTower() { }

	public void ResetScreen(bool selectNext) { }

	public void ResetTowerXpToSpend() { }

	public UpgradeDetails ResetUpgradeUnlocks(UpgradeDetails[] upgrades, UpgradeDetails upgradeToSelect) { }

	public void SelectUpgrade(UpgradeDetails details, bool showSelected = true) { }

	private void SetIapButtons(string towerId) { }

	private void SetUpParagonPath() { }

	private void SetUpPaths() { }

	public bool ShowParagonPanel() { }

	public void ShowPopup(string msg, Vector2 pos, int tier) { }

	public void ShowPurchaseParagon() { }

	public void ShowPurchaseUpgrades() { }

	private void SwitchTower(bool nextTower) { }

	public void UnlockAll() { }

	public void UpdateParagonToggleUi() { }

	private void UpdatePortraitBackground() { }

	public void UpdateUi(string towerId, string initialSelectedUpgrade = "") { }

	public void UpdateUpgradeIcons() { }

}

