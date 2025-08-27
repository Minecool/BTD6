namespace UnityEngine.Experimental.Rendering;

public struct XRPassCreateInfo
{
	internal RenderTargetIdentifier renderTarget; //Field offset: 0x0
	internal RenderTextureDescriptor renderTargetDesc; //Field offset: 0x28
	internal ScriptableCullingParameters cullingParameters; //Field offset: 0x60
	internal Material occlusionMeshMaterial; //Field offset: 0x690
	internal float occlusionMeshScale; //Field offset: 0x698
	internal IntPtr foveatedRenderingInfo; //Field offset: 0x6A0
	internal int multipassId; //Field offset: 0x6A8
	internal int cullingPassId; //Field offset: 0x6AC
	internal bool copyDepth; //Field offset: 0x6B0
	internal XRRenderPass xrSdkRenderPass; //Field offset: 0x6B8

}

