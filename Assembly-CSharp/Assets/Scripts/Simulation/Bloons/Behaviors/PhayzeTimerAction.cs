namespace Assets.Scripts.Simulation.Bloons.Behaviors;

public class PhayzeTimerAction : BloonBehaviorAction
{
	public PhayzeTimerActionModel phayzeTimerActionModel; //Field offset: 0x78

	public PhayzeTimerAction() { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	protected virtual void OnDestroy() { }

	public virtual void PerformAction() { }

	public virtual void UpdatedModel(Model modelToUse) { }

}

