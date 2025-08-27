namespace Assets.Scripts.Simulation.Behaviors;

public class AgeingDestroy : RootBehavior
{
	public AgeingDestroyModel ageingDestroyModel; //Field offset: 0x58
	public int lifespan; //Field offset: 0x60
	public int createdAt; //Field offset: 0x64

	public AgeingDestroy() { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	protected virtual void OnDestroy() { }

	private void Process(int elapsed) { }

}

