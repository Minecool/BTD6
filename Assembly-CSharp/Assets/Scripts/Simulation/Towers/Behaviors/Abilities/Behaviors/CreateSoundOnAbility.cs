namespace Assets.Scripts.Simulation.Towers.Behaviors.Abilities.Behaviors;

public class CreateSoundOnAbility : AbilityBehavior
{
	public CreateSoundOnAbilityModel createSoundOnAbilityModel; //Field offset: 0x68

	public CreateSoundOnAbility() { }

	public virtual void Activate() { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	private void PlayActivateHeroSound(string groupLimitId, string groupId) { }

	private void PlayActivateSound() { }

	public virtual void UpdatedModel(Model modelToUse) { }

}

