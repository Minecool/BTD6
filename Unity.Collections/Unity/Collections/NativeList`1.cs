namespace Unity.Collections;

[BurstCompatible(GenericTypeArguments = new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {typeof(int}])]
[DebuggerDisplay("Length = {Length}")]
[DebuggerTypeProxy(typeof(NativeListDebugView`1))]
[DefaultMember("Item")]
[NativeContainer]
public struct NativeList : IDisposable, IEnumerable<T>, IEnumerable
{
	[NativeDisableUnsafePtrRestriction]
	internal UnsafeList<T>* m_ListData; //Field offset: 0x0
	internal AllocatorHandle m_DeprecatedAllocator; //Field offset: 0x0

	public override T Item
	{
		 get { } //Length: 265
	}

	public override int Length
	{
		 get { } //Length: 117
	}

	public NativeList`1(int initialCapacity, AllocatorHandle allocator) { }

	private NativeList`1(int initialCapacity, AllocatorHandle allocator, int disposeSentinelStackDepth) { }

	public void Add(in T value) { }

	public NativeArray<T> AsArray() { }

	public override void Clear() { }

	public override void Dispose() { }

	public override T get_Item(int index) { }

	public override int get_Length() { }

	public Enumerator<T> GetEnumerator() { }

	[BurstCompatible(GenericTypeArguments = new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {typeof(AllocatorHandle)}])]
	internal void Initialize(int initialCapacity, ref U allocator, int disposeSentinelStackDepth) { }

	private override IEnumerator<T> System.Collections.Generic.IEnumerable<T>.GetEnumerator() { }

	private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

}

