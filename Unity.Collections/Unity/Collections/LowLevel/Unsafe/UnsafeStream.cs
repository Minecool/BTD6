namespace Unity.Collections.LowLevel.Unsafe;

[GenerateTestsForBurstCompatibility]
public struct UnsafeStream : IDisposable
{
	[BurstCompile]
	private struct ConstructJob : IJob
	{
		public UnsafeStream Container; //Field offset: 0x0
		[ReadOnly]
		public NativeArray<Int32> Length; //Field offset: 0x20

		public override void Execute() { }

	}

	[BurstCompile]
	private struct ConstructJobList : IJob
	{
		public UnsafeStream Container; //Field offset: 0x0
		[NativeDisableUnsafePtrRestriction]
		[ReadOnly]
		public UntypedUnsafeList* List; //Field offset: 0x20

		public override void Execute() { }

	}

	[BurstCompile]
	private struct DisposeJob : IJob
	{
		public UnsafeStream Container; //Field offset: 0x0

		public override void Execute() { }

	}

	[NativeDisableUnsafePtrRestriction]
	internal Block m_BlockData; //Field offset: 0x0

	public bool IsCreated
	{
		[IsReadOnly]
		 get { } //Length: 8
	}

	internal void AllocateForEach(int forEachCount) { }

	private void Deallocate() { }

	public override void Dispose() { }

	[IsReadOnly]
	public bool get_IsCreated() { }

}

