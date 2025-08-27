namespace Unity.Collections.LowLevel.Unsafe;

[DebuggerDisplay("Length = {Length}, Capacity = {Capacity}, IsCreated = {IsCreated}, IsEmpty = {IsEmpty}")]
[DebuggerTypeProxy(typeof(UnsafeRingQueueDebugView`1))]
[GenerateTestsForBurstCompatibility(GenericTypeArguments = new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {typeof(int}])]
public struct UnsafeRingQueue : IDisposable
{
	[NativeDisableUnsafePtrRestriction]
	public T* Ptr; //Field offset: 0x0
	public AllocatorHandle Allocator; //Field offset: 0x0
	internal readonly int m_Capacity; //Field offset: 0x0
	internal int m_Filled; //Field offset: 0x0
	internal int m_Write; //Field offset: 0x0
	internal int m_Read; //Field offset: 0x0

	public bool IsCreated
	{
		[IsReadOnly]
		 get { } //Length: 8
	}

	public override void Dispose() { }

	internal static void Free(UnsafeRingQueue<T>* data) { }

	[IsReadOnly]
	public bool get_IsCreated() { }

}

