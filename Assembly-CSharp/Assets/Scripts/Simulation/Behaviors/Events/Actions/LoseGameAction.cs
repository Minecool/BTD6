namespace Assets.Scripts.Simulation.Behaviors.Events.Actions;

public class LoseGameAction : EntityAction
{
	public LoseGameActionModel loseGameActionModel; //Field offset: 0x68

	public LoseGameAction() { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	public virtual void PerformAction() { }

	public virtual void UpdatedModel(Model modelToUse) { }

}

