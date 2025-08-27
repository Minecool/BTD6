namespace Assets.Scripts.Unity.UI_New.Store;

public class TowerProductButton : BaseProductButton
{
	private string tower; //Field offset: 0x70
	private UpgradeScreen upgradeScreen; //Field offset: 0x78
	private PurchaseTowerUnlockType unlockType; //Field offset: 0x80
	private bool allUpgardesAndParagon; //Field offset: 0x84

	public TowerProductButton() { }

	private bool AllUpgradesUnlocked() { }

	public void Bind(string productID, string tower, UpgradeScreen upgradeScreen, PurchaseTowerUnlockType unlockType) { }

	private bool ButtonDisableChecker() { }

	private bool IsParagonUnlocked(string towerId) { }

	public virtual void OnPurchaseComplete() { }

	public void OnPurchaseFailed() { }

	public virtual void StartPurchase() { }

	private bool TowerHasParagonUpgrade(string towerId) { }

}

