namespace Assets.Scripts.Simulation.Towers.Behaviors.Abilities.Behaviors;

public class MutateDamageOnAbility : AbilityBehavior
{
	public MutateDamageOnAbilityModel modl; //Field offset: 0x68

	public MutateDamageOnAbility() { }

	public virtual void Activate() { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	protected virtual void OnDestroy() { }

	public virtual void UpdatedModel(Model modelToUse) { }

}

