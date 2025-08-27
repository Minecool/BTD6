namespace Assets.Scripts.Simulation.Behaviors.Events.Actions;

public class GainCashAction : EntityAction
{
	public GainCashActionModel gainCashActionModel; //Field offset: 0x68

	public GainCashAction() { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	public virtual void PerformAction() { }

	public virtual void UpdatedModel(Model modelToUse) { }

}

