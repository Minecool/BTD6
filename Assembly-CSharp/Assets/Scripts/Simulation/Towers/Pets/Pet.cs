namespace Assets.Scripts.Simulation.Towers.Pets;

public class Pet : TowerBehavior
{
	public PetModel petModel; //Field offset: 0x68
	public DisplayBehavior display; //Field offset: 0x70
	public TransformBehavior transform; //Field offset: 0x78
	private List<RootBehavior> modelBehaviors; //Field offset: 0x80

	public virtual Vector3Boxed Position
	{
		 get { } //Length: 27
	}

	public Pet() { }

	public virtual Vector3Boxed get_Position() { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	public void Move(Vector2 moveBy) { }

	protected virtual void OnDestroy() { }

	public virtual void OnPlace(bool playPlacementEffects) { }

	public virtual void OnSold(float amount) { }

	public void RotateAroundPivot(Vector2 pivotPoint, float rotation) { }

	public void SetPosition(Vector2 pos) { }

	public virtual void UpdatedModel(Model modelToUse) { }

}

