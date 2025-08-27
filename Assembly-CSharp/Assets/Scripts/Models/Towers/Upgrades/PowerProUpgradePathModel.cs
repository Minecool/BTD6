namespace Assets.Scripts.Models.Towers.Upgrades;

public class PowerProUpgradePathModel : UpgradePathModel
{

	public PowerProUpgradePathModel(string upgrade, string tower) { }

	public virtual Model Clone() { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

}

