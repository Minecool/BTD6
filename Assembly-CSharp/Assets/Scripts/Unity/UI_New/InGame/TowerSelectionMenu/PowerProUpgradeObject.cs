namespace Assets.Scripts.Unity.UI_New.InGame.TowerSelectionMenu;

public class PowerProUpgradeObject : UpgradeObject
{
	public GameObject chooseUpgradeObject; //Field offset: 0x70
	public GameObject maxPowerObject; //Field offset: 0x78

	public PowerProUpgradeObject() { }

	protected virtual int CheckBlockedPath() { }

	protected virtual void CheckLocked() { }

	protected virtual int CheckRestrictedPath() { }

	public virtual void LoadUpgrades() { }

}

