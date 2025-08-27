namespace Assets.Scripts.Simulation.Towers.Behaviors;

public class TempleTowerMutatorGroup : TowerMutatorGroup
{
	public TempleTowerMutatorGroupModel templeTowerMutatorGroupModel; //Field offset: 0x88

	public TempleTowerMutatorGroup() { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	public virtual void UpdatedModel(Model modelToUse) { }

}

