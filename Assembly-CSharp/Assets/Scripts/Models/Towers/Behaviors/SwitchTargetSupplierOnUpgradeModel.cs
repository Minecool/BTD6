namespace Assets.Scripts.Models.Towers.Behaviors;

[Implementation(typeof(SwitchTargetSupplierOnUpgrade), False, False, new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {}])]
public class SwitchTargetSupplierOnUpgradeModel : TowerBehaviorModel
{
	public string targetSupplierName; //Field offset: 0x30

	public SwitchTargetSupplierOnUpgradeModel(string name, string targetSupplierName) { }

	public virtual Model Clone() { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

}

