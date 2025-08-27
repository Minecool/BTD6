namespace Assets.Scripts.Models.Bloons.Behaviors;

[Implementation(typeof(CreateSoundOnBreakArmour), False, False, new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {}])]
public class CreateSoundOnBreakArmourModel : BloonBehaviorModel
{
	public AudioClipReference[] sounds; //Field offset: 0x30

	public CreateSoundOnBreakArmourModel() { }

	public CreateSoundOnBreakArmourModel(string name, AudioClipReference[] sounds) { }

	public virtual Model Clone() { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

}

