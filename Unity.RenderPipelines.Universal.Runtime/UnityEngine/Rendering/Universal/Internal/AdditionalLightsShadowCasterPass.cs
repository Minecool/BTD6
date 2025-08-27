namespace UnityEngine.Rendering.Universal.Internal;

public class AdditionalLightsShadowCasterPass : ScriptableRenderPass
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static BaseRenderFunc<PassData, RasterGraphContext> <>9__64_0; //Field offset: 0x8

		private static <>c() { }

		public <>c() { }

		internal void <Render>b__64_0(PassData data, RasterGraphContext context) { }

	}

	private static class AdditionalShadowsConstantBuffer
	{
		public static readonly int _AdditionalLightsWorldToShadow; //Field offset: 0x0
		public static readonly int _AdditionalShadowParams; //Field offset: 0x4
		public static readonly int _AdditionalShadowOffset0; //Field offset: 0x8
		public static readonly int _AdditionalShadowOffset1; //Field offset: 0xC
		public static readonly int _AdditionalShadowFadeParams; //Field offset: 0x10
		public static readonly int _AdditionalShadowmapSize; //Field offset: 0x14
		public static readonly int _AdditionalLightsShadowmapID; //Field offset: 0x18
		public static readonly int _AdditionalLightsWorldToShadow_SSBO; //Field offset: 0x1C
		public static readonly int _AdditionalShadowParams_SSBO; //Field offset: 0x20

		private static AdditionalShadowsConstantBuffer() { }

	}

	private class PassData
	{
		internal int shadowmapID; //Field offset: 0x10
		internal bool emptyShadowmap; //Field offset: 0x14
		internal bool setKeywordForEmptyShadowmap; //Field offset: 0x15
		internal bool useStructuredBuffer; //Field offset: 0x16
		internal bool stripShadowsOffVariants; //Field offset: 0x17
		internal Matrix4x4 viewMatrix; //Field offset: 0x18
		internal Vector2Int allocatedShadowAtlasSize; //Field offset: 0x58
		internal TextureHandle shadowmapTexture; //Field offset: 0x60
		internal UniversalLightData lightData; //Field offset: 0x70
		internal UniversalShadowData shadowData; //Field offset: 0x78
		internal AdditionalLightsShadowCasterPass pass; //Field offset: 0x80
		internal readonly RendererList[] shadowRendererLists; //Field offset: 0x88
		internal readonly RendererListHandle[] shadowRendererListsHdl; //Field offset: 0x90

		public PassData() { }

	}

	[Obsolete("AdditionalLightsShadowCasterPass.m_AdditionalShadowsBufferId was deprecated. Shadow slice matrix is now passed to the GPU using an entry in buffer m_AdditionalLightsWorldToShadow_SSBO", True)]
	public static int m_AdditionalShadowsBufferId; //Field offset: 0x0
	private const string k_EmptyAdditionalLightShadowMapTextureName = "_EmptyAdditionalLightShadowmapTexture"; //Field offset: 0x0
	private const string k_AdditionalLightShadowMapTextureName = "_AdditionalLightsShadowmapTexture"; //Field offset: 0x0
	private const float k_LightTypeIdentifierInShadowParams_Point = 1; //Field offset: 0x0
	private const float k_LightTypeIdentifierInShadowParams_Spot = 0; //Field offset: 0x0
	private const int k_EmptyShadowMapDimensions = 1; //Field offset: 0x0
	private const int k_ShadowmapBufferBits = 16; //Field offset: 0x0
	[Obsolete("AdditionalLightsShadowCasterPass.m_AdditionalShadowsIndicesId was deprecated. Shadow slice index is now passed to the GPU using last member of an entry in buffer m_AdditionalShadowParams_SSBO", True)]
	public static int m_AdditionalShadowsIndicesId; //Field offset: 0x4
	private static bool m_IssuedMessageAboutPointLightHardShadowResolutionTooSmall; //Field offset: 0x8
	private static bool m_IssuedMessageAboutPointLightSoftShadowResolutionTooSmall; //Field offset: 0x9
	private static readonly Vector4 c_DefaultShadowParams; //Field offset: 0xC
	private static Vector4 s_EmptyAdditionalShadowFadeParams; //Field offset: 0x1C
	private static Vector4[] s_EmptyAdditionalLightIndexToShadowParams; //Field offset: 0x30
	private static bool isAdditionalShadowParamsDirty; //Field offset: 0x38
	internal RTHandle m_AdditionalLightsShadowmapHandle; //Field offset: 0xB8
	private int renderTargetWidth; //Field offset: 0xC0
	private int renderTargetHeight; //Field offset: 0xC4
	private bool m_CreateEmptyShadowmap; //Field offset: 0xC8
	private bool m_SetKeywordForEmptyShadowmap; //Field offset: 0xC9
	private bool m_EmptyShadowmapNeedsClear; //Field offset: 0xCA
	private bool m_IssuedMessageAboutShadowSlicesTooMany; //Field offset: 0xCB
	private bool m_IssuedMessageAboutShadowMapsRescale; //Field offset: 0xCC
	private bool m_IssuedMessageAboutShadowMapsTooBig; //Field offset: 0xCD
	private bool m_IssuedMessageAboutRemovedShadowSlices; //Field offset: 0xCE
	private readonly bool m_UseStructuredBuffer; //Field offset: 0xCF
	private float m_MaxShadowDistanceSq; //Field offset: 0xD0
	private float m_CascadeBorder; //Field offset: 0xD4
	private PassData m_PassData; //Field offset: 0xD8
	private RTHandle m_EmptyAdditionalLightShadowmapTexture; //Field offset: 0xE0
	private Boolean[] m_VisibleLightIndexToIsCastingShadows; //Field offset: 0xE8
	private Int16[] m_VisibleLightIndexToAdditionalLightIndex; //Field offset: 0xF0
	private Int16[] m_AdditionalLightIndexToVisibleLightIndex; //Field offset: 0xF8
	private Vector4[] m_AdditionalLightIndexToShadowParams; //Field offset: 0x100
	private Matrix4x4[] m_AdditionalLightShadowSliceIndexTo_WorldShadowMatrix; //Field offset: 0x108
	private ShadowSliceData[] m_AdditionalLightsShadowSlices; //Field offset: 0x110
	private readonly List<Byte> m_GlobalShadowSliceIndexToPerLightShadowSliceIndex; //Field offset: 0x118
	private readonly List<Int16> m_ShadowSliceToAdditionalLightIndex; //Field offset: 0x120
	private readonly Dictionary<Int32, UInt64> m_ShadowRequestsHashes; //Field offset: 0x128
	private readonly ProfilingSampler m_ProfilingSetupSampler; //Field offset: 0x130
	private RenderTextureDescriptor m_AdditionalLightShadowDescriptor; //Field offset: 0x138

	private static AdditionalLightsShadowCasterPass() { }

	public AdditionalLightsShadowCasterPass(RenderPassEvent evt) { }

	private bool AnyAdditionalLightHasMixedShadows(UniversalLightData lightData) { }

	internal static float CalcGuardAngle(float frustumAngleInDegrees, float guardBandSizeInTexels, float sliceResolutionInTexels) { }

	private void Clear() { }

	private ulong ComputeShadowRequestHash(UniversalLightData lightData, UniversalShadowData shadowData) { }

	[Obsolete("This rendering path is for compatibility mode only (when Render Graph is disabled). Use Render Graph API instead.", False)]
	public virtual void Configure(CommandBuffer cmd, RenderTextureDescriptor cameraTextureDescriptor) { }

	public void Dispose() { }

	[Obsolete("This rendering path is for compatibility mode only (when Render Graph is disabled). Use Render Graph API instead.", False)]
	public virtual void Execute(ScriptableRenderContext context, ref RenderingData renderingData) { }

	private float GetLightTypeIdentifierForShadowParams(LightType lightType) { }

	internal static float GetPointLightShadowFrustumFovBiasInDegrees(int shadowSliceResolution, bool shadowFiltering) { }

	public int GetShadowLightIndexFromLightIndex(int visibleLightIndex) { }

	private void InitPassData(ref PassData passData, UniversalCameraData cameraData, UniversalLightData lightData, UniversalShadowData shadowData) { }

	private void InitRendererLists(ref CullingResults cullResults, ref PassData passData, ScriptableRenderContext context, RenderGraph renderGraph, bool useRenderGraph) { }

	internal TextureHandle Render(RenderGraph graph, ContextContainer frameData) { }

	private void RenderAdditionalShadowmapAtlas(RasterCommandBuffer cmd, ref PassData data, bool useRenderGraph) { }

	private ulong ResolutionLog2ForHash(int resolution) { }

	internal static void SetShadowParamsForEmptyShadowmap(RasterCommandBuffer rasterCommandBuffer) { }

	public bool Setup(UniversalRenderingData renderingData, UniversalCameraData cameraData, UniversalLightData lightData, UniversalShadowData shadowData) { }

	public bool Setup(ref RenderingData renderingData) { }

	private void SetupAdditionalLightsShadowReceiverConstants(RasterCommandBuffer cmd, Vector2Int allocatedShadowAtlasSize, bool useStructuredBuffer, bool softShadows) { }

	private bool SetupForEmptyRendering(bool stripShadowsOffVariants, bool shadowsEnabled, UniversalLightData lightData, UniversalShadowData shadowData) { }

	private void UpdateTextureDescriptorIfNeeded() { }

	private bool UsesBakedShadows(Light light) { }

}

