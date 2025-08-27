namespace Assets.Scripts.Models.SimulationBehaviors;

[Implementation(typeof(TriggerBehaviorsOnRound), False, False, new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {}])]
public class TriggerBehaviorsOnRoundModel : SimulationBehaviorModel
{
	public Int32[] roundArr; //Field offset: 0x30
	public String[] triggerIdArr; //Field offset: 0x38

	public TriggerBehaviorsOnRoundModel(Int32[] roundArr, String[] triggerIdArr) { }

	public virtual Model Clone() { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

}

