namespace Assets.Scripts.Simulation.Towers.Behaviors;

public class SelectParentOnSelected : TowerBehavior
{
	public SelectParentOnSelectedModel selectParentOnSelectedModel; //Field offset: 0x68

	public SelectParentOnSelected() { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	public virtual void UpdatedModel(Model modelToUse) { }

}

