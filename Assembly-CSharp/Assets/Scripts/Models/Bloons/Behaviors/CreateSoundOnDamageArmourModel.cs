namespace Assets.Scripts.Models.Bloons.Behaviors;

[Implementation(typeof(CreateSoundOnDamageArmour), False, False, new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {}])]
public class CreateSoundOnDamageArmourModel : BloonBehaviorModel
{
	public AudioClipReference[] sounds; //Field offset: 0x30

	public CreateSoundOnDamageArmourModel() { }

	public CreateSoundOnDamageArmourModel(string name, AudioClipReference[] sounds) { }

	public virtual Model Clone() { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

}

