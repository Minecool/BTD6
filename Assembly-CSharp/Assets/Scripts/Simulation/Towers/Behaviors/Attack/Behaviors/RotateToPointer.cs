namespace Assets.Scripts.Simulation.Towers.Behaviors.Attack.Behaviors;

public class RotateToPointer : AttackBehavior
{
	public RotateToPointerModel rotateToPointerModel; //Field offset: 0x68
	public Vector2 lastPointerPos; //Field offset: 0x70
	public Nullable<Vector2> positionOverride; //Field offset: 0x78
	private DartlingMaintainLastPos dartlingMaintainLastPos; //Field offset: 0x88
	private float yVelocity; //Field offset: 0x90

	public RotateToPointer() { }

	public virtual void GetSaveMetaData(Dictionary<String, String> metaData) { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	protected virtual void OnDestroy() { }

	public void Process(int elapsed) { }

	public void SetRotation(float rotation) { }

	public virtual void SetSaveMetaData(Dictionary<String, String> metaData) { }

	public virtual void SetUpAttack() { }

	public virtual void UpdatedModel(Model modelToUse) { }

}

