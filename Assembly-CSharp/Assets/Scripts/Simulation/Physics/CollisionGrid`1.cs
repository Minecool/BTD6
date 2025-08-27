namespace Assets.Scripts.Simulation.Physics;

[Il2CppSetOption(Option::NullChecks (1), False)]
[Il2CppSetOption(Option::ArrayBoundsChecks (2), False)]
public class CollisionGrid
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c<T> <>9; //Field offset: 0x0
		public static Comparison<Int32[]> <>9__14_0; //Field offset: 0x0

		private static <>c() { }

		public <>c() { }

		internal int <.ctor>b__14_0(Int32[] a, Int32[] b) { }

	}

	[Il2CppSetOption(Option::ArrayBoundsChecks (2), False)]
	[Il2CppSetOption(Option::NullChecks (1), False)]
	internal class CollisionState : IEnumerator<T>, IEnumerator, IDisposable
	{
		private CollisionGrid<T> grid; //Field offset: 0x0
		private float x; //Field offset: 0x0
		private float y; //Field offset: 0x0
		private float radius; //Field offset: 0x0
		private float gridMargin; //Field offset: 0x0
		private float withRadiusOverride; //Field offset: 0x0
		private int i; //Field offset: 0x0
		private int j; //Field offset: 0x0
		private int bucketGridX; //Field offset: 0x0
		private int bucketGridY; //Field offset: 0x0
		private int bucketSpan; //Field offset: 0x0
		private Vector2 pos; //Field offset: 0x0
		private int bucketAreaSize; //Field offset: 0x0
		[CompilerGenerated]
		private T <Current>k__BackingField; //Field offset: 0x0

		public private override T Current
		{
			[CompilerGenerated]
			 get { } //Length: 5
			[CompilerGenerated]
			private set { } //Length: 5
		}

		private override object System.Collections.IEnumerator.Current
		{
			private get { } //Length: 5
		}

		public CollisionState() { }

		public override void Dispose() { }

		[CompilerGenerated]
		public override T get_Current() { }

		public void Initialize(CollisionGrid<T> grid, float x, float y, float radius, float gridMargin = 40, float withRadiusOverride = -1) { }

		[Il2CppSetOption(Option::NullChecks (1), False)]
		[Il2CppSetOption(Option::ArrayBoundsChecks (2), False)]
		public override bool MoveNext() { }

		public override void Reset() { }

		[CompilerGenerated]
		private void set_Current(T value) { }

		private override object System.Collections.IEnumerator.get_Current() { }

	}

	private const float collisionMargin = 52; //Field offset: 0x0
	private const float collisionXMin = -202; //Field offset: 0x0
	private const float collisionXMax = 202; //Field offset: 0x0
	private const float collisionYMin = -168; //Field offset: 0x0
	private const float collisionYMax = 168; //Field offset: 0x0
	private const float collisionWidth = 404; //Field offset: 0x0
	private const float collisionHeight = 336; //Field offset: 0x0
	private readonly int bucketsW; //Field offset: 0x0
	private readonly int bucketsH; //Field offset: 0x0
	private readonly Bucket<T>[] buckets; //Field offset: 0x0
	private readonly LockList<T> source; //Field offset: 0x0
	private readonly Int32[] orderedNeighborOffsets; //Field offset: 0x0
	private readonly int orderedNeighborOffsetsLength; //Field offset: 0x0
	private bool isEmpty; //Field offset: 0x0
	private int currentCollisionState; //Field offset: 0x0
	private readonly CollisionState<T>[] collisionStates; //Field offset: 0x0

	public CollisionGrid`1(LockList<T> source) { }

	public void Fill(int elapsed) { }

	private Bucket<T> GetBucket(float x, float y) { }

	private int GetBucketIndex(float x, float y) { }

	public CollisionState<T> GetInRange(float x, float y, float radius, float gridMargin = 40, float withRadiusOverride = -1) { }

}

