namespace UnityEngine.Rendering;

[Flags]
public enum FoveatedRenderingCaps
{
	None = 0,
	FoveationImage = 1,
	NonUniformRaster = 2,
	ModeChangeOnlyBeforeRenderTargetSet = 4,
}

