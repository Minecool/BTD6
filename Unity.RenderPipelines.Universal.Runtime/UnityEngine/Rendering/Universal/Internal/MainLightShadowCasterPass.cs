namespace UnityEngine.Rendering.Universal.Internal;

public class MainLightShadowCasterPass : ScriptableRenderPass
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static BaseRenderFunc<PassData, RasterGraphContext> <>9__39_0; //Field offset: 0x8

		private static <>c() { }

		public <>c() { }

		internal void <Render>b__39_0(PassData data, RasterGraphContext context) { }

	}

	private static class MainLightShadowConstantBuffer
	{
		public static readonly int _WorldToShadow; //Field offset: 0x0
		public static readonly int _ShadowParams; //Field offset: 0x4
		public static readonly int _CascadeShadowSplitSpheres0; //Field offset: 0x8
		public static readonly int _CascadeShadowSplitSpheres1; //Field offset: 0xC
		public static readonly int _CascadeShadowSplitSpheres2; //Field offset: 0x10
		public static readonly int _CascadeShadowSplitSpheres3; //Field offset: 0x14
		public static readonly int _CascadeShadowSplitSphereRadii; //Field offset: 0x18
		public static readonly int _ShadowOffset0; //Field offset: 0x1C
		public static readonly int _ShadowOffset1; //Field offset: 0x20
		public static readonly int _ShadowmapSize; //Field offset: 0x24
		public static readonly int _MainLightShadowmapID; //Field offset: 0x28

		private static MainLightShadowConstantBuffer() { }

	}

	private class PassData
	{
		internal bool emptyShadowmap; //Field offset: 0x10
		internal bool setKeywordForEmptyShadowmap; //Field offset: 0x11
		internal UniversalRenderingData renderingData; //Field offset: 0x18
		internal UniversalCameraData cameraData; //Field offset: 0x20
		internal UniversalLightData lightData; //Field offset: 0x28
		internal UniversalShadowData shadowData; //Field offset: 0x30
		internal MainLightShadowCasterPass pass; //Field offset: 0x38
		internal TextureHandle shadowmapTexture; //Field offset: 0x40
		internal readonly RendererList[] shadowRendererLists; //Field offset: 0x50
		internal readonly RendererListHandle[] shadowRendererListsHandle; //Field offset: 0x58

		public PassData() { }

	}

	private const string k_EmptyMainLightShadowMapTextureName = "_EmptyMainLightShadowmapTexture"; //Field offset: 0x0
	private const string k_MainLightShadowMapTextureName = "_MainLightShadowmapTexture"; //Field offset: 0x0
	private const int k_ShadowmapBufferBits = 16; //Field offset: 0x0
	private const int k_MaxCascades = 4; //Field offset: 0x0
	private const int k_EmptyShadowMapDimensions = 1; //Field offset: 0x0
	private static Vector4 s_EmptyShadowParams; //Field offset: 0x0
	private static readonly Vector4 s_EmptyShadowmapSize; //Field offset: 0x10
	internal RTHandle m_MainLightShadowmapTexture; //Field offset: 0xB8
	private int renderTargetWidth; //Field offset: 0xC0
	private int renderTargetHeight; //Field offset: 0xC4
	private int m_ShadowCasterCascadesCount; //Field offset: 0xC8
	private bool m_CreateEmptyShadowmap; //Field offset: 0xCC
	private bool m_SetKeywordForEmptyShadowmap; //Field offset: 0xCD
	private bool m_EmptyShadowmapNeedsClear; //Field offset: 0xCE
	private float m_CascadeBorder; //Field offset: 0xD0
	private float m_MaxShadowDistanceSq; //Field offset: 0xD4
	private PassData m_PassData; //Field offset: 0xD8
	private RTHandle m_EmptyMainLightShadowmapTexture; //Field offset: 0xE0
	private RenderTextureDescriptor m_MainLightShadowDescriptor; //Field offset: 0xE8
	private readonly Vector4[] m_CascadeSplitDistances; //Field offset: 0x120
	private readonly Matrix4x4[] m_MainLightShadowMatrices; //Field offset: 0x128
	private readonly ProfilingSampler m_ProfilingSetupSampler; //Field offset: 0x130
	private readonly ShadowSliceData[] m_CascadeSlices; //Field offset: 0x138

	private static MainLightShadowCasterPass() { }

	public MainLightShadowCasterPass(RenderPassEvent evt) { }

	private void Clear() { }

	[Obsolete("This rendering path is for compatibility mode only (when Render Graph is disabled). Use Render Graph API instead.", False)]
	public virtual void Configure(CommandBuffer cmd, RenderTextureDescriptor cameraTextureDescriptor) { }

	public void Dispose() { }

	[Obsolete("This rendering path is for compatibility mode only (when Render Graph is disabled). Use Render Graph API instead.", False)]
	public virtual void Execute(ScriptableRenderContext context, ref RenderingData renderingData) { }

	private void InitPassData(ref PassData passData, UniversalRenderingData renderingData, UniversalCameraData cameraData, UniversalLightData lightData, UniversalShadowData shadowData) { }

	private void InitRendererLists(ref PassData passData, ScriptableRenderContext context, RenderGraph renderGraph, bool useRenderGraph) { }

	internal TextureHandle Render(RenderGraph graph, ContextContainer frameData) { }

	private void RenderMainLightCascadeShadowmap(RasterCommandBuffer cmd, ref PassData data, bool isRenderGraph) { }

	internal static void SetShadowParamsForEmptyShadowmap(RasterCommandBuffer rasterCommandBuffer) { }

	public bool Setup(ref RenderingData renderingData) { }

	public bool Setup(UniversalRenderingData renderingData, UniversalCameraData cameraData, UniversalLightData lightData, UniversalShadowData shadowData) { }

	private bool SetupForEmptyRendering(bool stripShadowsOffVariants, bool shadowsEnabled, Light light, UniversalCameraData cameraData, UniversalShadowData shadowData) { }

	private void SetupMainLightShadowReceiverConstants(RasterCommandBuffer cmd, ref VisibleLight shadowLight, UniversalShadowData shadowData) { }

	private void UpdateTextureDescriptorIfNeeded() { }

}

