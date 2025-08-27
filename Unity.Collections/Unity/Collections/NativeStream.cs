namespace Unity.Collections;

[GenerateTestsForBurstCompatibility]
[NativeContainer]
public struct NativeStream : IDisposable
{
	[BurstCompile]
	private struct ConstructJob : IJob
	{
		public NativeStream Container; //Field offset: 0x0
		[ReadOnly]
		public NativeArray<Int32> Length; //Field offset: 0x20

		public override void Execute() { }

	}

	[BurstCompile]
	private struct ConstructJobList : IJob
	{
		public NativeStream Container; //Field offset: 0x0
		[NativeDisableUnsafePtrRestriction]
		[ReadOnly]
		public UntypedUnsafeList* List; //Field offset: 0x20

		public override void Execute() { }

	}

	private UnsafeStream m_Stream; //Field offset: 0x0

	public bool IsCreated
	{
		[IsReadOnly]
		 get { } //Length: 8
	}

	private void AllocateForEach(int forEachCount) { }

	public override void Dispose() { }

	[IsReadOnly]
	public bool get_IsCreated() { }

}

