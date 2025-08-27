namespace Assets.Scripts.Simulation.Behaviors.Events.Actions;

public class GainLivesAction : EntityAction
{
	public GainLivesActionModel gainLivesActionModel; //Field offset: 0x68

	public GainLivesAction() { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	public virtual void PerformAction() { }

	public virtual void UpdatedModel(Model modelToUse) { }

}

