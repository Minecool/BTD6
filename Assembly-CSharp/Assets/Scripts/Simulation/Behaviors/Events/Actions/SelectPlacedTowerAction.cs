namespace Assets.Scripts.Simulation.Behaviors.Events.Actions;

public class SelectPlacedTowerAction : EntityAction
{
	public SelectPlacedTowerActionModel behaviorModel; //Field offset: 0x68

	public SelectPlacedTowerAction() { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	public virtual void PerformAction() { }

	public virtual void UpdatedModel(Model modelToUse) { }

}

