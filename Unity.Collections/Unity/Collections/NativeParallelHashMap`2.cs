namespace Unity.Collections;

[DebuggerDisplay("Count = {m_HashMapData.Count()}, Capacity = {m_HashMapData.Capacity}, IsCreated = {m_HashMapData.IsCreated}, IsEmpty = {IsEmpty}")]
[DebuggerTypeProxy(typeof(NativeParallelHashMapDebuggerTypeProxy`2))]
[DefaultMember("Item")]
[GenerateTestsForBurstCompatibility(GenericTypeArguments = new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {typeof(int, typeof(int}])]
[NativeContainer]
public struct NativeParallelHashMap : IDisposable, IEnumerable<KeyValue`2<TKey, TValue>>, IEnumerable
{
	[NativeContainer]
	[NativeContainerIsReadOnly]
	internal struct Enumerator : IEnumerator<KeyValue`2<TKey, TValue>>, IEnumerator, IDisposable
	{
		internal UnsafeParallelHashMapDataEnumerator m_Enumerator; //Field offset: 0x0

		public override KeyValue<TKey, TValue> Current
		{
			 get { } //Length: 79
		}

		private override object System.Collections.IEnumerator.Current
		{
			private get { } //Length: 153
		}

		public override void Dispose() { }

		public override KeyValue<TKey, TValue> get_Current() { }

		public override bool MoveNext() { }

		public override void Reset() { }

		private override object System.Collections.IEnumerator.get_Current() { }

	}

	[DebuggerDisplay("Capacity = {m_Writer.Capacity}")]
	[GenerateTestsForBurstCompatibility(GenericTypeArguments = new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {typeof(int, typeof(int}])]
	[NativeContainer]
	[NativeContainerIsAtomicWriteOnly]
	internal struct ParallelWriter
	{
		internal ParallelWriter<TKey, TValue> m_Writer; //Field offset: 0x0

		public bool TryAdd(TKey key, TValue item) { }

	}

	[DebuggerDisplay("Count = {m_HashMapData.Count()}, Capacity = {m_HashMapData.Capacity}, IsCreated = {m_HashMapData.IsCreated}, IsEmpty = {IsEmpty}")]
	[DebuggerTypeProxy(typeof(NativeParallelHashMapDebuggerTypeProxy`2))]
	[DefaultMember("Item")]
	[GenerateTestsForBurstCompatibility(GenericTypeArguments = new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {typeof(int, typeof(int}])]
	[NativeContainer]
	[NativeContainerIsReadOnly]
	internal struct ReadOnly : IEnumerable<KeyValue`2<TKey, TValue>>, IEnumerable
	{
		internal UnsafeParallelHashMap<TKey, TValue> m_HashMapData; //Field offset: 0x0

		public TValue Item
		{
			[IsReadOnly]
			 get { } //Length: 150
		}

		internal ReadOnly(UnsafeParallelHashMap<TKey, TValue> hashMapData) { }

		[IsReadOnly]
		public bool ContainsKey(TKey key) { }

		[IsReadOnly]
		public TValue get_Item(TKey key) { }

		private override IEnumerator<KeyValue`2<TKey, TValue>> System.Collections.Generic.IEnumerable<Unity.Collections.LowLevel.Unsafe.KeyValue<TKey,TValue>>.GetEnumerator() { }

		private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

		[IsReadOnly]
		public bool TryGetValue(TKey key, out TValue item) { }

	}

	internal UnsafeParallelHashMap<TKey, TValue> m_HashMapData; //Field offset: 0x0

	public int Capacity
	{
		[IsReadOnly]
		 get { } //Length: 49
		 set { } //Length: 67
	}

	public bool IsCreated
	{
		[IsReadOnly]
		 get { } //Length: 40
	}

	public TValue Item
	{
		 get { } //Length: 144
		 set { } //Length: 125
	}

	public NativeParallelHashMap`2(int capacity, AllocatorHandle allocator) { }

	public void Add(TKey key, TValue item) { }

	public ParallelWriter<TKey, TValue> AsParallelWriter() { }

	public ReadOnly<TKey, TValue> AsReadOnly() { }

	public bool ContainsKey(TKey key) { }

	public int Count() { }

	public override void Dispose() { }

	[IsReadOnly]
	public int get_Capacity() { }

	[IsReadOnly]
	public bool get_IsCreated() { }

	public TValue get_Item(TKey key) { }

	public Enumerator<TKey, TValue> GetEnumerator() { }

	public bool Remove(TKey key) { }

	public void set_Capacity(int value) { }

	public void set_Item(TKey key, TValue value) { }

	private override IEnumerator<KeyValue`2<TKey, TValue>> System.Collections.Generic.IEnumerable<Unity.Collections.LowLevel.Unsafe.KeyValue<TKey,TValue>>.GetEnumerator() { }

	private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	public bool TryAdd(TKey key, TValue item) { }

	public bool TryGetValue(TKey key, out TValue item) { }

}

