namespace UnityEngine.Rendering;

[BurstCompile(DisableSafetyChecks = True, OptimizeFor = OptimizeFor::Performance (1))]
internal struct CreateDrawBatchesJob : IJob
{
	[ReadOnly]
	public bool implicitInstanceIndices; //Field offset: 0x0
	[ReadOnly]
	public NativeArray<InstanceHandle> instances; //Field offset: 0x8
	[ReadOnly]
	public GPUDrivenRendererGroupData rendererData; //Field offset: 0x18
	[ReadOnly]
	public ReadOnly<Int32, BatchMeshID> batchMeshHash; //Field offset: 0x1D8
	[ReadOnly]
	public ReadOnly<Int32, BatchMaterialID> batchMaterialHash; //Field offset: 0x1E8
	[ReadOnly]
	public ReadOnly<Int32, GPUDrivenPackedMaterialData> packedMaterialDataHash; //Field offset: 0x1F8
	public NativeParallelHashMap<RangeKey, Int32> rangeHash; //Field offset: 0x208
	public NativeList<DrawRange> drawRanges; //Field offset: 0x218
	public NativeParallelHashMap<DrawKey, Int32> batchHash; //Field offset: 0x220
	public NativeList<DrawBatch> drawBatches; //Field offset: 0x230
	[WriteOnly]
	public NativeList<DrawInstance> drawInstances; //Field offset: 0x238

	private DrawBatch EditDrawBatch(in DrawKey key, in SubMeshDescriptor subMeshDescriptor) { }

	private DrawRange EditDrawRange(in RangeKey key) { }

	public override void Execute() { }

	public void ProcessRenderer(int i) { }

}

