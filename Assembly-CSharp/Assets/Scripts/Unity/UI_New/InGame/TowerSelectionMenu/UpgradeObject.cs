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
	private TowerToSimulation tts; //Field offset: 0x58
	private int path; //Field offset: 0x60
	private int tier; //Field offset: 0x64

	public UpgradeObject() { }

	private void Awake() { }

	private int CheckBlockedPath() { }

	public void CheckCash() { }

	private void CheckLocked() { }

	private int CheckRestrictedPath() { }

	public void CheckXP() { }

	public bool ConfirmCanUpgrade() { }

	public void DeInit() { }

	public int GetTier() { }

	private UpgradeModel GetUpgrade(TowerModel tm, UnityToSimulation bridge) { }

	public void IncreaseTier() { }

	public void InitForTower(int path, TowerToSimulation tts) { }

	public void LoadUpgrades() { }

	public void OnBeastHandlerMerge() { }

	public void OnUpgrade() { }

	public void PostSimUpgrade() { }

	public void SetTier(int tier, int maxTier, int maxTierRestricted) { }

	public void SetTier(int value) { }

	public void UpdateCost() { }

	public void UpdateSpecialButtons(int path, TowerToSimulation tts) { }

	public void UpdateVisuals(int path, bool upgradeClicked) { }

	public void WobbleUpgrade() { }

}

