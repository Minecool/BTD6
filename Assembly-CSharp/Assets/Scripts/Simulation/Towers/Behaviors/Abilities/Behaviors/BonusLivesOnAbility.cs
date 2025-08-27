namespace Assets.Scripts.Simulation.Towers.Behaviors.Abilities.Behaviors;

public class BonusLivesOnAbility : AbilityBehavior
{
	public BonusLivesOnAbilityModel bonusLivesOnAbilityModel; //Field offset: 0x68

	public BonusLivesOnAbility() { }

	public virtual void Activate() { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	public virtual void UpdatedModel(Model modelToUse) { }

}

