namespace Assets.Scripts.Models.Towers.Behaviors;

[Implementation(typeof(AddBehaviorToTowerSupport), True, False, new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {}])]
public class AddBehaviorToTowerSupportModel : SupportModel
{
	public TowerBehaviorModel[] behaviors; //Field offset: 0x60
	public string mutationId; //Field offset: 0x68

	public AddBehaviorToTowerSupportModel(string name, TowerBehaviorModel[] behaviors, string mutationId, TowerFilterModel[] filters, string buffLocsName, string buffIconName, bool isGlobal) { }

	public virtual Model Clone() { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

}

