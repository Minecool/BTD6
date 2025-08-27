namespace Assets.Scripts.Unity.Behaviors.Events.Actions;

public class ManageTowerUpgradesPanelAction : HudModifier
{
	public ToggleModdifier lockTowerUpgrades; //Field offset: 0x18
	public ToggleModdifier lockTowerPurchases; //Field offset: 0x1C
	public ToggleModdifier lockHeroPurchases; //Field offset: 0x20
	public ToggleModdifier toggleGlowUpgradePath1; //Field offset: 0x24
	public ToggleModdifier toggleGlowUpgradePath2; //Field offset: 0x28
	public ToggleModdifier toggleGlowUpgradePath3; //Field offset: 0x2C

	public virtual Model Model
	{
		 get { } //Length: 171
	}

	public virtual string Type
	{
		 get { } //Length: 44
	}

	public ManageTowerUpgradesPanelAction() { }

	public virtual Model get_Model() { }

	public virtual string get_Type() { }

}

