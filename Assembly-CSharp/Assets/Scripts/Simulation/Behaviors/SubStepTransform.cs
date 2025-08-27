namespace Assets.Scripts.Simulation.Behaviors;

public class SubStepTransform : RootBehavior
{
	public readonly Vector3Boxed position; //Field offset: 0x58
	public readonly FloatBoxed rotation; //Field offset: 0x60

	public SubStepTransform() { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	public void Process(int elapsed) { }

}

