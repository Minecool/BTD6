namespace Assets.Scripts.Simulation.Map.Actions;

public class RemovableActiveAction : MapAction
{
	public bool setActiveToo; //Field offset: 0x60
	public string removeableName; //Field offset: 0x68

	public RemovableActiveAction() { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	public virtual void PerformAction() { }

}

