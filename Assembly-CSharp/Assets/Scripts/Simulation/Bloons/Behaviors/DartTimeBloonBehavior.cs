namespace Assets.Scripts.Simulation.Bloons.Behaviors;

public class DartTimeBloonBehavior : BloonBehavior
{
	public DartTimeBloonBehaviorModel dartTimeBloonBehaviorModel; //Field offset: 0x70

	public DartTimeBloonBehavior() { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	protected virtual void OnDestroy() { }

	public virtual void UpdatedModel(Model modelToUse) { }

}

