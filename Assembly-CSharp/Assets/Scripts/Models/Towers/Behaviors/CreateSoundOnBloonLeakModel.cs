namespace Assets.Scripts.Models.Towers.Behaviors;

[Implementation(typeof(CreateSoundOnBloonLeak), False, False, new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {}])]
public class CreateSoundOnBloonLeakModel : TowerBehaviorModel
{
	public SoundModel sound1; //Field offset: 0x30
	public SoundModel sound2; //Field offset: 0x38

	public CreateSoundOnBloonLeakModel(string name, SoundModel sound1, SoundModel sound2) { }

	public virtual Model Clone() { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

}

