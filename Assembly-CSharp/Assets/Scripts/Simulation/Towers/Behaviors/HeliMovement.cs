namespace Assets.Scripts.Simulation.Towers.Behaviors;

public class HeliMovement : TowerBehavior
{
	internal class CustomMovement
	{
		public Tower targetTower; //Field offset: 0x10
		public bool ignoreTargeting; //Field offset: 0x18
		public bool isActive; //Field offset: 0x19
		public Vector2 position; //Field offset: 0x1C
		public bool dontStrafe; //Field offset: 0x24
		public bool onlyMoveDuringRound; //Field offset: 0x25

		public CustomMovement() { }

	}

	public HeliMovementModel heliMovementModel; //Field offset: 0x68
	private List<HeliMovement> heliPositionsInRepulseRange; //Field offset: 0x70
	private Vector2 currentVelocity; //Field offset: 0x78
	public HeliGroupOffset heliGroupOffsetTouch; //Field offset: 0x80
	public HeliGroupOffset heliGroupOffsetPursuit; //Field offset: 0x88
	public bool canMoveOutsideScreen; //Field offset: 0x90
	public bool ignoreRepulsion; //Field offset: 0x91
	public Vector2 lastGroupOffset; //Field offset: 0x94
	private readonly CustomMovement customMovement; //Field offset: 0xA0
	private readonly List<Attack> attacks; //Field offset: 0xA8
	private readonly List<PathSupplier> pathSuppliers; //Field offset: 0xB0
	private PathSupplier currentPathSupplier; //Field offset: 0xB8
	private TransformBehavior heliTransformBehavior; //Field offset: 0xC0
	private Vector2[] path; //Field offset: 0xC8
	private int pathIndex; //Field offset: 0xD0

	public CustomMovement GetCustomMovement
	{
		 get { } //Length: 8
	}

	public HeliMovement() { }

	private void ApplyMovement(Vector2 destinationPosition2d, float delta) { }

	public virtual void Attatched() { }

	public void EndCustomMovement() { }

	private Vector2 FindCustomMovementDestination() { }

	private Vector2 FindDefaultPatrolPointsDestination(Vector2[] path, PatrolPointsSetting patrolPointsSetting) { }

	private Vector2 FindFollowTouchDestination(Vector2[] path) { }

	private Vector2 FindPatrolPointsDestination(Vector2[] path, PatrolPointsSetting patrolPointsSetting) { }

	private Vector2 FindPursuitDestination(Vector2[] path) { }

	private Vector2 FindPursuitPatrolPointsDestination(Vector2[] path, PatrolPointsSetting patrolPointsSetting) { }

	public CustomMovement get_GetCustomMovement() { }

	private Vector2 GetCappedVelocity(float velocityCapScale) { }

	public static HeliGroupOffset GetGroupOffsetInstance(Simulation sim, string targetTypeId, string baseTowerId) { }

	private Tower GetParentTower() { }

	public Vector2 GetPosition() { }

	public float GetRange() { }

	private Vector2 GetRepulsionVector(Vector2 currentPosition) { }

	private void HeliEnter(HeliMovement heliMovement) { }

	private void HeliExit(HeliMovement heliMovement) { }

	public void Init() { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	public virtual void OnChangeTargetPriority(TargetType targetType) { }

	protected virtual void OnDestroy() { }

	public void PauseAttacks() { }

	public void Process(int elapsed) { }

	public void SetCustomMovement(Tower targetTower, bool ignoreTargeting, Vector2 position = null, bool dontStrafe = false, bool onlyMoveDuringRound = false) { }

	public void UnpauseAttacks() { }

	public virtual void UpdatedModel(Model modelToUse) { }

	private void UpdateRotation(Vector2 newPosition, Vector2 targetPosition, Vector2 directionToTarget, TransformBehavior currentTransform) { }

	private void UpdateTilt() { }

}

