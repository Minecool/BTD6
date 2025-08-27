namespace Assets.Scripts.Simulation.Map.Actions;

public class SellRemoveableAction : MapAction
{
	public string removeableName; //Field offset: 0x60

	public SellRemoveableAction() { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	public virtual void PerformAction() { }

}

