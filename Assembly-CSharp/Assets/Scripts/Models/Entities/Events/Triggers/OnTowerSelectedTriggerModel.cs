namespace Assets.Scripts.Models.Entities.Events.Triggers;

[Implementation(typeof(OnTowerSelectedTrigger), False, False, new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {}])]
public class OnTowerSelectedTriggerModel : EntityTriggerModel
{
	public String[] towerIds; //Field offset: 0x38

	public OnTowerSelectedTriggerModel(string name, String[] towerIds) { }

	public virtual Model Clone() { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

}

