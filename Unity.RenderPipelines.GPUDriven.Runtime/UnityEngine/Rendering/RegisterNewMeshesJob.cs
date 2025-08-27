namespace UnityEngine.Rendering;

[BurstCompile(DisableSafetyChecks = True, OptimizeFor = OptimizeFor::Performance (1))]
internal struct RegisterNewMeshesJob : IJobParallelFor
{
	[ReadOnly]
	public NativeArray<Int32> instanceIDs; //Field offset: 0x0
	[ReadOnly]
	public NativeArray<BatchMeshID> batchIDs; //Field offset: 0x10
	[WriteOnly]
	public ParallelWriter<Int32, BatchMeshID> hashMap; //Field offset: 0x20

	public override void Execute(int index) { }

}

