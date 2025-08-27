namespace Assets.Scripts.Models.Map.Triggers;

[Implementation(typeof(RepeatableTrigger), False, False, new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {}])]
public class RepeatableTriggerModel : MapTriggerModel
{
	public float repeatDelay; //Field offset: 0x38
	public RegenRemovableModel triggeredBy; //Field offset: 0x40
	public readonly int repeatDelayFrames; //Field offset: 0x48

	public RepeatableTriggerModel(string name, float repeatDelay, RegenRemovableModel triggeredBy) { }

	public virtual Model Clone() { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

}

