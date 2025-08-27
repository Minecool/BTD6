namespace Assets.Scripts.Models.Towers.Behaviors;

[Implementation(typeof(CreateSoundOnAttached), False, False, new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {}])]
public class CreateSoundOnAttachedModel : TowerBehaviorModel
{
	public SoundModel sound; //Field offset: 0x30
	public SoundModel altSound; //Field offset: 0x38

	public CreateSoundOnAttachedModel(string name, SoundModel sound, SoundModel altSound) { }

	public virtual Model Clone() { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

}

