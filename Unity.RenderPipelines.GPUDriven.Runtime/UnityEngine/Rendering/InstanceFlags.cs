namespace UnityEngine.Rendering;

[Flags]
internal enum InstanceFlags
{
	None = 0,
	AffectsLightmaps = 1,
	IsShadowsOff = 2,
	IsShadowsOnly = 4,
	HasProgressiveLod = 8,
	SmallMeshCulling = 16,
}

