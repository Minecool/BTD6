namespace Assets.Scripts.Models.Towers.Upgrades;

public class PowerProUpgradeModel : UpgradeModel
{

	public PowerProUpgradeModel(string name, int cost, int xpCost, SpriteReference icon, int path, int tier, int locked, string confirmation, string localizedNameOverride) { }

	public virtual Model Clone() { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

}

