namespace Assets.Scripts.Simulation.Towers.Behaviors.Abilities.Behaviors;

public class ZeroRotationOnAbility : AbilityBehavior
{
	public ZeroRotationOnAbilityModel zeroRotationOnAbilityModel; //Field offset: 0x68

	public ZeroRotationOnAbility() { }

	public virtual void Activate() { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	public virtual void UpdatedModel(Model modelToUse) { }

}

