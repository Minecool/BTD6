namespace Assets.Scripts.Models.Entities.Events.Triggers;

[Implementation(typeof(OnTowerTargetTypeChangedTrigger), False, False, new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {}])]
public class OnTowerTargetTypeChangedTriggerModel : EntityTriggerModel
{
	public String[] towerIds; //Field offset: 0x38
	public TargetType targetType; //Field offset: 0x40

	public OnTowerTargetTypeChangedTriggerModel(string name, String[] towerIds, TargetType targetType) { }

	public virtual Model Clone() { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

}

