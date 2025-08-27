namespace Unity.Collections.LowLevel.Unsafe;

[DebuggerDisplay("Length = {Length}, Capacity = {Capacity}, IsCreated = {IsCreated}, IsEmpty = {IsEmpty}")]
[DebuggerTypeProxy(typeof(UnsafeListTDebugView`1))]
[DefaultMember("Item")]
[GenerateTestsForBurstCompatibility(GenericTypeArguments = new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {typeof(int}])]
public struct UnsafeList : IDisposable, INativeList<T>, IIndexable<T>, IEnumerable<T>, IEnumerable
{
	[NativeDisableUnsafePtrRestriction]
	public T* Ptr; //Field offset: 0x0
	public int m_length; //Field offset: 0x0
	public int m_capacity; //Field offset: 0x0
	public AllocatorHandle Allocator; //Field offset: 0x0
	private readonly int padding; //Field offset: 0x0

	public override int Capacity
	{
		[IsReadOnly]
		 get { } //Length: 4
		 set { } //Length: 114
	}

	public bool IsCreated
	{
		[IsReadOnly]
		 get { } //Length: 8
	}

	public override T Item
	{
		 get { } //Length: 94
		 set { } //Length: 91
	}

	public override int Length
	{
		[IsReadOnly]
		 get { } //Length: 4
		 set { } //Length: 125
	}

	public UnsafeList`1(T* ptr, int length) { }

	public UnsafeList`1(int initialCapacity, AllocatorHandle allocator, NativeArrayOptions options = 0) { }

	public void Add(in T value) { }

	public void AddNoResize(T value) { }

	public void AddRange(Void* ptr, int count) { }

	public override void Clear() { }

	[GenerateTestsForBurstCompatibility(GenericTypeArguments = new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {typeof(AllocatorHandle)}])]
	internal static UnsafeList<T>* Create(int initialCapacity, ref U allocator, NativeArrayOptions options) { }

	public static void Destroy(UnsafeList<T>* listData) { }

	public override void Dispose() { }

	public override T ElementAt(int index) { }

	[IsReadOnly]
	public override int get_Capacity() { }

	[IsReadOnly]
	public bool get_IsCreated() { }

	public override T get_Item(int index) { }

	[IsReadOnly]
	public override int get_Length() { }

	public void RemoveAt(int index) { }

	public void RemoveAtSwapBack(int index) { }

	public void Resize(int length, NativeArrayOptions options = 0) { }

	private void ResizeExact(ref U allocator, int newCapacity) { }

	public override void set_Capacity(int value) { }

	public override void set_Item(int index, T value) { }

	public override void set_Length(int value) { }

	private void SetCapacity(ref U allocator, int capacity) { }

	public void SetCapacity(int capacity) { }

	private override IEnumerator<T> System.Collections.Generic.IEnumerable<T>.GetEnumerator() { }

	private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

}

