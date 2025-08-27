namespace Unity.Collections;

[DebuggerTypeProxy(typeof(NativeHashMapDebuggerTypeProxy`2))]
[DefaultMember("Item")]
[GenerateTestsForBurstCompatibility(GenericTypeArguments = new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {typeof(int, typeof(int}])]
[NativeContainer]
public struct NativeHashMap : IDisposable, IEnumerable<KVPair`2<TKey, TValue>>, IEnumerable
{
	[NativeDisableUnsafePtrRestriction]
	internal HashMapHelper<TKey>* m_Data; //Field offset: 0x0

	public bool IsCreated
	{
		[IsReadOnly]
		 get { } //Length: 53
	}

	public NativeHashMap`2(int initialCapacity, AllocatorHandle allocator) { }

	public void Add(TKey key, TValue item) { }

	public void Clear() { }

	public bool ContainsKey(TKey key) { }

	public override void Dispose() { }

	[IsReadOnly]
	public bool get_IsCreated() { }

	private override IEnumerator<KVPair`2<TKey, TValue>> System.Collections.Generic.IEnumerable<Unity.Collections.KVPair<TKey,TValue>>.GetEnumerator() { }

	private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	public bool TryAdd(TKey key, TValue item) { }

	public bool TryGetValue(TKey key, out TValue item) { }

}

