namespace Assets.Scripts.Simulation.Objects;

public class CommonBehaviorProxy : Mutable, ICommonBehaviorProxy, IMutable, IRootBehavior, IRootObject
{
	[CompilerGenerated]
	private DisplayBehavior <Display>k__BackingField; //Field offset: 0x0
	public Action onSelectionBlocked; //Field offset: 0x0
	[CompilerGenerated]
	private Target <target>k__BackingField; //Field offset: 0x0
	[CompilerGenerated]
	private Tower <EmittedBy>k__BackingField; //Field offset: 0x0
	[CompilerGenerated]
	private ObjectId <ParentId>k__BackingField; //Field offset: 0x0
	[CompilerGenerated]
	private TargetType <TargetType>k__BackingField; //Field offset: 0x0
	[CompilerGenerated]
	private Vector3Boxed <Direction>k__BackingField; //Field offset: 0x0
	[CompilerGenerated]
	private bool <IsStunned>k__BackingField; //Field offset: 0x0
	[CompilerGenerated]
	private bool <IsInvulnerable>k__BackingField; //Field offset: 0x0
	[CompilerGenerated]
	private bool <IsSuspended>k__BackingField; //Field offset: 0x0
	[CompilerGenerated]
	private int <PlayerOwnerId>k__BackingField; //Field offset: 0x0
	[CompilerGenerated]
	private int <CreatedAt>k__BackingField; //Field offset: 0x0
	[CompilerGenerated]
	private int <Lifespan>k__BackingField; //Field offset: 0x0
	[CompilerGenerated]
	private readonly RootObjectLockList<T> <Behaviors>k__BackingField; //Field offset: 0x0
	[CompilerGenerated]
	private TransformBehavior <Transform>k__BackingField; //Field offset: 0x0
	[CompilerGenerated]
	private EntityModel <EntityModel>k__BackingField; //Field offset: 0x0
	public Action onSuspendedChanged; //Field offset: 0x0
	[CompilerGenerated]
	private OnUpgradedDelegate OnUpgradedEvent; //Field offset: 0x0

	public override event OnUpgradedDelegate OnUpgradedEvent
	{
		[CompilerGenerated]
		 add { } //Length: 162
		[CompilerGenerated]
		 remove { } //Length: 162
	}

	public override RootObjectLockList<T> Behaviors
	{
		[CompilerGenerated]
		 get { } //Length: 8
	}

	public override int CreatedAt
	{
		[CompilerGenerated]
		 get { } //Length: 7
		[CompilerGenerated]
		 set { } //Length: 7
	}

	public override Vector3Boxed Direction
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 8
	}

	public private override DisplayBehavior Display
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 8
	}

	public override Tower EmittedBy
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 8
	}

	public private override EntityModel EntityModel
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 8
	}

	public override bool IsInvulnerable
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 7
	}

	public override bool IsStunned
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 7
	}

	public override bool IsSuspended
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 7
	}

	public override int Lifespan
	{
		[CompilerGenerated]
		 get { } //Length: 7
		[CompilerGenerated]
		 set { } //Length: 7
	}

	public override DisplayNode Node
	{
		 get { } //Length: 30
	}

	public override ObjectId ParentId
	{
		[CompilerGenerated]
		 get { } //Length: 7
		[CompilerGenerated]
		 set { } //Length: 7
	}

	public override int PlayerOwnerId
	{
		[CompilerGenerated]
		 get { } //Length: 7
		[CompilerGenerated]
		 set { } //Length: 7
	}

	public override Vector3Boxed Position
	{
		 get { } //Length: 102
	}

	public override float Rotation
	{
		 get { } //Length: 40
		 set { } //Length: 40
	}

	public override Vector3Boxed Scale
	{
		 get { } //Length: 30
		 set { } //Length: 42
	}

	public override Target target
	{
		[CompilerGenerated]
		 get { } //Length: 60
		[CompilerGenerated]
		 set { } //Length: 57
	}

	public override TargetType TargetType
	{
		[CompilerGenerated]
		 get { } //Length: 27
		[CompilerGenerated]
		 set { } //Length: 24
	}

	public override TransformBehavior Transform
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 8
	}

	public CommonBehaviorProxy`1() { }

	[CompilerGenerated]
	public override void add_OnUpgradedEvent(OnUpgradedDelegate value) { }

	public virtual void Attatched() { }

	public override void Expire() { }

	[CompilerGenerated]
	public override RootObjectLockList<T> get_Behaviors() { }

	[CompilerGenerated]
	public override int get_CreatedAt() { }

	[CompilerGenerated]
	public override Vector3Boxed get_Direction() { }

	[CompilerGenerated]
	public override DisplayBehavior get_Display() { }

	[CompilerGenerated]
	public override Tower get_EmittedBy() { }

	[CompilerGenerated]
	public override EntityModel get_EntityModel() { }

	[CompilerGenerated]
	public override bool get_IsInvulnerable() { }

	[CompilerGenerated]
	public override bool get_IsStunned() { }

	[CompilerGenerated]
	public override bool get_IsSuspended() { }

	[CompilerGenerated]
	public override int get_Lifespan() { }

	public override DisplayNode get_Node() { }

	[CompilerGenerated]
	public override ObjectId get_ParentId() { }

	[CompilerGenerated]
	public override int get_PlayerOwnerId() { }

	public override Vector3Boxed get_Position() { }

	public override float get_Rotation() { }

	public override Vector3Boxed get_Scale() { }

	[CompilerGenerated]
	public override Target get_target() { }

	[CompilerGenerated]
	public override TargetType get_TargetType() { }

	[CompilerGenerated]
	public override TransformBehavior get_Transform() { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	protected virtual void OnDestroy() { }

	public override void OnProjectilesCreated(List<Projectile> projectiles) { }

	public override void OnUpgraded(int path) { }

	public override float Pickup() { }

	[CompilerGenerated]
	public override void remove_OnUpgradedEvent(OnUpgradedDelegate value) { }

	[CompilerGenerated]
	public override void set_CreatedAt(int value) { }

	[CompilerGenerated]
	public void set_Direction(Vector3Boxed value) { }

	[CompilerGenerated]
	private void set_Display(DisplayBehavior value) { }

	[CompilerGenerated]
	public override void set_EmittedBy(Tower value) { }

	[CompilerGenerated]
	private void set_EntityModel(EntityModel value) { }

	[CompilerGenerated]
	public override void set_IsInvulnerable(bool value) { }

	[CompilerGenerated]
	protected override void set_IsStunned(bool value) { }

	[CompilerGenerated]
	protected void set_IsSuspended(bool value) { }

	[CompilerGenerated]
	public override void set_Lifespan(int value) { }

	[CompilerGenerated]
	public override void set_ParentId(ObjectId value) { }

	[CompilerGenerated]
	public void set_PlayerOwnerId(int value) { }

	public override void set_Rotation(float value) { }

	public void set_Scale(Vector3Boxed value) { }

	[CompilerGenerated]
	public override void set_target(Target value) { }

	[CompilerGenerated]
	protected void set_TargetType(TargetType value) { }

	[CompilerGenerated]
	public void set_Transform(TransformBehavior value) { }

	public virtual void UpdatedModel(Model modelToUse) { }

}

