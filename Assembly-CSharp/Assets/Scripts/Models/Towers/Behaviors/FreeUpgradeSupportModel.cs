namespace Assets.Scripts.Models.Towers.Behaviors;

[Implementation(typeof(FreeUpgradeSupport), True, False, new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {}])]
public class FreeUpgradeSupportModel : SupportModel
{
	public string mutatorId; //Field offset: 0x60
	public int upgrade; //Field offset: 0x68

	public FreeUpgradeSupportModel(string name, int upgrade, string mutatorId, TowerFilterModel[] filters) { }

	public virtual Model Clone() { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

}

