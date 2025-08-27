namespace Assets.Scripts.Simulation.Towers.Behaviors;

public class IgnoreAllMutatorsTower : TowerBehavior
{
	public IgnoreAllMutatorsTowerModel ignoreAllMutatorsTowerModel; //Field offset: 0x68

	public IgnoreAllMutatorsTower() { }

	public virtual bool FilterMutation(BehaviorMutator mutation, ICollection<BehaviorMutatorFilter> filters) { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	public virtual void UpdatedModel(Model modelToUse) { }

}

