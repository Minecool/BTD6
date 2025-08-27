namespace Assets.Scripts.Models.Towers.Behaviors;

[Implementation(typeof(CreateSoundOnBloonDestroyed), False, False, new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {}])]
public class CreateSoundOnBloonDestroyedModel : TowerBehaviorModel
{
	public SoundModel sound1; //Field offset: 0x30
	public SoundModel sound2; //Field offset: 0x38
	public string tag; //Field offset: 0x40

	public CreateSoundOnBloonDestroyedModel(string name, SoundModel sound1, SoundModel sound2, string tag) { }

	public virtual Model Clone() { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

}

