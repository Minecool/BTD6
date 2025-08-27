namespace Assets.Scripts.Models.GeraldoItems;

[Implementation(typeof(GeraldoUpgradeTower), False, False, new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {}])]
public class GeraldoUpgradeTowerModel : GeraldoItemBehaviorModel
{
	public int level; //Field offset: 0x30
	public string towerId; //Field offset: 0x38

	public GeraldoUpgradeTowerModel(string name, int level, string towerId) { }

	public virtual Model Clone() { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

}

