namespace Assets.Scripts.Simulation.Towers.Behaviors.Abilities.Behaviors;

public class MutateProjectileOnAbility : AbilityBehavior
{
	public MutateProjectileOnAbilityModel mutateProjectileOnAbilityModel; //Field offset: 0x68

	public MutateProjectileOnAbility() { }

	public virtual void Activate() { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	public virtual bool IsActive() { }

	protected virtual void OnDestroy() { }

	public virtual void UpdatedModel(Model modelToUse) { }

}

