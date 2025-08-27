namespace Assets.Scripts.Unity.Towers.Upgrades;

[ExecuteInEditMode]
public class PowerProUpgradePath : UpgradePath
{

	public PowerProUpgradePath() { }

	public virtual Upgradeable GetSolid() { }

	public Tower GetSolidTower() { }

	public virtual MonoBehaviour GetUpgrade() { }

}

