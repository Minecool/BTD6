namespace Assets.Scripts.Simulation.Movement;

public class TrackTargetOrOrbitParent : RootBehavior
{
	private enum MovableEntityState
	{
		NotSet = 0,
		TrackingTarget = 1,
		MovingToOrbit = 2,
		Orbiting = 3,
		Destroyed = 4,
	}

	private Entity movableEntity; //Field offset: 0x58
	private Entity parentEntity; //Field offset: 0x60
	private Func<Target> getTarget; //Field offset: 0x68
	private Func<Target, Boolean> isTargetValid; //Field offset: 0x70
	private Action<Vector2> updateRotation; //Field offset: 0x78
	private int searchDelayFrames; //Field offset: 0x80
	private TrackTargetParameters parameters; //Field offset: 0x88
	private Target currentTarget; //Field offset: 0x90
	private MovableEntityState movableEntityState; //Field offset: 0xD8
	private int lastTargetSearchElapsed; //Field offset: 0xDC
	private Vector2 currentPosition; //Field offset: 0xE0
	private Vector2 movementDirection; //Field offset: 0xE8
	private Vector2 orbitDestination; //Field offset: 0xF0
	private float orbitAngle; //Field offset: 0xF8
	private bool isAccelerating; //Field offset: 0xFC
	private float currentSpeed; //Field offset: 0x100
	public float orbitSpeedScale; //Field offset: 0x104
	public float turnSpeedScale; //Field offset: 0x108

	public TrackTargetOrOrbitParent(Entity movableEntity, Entity parentEntity, Func<Target> getTarget, Func<Target, Boolean> isTargetValid, int searchDelayFrames, TrackTargetParameters idleAroundParameters) { }

	private bool GetAccelerationState(float angleBetween) { }

	private MovableEntityState GetMovableEntityState() { }

	private void Orbit() { }

	private void Process(int elapsed) { }

	private void SetOrbitDestination() { }

	private void TrackTowards(Vector2 target) { }

	public void UpdateOrbitSpeed(float scale) { }

	public void UpdateTurnSpeed(float scale) { }

}

