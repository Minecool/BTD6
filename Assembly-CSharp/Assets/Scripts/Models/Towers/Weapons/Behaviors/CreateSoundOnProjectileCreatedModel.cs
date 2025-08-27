namespace Assets.Scripts.Models.Towers.Weapons.Behaviors;

[Implementation(typeof(CreateSoundOnProjectileCreated), False, False, new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {}])]
public class CreateSoundOnProjectileCreatedModel : WeaponBehaviorModel
{
	public SoundModel sound1; //Field offset: 0x30
	public SoundModel sound2; //Field offset: 0x38
	public SoundModel sound3; //Field offset: 0x40
	public SoundModel sound4; //Field offset: 0x48
	public SoundModel sound5; //Field offset: 0x50
	public string type; //Field offset: 0x58

	public CreateSoundOnProjectileCreatedModel(string name, SoundModel sound1, SoundModel sound2, SoundModel sound3, SoundModel sound4, SoundModel sound5, string type) { }

	public virtual Model Clone() { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

}

