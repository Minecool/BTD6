namespace Assets.Scripts.Simulation.Map.Actions;

public class PathActiveAction : MapAction
{
	public bool setActiveToo; //Field offset: 0x60
	public string pathName; //Field offset: 0x68

	public PathActiveAction() { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	public virtual void PerformAction() { }

}

