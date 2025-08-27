namespace Assets.Scripts.Simulation.Towers.Behaviors;

public class UseParentVisibility : TowerBehavior
{
	public UseParentVisibilityModel useParentVisibilityModel; //Field offset: 0x68
	private Tower parentTower; //Field offset: 0x70

	public UseParentVisibility() { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	private void Process(int elapsed) { }

	public virtual void UpdatedModel(Model modelToUse) { }

}

