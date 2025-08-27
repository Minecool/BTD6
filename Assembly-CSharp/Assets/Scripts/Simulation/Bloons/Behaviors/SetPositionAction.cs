namespace Assets.Scripts.Simulation.Bloons.Behaviors;

public class SetPositionAction : BloonBehaviorAction
{
	public SetPositionActionModel setPosActionModel; //Field offset: 0x78

	public SetPositionAction() { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	public virtual void PerformAction() { }

	private void Process(int elasped) { }

	public virtual void UpdatedModel(Model modelToUse) { }

}

