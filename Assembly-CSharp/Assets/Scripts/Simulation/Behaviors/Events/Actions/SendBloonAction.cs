namespace Assets.Scripts.Simulation.Behaviors.Events.Actions;

public class SendBloonAction : EntityAction
{
	public SendBloonActionModel sendBloonActionModel; //Field offset: 0x68
	private BloonModel bloonModel; //Field offset: 0x70

	public SendBloonAction() { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	public virtual void PerformAction() { }

	private void UpdateBloonModel() { }

	public virtual void UpdatedModel(Model modelToUse) { }

}

