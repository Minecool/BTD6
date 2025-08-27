namespace Assets.Scripts.Simulation.Towers.Behaviors;

public class SpiritTowerMovement : TowerBehavior
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func<Bloon, Single> <>9__45_0; //Field offset: 0x8
		public static Func<Bloon, Single> <>9__45_1; //Field offset: 0x10

		private static <>c() { }

		public <>c() { }

		internal float <GetTarget>b__45_0(Bloon possibleTarget) { }

		internal float <GetTarget>b__45_1(Bloon possibleTarget) { }

	}

	internal enum TargetingState
	{
		Bloon = 0,
		IdleRetreat = 1,
		IdleReposition = 2,
		IdleNoMovement = 3,
		MoveAlongTrack = 4,
	}

	public SpiritTowerMovementModel spiritTowerMovementModel; //Field offset: 0x68
	private Tower parentTower; //Field offset: 0x70
	private Target currentTarget; //Field offset: 0x78
	private int lastTargetSearchElapsed; //Field offset: 0xC0
	private Vector2 movementDirection; //Field offset: 0xC4
	private TargetingState targetingState; //Field offset: 0xCC
	private float currentSpeedPerFrame; //Field offset: 0xD0
	private bool isAccelerating; //Field offset: 0xD4
	private int nextIdleMovementAt; //Field offset: 0xD8
	private int timeOfLastBloonTargetValid; //Field offset: 0xDC
	public readonly Dictionary<String, Single> scaleBonusesToSpeed; //Field offset: 0xE0
	public readonly Dictionary<String, Single> scaleBonusesToTurning; //Field offset: 0xE8
	public bool isPaused; //Field offset: 0xF0
	private Path pathMovingAlong; //Field offset: 0xF8
	private bool isMovingAlongTrackInReverse; //Field offset: 0x100
	private float distanceAlongPath; //Field offset: 0x104
	private float trackSpeedBonusFrames; //Field offset: 0x108
	private Vector2 lastDirection; //Field offset: 0x10C
	public bool useFirst; //Field offset: 0x114

	public TargetingState GetTargetingState
	{
		 get { } //Length: 7
	}

	public SpiritTowerMovement() { }

	public void ApplyScaleBonusToSpeed(string bonusKey, float scaleBonus) { }

	public void ApplyScaleBonusToTurning(string bonusKey, float scaleBonus) { }

	private void EndIdleReposition() { }

	private void EndMovingAlongTrack() { }

	private void EndRetreat() { }

	public TargetingState get_GetTargetingState() { }

	private bool GetAccelerationState(float angleBetween) { }

	private float GetMaxSpeedPerFrame() { }

	private Vector3 GetRandomPositionInRangeOfParent() { }

	public Target GetTarget(Tower corvusTower) { }

	private void IdleReposition() { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	private bool IsBloonValid(Bloon bloon) { }

	public bool IsIdle() { }

	private void Process(int elapsed) { }

	public void RemoveScaleBonusToSpeed(string bonusKey) { }

	public void RemoveScaleBonusToTurning(string bonusKey) { }

	public void StartMovingAlongTrack(float speedBonusFrames, bool isReverse) { }

	private void StartRetreat() { }

	public void StopMovingAlongTrack() { }

	private void TrackTowards(Vector2 target) { }

	public virtual void UpdatedModel(Model modelToUse) { }

	private void UpdatePositionAlongTrack() { }

	private void UpdateRotation(Vector2 direction, bool isAccelerating) { }

	private void UpdateTargetingState() { }

}

