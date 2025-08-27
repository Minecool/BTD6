namespace Assets.Scripts.Simulation.Towers.Behaviors;

public class SavedSubTower : TowerBehavior
{
	public SavedSubTowerModel savedSubTowerModel; //Field offset: 0x68

	public SavedSubTower() { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	public virtual void UpdatedModel(Model modelToUse) { }

}

