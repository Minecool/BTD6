namespace Assets.Scripts.Models.Entities.Events.Triggers;

[Implementation(typeof(OnTowerAbilitiesChangedTrigger), False, False, new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {}])]
public class OnTowerAbilitiesChangedTriggerModel : EntityTriggerModel
{
	public String[] towerIds; //Field offset: 0x38

	public OnTowerAbilitiesChangedTriggerModel(string name, String[] towerIds) { }

	public virtual Model Clone() { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

}

