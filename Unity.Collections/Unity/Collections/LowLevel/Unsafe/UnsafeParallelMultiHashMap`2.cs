namespace Unity.Collections.LowLevel.Unsafe;

[DebuggerTypeProxy(typeof(UnsafeParallelMultiHashMapDebuggerTypeProxy`2))]
[GenerateTestsForBurstCompatibility(GenericTypeArguments = new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {typeof(int, typeof(int}])]
public struct UnsafeParallelMultiHashMap : IDisposable, IEnumerable<KeyValue`2<TKey, TValue>>, IEnumerable
{
	[NativeDisableUnsafePtrRestriction]
	internal UnsafeParallelHashMapData* m_Buffer; //Field offset: 0x0
	internal AllocatorHandle m_AllocatorLabel; //Field offset: 0x0

	public bool IsCreated
	{
		[IsReadOnly]
		 get { } //Length: 8
	}

	public UnsafeParallelMultiHashMap`2(int capacity, AllocatorHandle allocator) { }

	public void Add(TKey key, TValue item) { }

	public void Clear() { }

	public override void Dispose() { }

	[IsReadOnly]
	public bool get_IsCreated() { }

	public int Remove(TKey key) { }

	public void Remove(NativeParallelMultiHashMapIterator<TKey> it) { }

	private override IEnumerator<KeyValue`2<TKey, TValue>> System.Collections.Generic.IEnumerable<Unity.Collections.LowLevel.Unsafe.KeyValue<TKey,TValue>>.GetEnumerator() { }

	private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	[IsReadOnly]
	public bool TryGetFirstValue(TKey key, out TValue item, out NativeParallelMultiHashMapIterator<TKey>& it) { }

	[IsReadOnly]
	public bool TryGetNextValue(out TValue item, ref NativeParallelMultiHashMapIterator<TKey>& it) { }

}

