namespace Assets.Scripts.Simulation.Towers.Behaviors.Attack.Behaviors;

public class RotateToTargetAttackOffset : RotateToTarget
{
	public RotateToTargetAttackOffsetModel rotateToTargetAttackOffsetModel; //Field offset: 0x88
	private TransformBehavior transform; //Field offset: 0x90
	private int stopIgnoringRotationAt; //Field offset: 0x98

	public RotateToTargetAttackOffset() { }

	protected virtual void ApplyRotation() { }

	private Vector3 GetOrigin() { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	protected virtual void OnDestroy() { }

	private void Process(int elapsed) { }

	private void RotateToStartingPoint() { }

	private void SetRotation(Vector3 targetPos, bool reset = false) { }

	public virtual void UpdatedModel(Model modelToUse) { }

}

