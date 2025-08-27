namespace Assets.Scripts.Unity.UI_New.InGame.TowerSelectionMenu;

public class UpgradeObject : MonoBehaviour
{
	public int buttonID; //Field offset: 0x20
	public UpgradeButton upgradeButton; //Field offset: 0x28
	public CurrentUpgrade currentUpgrade; //Field offset: 0x30
	public TierObject[] tiers; //Field offset: 0x38
	public GameObject locked; //Field offset: 0x40
	public GameObject restricted; //Field offset: 0x48
	public TowerSelectionMenu towerSelectionMenu; //Field offset: 0x50
	public UpgradeModel currentUpgradeModel; //Field offset: 0x58
	protected TowerToSimulation tts; //Field offset: 0x60
	protected int path; //Field offset: 0x68
	protected int tier; //Field offset: 0x6C

	public bool IsUpgradePathPurchasable
	{
		 get { } //Length: 57
	}

	public bool IsUpgradeUnlocked
	{
		 get { } //Length: 503
	}

	public UpgradeObject() { }

	private void Awake() { }

	protected override int CheckBlockedPath() { }

	public void CheckCash() { }

	protected override void CheckLocked() { }

	protected override int CheckRestrictedPath() { }

	public void CheckXP() { }

	public override bool ConfirmCanUpgrade() { }

	public override void DeInit() { }

	public bool get_IsUpgradePathPurchasable() { }

	public bool get_IsUpgradeUnlocked() { }

	public int GetTier() { }

	protected UpgradeModel GetUpgrade(TowerModel tm, UnityToSimulation bridge) { }

	public void IncreaseTier() { }

	public override void InitForTower(int path, TowerToSimulation tts) { }

	public override void LoadUpgrades() { }

	public void OnBeastHandlerMerge() { }

	public void OnUpgrade() { }

	public void PostSimUpgrade() { }

	public void SetTier(int tier, int maxTier, int maxTierRestricted) { }

	public void SetTier(int value) { }

	public void ToggleGlowHighlight(bool isActive) { }

	public void UpdateCost() { }

	public void UpdateSpecialButtons(int path, TowerToSimulation tts) { }

	public override void UpdateVisuals(int path, bool upgradeClicked) { }

	public void WobbleUpgrade() { }

}

