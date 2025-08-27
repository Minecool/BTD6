namespace Assets.Scripts.Simulation.Behaviors.Events.Actions;

public class LoseLivesAction : EntityAction
{
	public LoseLivesActionModel loseLivesActionModel; //Field offset: 0x68

	public LoseLivesAction() { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	public virtual void PerformAction() { }

	public virtual void UpdatedModel(Model modelToUse) { }

}

