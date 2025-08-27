namespace Assets.Scripts.Simulation.Towers.Behaviors;

public class DartlingMaintainLastPos : TowerBehavior
{
	public DartlingMaintainLastPosModel dartlingMaintainLastPosModel; //Field offset: 0x68
	public Nullable<Vector2> positionToMaintain; //Field offset: 0x70
	private List<Nullable`1<Single>> rotations; //Field offset: 0x80
	private List<RotateToPointer> rotateToPointers; //Field offset: 0x88

	public DartlingMaintainLastPos() { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	public virtual void OnUpgraded(int pathUpgraded) { }

	public virtual void UpdatedModel(Model modelToUse) { }

	public void UpdateRotation(RotateToPointer updateFrom, float rotation) { }

}

