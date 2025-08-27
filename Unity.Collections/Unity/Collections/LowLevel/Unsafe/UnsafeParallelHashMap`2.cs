namespace Unity.Collections.LowLevel.Unsafe;

[DebuggerDisplay("Count = {Count()}, Capacity = {Capacity}, IsCreated = {IsCreated}, IsEmpty = {IsEmpty}")]
[DebuggerTypeProxy(typeof(UnsafeParallelHashMapDebuggerTypeProxy`2))]
[DefaultMember("Item")]
[GenerateTestsForBurstCompatibility(GenericTypeArguments = new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {typeof(int, typeof(int}])]
public struct UnsafeParallelHashMap : IDisposable, IEnumerable<KeyValue`2<TKey, TValue>>, IEnumerable
{
	[GenerateTestsForBurstCompatibility(GenericTypeArguments = new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {typeof(int, typeof(int}])]
	internal struct ParallelWriter
	{
		[NativeDisableUnsafePtrRestriction]
		internal UnsafeParallelHashMapData* m_Buffer; //Field offset: 0x0
		[NativeSetThreadIndex]
		internal int m_ThreadIndex; //Field offset: 0x0

		public bool TryAdd(TKey key, TValue item) { }

	}

	[NativeDisableUnsafePtrRestriction]
	internal UnsafeParallelHashMapData* m_Buffer; //Field offset: 0x0
	internal AllocatorHandle m_AllocatorLabel; //Field offset: 0x0

	public int Capacity
	{
		[IsReadOnly]
		 get { } //Length: 25
		 set { } //Length: 132
	}

	public bool IsCreated
	{
		[IsReadOnly]
		 get { } //Length: 8
	}

	public TKey Item
	{
		 set { } //Length: 360
	}

	public UnsafeParallelHashMap`2(int capacity, AllocatorHandle allocator) { }

	public ParallelWriter<TKey, TValue> AsParallelWriter() { }

	public void Clear() { }

	public bool ContainsKey(TKey key) { }

	[IsReadOnly]
	public int Count() { }

	public override void Dispose() { }

	[IsReadOnly]
	public int get_Capacity() { }

	[IsReadOnly]
	public bool get_IsCreated() { }

	public bool Remove(TKey key) { }

	public void set_Capacity(int value) { }

	public void set_Item(TKey key, TValue value) { }

	private override IEnumerator<KeyValue`2<TKey, TValue>> System.Collections.Generic.IEnumerable<Unity.Collections.LowLevel.Unsafe.KeyValue<TKey,TValue>>.GetEnumerator() { }

	private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	public bool TryGetValue(TKey key, out TValue item) { }

}

