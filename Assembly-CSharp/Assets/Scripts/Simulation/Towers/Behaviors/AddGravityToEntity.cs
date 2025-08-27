namespace Assets.Scripts.Simulation.Towers.Behaviors;

internal class AddGravityToEntity : TowerBehavior
{
	private const float TWEEN_SPEED = 5; //Field offset: 0x0
	public AddGravityToEntityModel behaviorModel; //Field offset: 0x68
	public bool isGrounded; //Field offset: 0x70
	public float mass; //Field offset: 0x74
	public Vector3 velocity; //Field offset: 0x78
	public Vector3 acceleration; //Field offset: 0x84
	public Vector3 gravity; //Field offset: 0x90
	public Vector3 impulse; //Field offset: 0x9C
	private Quaternion origionalRotation; //Field offset: 0xA8
	private float currentTiltAngle; //Field offset: 0xB8
	private Nullable<Single> _minY; //Field offset: 0xBC
	private Nullable<Single> _maxY; //Field offset: 0xC4

	private float MaxY
	{
		private get { } //Length: 205
	}

	private float MinY
	{
		private get { } //Length: 219
	}

	public AddGravityToEntity() { }

	private void ApplyGravity() { }

	private void ApplyInertia() { }

	private void ApplyTilt() { }

	private void CheckGroundCollision() { }

	private float get_MaxY() { }

	private float get_MinY() { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	protected virtual void OnDestroy() { }

	public void OnSelectionChangedAddImpulse(ISelectable entity) { }

	public void Process(int elapsed) { }

	private void Setup() { }

	public virtual void UpdatedModel(Model modelToUse) { }

	private void UpdatePosition() { }

}

