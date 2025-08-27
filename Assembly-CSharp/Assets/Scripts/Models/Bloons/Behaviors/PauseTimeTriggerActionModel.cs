namespace Assets.Scripts.Models.Bloons.Behaviors;

[Implementation(typeof(PauseTimeTriggerAction), False, False, new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {}])]
public class PauseTimeTriggerActionModel : BloonBehaviorModel
{
	public string triggerName; //Field offset: 0x30
	public bool setPaused; //Field offset: 0x38

	public PauseTimeTriggerActionModel() { }

	public PauseTimeTriggerActionModel(string name, string triggerName, bool setPaused) { }

	public virtual Model Clone() { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

}

