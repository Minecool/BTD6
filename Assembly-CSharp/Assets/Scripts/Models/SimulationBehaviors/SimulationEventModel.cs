namespace Assets.Scripts.Models.SimulationBehaviors;

[Implementation(typeof(EntityEvent), False, False, new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {}])]
public class SimulationEventModel : SimulationBehaviorModel
{
	public int entityEventIndex; //Field offset: 0x30
	public bool requiresAllTriggers; //Field offset: 0x34
	public int maxActivationLimit; //Field offset: 0x38

	public SimulationEventModel(int entityEventIndex, bool requiresAllTriggers, int maxActivationLimit) { }

	public virtual Model Clone() { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

}

