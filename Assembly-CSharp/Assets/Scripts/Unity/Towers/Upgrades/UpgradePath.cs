namespace Assets.Scripts.Unity.Towers.Upgrades;

[ExecuteInEditMode]
public class UpgradePath : UpgradePathGeneric
{
	public Tower tower; //Field offset: 0x38
	public Upgrade upgrade; //Field offset: 0x40

	public UpgradePath() { }

	public virtual Upgradeable GetSolid() { }

	public Tower GetSolidTower() { }

	public virtual MonoBehaviour GetUpgrade() { }

}

