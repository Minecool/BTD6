namespace Assets.Scripts.Models.Towers.Behaviors.Abilities.Behaviors;

[Implementation(typeof(CreateSoundOnAbility), False, False, new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {}])]
public class CreateSoundOnAbilityModel : AbilityBehaviorModel
{
	public SoundModel sound; //Field offset: 0x30
	public SoundModel heroSound; //Field offset: 0x38
	public SoundModel heroSound2; //Field offset: 0x40

	public CreateSoundOnAbilityModel(string name, SoundModel sound, SoundModel heroSound, SoundModel heroSound2) { }

	public virtual Model Clone() { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

}

