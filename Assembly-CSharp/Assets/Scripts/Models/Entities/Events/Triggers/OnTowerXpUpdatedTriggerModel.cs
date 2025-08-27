namespace Assets.Scripts.Models.Entities.Events.Triggers;

[Implementation(typeof(OnTowerXpUpdatedTrigger), False, False, new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {}])]
public class OnTowerXpUpdatedTriggerModel : EntityTriggerModel
{
	public String[] towerIds; //Field offset: 0x38

	public OnTowerXpUpdatedTriggerModel(string name, String[] towerIds) { }

	public virtual Model Clone() { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

}

