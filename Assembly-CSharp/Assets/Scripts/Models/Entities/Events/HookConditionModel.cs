namespace Assets.Scripts.Models.Entities.Events;

[Implementation(typeof(HookCondition), True, False, new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {}])]
public class HookConditionModel : EntityEventModel
{
	public EntityTriggerModel[] eventTriggers; //Field offset: 0x40
	public EntityActionModel[] eventActions; //Field offset: 0x48

	public HookConditionModel(string name, EntityTriggerModel[] eventTriggers, EntityActionModel[] eventActions, int entityEventIndex, bool requiresAllTriggers, int maxActivationLimit) { }

	public virtual Model Clone() { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

}

