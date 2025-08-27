namespace Unity.Collections;

[GenerateTestsForBurstCompatibility(GenericTypeArguments = new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {typeof(int}])]
[NativeContainer]
public struct NativeQueue : IDisposable
{
	[NativeDisableUnsafePtrRestriction]
	private UnsafeQueue<T>* m_Queue; //Field offset: 0x0

	public bool IsCreated
	{
		[IsReadOnly]
		 get { } //Length: 53
	}

	public NativeQueue`1(AllocatorHandle allocator) { }

	public T Dequeue() { }

	public override void Dispose() { }

	public void Enqueue(T value) { }

	[IsReadOnly]
	public bool get_IsCreated() { }

	[IsReadOnly]
	public bool IsEmpty() { }

	public T Peek() { }

	public bool TryDequeue(out T item) { }

}

