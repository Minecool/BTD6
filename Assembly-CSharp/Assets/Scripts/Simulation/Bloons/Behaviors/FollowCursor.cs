namespace Assets.Scripts.Simulation.Bloons.Behaviors;

public class FollowCursor : RootBehavior
{
	public FollowCursorModel followCursorModel; //Field offset: 0x58
	private Bloon bloon; //Field offset: 0x60

	public FollowCursor() { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	public void Process(int elapsed) { }

	public virtual void UpdatedModel(Model modelToUse) { }

}

