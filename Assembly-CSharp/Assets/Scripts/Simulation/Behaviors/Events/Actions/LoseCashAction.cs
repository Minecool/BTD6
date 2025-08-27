namespace Assets.Scripts.Simulation.Behaviors.Events.Actions;

public class LoseCashAction : EntityAction
{
	public LoseCashActionModel loseCashActionModel; //Field offset: 0x68

	public LoseCashAction() { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	public virtual void PerformAction() { }

	public virtual void UpdatedModel(Model modelToUse) { }

}

