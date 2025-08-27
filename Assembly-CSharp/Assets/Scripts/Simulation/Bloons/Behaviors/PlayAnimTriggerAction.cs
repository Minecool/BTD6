namespace Assets.Scripts.Simulation.Bloons.Behaviors;

public class PlayAnimTriggerAction : BloonBehaviorAction
{
	public PlayAnimTriggerActionModel modl; //Field offset: 0x78

	public PlayAnimTriggerAction() { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	public virtual void PerformAction() { }

	public virtual void UpdatedModel(Model modelToUse) { }

}

