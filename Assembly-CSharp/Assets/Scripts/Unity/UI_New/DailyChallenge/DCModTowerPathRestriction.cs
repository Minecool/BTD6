namespace Assets.Scripts.Unity.UI_New.DailyChallenge;

public class DCModTowerPathRestriction : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Action<GameObject> <>9__28_1; //Field offset: 0x8

		private static <>c() { }

		public <>c() { }

		internal void <GamepadSetup>b__28_1(GameObject x) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass34_0
	{
		public Slider slider; //Field offset: 0x10

		public <>c__DisplayClass34_0() { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass34_1
	{
		public DCRestrictionUpgradeDisplay upgradeDisplay; //Field offset: 0x10
		public <>c__DisplayClass34_0 CS$<>8__locals1; //Field offset: 0x18

		public <>c__DisplayClass34_1() { }

		internal void <SetupUI>b__0() { }

		internal void <SetupUI>b__1() { }

		internal void <SetupUI>b__2() { }

		internal void <SetupUI>b__3() { }

		internal void <SetupUI>b__4() { }

	}

	public const int VALUE_0 = 0; //Field offset: 0x0
	public const int VALUE_1 = 1; //Field offset: 0x0
	public const int VALUE_2 = 2; //Field offset: 0x0
	public const int VALUE_3 = 3; //Field offset: 0x0
	public const int VALUE_4 = 4; //Field offset: 0x0
	private int lastValueSlider1; //Field offset: 0x20
	private int lastValueSlider2; //Field offset: 0x24
	private int lastValueSlider3; //Field offset: 0x28
	public NK_TextMeshProUGUI towerName; //Field offset: 0x30
	public NK_TextMeshProUGUI towerUpgrades; //Field offset: 0x38
	public Slider path1; //Field offset: 0x40
	public Slider path2; //Field offset: 0x48
	public Slider path3; //Field offset: 0x50
	public GameObject[] path1Upgrades; //Field offset: 0x58
	public GameObject[] path2Upgrades; //Field offset: 0x60
	public GameObject[] path3Upgrades; //Field offset: 0x68
	public GameObject paragonContainer; //Field offset: 0x70
	public Lightbox bckgroundBackBtn; //Field offset: 0x78
	public Button applyAllBtn; //Field offset: 0x80
	public Button resetAllBtn; //Field offset: 0x88
	public Transform towersList; //Field offset: 0x90
	public GameObject towerPrefab; //Field offset: 0x98
	public GameObject heroPrefab; //Field offset: 0xA0
	public DCModTowerDisplayRestriction selectedTower; //Field offset: 0xA8
	private TowerContainer towerContainer; //Field offset: 0xB0
	private DCModTowerDisplay[] towsToDisplay; //Field offset: 0xB8
	public Button toggleSelectEditBtn; //Field offset: 0xC0
	private DCModTowerDisplayRestriction[] towerDisplayList; //Field offset: 0xC8

	public DCModTowerPathRestriction() { }

	[CompilerGenerated]
	private void <GamepadSetup>b__28_0() { }

	[CompilerGenerated]
	private GameObject <GamepadSetup>b__28_2() { }

	private void ApplyAllUpgradesClicked() { }

	private void ApplyAllUpgradesConfirmed() { }

	private void BackgroundClicked() { }

	private int FlipSliderValuesForTierValue(Slider slider) { }

	private void GamepadSetup() { }

	private void InitialiseParagonUI() { }

	private void InitialiseUI(int path, GameObject[] upgrades) { }

	private bool IsParagonRestrictedByLowerTiers() { }

	private void OnDisable() { }

	private void OnEnable() { }

	private void OnParagonRestrictionChanged(bool isRestricted) { }

	private void ResetAllUpgradesClicked() { }

	private void ResetAllUpgradesConfirmed() { }

	private void ResetUpgradesClicked() { }

	private void SetupUI(int path, Slider slider, GameObject[] upgrades) { }

	private void SyncTowerText() { }

	public void TowerClicked(DCModTowerDisplayRestriction towerData) { }

	public void Update() { }

	public void UpdatePathButtons(int path, DCRestrictionUpgradeDisplay display) { }

	private void UpdatePathButtonStates(Slider slider, int path, DCRestrictionUpgradeDisplay display) { }

}

