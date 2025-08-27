namespace UnityEngine.Rendering.Universal;

[DisallowMultipleRendererFeature("Decal")]
[Tooltip("With this Renderer Feature, Unity can project specific Materials (decals) onto other objects in the Scene.")]
internal class DecalRendererFeature : ScriptableRendererFeature
{
	[CompilerGenerated]
	private static readonly SharedDecalEntityManager <sharedDecalEntityManager>k__BackingField; //Field offset: 0x0
	[SerializeField]
	private DecalSettings m_Settings; //Field offset: 0x20
	[HideInInspector]
	[Reload("Shaders/Utils/CopyDepth.shader", Package::Root (1))]
	[SerializeField]
	private Shader m_CopyDepthPS; //Field offset: 0x28
	[HideInInspector]
	[Reload("Runtime/Decal/DBuffer/DBufferClear.shader", Package::Root (1))]
	[SerializeField]
	private Shader m_DBufferClear; //Field offset: 0x30
	private DecalTechnique m_Technique; //Field offset: 0x38
	private DBufferSettings m_DBufferSettings; //Field offset: 0x40
	private DecalScreenSpaceSettings m_ScreenSpaceSettings; //Field offset: 0x48
	private bool m_RecreateSystems; //Field offset: 0x50
	private CopyDepthPass m_CopyDepthPass; //Field offset: 0x58
	private DecalPreviewPass m_DecalPreviewPass; //Field offset: 0x60
	private Material m_CopyDepthMaterial; //Field offset: 0x68
	private DecalEntityManager m_DecalEntityManager; //Field offset: 0x70
	private DecalUpdateCachedSystem m_DecalUpdateCachedSystem; //Field offset: 0x78
	private DecalUpdateCullingGroupSystem m_DecalUpdateCullingGroupSystem; //Field offset: 0x80
	private DecalUpdateCulledSystem m_DecalUpdateCulledSystem; //Field offset: 0x88
	private DecalCreateDrawCallSystem m_DecalCreateDrawCallSystem; //Field offset: 0x90
	private DecalDrawErrorSystem m_DrawErrorSystem; //Field offset: 0x98
	private DBufferRenderPass m_DBufferRenderPass; //Field offset: 0xA0
	private DecalForwardEmissivePass m_ForwardEmissivePass; //Field offset: 0xA8
	private DecalDrawDBufferSystem m_DecalDrawDBufferSystem; //Field offset: 0xB0
	private DecalDrawFowardEmissiveSystem m_DecalDrawForwardEmissiveSystem; //Field offset: 0xB8
	private Material m_DBufferClearMaterial; //Field offset: 0xC0
	private DecalScreenSpaceRenderPass m_ScreenSpaceDecalRenderPass; //Field offset: 0xC8
	private DecalDrawScreenSpaceSystem m_DecalDrawScreenSpaceSystem; //Field offset: 0xD0
	private DecalSkipCulledSystem m_DecalSkipCulledSystem; //Field offset: 0xD8
	private DecalGBufferRenderPass m_GBufferRenderPass; //Field offset: 0xE0
	private DecalDrawGBufferSystem m_DrawGBufferSystem; //Field offset: 0xE8
	private DeferredLights m_DeferredLights; //Field offset: 0xF0

	internal bool intermediateRendering
	{
		internal get { } //Length: 8
	}

	internal static bool isGLDevice
	{
		internal get { } //Length: 53
	}

	internal bool requiresDecalLayers
	{
		internal get { } //Length: 27
	}

	internal DecalSettings settings
	{
		internal get { } //Length: 5
	}

	private static SharedDecalEntityManager sharedDecalEntityManager
	{
		[CompilerGenerated]
		private get { } //Length: 78
	}

	private static DecalRendererFeature() { }

	public DecalRendererFeature() { }

	public virtual void AddRenderPasses(ScriptableRenderer renderer, ref RenderingData renderingData) { }

	[Conditional("ADAPTIVE_PERFORMANCE_4_0_0_OR_NEWER")]
	private void ChangeAdaptivePerformanceDrawDistances() { }

	public virtual void Create() { }

	protected virtual void Dispose(bool disposing) { }

	internal bool get_intermediateRendering() { }

	internal static bool get_isGLDevice() { }

	internal bool get_requiresDecalLayers() { }

	internal DecalSettings get_settings() { }

	[CompilerGenerated]
	private static SharedDecalEntityManager get_sharedDecalEntityManager() { }

	internal DBufferSettings GetDBufferSettings() { }

	internal DecalScreenSpaceSettings GetScreenSpaceSettings() { }

	internal DecalTechnique GetTechnique(bool isDeferred, bool needsGBufferAccurateNormals, bool checkForInvalidTechniques = true) { }

	internal DecalTechnique GetTechnique(ScriptableRendererData renderer) { }

	internal DecalTechnique GetTechnique(ScriptableRenderer renderer) { }

	private bool IsAutomaticDBuffer() { }

	public virtual void OnCameraPreCull(ScriptableRenderer renderer, in CameraData cameraData) { }

	private bool RecreateSystemsIfNeeded(ScriptableRenderer renderer, in CameraData cameraData) { }

	internal virtual bool RequireRenderingLayers(bool isDeferred, bool needsGBufferAccurateNormals, out Event atEvent, out MaskSize maskSize) { }

	public virtual void SetupRenderPasses(ScriptableRenderer renderer, in RenderingData renderingData) { }

	internal virtual bool SupportsNativeRenderPass() { }

}

