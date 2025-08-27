namespace Assets.Scripts.Models.SimulationBehaviors;

[Implementation(typeof(AddEventHook), True, False, new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {}])]
public class AddEventHookModel : SimulationBehaviorModel
{
	public bool requireAllTriggersWithinRound; //Field offset: 0x30
	public string hookId; //Field offset: 0x38
	public bool isAnalyticsDisabled; //Field offset: 0x40
	public HookConditionModel onHookStartCondition; //Field offset: 0x48
	public HookConditionModel[] onHookEndConditions; //Field offset: 0x50

	public AddEventHookModel(string hookId, HookConditionModel onHookStartCondition, HookConditionModel[] onHookEndConditions, bool requireAllTriggersWithinRound, bool isAnalyticsDisabled) { }

	public virtual Model Clone() { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

}

