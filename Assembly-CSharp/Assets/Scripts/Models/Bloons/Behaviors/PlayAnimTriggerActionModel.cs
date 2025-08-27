namespace Assets.Scripts.Models.Bloons.Behaviors;

[Implementation(typeof(PlayAnimTriggerAction), False, False, new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {}])]
public class PlayAnimTriggerActionModel : BloonBehaviorActionModel
{
	public string triggerName; //Field offset: 0x38
	public float pauseMovementDuration; //Field offset: 0x40

	public PlayAnimTriggerActionModel() { }

	public PlayAnimTriggerActionModel(string name, string actionId, string triggerName, float pauseMovementDuration) { }

	public virtual Model Clone() { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

}

