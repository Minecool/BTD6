namespace UnityEngine.Rendering;

internal struct CPUSharedInstanceData : IDisposable
{
	[IsReadOnly]
	public struct ReadOnly
	{
		public readonly ReadOnly<Int32> instanceIndices; //Field offset: 0x0
		public readonly ReadOnly<SharedInstanceHandle> instances; //Field offset: 0x10
		public readonly ReadOnly<Int32> rendererGroupIDs; //Field offset: 0x20
		public readonly ReadOnly<SmallIntegerArray> materialIDArrays; //Field offset: 0x30
		public readonly ReadOnly<Int32> meshIDs; //Field offset: 0x40
		public readonly ReadOnly<AABB> localAABBs; //Field offset: 0x50
		public readonly ReadOnly<CPUSharedInstanceFlags> flags; //Field offset: 0x60
		public readonly ReadOnly<UInt32> lodGroupAndMasks; //Field offset: 0x70
		public readonly ReadOnly<Int32> gameObjectLayers; //Field offset: 0x80
		public readonly ReadOnly<Int32> refCounts; //Field offset: 0x90

		public ReadOnly(in CPUSharedInstanceData instanceData) { }

		public int InstanceToIndex(in ReadOnly instanceData, InstanceHandle instance) { }

		public int SharedInstanceToIndex(SharedInstanceHandle instance) { }

	}

	private NativeArray<Int32> m_StructData; //Field offset: 0x0
	private NativeList<Int32> m_InstanceIndices; //Field offset: 0x10
	public NativeArray<SharedInstanceHandle> instances; //Field offset: 0x18
	public NativeArray<Int32> rendererGroupIDs; //Field offset: 0x28
	public NativeArray<SmallIntegerArray> materialIDArrays; //Field offset: 0x38
	public NativeArray<Int32> meshIDs; //Field offset: 0x48
	public NativeArray<AABB> localAABBs; //Field offset: 0x58
	public NativeArray<CPUSharedInstanceFlags> flags; //Field offset: 0x68
	public NativeArray<UInt32> lodGroupAndMasks; //Field offset: 0x78
	public NativeArray<Int32> gameObjectLayers; //Field offset: 0x88
	public NativeArray<Int32> refCounts; //Field offset: 0x98

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

	public void AddNoGrow(SharedInstanceHandle instance) { }

	private void AddUnsafe(SharedInstanceHandle instance) { }

	public ReadOnly AsReadOnly() { }

	public override void Dispose() { }

	public void EnsureFreeInstances(int instancesCount) { }

	public int get_instancesCapacity() { }

	public int get_instancesLength() { }

	public int Get_MeshID(SharedInstanceHandle instance) { }

	public int Get_RefCount(SharedInstanceHandle instance) { }

	public int Get_RendererGroupID(SharedInstanceHandle instance) { }

	public int GetFreeInstancesCount() { }

	private void Grow(int newCapacity) { }

	public void Initialize(int initCapacity) { }

	public int InstanceToIndex(in CPUInstanceData instanceData, InstanceHandle instance) { }

	public void Remove(SharedInstanceHandle instance) { }

	public void Set(SharedInstanceHandle instance, int rendererGroupID, in SmallIntegerArray materialIDs, int meshID, in AABB localAABB, TransformUpdateFlags transformUpdateFlags, InstanceFlags instanceFlags, uint lodGroupAndMask, int gameObjectLayer, int refCount) { }

	public void set_instancesCapacity(int value) { }

	public void set_instancesLength(int value) { }

	public void Set_RefCount(SharedInstanceHandle instance, int refCount) { }

	public void SetDefault(SharedInstanceHandle instance) { }

	public int SharedInstanceToIndex(SharedInstanceHandle instance) { }

}

