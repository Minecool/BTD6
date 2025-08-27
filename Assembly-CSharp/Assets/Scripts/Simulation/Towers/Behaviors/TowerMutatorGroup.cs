namespace Assets.Scripts.Simulation.Towers.Behaviors;

public class TowerMutatorGroup : TowerBehavior
{
	public TowerMutatorGroupModel towerMutatorGroupModel; //Field offset: 0x68
	protected List<RootBehavior> mutators; //Field offset: 0x70
	protected bool addMutators; //Field offset: 0x78
	private List<RootBehavior> createdBehaviors; //Field offset: 0x80

	public TowerMutatorGroup() { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	protected virtual void OnDestroy() { }

	public virtual void UpdatedModel(Model modelToUse) { }

}

