namespace Assets.Scripts.Simulation.Towers.Behaviors.Abilities.Behaviors;

public class ActivateAbilitiesOnAbility : AbilityBehavior
{
	public ActivateAbilitiesOnAbilityModel activateAbilitiesOnAbilityModel; //Field offset: 0x68
	private bool isActivatedByOther; //Field offset: 0x70

	public ActivateAbilitiesOnAbility() { }

	public virtual void Activate() { }

	public virtual SpriteReference GetAbilityIcon() { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	public virtual void UpdatedModel(Model modelToUse) { }

}

