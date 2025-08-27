namespace Assets.Scripts.Simulation.Objects;

public interface ICommonBehaviorProxy : IMutable, IRootBehavior, IRootObject
{

	public event OnUpgradedDelegate OnUpgradedEvent
	{
		[CompilerGenerated]
		 add { } //Length: 0
		[CompilerGenerated]
		 remove { } //Length: 0
	}

	public int CreatedAt
	{
		 get { } //Length: 0
		 set { } //Length: 0
	}

	public Vector3Boxed Direction
	{
		 get { } //Length: 0
	}

	public DisplayBehavior Display
	{
		 get { } //Length: 0
	}

	public Tower EmittedBy
	{
		 get { } //Length: 0
		 set { } //Length: 0
	}

	public EntityModel EntityModel
	{
		 get { } //Length: 0
	}

	public bool IsInvulnerable
	{
		 get { } //Length: 0
	}

	public bool IsStunned
	{
		 get { } //Length: 0
	}

	public bool IsSuspended
	{
		 get { } //Length: 0
	}

	public int Lifespan
	{
		 get { } //Length: 0
		 set { } //Length: 0
	}

	public DisplayNode Node
	{
		 get { } //Length: 0
	}

	public ObjectId ParentId
	{
		 get { } //Length: 0
		 set { } //Length: 0
	}

	public int PlayerOwnerId
	{
		 get { } //Length: 0
	}

	public Vector3Boxed Position
	{
		 get { } //Length: 0
	}

	public float Rotation
	{
		 get { } //Length: 0
		 set { } //Length: 0
	}

	public Vector3Boxed Scale
	{
		 get { } //Length: 0
	}

	public Target target
	{
		 get { } //Length: 0
		 set { } //Length: 0
	}

	public TargetType TargetType
	{
		 get { } //Length: 0
	}

	public TransformBehavior Transform
	{
		 get { } //Length: 0
	}

	[CompilerGenerated]
	public void add_OnUpgradedEvent(OnUpgradedDelegate value) { }

	public void Expire() { }

	public int get_CreatedAt() { }

	public Vector3Boxed get_Direction() { }

	public DisplayBehavior get_Display() { }

	public Tower get_EmittedBy() { }

	public EntityModel get_EntityModel() { }

	public bool get_IsInvulnerable() { }

	public bool get_IsStunned() { }

	public bool get_IsSuspended() { }

	public int get_Lifespan() { }

	public DisplayNode get_Node() { }

	public ObjectId get_ParentId() { }

	public int get_PlayerOwnerId() { }

	public Vector3Boxed get_Position() { }

	public float get_Rotation() { }

	public Vector3Boxed get_Scale() { }

	public Target get_target() { }

	public TargetType get_TargetType() { }

	public TransformBehavior get_Transform() { }

	public void OnProjectilesCreated(List<Projectile> projectiles) { }

	public float Pickup(Tower towerPickingUp) { }

	[CompilerGenerated]
	public void remove_OnUpgradedEvent(OnUpgradedDelegate value) { }

	public void set_CreatedAt(int value) { }

	public void set_EmittedBy(Tower value) { }

	public void set_Lifespan(int value) { }

	public void set_ParentId(ObjectId value) { }

	public void set_Rotation(float value) { }

	public void set_target(Target value) { }

}

