namespace Assets.Scripts.Simulation.Towers.Behaviors.Attack.Behaviors;

public class GyrfalconPattern : TargetSupplier
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func<Bloon, Single> <>9__36_0; //Field offset: 0x8
		public static Func<Bloon, Single> <>9__36_1; //Field offset: 0x10

		private static <>c() { }

		public <>c() { }

		internal float <GetBloonTarget>b__36_0(Bloon possibleTarget) { }

		internal float <GetBloonTarget>b__36_1(Bloon possibleTarget) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass36_0
	{
		public GyrfalconPattern <>4__this; //Field offset: 0x10
		public float withinRange; //Field offset: 0x18
		public PathSegment pathSegment; //Field offset: 0x20

		public <>c__DisplayClass36_0() { }

		internal bool <GetBloonTarget>b__2(Bloon possibleTarget) { }

		internal bool <GetBloonTarget>b__3(Bloon possibleTarget) { }

	}

	[CompilerGenerated]
	private sealed class <GetTargets>d__35 : IEnumerable<Target>, IEnumerable, IEnumerator<Target>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private Target <>2__current; //Field offset: 0x18
		private int <>l__initialThreadId; //Field offset: 0x60
		public GyrfalconPattern <>4__this; //Field offset: 0x68

		private override Target System.Collections.Generic.IEnumerator<Assets.Scripts.Simulation.Towers.Target>.Current
		{
			[DebuggerHidden]
			private get { } //Length: 45
		}

		private override object System.Collections.IEnumerator.Current
		{
			[DebuggerHidden]
			private get { } //Length: 107
		}

		[DebuggerHidden]
		public <GetTargets>d__35(int <>1__state) { }

		private override bool MoveNext() { }

		[DebuggerHidden]
		private override IEnumerator<Target> System.Collections.Generic.IEnumerable<Assets.Scripts.Simulation.Towers.Target>.GetEnumerator() { }

		[DebuggerHidden]
		private override Target System.Collections.Generic.IEnumerator<Assets.Scripts.Simulation.Towers.Target>.get_Current() { }

		[DebuggerHidden]
		private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

		[DebuggerHidden]
		private override object System.Collections.IEnumerator.get_Current() { }

		[DebuggerHidden]
		private override void System.Collections.IEnumerator.Reset() { }

		[DebuggerHidden]
		private override void System.IDisposable.Dispose() { }

	}

	public GyrfalconPatternModel gyrfalconPatternModel; //Field offset: 0x68
	public AirUnit airUnit; //Field offset: 0x70
	private PathMovement pathMovement; //Field offset: 0x78
	private Target currentTarget; //Field offset: 0x80
	private int lastElapsed; //Field offset: 0xC8
	private Tower parentTower; //Field offset: 0xD0
	private BeastHandlerLeash parentTowerLeash; //Field offset: 0xD8
	private Tower hoveredTower; //Field offset: 0xE0
	private Vector2 lastMovementDestination; //Field offset: 0xE8
	private PathSegment lastPathSegmentThisFrame; //Field offset: 0xF0
	public PathSegment selectedPathSegment; //Field offset: 0xF8
	private List<Bloon> heldBloons; //Field offset: 0x100
	private List<Bloon> heldAndDestroyedBloons; //Field offset: 0x108
	private List<Bloon> bloonsTaggedThisFrame; //Field offset: 0x110
	private int lastGrappleDamageAt; //Field offset: 0x118
	private int cooldownFrom; //Field offset: 0x11C
	private int cooldownStartedAt; //Field offset: 0x120
	private float lastRotationSet; //Field offset: 0x124
	private int timeOfNextIdleMove; //Field offset: 0x128
	private Nullable<Vector2> hoveredIdlePosition; //Field offset: 0x12C
	private bool setInitialPosition; //Field offset: 0x138

	public Vector2 LastMovementDestination
	{
		 get { } //Length: 25
	}

	public PathSegment LastPathSegmentThisFrame
	{
		 get { } //Length: 52
	}

	public GyrfalconPattern() { }

	private void ApplyMovement(Vector2 finalDestination, float delta) { }

	public virtual void ApplyTargetTypeData(Vector2 data) { }

	private int DamageBloon(Bloon bloon, bool blockSpawnChildren) { }

	public Vector2 get_LastMovementDestination() { }

	public PathSegment get_LastPathSegmentThisFrame() { }

	private Bloon GetBloonTarget(float withinRange = -1, PathSegment pathSegment = null) { }

	public PathSegment GetDestinationPathSegment() { }

	public virtual string GetName() { }

	private int GetPierceUsage(BloonModel bloonModel) { }

	public virtual void GetSaveMetaData(Dictionary<String, String> metaData) { }

	public virtual Target GetTarget() { }

	[IteratorStateMachine(typeof(<GetTargets>d__35))]
	public virtual IEnumerable<Target> GetTargets() { }

	private Tower GetTowerTarget() { }

	private void HoverInPlace() { }

	private void HoverOverTower(Tower towerToHover) { }

	private void IdleMove() { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	private bool IsBloonValid(Bloon bloon) { }

	private bool IsBloonValidAndInsideTowerRange(Bloon bloon) { }

	private bool IsBloonVisible(Bloon bloon) { }

	private bool IsInCooldown() { }

	private bool IsPathSegmentStillValid(PathSegment pathSegmentToCheck) { }

	private bool IsValidForHovering(BeastHandlerLeash leash) { }

	public virtual void LateSetSaveMetaData(Dictionary<String, String> metaData) { }

	protected virtual void OnDestroy() { }

	public virtual void OnSwitchedFrom() { }

	public virtual void OnSwitchedTo() { }

	private void PlayFlyingAnimation() { }

	private void PlayHoverAnimation() { }

	private void PlayNoGrabEffect() { }

	private void PlaySnatchFlyingAnimation() { }

	private void PlaySnatchHoverAnimation() { }

	private void Process(int elapsed) { }

	private void ReleaseBloons() { }

	private void Reset() { }

	private void SetInitialPosition() { }

	private void SetRotation(float rotation) { }

	private int SnatchBloon(Bloon bloon, PathSegment destinationPathSegment) { }

	private bool TargetCheck(float withinRange, PathSegment pathSegment, Bloon possibleTarget) { }

	public virtual void UpdatedModel(Model modelToUse) { }

	private void UpdateGrappleDamage() { }

	private void UpdateIdle() { }

	private void UpdateMovement(float delta) { }

	private void UpdateTargeting() { }

}

