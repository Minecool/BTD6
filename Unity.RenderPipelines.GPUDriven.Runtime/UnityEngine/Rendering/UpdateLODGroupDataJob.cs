namespace UnityEngine.Rendering;

[BurstCompile(DisableSafetyChecks = True, OptimizeFor = OptimizeFor::Performance (1))]
internal struct UpdateLODGroupDataJob : IJobParallelFor
{
	[ReadOnly]
	public NativeArray<GPUInstanceIndex> lodGroupInstances; //Field offset: 0x0
	[ReadOnly]
	public GPUDrivenLODGroupData inputData; //Field offset: 0x10
	[ReadOnly]
	public bool supportDitheringCrossFade; //Field offset: 0xE0
	public NativeArray<LODGroupData> lodGroupsData; //Field offset: 0xE8
	public NativeArray<LODGroupCullingData> lodGroupsCullingData; //Field offset: 0xF8
	[NativeDisableUnsafePtrRestriction]
	public UnsafeAtomicCounter32 rendererCount; //Field offset: 0x108

	public override void Execute(int index) { }

}

