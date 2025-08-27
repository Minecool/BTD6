namespace Assets.Scripts.Simulation.Towers.Behaviors;

public class MutationImunityTower : TowerBehavior
{
	public MutationImunityTowerModel mutationImunityTowerModel; //Field offset: 0x68

	public MutationImunityTower() { }

	public virtual bool FilterMutation(BehaviorMutator mutation, ICollection<BehaviorMutatorFilter> filters) { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	public virtual void UpdatedModel(Model modelToUse) { }

}

