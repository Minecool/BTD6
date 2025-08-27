namespace Assets.Scripts.Simulation.Physics;

[Il2CppSetOption(Option::NullChecks (1), False)]
[Il2CppSetOption(Option::ArrayBoundsChecks (2), False)]
public class CollisionChecker : RootBehavior
{
	[CompilerGenerated]
	private sealed class <GetInLine>d__7 : IEnumerable<T>, IEnumerable, IEnumerator<T>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x0
		private T <>2__current; //Field offset: 0x0
		private int <>l__initialThreadId; //Field offset: 0x0
		private Vector3 directionAndLength; //Field offset: 0x0
		public Vector3 <>3__directionAndLength; //Field offset: 0x0
		private float thickness; //Field offset: 0x0
		public float <>3__thickness; //Field offset: 0x0
		private Vector3 position; //Field offset: 0x0
		public Vector3 <>3__position; //Field offset: 0x0
		public CollisionChecker <>4__this; //Field offset: 0x0
		private float <length>5__2; //Field offset: 0x0
		private float <current>5__3; //Field offset: 0x0
		private CollisionState<T> <collisionState>5__4; //Field offset: 0x0

		private override T System.Collections.Generic.IEnumerator<T>.Current
		{
			[DebuggerHidden]
			private get { } //Length: 5
		}

		private override object System.Collections.IEnumerator.Current
		{
			[DebuggerHidden]
			private get { } //Length: 5
		}

		[DebuggerHidden]
		public <GetInLine>d__7`1(int <>1__state) { }

		private override bool MoveNext() { }

		[DebuggerHidden]
		private override IEnumerator<T> System.Collections.Generic.IEnumerable<T>.GetEnumerator() { }

		[DebuggerHidden]
		private override T System.Collections.Generic.IEnumerator<T>.get_Current() { }

		[DebuggerHidden]
		private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

		[DebuggerHidden]
		private override object System.Collections.IEnumerator.get_Current() { }

		[DebuggerHidden]
		private override void System.Collections.IEnumerator.Reset() { }

		[DebuggerHidden]
		private override void System.IDisposable.Dispose() { }

	}

	internal struct Collisions
	{
		public From from; //Field offset: 0x0
		public IEnumerable<To> to; //Field offset: 0x0

	}

	private readonly Dictionary<Type, Object> grids; //Field offset: 0x58
	private LockList<Projectile> projectiles; //Field offset: 0x60

	public CollisionChecker() { }

	public CollisionGrid<T> GetGrid() { }

	[IteratorStateMachine(typeof(<GetInLine>d__7`1))]
	public IEnumerable<T> GetInLine(Vector3 position, Vector3 directionAndLength, float thickness) { }

	public CollisionState<T> GetInRange(float x, float y, float range, float gridMargin = 40, float withRadiusOverride = -1) { }

	public void MakeGrids() { }

	public void Process(int elapsed) { }

}

