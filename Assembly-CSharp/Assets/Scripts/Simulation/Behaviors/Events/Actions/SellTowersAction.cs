namespace Assets.Scripts.Simulation.Behaviors.Events.Actions;

public class SellTowersAction : EntityAction
{
	public SellTowersActionModel sellTowersActionModel; //Field offset: 0x68

	public SellTowersAction() { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	public virtual void PerformAction() { }

	public virtual void UpdatedModel(Model modelToUse) { }

}

