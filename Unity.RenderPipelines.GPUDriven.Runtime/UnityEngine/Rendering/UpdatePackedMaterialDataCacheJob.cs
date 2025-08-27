namespace UnityEngine.Rendering;

[BurstCompile(DisableSafetyChecks = True, OptimizeFor = OptimizeFor::Performance (1))]
internal struct UpdatePackedMaterialDataCacheJob : IJob
{
	[ReadOnly]
	public ReadOnly<Int32> materialIDs; //Field offset: 0x0
	[ReadOnly]
	public ReadOnly<GPUDrivenPackedMaterialData> packedMaterialDatas; //Field offset: 0x10
	public NativeParallelHashMap<Int32, GPUDrivenPackedMaterialData> packedMaterialHash; //Field offset: 0x20

	public override void Execute() { }

	private void ProcessMaterial(int i) { }

}

