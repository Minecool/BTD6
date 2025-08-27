namespace Assets.Scripts.Simulation.Behaviors;

public class WrappedMovement : RootBehavior
{
	public WrappedMovementModel wrappedMovementModel; //Field offset: 0x58
	public float t; //Field offset: 0x60

	public WrappedMovement() { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	public void Process(int elapsed) { }

	public virtual void UpdatedModel(Model modelToUse) { }

}

