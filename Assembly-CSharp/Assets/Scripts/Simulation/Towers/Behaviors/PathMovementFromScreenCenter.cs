namespace Assets.Scripts.Simulation.Towers.Behaviors;

public class PathMovementFromScreenCenter : TowerBehavior
{
	public PathMovementFromScreenCenterModel pathMovementFromScreenCenterModel; //Field offset: 0x68
	private int pathIndex; //Field offset: 0x70
	private string prevTargetId; //Field offset: 0x78

	public PathMovementFromScreenCenter() { }

	private int GetClosestPathIndex(Vector2[] path) { }

	public int GetPathIndex() { }

	public string GetPrevTargetID() { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	public void Process(int elapsed) { }

	public void SetCircleStartPosition(int index, string id) { }

	public virtual void UpdatedModel(Model modelToUse) { }

}

