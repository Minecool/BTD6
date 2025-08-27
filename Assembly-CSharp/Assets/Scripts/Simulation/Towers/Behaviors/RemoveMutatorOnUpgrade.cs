namespace Assets.Scripts.Simulation.Towers.Behaviors;

public class RemoveMutatorOnUpgrade : TowerBehavior
{
	public RemoveMutatorOnUpgradeModel removeMutatorOnUpgradeModel; //Field offset: 0x68

	public RemoveMutatorOnUpgrade() { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	public virtual void OnUpgraded(int pathUpgraded) { }

	public virtual void UpdatedModel(Model modelToUse) { }

}

