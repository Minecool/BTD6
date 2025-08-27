namespace Unity.Collections.LowLevel.Unsafe;

[DebuggerDisplay("Length = {Length}, IsCreated = {IsCreated}")]
[DebuggerTypeProxy(typeof(UnsafeBitArrayDebugView))]
[GenerateTestsForBurstCompatibility]
public struct UnsafeBitArray : IDisposable
{
	[NativeDisableUnsafePtrRestriction]
	public UInt64* Ptr; //Field offset: 0x0
	public int Length; //Field offset: 0x8
	public int Capacity; //Field offset: 0xC
	public AllocatorHandle Allocator; //Field offset: 0x10

	public bool IsCreated
	{
		[IsReadOnly]
		 get { } //Length: 8
	}

	public override void Dispose() { }

	internal static void Free(UnsafeBitArray* data, AllocatorHandle allocator) { }

	[IsReadOnly]
	public bool get_IsCreated() { }

}

