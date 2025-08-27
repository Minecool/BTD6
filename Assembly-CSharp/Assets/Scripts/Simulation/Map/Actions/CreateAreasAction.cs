namespace Assets.Scripts.Simulation.Map.Actions;

public class CreateAreasAction : MapAction
{
	public CreateAreasActionModel createAreasActionModel; //Field offset: 0x60

	public CreateAreasAction() { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	public virtual void PerformAction() { }

}

