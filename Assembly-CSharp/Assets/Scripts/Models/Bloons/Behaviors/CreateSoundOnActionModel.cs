namespace Assets.Scripts.Models.Bloons.Behaviors;

[Implementation(typeof(CreateSoundOnAction), False, False, new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {}])]
public class CreateSoundOnActionModel : BloonBehaviorActionModel
{
	public AudioClipReference[] sounds; //Field offset: 0x38
	public float delay; //Field offset: 0x40

	public CreateSoundOnActionModel() { }

	public CreateSoundOnActionModel(string name, string actionId, AudioClipReference[] sounds, float delay) { }

	public virtual Model Clone() { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

}

