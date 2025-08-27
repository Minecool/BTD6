namespace Unity.Collections;

[DebuggerTypeProxy(typeof(NativeParallelMultiHashMapDebuggerTypeProxy`2))]
[GenerateTestsForBurstCompatibility(GenericTypeArguments = new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {typeof(int, typeof(int}])]
[NativeContainer]
public struct NativeParallelMultiHashMap : IDisposable, IEnumerable<KeyValue`2<TKey, TValue>>, IEnumerable
{
	internal UnsafeParallelMultiHashMap<TKey, TValue> m_MultiHashMapData; //Field offset: 0x0

	public bool IsCreated
	{
		[IsReadOnly]
		 get { } //Length: 40
	}

	public NativeParallelMultiHashMap`2(int capacity, AllocatorHandle allocator) { }

	public void Add(TKey key, TValue item) { }

	public override void Dispose() { }

	[IsReadOnly]
	public bool get_IsCreated() { }

	[GenerateTestsForBurstCompatibility(GenericTypeArguments = new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {typeof(AllocatorHandle)}])]
	internal void Initialize(int capacity, ref U allocator) { }

	public int Remove(TKey key) { }

	public void Remove(NativeParallelMultiHashMapIterator<TKey> it) { }

	private override IEnumerator<KeyValue`2<TKey, TValue>> System.Collections.Generic.IEnumerable<Unity.Collections.LowLevel.Unsafe.KeyValue<TKey,TValue>>.GetEnumerator() { }

	private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	public bool TryGetFirstValue(TKey key, out TValue item, out NativeParallelMultiHashMapIterator<TKey>& it) { }

	public bool TryGetNextValue(out TValue item, ref NativeParallelMultiHashMapIterator<TKey>& it) { }

}

