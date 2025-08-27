namespace Assets.Scripts.Simulation.Map.Actions;

public class SetRegenRemovableActiveAction : MapAction
{
	public SetRegenRemovableActiveActionModel setRegenActiveModel; //Field offset: 0x60

	public SetRegenRemovableActiveAction() { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	public virtual void PerformAction() { }

	public virtual void UpdatedModel(Model modelToUse) { }

}

