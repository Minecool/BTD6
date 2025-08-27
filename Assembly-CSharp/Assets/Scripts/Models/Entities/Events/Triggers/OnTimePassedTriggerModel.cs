namespace Assets.Scripts.Models.Entities.Events.Triggers;

[Implementation(typeof(OnTimePassedTrigger), False, False, new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {}])]
public class OnTimePassedTriggerModel : EntityTriggerModel
{
	public float time; //Field offset: 0x38
	public int timeFrames; //Field offset: 0x3C
	public bool roundTimeOnly; //Field offset: 0x40
	public bool resetOnTrigger; //Field offset: 0x41
	public bool resetOnRoundStart; //Field offset: 0x42

	public OnTimePassedTriggerModel(string name, float time, bool roundTimeOnly, bool resetOnTrigger, bool resetOnRoundStart) { }

	public virtual Model Clone() { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

}

