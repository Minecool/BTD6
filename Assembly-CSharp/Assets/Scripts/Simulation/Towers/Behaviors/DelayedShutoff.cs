namespace Assets.Scripts.Simulation.Towers.Behaviors;

public class DelayedShutoff : TowerBehavior
{
	public DelayedShutoffModel delayedShutoffModel; //Field offset: 0x68
	private int startedAt; //Field offset: 0x70

	public DelayedShutoff() { }

	public virtual void Attatched() { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	private void Process(int elapsed) { }

	public virtual void UpdatedModel(Model modelToUse) { }

}

