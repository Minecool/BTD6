namespace Assets.Scripts.Models.SimulationBehaviors;

[Implementation(typeof(TriggerGameModeBehaviors), False, False, new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {}])]
public class TriggerGameModeBehaviorsModel : SimulationBehaviorModel
{
	public bool triggerInfinitHealthMode; //Field offset: 0x30
	public bool triggerInfinitRoundsMode; //Field offset: 0x31
	public bool showCurrentRoundNum; //Field offset: 0x32

	public TriggerGameModeBehaviorsModel(bool triggerInfinitHealthMode, bool triggerInfinitRoundsMode, bool showCurrentRoundNum) { }

	public virtual Model Clone() { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

}

