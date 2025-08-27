namespace Assets.Scripts.Simulation.Bloons.Behaviors;

public class MutationImunity : BloonBehavior
{
	public MutationImunityDef mutationImunityDef; //Field offset: 0x70

	public MutationImunity() { }

	public virtual bool FilterMutation(BehaviorMutator mutation, ICollection<BehaviorMutatorFilter> filters) { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	public virtual void UpdatedModel(Model modelToUse) { }

}

