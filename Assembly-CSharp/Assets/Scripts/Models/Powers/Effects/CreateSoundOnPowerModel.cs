namespace Assets.Scripts.Models.Powers.Effects;

[Implementation(typeof(CreateSoundOnPower), False, False, new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {}])]
public class CreateSoundOnPowerModel : PowerBehaviorModel
{
	public SoundModel sound; //Field offset: 0x30

	public CreateSoundOnPowerModel(string name, SoundModel sound) { }

	public virtual Model Clone() { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

}

