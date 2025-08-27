namespace Assets.Scripts.Models.Towers.Behaviors.Abilities.Behaviors;

[Implementation(typeof(Deploy), False, False, new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {}])]
public class DeployModel : AbilityBehaviorModel
{
	public SoundModel activateSound; //Field offset: 0x30
	public SoundModel dropOffSound; //Field offset: 0x38

	public DeployModel(string name, SoundModel activateSound, SoundModel dropOffSound) { }

	public virtual Model Clone() { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

}

