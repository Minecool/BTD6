namespace Assets.Scripts.Simulation.Towers.Behaviors.Attack.Behaviors;

public class WingmonkeyPattern : PathSupplier
{
	[CompilerGenerated]
	private sealed class <GetTargets>d__25 : IEnumerable<Target>, IEnumerable, IEnumerator<Target>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private Target <>2__current; //Field offset: 0x18
		private int <>l__initialThreadId; //Field offset: 0x60
		public WingmonkeyPattern <>4__this; //Field offset: 0x68

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
		public <GetTargets>d__25(int <>1__state) { }

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

	public WingmonkeyPatternModel wingmonkeyPatternModel; //Field offset: 0xA0
	public AirUnit airUnit; //Field offset: 0xA8
	private PathMovement pathMovement; //Field offset: 0xB0
	private Bloon currentBloonTarget; //Field offset: 0xB8
	private bool flyoverEngaged; //Field offset: 0xC0
	private Vector3 flyoverDestination; //Field offset: 0xC4
	private int lastElapsed; //Field offset: 0xD0
	private float lastBank; //Field offset: 0xD4
	private float lastRandomPositionAngle; //Field offset: 0xD8
	private bool wasTargetValidLastFrame; //Field offset: 0xDC
	private Vector3 lastPositionOfTarget; //Field offset: 0xE0
	private bool canCheckForTargetsWhileInFlyover; //Field offset: 0xEC
	private float timeUntilNextCheckForTargets; //Field offset: 0xF0
	private WingmonkeySimulation wingmonkeySimulation; //Field offset: 0xF8
	private Vector3 lastMovementDestination; //Field offset: 0x100

	public Vector3 LastMovementDestination
	{
		 get { } //Length: 25
	}

	public WingmonkeyPattern() { }

	private void ApplyMovement(Vector3 finalDestination, float delta) { }

	private bool CurrentlyHasValidTarget() { }

	public Vector3 get_LastMovementDestination() { }

	private Bloon GetBloonTarget(bool adjacent) { }

	public virtual string GetName() { }

	private Vector3 GetRandomFlyoverPosition() { }

	[IteratorStateMachine(typeof(<GetTargets>d__25))]
	public virtual IEnumerable<Target> GetTargets() { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	private bool IsBloonAdjacentAndValid(Bloon bloon) { }

	protected virtual bool IsBloonValid(Bloon bloon) { }

	protected virtual bool IsBloonVisible(Bloon bloon) { }

	protected virtual void OnDestroy() { }

	public virtual void OnSwitchedFrom() { }

	public virtual void OnSwitchedTo() { }

	private void Process(int elapsed) { }

	private void Reset() { }

	public virtual void UpdatedModel(Model modelToUse) { }

	private void UpdateMovement(float delta) { }

}

