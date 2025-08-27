namespace Assets.Scripts.Models.Towers.Pets;

[Implementation(typeof(PetCreateSoundOnIdle), False, False, new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {}])]
public class PetCreateSoundOnIdleModel : PetBehaviorModel
{
	public AudioClipReference sound1Id; //Field offset: 0x30
	public AudioClipReference sound2Id; //Field offset: 0x38
	public AudioClipReference sound3Id; //Field offset: 0x40
	public AudioClipReference sound4Id; //Field offset: 0x48
	public int idleMin; //Field offset: 0x50
	public int idleMax; //Field offset: 0x54

	public PetCreateSoundOnIdleModel(string name, AudioClipReference sound1Id, AudioClipReference sound2Id, AudioClipReference sound3Id, AudioClipReference sound4Id, int idleMin, int idleMax) { }

	public virtual Model Clone() { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

}

