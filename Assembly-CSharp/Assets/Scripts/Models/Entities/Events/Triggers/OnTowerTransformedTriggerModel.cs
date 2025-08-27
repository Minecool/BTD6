namespace Assets.Scripts.Models.Entities.Events.Triggers;

[Implementation(typeof(OnTowerTransformedTrigger), False, False, new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {}])]
public class OnTowerTransformedTriggerModel : EntityTriggerModel
{
	public String[] towerIds; //Field offset: 0x38

	public OnTowerTransformedTriggerModel(string name, String[] towerIds) { }

	public virtual Model Clone() { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

}

