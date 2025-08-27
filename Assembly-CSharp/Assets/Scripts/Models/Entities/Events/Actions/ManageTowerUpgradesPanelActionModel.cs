namespace Assets.Scripts.Models.Entities.Events.Actions;

[Implementation(typeof(ManageTowerUpgradesPanelAction), False, False, new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {}])]
public class ManageTowerUpgradesPanelActionModel : EntityActionModel
{
	public ToggleModdifier lockTowerUpgrades; //Field offset: 0x38
	public ToggleModdifier lockTowerPurchases; //Field offset: 0x3C
	public ToggleModdifier lockHeroPurchases; //Field offset: 0x40
	public ToggleModdifier toggleGlowUpgradePath1; //Field offset: 0x44
	public ToggleModdifier toggleGlowUpgradePath2; //Field offset: 0x48
	public ToggleModdifier toggleGlowUpgradePath3; //Field offset: 0x4C

	public ManageTowerUpgradesPanelActionModel(string name, ToggleModdifier lockTowerUpgrades, ToggleModdifier lockTowerPurchases, ToggleModdifier lockHeroPurchases, ToggleModdifier toggleGlowUpgradePath1, ToggleModdifier toggleGlowUpgradePath2, ToggleModdifier toggleGlowUpgradePath3) { }

	public virtual Model Clone() { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

}

