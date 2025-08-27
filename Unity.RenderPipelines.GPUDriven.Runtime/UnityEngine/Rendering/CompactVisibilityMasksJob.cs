namespace UnityEngine.Rendering;

[BurstCompile(DisableSafetyChecks = True, OptimizeFor = OptimizeFor::Performance (1))]
internal struct CompactVisibilityMasksJob : IJobParallelForBatch
{
	[ReadOnly]
	public NativeArray<Byte> rendererVisibilityMasks; //Field offset: 0x0
	[NativeDisableContainerSafetyRestriction]
	[NoAlias]
	public ParallelBitArray compactedVisibilityMasks; //Field offset: 0x10

	public override void Execute(int startIndex, int count) { }

}

