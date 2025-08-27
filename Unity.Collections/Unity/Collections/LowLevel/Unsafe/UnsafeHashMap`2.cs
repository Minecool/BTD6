namespace Unity.Collections.LowLevel.Unsafe;

[DebuggerTypeProxy(typeof(UnsafeHashMapDebuggerTypeProxy`2))]
[DefaultMember("Item")]
[GenerateTestsForBurstCompatibility(GenericTypeArguments = new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {typeof(int, typeof(int}])]
public struct UnsafeHashMap : IDisposable, IEnumerable<KVPair`2<TKey, TValue>>, IEnumerable
{
	[NativeDisableUnsafePtrRestriction]
	internal HashMapHelper<TKey> m_Data; //Field offset: 0x0

	public bool IsCreated
	{
		[IsReadOnly]
		 get { } //Length: 40
	}

	public override void Dispose() { }

	[IsReadOnly]
	public bool get_IsCreated() { }

	private override IEnumerator<KVPair`2<TKey, TValue>> System.Collections.Generic.IEnumerable<Unity.Collections.KVPair<TKey,TValue>>.GetEnumerator() { }

	private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

}

