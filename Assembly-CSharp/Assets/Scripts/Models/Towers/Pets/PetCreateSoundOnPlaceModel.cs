namespace Assets.Scripts.Models.Towers.Pets;

[Implementation(typeof(PetCreateSoundOnPlace), False, False, new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {}])]
public class PetCreateSoundOnPlaceModel : PetBehaviorModel
{
	public AudioClipReference soundId; //Field offset: 0x30
	public float delay; //Field offset: 0x38

	public PetCreateSoundOnPlaceModel(string name, AudioClipReference soundId, float delay) { }

	public virtual Model Clone() { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

}

