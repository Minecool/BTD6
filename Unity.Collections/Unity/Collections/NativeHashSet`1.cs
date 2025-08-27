namespace Unity.Collections;

[DebuggerTypeProxy(typeof(NativeHashSetDebuggerTypeProxy`1))]
[GenerateTestsForBurstCompatibility(GenericTypeArguments = new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {typeof(int}])]
[NativeContainer]
public struct NativeHashSet : IDisposable, IEnumerable<T>, IEnumerable
{
	[GenerateTestsForBurstCompatibility(GenericTypeArguments = new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {typeof(int}])]
	[NativeContainer]
	[NativeContainerIsReadOnly]
	internal struct ReadOnly : IEnumerable<T>, IEnumerable
	{
		[NativeDisableUnsafePtrRestriction]
		internal HashMapHelper<T>* m_Data; //Field offset: 0x0

		internal ReadOnly(ref NativeHashSet<T>& data) { }

		[IsReadOnly]
		public bool Contains(T item) { }

		private override IEnumerator<T> System.Collections.Generic.IEnumerable<T>.GetEnumerator() { }

		private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	}

	[NativeDisableUnsafePtrRestriction]
	internal HashMapHelper<T>* m_Data; //Field offset: 0x0

	public int Count
	{
		[IsReadOnly]
		 get { } //Length: 25
	}

	public bool IsCreated
	{
		[IsReadOnly]
		 get { } //Length: 53
	}

	public NativeHashSet`1(int initialCapacity, AllocatorHandle allocator) { }

	public bool Add(T item) { }

	public ReadOnly<T> AsReadOnly() { }

	public override void Dispose() { }

	[IsReadOnly]
	public int get_Count() { }

	[IsReadOnly]
	public bool get_IsCreated() { }

	private override IEnumerator<T> System.Collections.Generic.IEnumerable<T>.GetEnumerator() { }

	private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

}

