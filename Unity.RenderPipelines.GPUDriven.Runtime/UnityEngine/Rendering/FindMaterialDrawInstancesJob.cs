namespace UnityEngine.Rendering;

[BurstCompile(DisableSafetyChecks = True, OptimizeFor = OptimizeFor::Performance (1))]
internal struct FindMaterialDrawInstancesJob : IJobParallelForBatch
{
	[ReadOnly]
	public NativeArray<UInt32> materialsSorted; //Field offset: 0x0
	[NativeDisableContainerSafetyRestriction]
	[NoAlias]
	[ReadOnly]
	public NativeList<DrawInstance> drawInstances; //Field offset: 0x10
	[WriteOnly]
	public ParallelWriter<Int32> outDrawInstanceIndicesWriter; //Field offset: 0x18

	public override void Execute(int startIndex, int count) { }

}

