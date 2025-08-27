namespace Assets.Scripts.Simulation.Towers.Behaviors;

public class TowerRadius : TowerBehavior
{
	public TowerRadiusModel towerRadiusModel; //Field offset: 0x68
	public float range; //Field offset: 0x70

	public TowerRadius() { }

	public void FirstUpdate(int elapsed) { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	public virtual void UpdatedModel(Model modelToUse) { }

}

