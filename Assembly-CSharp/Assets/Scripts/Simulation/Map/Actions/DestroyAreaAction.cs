namespace Assets.Scripts.Simulation.Map.Actions;

public class DestroyAreaAction : MapAction
{
	public string areaName; //Field offset: 0x60

	public DestroyAreaAction() { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	public virtual void PerformAction() { }

}

