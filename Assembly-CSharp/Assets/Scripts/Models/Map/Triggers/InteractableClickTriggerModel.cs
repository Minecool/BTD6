namespace Assets.Scripts.Models.Map.Triggers;

[Implementation(typeof(InteractableClickTrigger), False, False, new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {}])]
public class InteractableClickTriggerModel : MapTriggerModel
{
	public string interactableName; //Field offset: 0x38
	public float cooldownDuration; //Field offset: 0x40
	public int cooldownDurationFrames; //Field offset: 0x44

	public InteractableClickTriggerModel(string name, string interactableName, float cooldownDuration) { }

	public virtual Model Clone() { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

}

