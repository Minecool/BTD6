namespace UnityEngine.Rendering;

internal struct CPUInstanceData : IDisposable
{
	[IsReadOnly]
	public struct ReadOnly
	{
		public readonly ReadOnly<Int32> instanceIndices; //Field offset: 0x0
		public readonly ReadOnly<InstanceHandle> instances; //Field offset: 0x10
		public readonly ReadOnly<SharedInstanceHandle> sharedInstances; //Field offset: 0x20
		public readonly ParallelBitArray localToWorldIsFlippedBits; //Field offset: 0x30
		public readonly ReadOnly<AABB> worldAABBs; //Field offset: 0x50
		public readonly ReadOnly<Int32> tetrahedronCacheIndices; //Field offset: 0x60
		public readonly ParallelBitArray movedInCurrentFrameBits; //Field offset: 0x70
		public readonly ParallelBitArray movedInPreviousFrameBits; //Field offset: 0x90
		public readonly ParallelBitArray visibleInPreviousFrameBits; //Field offset: 0xB0
		public readonly ReadOnly editorData; //Field offset: 0xD0

		public int handlesLength
		{
			 get { } //Length: 55
		}

		public int instancesLength
		{
			 get { } //Length: 56
		}

		public ReadOnly(in CPUInstanceData instanceData) { }

		public int get_handlesLength() { }

		public int get_instancesLength() { }

		public int InstanceToIndex(InstanceHandle instance) { }

	}

	private NativeArray<Int32> m_StructData; //Field offset: 0x0
	private NativeList<Int32> m_InstanceIndices; //Field offset: 0x10
	public NativeArray<InstanceHandle> instances; //Field offset: 0x18
	public NativeArray<SharedInstanceHandle> sharedInstances; //Field offset: 0x28
	public ParallelBitArray localToWorldIsFlippedBits; //Field offset: 0x38
	public NativeArray<AABB> worldAABBs; //Field offset: 0x58
	public NativeArray<Int32> tetrahedronCacheIndices; //Field offset: 0x68
	public ParallelBitArray movedInCurrentFrameBits; //Field offset: 0x78
	public ParallelBitArray movedInPreviousFrameBits; //Field offset: 0x98
	public ParallelBitArray visibleInPreviousFrameBits; //Field offset: 0xB8
	public EditorInstanceDataArrays editorData; //Field offset: 0xD8

	public int instancesCapacity
	{
		 get { } //Length: 7
		 set { } //Length: 7
	}

	public int instancesLength
	{
		 get { } //Length: 6
		 set { } //Length: 6
	}

	public void AddNoGrow(InstanceHandle instance) { }

	private void AddUnsafe(InstanceHandle instance) { }

	public ReadOnly AsReadOnly() { }

	public override void Dispose() { }

	public void EnsureFreeInstances(int instancesCount) { }

	public int get_instancesCapacity() { }

	public int get_instancesLength() { }

	public SharedInstanceHandle Get_SharedInstance(InstanceHandle instance) { }

	public int GetFreeInstancesCount() { }

	private void Grow(int newCapacity) { }

	public InstanceHandle IndexToInstance(int index) { }

	public void Initialize(int initCapacity) { }

	public int InstanceToIndex(InstanceHandle instance) { }

	public bool IsValidInstance(InstanceHandle instance) { }

	public void Remove(InstanceHandle instance) { }

	public void Set(InstanceHandle instance, SharedInstanceHandle sharedInstance, bool localToWorldIsFlipped, in AABB worldAABB, int tetrahedronCacheIndex, bool movedInCurrentFrame, bool movedInPreviousFrame, bool visibleInPreviousFrame) { }

	public void set_instancesCapacity(int value) { }

	public void set_instancesLength(int value) { }

	public void Set_TetrahedronCacheIndex(InstanceHandle instance, int tetrahedronCacheIndex) { }

	public void SetDefault(InstanceHandle instance) { }

}

