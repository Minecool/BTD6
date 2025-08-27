namespace Assets.Scripts.Simulation.Towers.Behaviors.Attack.Behaviors;

public class PathMovementFromScreenCenterPattern : PathSupplier
{
	public PathMovementFromScreenCenterPatternModel pathMovementFromScreenCenterPatternModel; //Field offset: 0xA0
	private Vector2[] path; //Field offset: 0xA8

	public PathMovementFromScreenCenterPattern() { }

	private Vector2[] BuildPath() { }

	public virtual string GetName() { }

	public virtual Vector2[] GetPath() { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	public virtual void UpdatedModel(Model modelToUse) { }

}

