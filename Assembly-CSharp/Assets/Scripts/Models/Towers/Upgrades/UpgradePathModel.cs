namespace Assets.Scripts.Models.Towers.Upgrades;

public class UpgradePathModel : Model
{
	public string tower; //Field offset: 0x30
	public string upgrade; //Field offset: 0x38

	public UpgradePathModel(string upgrade, string tower) { }

	public virtual Model Clone() { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

}

