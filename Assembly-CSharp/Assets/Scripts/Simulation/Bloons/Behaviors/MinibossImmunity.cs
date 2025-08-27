namespace Assets.Scripts.Simulation.Bloons.Behaviors;

public class MinibossImmunity : BloonBehavior
{
	private static readonly String[] exclusiveMutatorAllowList; //Field offset: 0x0
	public MinibossImmunityModel minibossImmunityModel; //Field offset: 0x70

	private static MinibossImmunity() { }

	public MinibossImmunity() { }

	public virtual bool FilterMutation(BehaviorMutator mutation, ICollection<BehaviorMutatorFilter> filters) { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	public virtual void UpdatedModel(Model modelToUse) { }

}

