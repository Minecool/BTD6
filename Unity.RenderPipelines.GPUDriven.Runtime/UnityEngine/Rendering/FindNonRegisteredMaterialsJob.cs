namespace UnityEngine.Rendering;

[BurstCompile(DisableSafetyChecks = True, OptimizeFor = OptimizeFor::Performance (1))]
internal struct FindNonRegisteredMaterialsJob : IJobParallelForBatch
{
	[ReadOnly]
	public NativeArray<Int32> instanceIDs; //Field offset: 0x0
	[ReadOnly]
	public NativeArray<GPUDrivenPackedMaterialData> packedMaterialDatas; //Field offset: 0x10
	[ReadOnly]
	public NativeParallelHashMap<Int32, BatchMaterialID> hashMap; //Field offset: 0x20
	[WriteOnly]
	public ParallelWriter<Int32> outInstancesWriter; //Field offset: 0x30
	[WriteOnly]
	public ParallelWriter<GPUDrivenPackedMaterialData> outPackedMaterialDatasWriter; //Field offset: 0x38

	public override void Execute(int startIndex, int count) { }

}

