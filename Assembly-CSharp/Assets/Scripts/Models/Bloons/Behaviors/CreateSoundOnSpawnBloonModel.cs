namespace Assets.Scripts.Models.Bloons.Behaviors;

[Implementation(typeof(CreateSoundOnSpawnBloon), False, False, new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {}])]
public class CreateSoundOnSpawnBloonModel : BloonBehaviorModel
{
	public AudioClipReference sound; //Field offset: 0x30

	public CreateSoundOnSpawnBloonModel() { }

	public CreateSoundOnSpawnBloonModel(string name, AudioClipReference sound) { }

	public virtual Model Clone() { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

}

