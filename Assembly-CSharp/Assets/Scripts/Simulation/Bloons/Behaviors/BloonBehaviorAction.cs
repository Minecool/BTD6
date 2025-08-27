namespace Assets.Scripts.Simulation.Bloons.Behaviors;

public class BloonBehaviorAction : BloonBehavior
{
	public BloonBehaviorActionModel bbaModel; //Field offset: 0x70

	public BloonBehaviorAction() { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	public override void PerformAction() { }

	public virtual void UpdatedModel(Model modelToUse) { }

}

