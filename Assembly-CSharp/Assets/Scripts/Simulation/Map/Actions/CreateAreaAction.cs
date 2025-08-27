namespace Assets.Scripts.Simulation.Map.Actions;

public class CreateAreaAction : MapAction
{
	public string areaName; //Field offset: 0x60

	public CreateAreaAction() { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	public virtual void PerformAction() { }

}

