namespace UnityEngine.Rendering;

[BurstCompile(DisableSafetyChecks = True, OptimizeFor = OptimizeFor::Performance (1))]
internal struct FindNonRegisteredMeshesJob : IJobParallelForBatch
{
	[ReadOnly]
	public NativeArray<Int32> instanceIDs; //Field offset: 0x0
	[ReadOnly]
	public NativeParallelHashMap<Int32, BatchMeshID> hashMap; //Field offset: 0x10
	[WriteOnly]
	public ParallelWriter<Int32> outInstancesWriter; //Field offset: 0x20

	public override void Execute(int startIndex, int count) { }

}

