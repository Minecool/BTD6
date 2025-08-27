namespace UnityEngine.Rendering;

[BurstCompile(DisableSafetyChecks = True, OptimizeFor = OptimizeFor::Performance (1))]
internal struct RegisterNewMaterialsJob : IJobParallelFor
{
	[ReadOnly]
	public NativeArray<Int32> instanceIDs; //Field offset: 0x0
	[ReadOnly]
	public NativeArray<GPUDrivenPackedMaterialData> packedMaterialDatas; //Field offset: 0x10
	[ReadOnly]
	public NativeArray<BatchMaterialID> batchIDs; //Field offset: 0x20
	[WriteOnly]
	public ParallelWriter<Int32, BatchMaterialID> batchMaterialHashMap; //Field offset: 0x30
	[WriteOnly]
	public ParallelWriter<Int32, GPUDrivenPackedMaterialData> packedMaterialHashMap; //Field offset: 0x40

	public override void Execute(int index) { }

}

