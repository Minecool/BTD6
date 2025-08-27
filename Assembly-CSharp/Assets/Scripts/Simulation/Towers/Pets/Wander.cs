namespace Assets.Scripts.Simulation.Towers.Pets;

public class Wander : PetBehavior
{
	internal enum WanderState
	{
		None = 0,
		Idle = 1,
		FindTarget = 2,
		Moving = 3,
	}

	private const float kMinWalkDist = 10; //Field offset: 0x0
	private const float kParentRadius = 10; //Field offset: 0x0
	private const float kDegreesPerSec = 720; //Field offset: 0x0
	private WanderModel wanderModel; //Field offset: 0x60
	private WanderState state; //Field offset: 0x68
	private int elapsedMovementTime; //Field offset: 0x6C
	private int totalMovementTime; //Field offset: 0x70
	private int totalRotationTime; //Field offset: 0x74
	private Vector2 startPosition; //Field offset: 0x78
	private Vector2 targetPosition; //Field offset: 0x80
	private float startRotation; //Field offset: 0x88
	private float targetRotation; //Field offset: 0x8C
	private int leaveIdleIn; //Field offset: 0x90
	private AnimationCurve motionCurve; //Field offset: 0x98

	private Vector2 CurrentPosition
	{
		private get { } //Length: 47
		private set { } //Length: 48
	}

	private float CurrentRotation
	{
		private get { } //Length: 46
		private set { } //Length: 46
	}

	private Vector2 parentPosition
	{
		private get { } //Length: 65
	}

	private BufferedRandom Rng
	{
		private get { } //Length: 62
	}

	public WanderState State
	{
		 get { } //Length: 4
	}

	public Wander() { }

	private void BeginFindTarget() { }

	private void BeginIdle() { }

	private void BeginMovement() { }

	private void DebugDrawCross(Vector2 pos, Color colour, float duration = 2) { }

	private void DebugDrawLine(Vector2 a, Vector2 b, Color colour, float duration = 2) { }

	private static float EaseRotation(float t) { }

	private void EnteringState(WanderState newState) { }

	private bool FindInitialPosition(Vector2 centre, float radius, out Vector2 to) { }

	private bool FindTargetPosition(Vector2 centre, float innerRadius, float outerRadius, out Vector2 to) { }

	private Vector2 get_CurrentPosition() { }

	private float get_CurrentRotation() { }

	private Vector2 get_parentPosition() { }

	private BufferedRandom get_Rng() { }

	public WanderState get_State() { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	public virtual void OnPlace() { }

	private void Process(int elapsed) { }

	private void ProcessFindTarget() { }

	private void ProcessIdle() { }

	private void ProcessMovement() { }

	public virtual void RotateAroundPivot(Vector2 pivotPoint, float rotation) { }

	private static Vector2 SampleOnCircumference(Vector2 center, float radius, BufferedRandom rand) { }

	private static Vector2 SampleWithinCircle(Vector2 center, float radius, BufferedRandom rand) { }

	private void set_CurrentPosition(Vector2 value) { }

	private void set_CurrentRotation(float value) { }

	public void SetMovementTarget(Vector2 target) { }

	private void SnapToFirstWalkPoint() { }

	private void SwitchState(WanderState newState) { }

	public virtual void UpdatedModel(Model modelToUse) { }

}

