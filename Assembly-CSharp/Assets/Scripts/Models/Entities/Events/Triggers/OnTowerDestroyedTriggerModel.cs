namespace Assets.Scripts.Models.Entities.Events.Triggers;

[Implementation(typeof(OnTowerDestroyedTrigger), False, False, new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {}])]
public class OnTowerDestroyedTriggerModel : EntityTriggerModel
{
	public String[] towerIds; //Field offset: 0x38

	public OnTowerDestroyedTriggerModel(string name, String[] towerIds) { }

	public virtual Model Clone() { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

}

