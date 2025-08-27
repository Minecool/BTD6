namespace Assets.Scripts.Simulation.Bloons.Behaviors;

public class PauseTimeTriggerAction : BloonBehaviorAction
{
	public PauseTimeTriggerActionModel pauseTimeTriggerActionModel; //Field offset: 0x78

	public PauseTimeTriggerAction() { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	public virtual void PerformAction() { }

	public virtual void UpdatedModel(Model modelToUse) { }

}

