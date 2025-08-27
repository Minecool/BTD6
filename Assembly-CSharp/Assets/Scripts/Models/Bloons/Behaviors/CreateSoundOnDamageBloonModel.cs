namespace Assets.Scripts.Models.Bloons.Behaviors;

[Implementation(typeof(CreateSoundOnDamageBloon), False, False, new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {}])]
public class CreateSoundOnDamageBloonModel : BloonBehaviorModel
{
	public AudioClipReference[] sounds; //Field offset: 0x30

	public CreateSoundOnDamageBloonModel() { }

	public CreateSoundOnDamageBloonModel(string name, AudioClipReference[] sounds) { }

	public virtual Model Clone() { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

}

