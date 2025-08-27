namespace Assets.Scripts.Unity.UI_New.InGame.TowerSelectionMenu;

public class PowerProUpgradeButton : UpgradeButton
{
	public GameObject maxUpgradesObject; //Field offset: 0x1C8
	public NK_TextMeshProUGUI earnXpText; //Field offset: 0x1D0

	public PowerProUpgradeButton() { }

	public virtual UpgradeStatus GetUpgradeStatus(int path, bool upgradeClicked = false) { }

	protected virtual bool HasUnlockedUpgrade() { }

	public virtual void UpdateVisuals(int path, int tier, bool upgradeClicked) { }

}

