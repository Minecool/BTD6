namespace UnityEngine.Rendering;

public class RTHandleSystem : IDisposable
{
	public enum ResizeMode
	{
		Auto = 0,
		OnDemand = 1,
	}

	private bool m_HardwareDynamicResRequested; //Field offset: 0x10
	private HashSet<RTHandle> m_AutoSizedRTs; //Field offset: 0x18
	private RTHandle[] m_AutoSizedRTsArray; //Field offset: 0x20
	private HashSet<RTHandle> m_ResizeOnDemandRTs; //Field offset: 0x28
	private RTHandleProperties m_RTHandleProperties; //Field offset: 0x30
	private int m_MaxWidths; //Field offset: 0x60
	private int m_MaxHeights; //Field offset: 0x64

	public RTHandleProperties rtHandleProperties
	{
		 get { } //Length: 27
	}

	public RTHandleSystem() { }

	public RTHandle Alloc(RenderTargetIdentifier texture, string name) { }

	public RTHandle Alloc(RenderTargetIdentifier texture) { }

	public RTHandle Alloc(Texture texture) { }

	public RTHandle Alloc(RenderTexture texture) { }

	public RTHandle Alloc(ScaleFunc scaleFunc, int slices = 1, DepthBits depthBufferBits = 0, GraphicsFormat colorFormat = 4, FilterMode filterMode = 0, TextureWrapMode wrapMode = 0, TextureDimension dimension = 2, bool enableRandomWrite = false, bool useMipMap = false, bool autoGenerateMips = true, bool isShadowMap = false, int anisoLevel = 1, float mipMapBias = 0, MSAASamples msaaSamples = 1, bool bindTextureMS = false, bool useDynamicScale = false, RenderTextureMemoryless memoryless = 0, VRTextureUsage vrUsage = 0, string name = "") { }

	public RTHandle Alloc(Vector2 scaleFactor, int slices = 1, DepthBits depthBufferBits = 0, GraphicsFormat colorFormat = 4, FilterMode filterMode = 0, TextureWrapMode wrapMode = 0, TextureDimension dimension = 2, bool enableRandomWrite = false, bool useMipMap = false, bool autoGenerateMips = true, bool isShadowMap = false, int anisoLevel = 1, float mipMapBias = 0, MSAASamples msaaSamples = 1, bool bindTextureMS = false, bool useDynamicScale = false, RenderTextureMemoryless memoryless = 0, VRTextureUsage vrUsage = 0, string name = "") { }

	public RTHandle Alloc(int width, int height, TextureWrapMode wrapModeU, TextureWrapMode wrapModeV, TextureWrapMode wrapModeW = 0, int slices = 1, DepthBits depthBufferBits = 0, GraphicsFormat colorFormat = 4, FilterMode filterMode = 0, TextureDimension dimension = 2, bool enableRandomWrite = false, bool useMipMap = false, bool autoGenerateMips = true, bool isShadowMap = false, int anisoLevel = 1, float mipMapBias = 0, MSAASamples msaaSamples = 1, bool bindTextureMS = false, bool useDynamicScale = false, RenderTextureMemoryless memoryless = 0, VRTextureUsage vrUsage = 0, string name = "") { }

	public RTHandle Alloc(int width, int height, int slices = 1, DepthBits depthBufferBits = 0, GraphicsFormat colorFormat = 4, FilterMode filterMode = 0, TextureWrapMode wrapMode = 0, TextureDimension dimension = 2, bool enableRandomWrite = false, bool useMipMap = false, bool autoGenerateMips = true, bool isShadowMap = false, int anisoLevel = 1, float mipMapBias = 0, MSAASamples msaaSamples = 1, bool bindTextureMS = false, bool useDynamicScale = false, RenderTextureMemoryless memoryless = 0, VRTextureUsage vrUsage = 0, string name = "") { }

	private static RTHandle Alloc(RTHandle tex) { }

	private RTHandle AllocAutoSizedRenderTexture(int width, int height, int slices, DepthBits depthBufferBits, GraphicsFormat colorFormat, FilterMode filterMode, TextureWrapMode wrapMode, TextureDimension dimension, bool enableRandomWrite, bool useMipMap, bool autoGenerateMips, bool isShadowMap, int anisoLevel, float mipMapBias, MSAASamples msaaSamples, bool bindTextureMS, bool useDynamicScale, RenderTextureMemoryless memoryless, VRTextureUsage vrUsage, string name) { }

	internal Vector2 CalculateRatioAgainstMaxSize(in Vector2Int viewportSize) { }

	private void DemandResize(RTHandle rth) { }

	public override void Dispose() { }

	private void Dispose(bool disposing) { }

	internal string DumpRTInfo() { }

	public RTHandleProperties get_rtHandleProperties() { }

	public int GetMaxHeight() { }

	public int GetMaxWidth() { }

	[Obsolete("useLegacyDynamicResControl is deprecated. Please use SetHardwareDynamicResolutionState() instead.")]
	public void Initialize(int width, int height, bool useLegacyDynamicResControl = false) { }

	public void Initialize(int width, int height) { }

	public void Release(RTHandle rth) { }

	internal void Remove(RTHandle rth) { }

	public void ResetReferenceSize(int width, int height) { }

	private void Resize(int width, int height, bool sizeChanged) { }

	public void SetHardwareDynamicResolutionState(bool enableHWDynamicRes) { }

	public void SetReferenceSize(int width, int height, bool reset) { }

	public void SetReferenceSize(int width, int height) { }

	internal void SwitchResizeMode(RTHandle rth, ResizeMode mode) { }

}

