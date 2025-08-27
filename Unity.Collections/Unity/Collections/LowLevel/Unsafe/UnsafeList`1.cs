namespace Unity.Collections.LowLevel.Unsafe;

[BurstCompatible(GenericTypeArguments = new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {typeof(int}])]
[DebuggerDisplay("Length = {Length}, Capacity = {Capacity}, IsCreated = {IsCreated}, IsEmpty = {IsEmpty}")]
[DebuggerTypeProxy(typeof(UnsafeListTDebugView`1))]
[DefaultMember("Item")]
public struct UnsafeList : IDisposable, IEnumerable<T>, IEnumerable
{
	[NativeDisableUnsafePtrRestriction]
	public T* Ptr; //Field offset: 0x0
	public int m_length; //Field offset: 0x0
	public int m_capacity; //Field offset: 0x0
	public AllocatorHandle Allocator; //Field offset: 0x0
	[Obsolete("Use Length property (UnityUpgradable) -> Length", True)]
	public int length; //Field offset: 0x0
	[Obsolete("Use Capacity property (UnityUpgradable) -> Capacity", True)]
	public int capacity; //Field offset: 0x0

	public override int Capacity
	{
		 get { } //Length: 10
	}

	public override T Item
	{
		 get { } //Length: 185
	}

	public override int Length
	{
		 get { } //Length: 10
	}

	public void Add(in T value) { }

	public override void Clear() { }

	[BurstCompatible(GenericTypeArguments = new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {typeof(AllocatorHandle)}])]
	internal static UnsafeList<T>* Create(int initialCapacity, ref U allocator, NativeArrayOptions options = 0) { }

	public static void Destroy(UnsafeList<T>* listData) { }

	public override void Dispose() { }

	public override int get_Capacity() { }

	public override T get_Item(int index) { }

	public override int get_Length() { }

	private void Realloc(ref U allocator, int newCapacity) { }

	public void Resize(int length, NativeArrayOptions options = 0) { }

	private void SetCapacity(ref U allocator, int capacity) { }

	public void SetCapacity(int capacity) { }

	private override IEnumerator<T> System.Collections.Generic.IEnumerable<T>.GetEnumerator() { }

	private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

}

