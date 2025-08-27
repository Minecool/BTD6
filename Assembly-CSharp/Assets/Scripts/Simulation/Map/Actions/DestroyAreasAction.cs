namespace Assets.Scripts.Simulation.Map.Actions;

public class DestroyAreasAction : MapAction
{
	public DestroyAreasActionModel destroyAreasActionModel; //Field offset: 0x60

	public DestroyAreasAction() { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	public virtual void PerformAction() { }

}

