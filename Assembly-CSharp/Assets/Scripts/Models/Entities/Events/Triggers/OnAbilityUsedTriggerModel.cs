namespace Assets.Scripts.Models.Entities.Events.Triggers;

[Implementation(typeof(OnAbilityUsedTrigger), False, False, new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {}])]
public class OnAbilityUsedTriggerModel : EntityTriggerModel
{
	public String[] towerIds; //Field offset: 0x38
	public String[] abilityIds; //Field offset: 0x40

	public OnAbilityUsedTriggerModel(string name, String[] towerIds, String[] abilityIds) { }

	public virtual Model Clone() { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

}

