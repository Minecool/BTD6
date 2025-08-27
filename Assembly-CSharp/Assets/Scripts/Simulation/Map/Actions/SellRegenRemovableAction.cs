namespace Assets.Scripts.Simulation.Map.Actions;

public class SellRegenRemovableAction : MapAction
{
	public string regenRemovableName; //Field offset: 0x60

	public SellRegenRemovableAction() { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	public virtual void PerformAction() { }

}

