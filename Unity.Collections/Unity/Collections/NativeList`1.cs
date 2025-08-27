namespace Unity.Collections;

[DebuggerDisplay("Length = {m_ListData == null ? default : m_ListData->Length}, Capacity = {m_ListData == null ? default : m_ListData->Capacity}")]
[DebuggerTypeProxy(typeof(NativeListDebugView`1))]
[DefaultMember("Item")]
[GenerateTestsForBurstCompatibility(GenericTypeArguments = new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {typeof(int}])]
[NativeContainer]
public struct NativeList : IDisposable, INativeList<T>, IIndexable<T>, IEnumerable<T>, IEnumerable
{
	[GenerateTestsForBurstCompatibility(GenericTypeArguments = new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {typeof(int}])]
	[NativeContainer]
	[NativeContainerIsAtomicWriteOnly]
	internal struct ParallelWriter
	{
		[NativeDisableUnsafePtrRestriction]
		public UnsafeList<T>* ListData; //Field offset: 0x0

		internal ParallelWriter(UnsafeList<T>* listData) { }

		public void AddRangeNoResize(Void* ptr, int count) { }

	}

	[NativeDisableUnsafePtrRestriction]
	internal UnsafeList<T>* m_ListData; //Field offset: 0x0

	public override int Capacity
	{
		[IsReadOnly]
		 get { } //Length: 36
		 set { } //Length: 67
	}

	public bool IsCreated
	{
		[IsReadOnly]
		 get { } //Length: 8
	}

	public override bool IsEmpty
	{
		[IsReadOnly]
		 get { } //Length: 53
	}

	public override T Item
	{
		 get { } //Length: 140
		 set { } //Length: 137
	}

	public override int Length
	{
		[IsReadOnly]
		 get { } //Length: 36
		 set { } //Length: 73
	}

	public NativeList`1(AllocatorHandle allocator) { }

	public NativeList`1(int initialCapacity, AllocatorHandle allocator) { }

	public void Add(in T value) { }

	public void AddRange(Void* ptr, int count) { }

	public void AddRange(NativeArray<T> array) { }

	public NativeArray<T> AsArray() { }

	public NativeArray<T> AsDeferredJobArray() { }

	public ParallelWriter<T> AsParallelWriter() { }

	public override void Clear() { }

	public override void Dispose() { }

	public override JobHandle Dispose(JobHandle inputDeps) { }

	public override T ElementAt(int index) { }

	[IsReadOnly]
	public override int get_Capacity() { }

	[IsReadOnly]
	public bool get_IsCreated() { }

	[IsReadOnly]
	public override bool get_IsEmpty() { }

	public override T get_Item(int index) { }

	[IsReadOnly]
	public override int get_Length() { }

	public Enumerator<T> GetEnumerator() { }

	public UnsafeList<T>* GetUnsafeList() { }

	[GenerateTestsForBurstCompatibility(GenericTypeArguments = new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {typeof(AllocatorHandle)}])]
	internal void Initialize(int initialCapacity, ref U allocator) { }

	public void RemoveAt(int index) { }

	public void RemoveAtSwapBack(int index) { }

	public void Resize(int length, NativeArrayOptions options) { }

	public void ResizeUninitialized(int length) { }

	public override void set_Capacity(int value) { }

	public override void set_Item(int index, T value) { }

	public override void set_Length(int value) { }

	public void SetCapacity(int capacity) { }

	private override IEnumerator<T> System.Collections.Generic.IEnumerable<T>.GetEnumerator() { }

	private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

}

