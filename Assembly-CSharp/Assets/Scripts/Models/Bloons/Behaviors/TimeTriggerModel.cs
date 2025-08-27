namespace Assets.Scripts.Models.Bloons.Behaviors;

[Implementation(typeof(TimeTrigger), False, False, new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {}])]
public class TimeTriggerModel : BloonBehaviorTriggerModel
{
	public float interval; //Field offset: 0x30
	public bool triggerImmediately; //Field offset: 0x34
	public String[] actionIds; //Field offset: 0x38

	public TimeTriggerModel(string name) { }

	public TimeTriggerModel(string name, float interval, bool triggerImmediately, String[] actionIds) { }

	public virtual Model Clone() { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

}

