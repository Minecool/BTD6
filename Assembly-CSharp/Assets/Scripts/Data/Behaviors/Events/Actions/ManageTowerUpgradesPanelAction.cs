namespace Assets.Scripts.Data.Behaviors.Events.Actions;

public class ManageTowerUpgradesPanelAction : EntityAction
{
	[SerializeField]
	public ToggleModdifier lockTowerUpgrades; //Field offset: 0x28
	[SerializeField]
	public ToggleModdifier lockTowerPurchases; //Field offset: 0x2C
	[SerializeField]
	public ToggleModdifier lockHeroPurchases; //Field offset: 0x30
	[SerializeField]
	public ToggleModdifier toggleGlowUpgradePath1; //Field offset: 0x34
	[SerializeField]
	public ToggleModdifier toggleGlowUpgradePath2; //Field offset: 0x38
	[SerializeField]
	public ToggleModdifier toggleGlowUpgradePath3; //Field offset: 0x3C

	public virtual Model Model
	{
		 get { } //Length: 171
	}

	public ManageTowerUpgradesPanelAction() { }

	public virtual Model get_Model() { }

}

