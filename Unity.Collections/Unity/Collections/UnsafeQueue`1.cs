namespace Unity.Collections;

[GenerateTestsForBurstCompatibility(GenericTypeArguments = new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {typeof(int}])]
public struct UnsafeQueue : IDisposable
{
	[NativeDisableUnsafePtrRestriction]
	internal UnsafeQueueData* m_Buffer; //Field offset: 0x0
	[NativeDisableUnsafePtrRestriction]
	internal UnsafeQueueBlockPoolData* m_QueuePool; //Field offset: 0x0
	internal AllocatorHandle m_AllocatorLabel; //Field offset: 0x0

	public bool IsCreated
	{
		[IsReadOnly]
		 get { } //Length: 8
	}

	public UnsafeQueue`1(AllocatorHandle allocator) { }

	internal static UnsafeQueue<T>* Alloc(AllocatorHandle allocator) { }

	public T Dequeue() { }

	public override void Dispose() { }

	public void Enqueue(T value) { }

	internal static void Free(UnsafeQueue<T>* data) { }

	[IsReadOnly]
	public bool get_IsCreated() { }

	[IsReadOnly]
	public bool IsEmpty() { }

	public T Peek() { }

	public bool TryDequeue(out T item) { }

}

