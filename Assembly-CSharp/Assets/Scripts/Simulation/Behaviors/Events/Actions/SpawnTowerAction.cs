namespace Assets.Scripts.Simulation.Behaviors.Events.Actions;

public class SpawnTowerAction : EntityAction
{
	public SpawnTowerActionModel spawnTowerActionModel; //Field offset: 0x68

	public SpawnTowerAction() { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	public virtual void PerformAction() { }

	public virtual void UpdatedModel(Model modelToUse) { }

}

