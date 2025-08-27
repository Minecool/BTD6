namespace Assets.Scripts.Simulation.Towers.Behaviors;

public class AirUnit : TowerBehavior
{
	public AirUnitModel airUnitModel; //Field offset: 0x68
	private readonly List<RootBehavior> modelBehaviors; //Field offset: 0x70
	public TransformBehavior transform; //Field offset: 0x78
	public DisplayBehavior display; //Field offset: 0x80
	public ObjectId groundedAreaId; //Field offset: 0x88

	public virtual Vector3Boxed Position
	{
		 get { } //Length: 27
	}

	public FloatBoxed Rotation
	{
		 get { } //Length: 27
	}

	public AirUnit() { }

	public virtual void Attatched() { }

	public virtual Vector3Boxed get_Position() { }

	public FloatBoxed get_Rotation() { }

	public virtual void GetSaveMetaData(Dictionary<String, String> metaData) { }

	public void GroundedMoveBy(Vector2 moveAmount) { }

	public void GroundedRotateAroundPivot(Vector2 pivotPoint, float rotation) { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	public bool IsGrounded() { }

	public virtual void LateSetSaveMetaData(Dictionary<String, String> metaData) { }

	protected virtual void OnDestroy() { }

	public virtual void SetSaveMetaData(Dictionary<String, String> metaData) { }

	public virtual void UpdatedModel(Model modelToUse) { }

}

