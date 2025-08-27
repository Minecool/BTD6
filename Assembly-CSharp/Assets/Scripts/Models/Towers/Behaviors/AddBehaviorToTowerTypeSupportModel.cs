namespace Assets.Scripts.Models.Towers.Behaviors;

[Implementation(typeof(AddBehaviorToTowerTypeSupport), True, False, new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {}])]
public class AddBehaviorToTowerTypeSupportModel : AddBehaviorToTowerSupportModel
{
	public string towerTypeIds; //Field offset: 0x70

	public AddBehaviorToTowerTypeSupportModel(string name, TowerBehaviorModel[] behaviors, string mutationId, TowerFilterModel[] filters, string buffLocsName, string buffIconName, string towerTypeIds) { }

	public virtual Model Clone() { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

}

