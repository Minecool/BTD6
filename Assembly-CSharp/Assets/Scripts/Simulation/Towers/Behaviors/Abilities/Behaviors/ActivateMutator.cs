namespace Assets.Scripts.Simulation.Towers.Behaviors.Abilities.Behaviors;

public class ActivateMutator : AbilityBehavior
{
	public ActivateMutatorModel activateMutatorModel; //Field offset: 0x68

	public ActivateMutator() { }

	public virtual void Activate() { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	public virtual void UpdatedModel(Model modelToUse) { }

}

