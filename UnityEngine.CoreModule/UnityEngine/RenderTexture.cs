namespace UnityEngine;

[NativeHeader("Runtime/Graphics/RenderBufferManager.h")]
[NativeHeader("Runtime/Graphics/GraphicsScriptBindings.h")]
[NativeHeader("Runtime/Camera/Camera.h")]
[NativeHeader("Runtime/Graphics/RenderTexture.h")]
[UsedByNativeCode]
public class RenderTexture : Texture
{

	public static RenderTexture active
	{
		 get { } //Length: 42
		 set { } //Length: 51
	}

	public int antiAliasing
	{
		 get { } //Length: 51
		 set { } //Length: 64
	}

	public bool autoGenerateMips
	{
		 get { } //Length: 51
		 set { } //Length: 66
	}

	public bool bindTextureMS
	{
		 get { } //Length: 51
		 set { } //Length: 66
	}

	public RenderBuffer colorBuffer
	{
		 get { } //Length: 90
	}

	public int depth
	{
		[FreeFunction("RenderTextureScripting::GetDepth", HasExplicitThis = True)]
		 get { } //Length: 51
		[FreeFunction("RenderTextureScripting::SetDepth", HasExplicitThis = True)]
		 set { } //Length: 64
	}

	public RenderBuffer depthBuffer
	{
		 get { } //Length: 90
	}

	public GraphicsFormat depthStencilFormat
	{
		 get { } //Length: 51
		 set { } //Length: 64
	}

	public RenderTextureDescriptor descriptor
	{
		 get { } //Length: 142
		 set { } //Length: 161
	}

	public virtual TextureDimension dimension
	{
		 get { } //Length: 51
		 set { } //Length: 64
	}

	[EditorBrowsable(EditorBrowsableState::Never (1))]
	[Obsolete("RenderTexture.enabled is always now, no need to use it.", False)]
	public static bool enabled
	{
		 get { } //Length: 5
		 set { } //Length: 3
	}

	public bool enableRandomWrite
	{
		 get { } //Length: 51
		 set { } //Length: 66
	}

	public RenderTextureFormat format
	{
		 get { } //Length: 244
		 set { } //Length: 178
	}

	public GraphicsFormat graphicsFormat
	{
		 get { } //Length: 53
		 set { } //Length: 64
	}

	public virtual int height
	{
		 get { } //Length: 51
		 set { } //Length: 64
	}

	[Obsolete("Use RenderTexture.dimension instead.", False)]
	public bool isCubemap
	{
		 get { } //Length: 34
		 set { } //Length: 45
	}

	public bool isPowerOfTwo
	{
		 get { } //Length: 51
		 set { } //Length: 3
	}

	[Obsolete("Use RenderTexture.dimension instead.", False)]
	public bool isVolume
	{
		 get { } //Length: 34
		 set { } //Length: 41
	}

	[NativeProperty("Memoryless")]
	public RenderTextureMemoryless memorylessMode
	{
		 get { } //Length: 51
		 set { } //Length: 64
	}

	[NativeProperty("SRGBReadWrite")]
	public bool sRGB
	{
		 get { } //Length: 51
	}

	public GraphicsFormat stencilFormat
	{
		 get { } //Length: 51
		 set { } //Length: 64
	}

	public bool useDynamicScale
	{
		 get { } //Length: 51
		 set { } //Length: 66
	}

	[NativeProperty("MipMap")]
	public bool useMipMap
	{
		 get { } //Length: 51
		 set { } //Length: 66
	}

	public int volumeDepth
	{
		 get { } //Length: 51
		 set { } //Length: 64
	}

	[NativeProperty("VRUsage")]
	public VRTextureUsage vrUsage
	{
		 get { } //Length: 51
		 set { } //Length: 64
	}

	public virtual int width
	{
		 get { } //Length: 51
		 set { } //Length: 64
	}

	[ExcludeFromDocs]
	public RenderTexture(int width, int height, int depth, GraphicsFormat format, int mipCount) { }

	[RequiredByNativeCode]
	protected private RenderTexture() { }

	public RenderTexture(RenderTextureDescriptor desc) { }

	[ExcludeFromDocs]
	public RenderTexture(int width, int height, int depth, RenderTextureFormat format, int mipCount) { }

	public RenderTexture(RenderTexture textureToCopy) { }

	[ExcludeFromDocs]
	public RenderTexture(int width, int height, int depth) { }

	[ExcludeFromDocs]
	public RenderTexture(int width, int height, int depth, DefaultFormat format) { }

	[ExcludeFromDocs]
	public RenderTexture(int width, int height, int depth, RenderTextureFormat format) { }

	[ExcludeFromDocs]
	public RenderTexture(int width, int height, int depth, GraphicsFormat format) { }

	[ExcludeFromDocs]
	public RenderTexture(int width, int height, GraphicsFormat colorFormat, GraphicsFormat depthStencilFormat, int mipCount) { }

	public RenderTexture(int width, int height, int depth, RenderTextureFormat format, RenderTextureReadWrite readWrite) { }

	[ExcludeFromDocs]
	public RenderTexture(int width, int height, GraphicsFormat colorFormat, GraphicsFormat depthStencilFormat) { }

	[NativeThrows]
	public void ConvertToEquirect(RenderTexture equirect, MonoOrStereoscopicEye eye = 2) { }

	public bool Create() { }

	public void DiscardContents(bool discardColor, bool discardDepth) { }

	public void DiscardContents() { }

	public void GenerateMips() { }

	public static RenderTexture get_active() { }

	public int get_antiAliasing() { }

	public bool get_autoGenerateMips() { }

	public bool get_bindTextureMS() { }

	public RenderBuffer get_colorBuffer() { }

	[FreeFunction("RenderTextureScripting::GetDepth", HasExplicitThis = True)]
	public int get_depth() { }

	public RenderBuffer get_depthBuffer() { }

	public GraphicsFormat get_depthStencilFormat() { }

	public RenderTextureDescriptor get_descriptor() { }

	public virtual TextureDimension get_dimension() { }

	public static bool get_enabled() { }

	public bool get_enableRandomWrite() { }

	public RenderTextureFormat get_format() { }

	public GraphicsFormat get_graphicsFormat() { }

	public virtual int get_height() { }

	public bool get_isCubemap() { }

	public bool get_isPowerOfTwo() { }

	public bool get_isVolume() { }

	public RenderTextureMemoryless get_memorylessMode() { }

	public bool get_sRGB() { }

	public GraphicsFormat get_stencilFormat() { }

	public bool get_useDynamicScale() { }

	public bool get_useMipMap() { }

	public int get_volumeDepth() { }

	public VRTextureUsage get_vrUsage() { }

	public virtual int get_width() { }

	[FreeFunction("RenderTexture::GetActive")]
	private static RenderTexture GetActive() { }

	[FreeFunction(Name = "RenderTextureScripting::GetColorBuffer", HasExplicitThis = True)]
	private RenderBuffer GetColorBuffer() { }

	private void GetColorBuffer_Injected(out RenderBuffer ret) { }

	[NativeName("GetColorFormat")]
	private GraphicsFormat GetColorFormat(bool suppressWarnings) { }

	internal static GraphicsFormat GetCompatibleFormat(RenderTextureFormat renderTextureFormat, RenderTextureReadWrite readWrite) { }

	internal static GraphicsFormat GetDefaultColorFormat(DefaultFormat format) { }

	internal static GraphicsFormat GetDefaultDepthStencilFormat(DefaultFormat format, int depth) { }

	[FreeFunction(Name = "RenderTextureScripting::GetDepthBuffer", HasExplicitThis = True)]
	private RenderBuffer GetDepthBuffer() { }

	private void GetDepthBuffer_Injected(out RenderBuffer ret) { }

	internal static GraphicsFormat GetDepthStencilFormatLegacy(int depthBits, RenderTextureFormat format) { }

	internal static GraphicsFormat GetDepthStencilFormatLegacy(int depthBits, DefaultFormat format) { }

	internal static GraphicsFormat GetDepthStencilFormatLegacy(int depthBits, bool requestedShadowMap) { }

	internal static GraphicsFormat GetDepthStencilFormatLegacy(int depthBits, GraphicsFormat colorFormat) { }

	[NativeName("GetRenderTextureDesc")]
	private RenderTextureDescriptor GetDescriptor() { }

	private void GetDescriptor_Injected(out RenderTextureDescriptor ret) { }

	private bool GetIsPowerOfTwo() { }

	public IntPtr GetNativeDepthBufferPtr() { }

	[ExcludeFromDocs]
	public static RenderTexture GetTemporary(int width, int height, int depthBuffer, RenderTextureFormat format, RenderTextureReadWrite readWrite) { }

	[ExcludeFromDocs]
	public static RenderTexture GetTemporary(int width, int height) { }

	[ExcludeFromDocs]
	public static RenderTexture GetTemporary(int width, int height, int depthBuffer) { }

	[ExcludeFromDocs]
	public static RenderTexture GetTemporary(int width, int height, int depthBuffer, GraphicsFormat format, int antiAliasing, RenderTextureMemoryless memorylessMode, VRTextureUsage vrUsage, bool useDynamicScale) { }

	[ExcludeFromDocs]
	public static RenderTexture GetTemporary(int width, int height, int depthBuffer, RenderTextureFormat format) { }

	[ExcludeFromDocs]
	public static RenderTexture GetTemporary(int width, int height, int depthBuffer, GraphicsFormat format, int antiAliasing, RenderTextureMemoryless memorylessMode, VRTextureUsage vrUsage) { }

	[ExcludeFromDocs]
	public static RenderTexture GetTemporary(int width, int height, int depthBuffer, GraphicsFormat format, int antiAliasing, RenderTextureMemoryless memorylessMode) { }

	[ExcludeFromDocs]
	public static RenderTexture GetTemporary(int width, int height, int depthBuffer, GraphicsFormat format) { }

	public static RenderTexture GetTemporary(int width, int height, int depthBuffer, RenderTextureFormat format, RenderTextureReadWrite readWrite, int antiAliasing, RenderTextureMemoryless memorylessMode, VRTextureUsage vrUsage, bool useDynamicScale) { }

	[ExcludeFromDocs]
	public static RenderTexture GetTemporary(int width, int height, int depthBuffer, RenderTextureFormat format, RenderTextureReadWrite readWrite, int antiAliasing, RenderTextureMemoryless memorylessMode, VRTextureUsage vrUsage) { }

	[ExcludeFromDocs]
	public static RenderTexture GetTemporary(int width, int height, int depthBuffer, RenderTextureFormat format, RenderTextureReadWrite readWrite, int antiAliasing, RenderTextureMemoryless memorylessMode) { }

	[ExcludeFromDocs]
	public static RenderTexture GetTemporary(int width, int height, int depthBuffer, RenderTextureFormat format, RenderTextureReadWrite readWrite, int antiAliasing) { }

	public static RenderTexture GetTemporary(RenderTextureDescriptor desc) { }

	[ExcludeFromDocs]
	public static RenderTexture GetTemporary(int width, int height, int depthBuffer, GraphicsFormat format, int antiAliasing) { }

	[FreeFunction("GetRenderBufferManager().GetTextures().GetTempBuffer")]
	private static RenderTexture GetTemporary_Internal(RenderTextureDescriptor desc) { }

	private static RenderTexture GetTemporary_Internal_Injected(ref RenderTextureDescriptor desc) { }

	private static RenderTexture GetTemporaryImpl(int width, int height, GraphicsFormat depthStencilFormat, GraphicsFormat colorFormat, int antiAliasing = 1, RenderTextureMemoryless memorylessMode = 0, VRTextureUsage vrUsage = 0, bool useDynamicScale = false) { }

	[EditorBrowsable(EditorBrowsableState::Never (1))]
	[Obsolete("GetTexelOffset always returns zero now, no point in using it.", False)]
	public Vector2 GetTexelOffset() { }

	private void Initialize(int width, int height, int depth, RenderTextureFormat format, RenderTextureReadWrite readWrite, int mipCount) { }

	[FreeFunction("RenderTextureScripting::Create")]
	private static void Internal_Create(RenderTexture rt) { }

	public bool IsCreated() { }

	[Obsolete("This function has no effect.", False)]
	public void MarkRestoreExpected() { }

	public void Release() { }

	[FreeFunction("GetRenderBufferManager().GetTextures().ReleaseTempBuffer")]
	public static void ReleaseTemporary(RenderTexture temp) { }

	[NativeName("ResolveAntiAliasedSurface")]
	private void ResolveAA() { }

	[NativeName("ResolveAntiAliasedSurface")]
	private void ResolveAATo(RenderTexture rt) { }

	public void ResolveAntiAliasedSurface(RenderTexture target) { }

	public void ResolveAntiAliasedSurface() { }

	public static void set_active(RenderTexture value) { }

	public void set_antiAliasing(int value) { }

	public void set_autoGenerateMips(bool value) { }

	public void set_bindTextureMS(bool value) { }

	[FreeFunction("RenderTextureScripting::SetDepth", HasExplicitThis = True)]
	public void set_depth(int value) { }

	public void set_depthStencilFormat(GraphicsFormat value) { }

	public void set_descriptor(RenderTextureDescriptor value) { }

	public virtual void set_dimension(TextureDimension value) { }

	public static void set_enabled(bool value) { }

	public void set_enableRandomWrite(bool value) { }

	public void set_format(RenderTextureFormat value) { }

	public void set_graphicsFormat(GraphicsFormat value) { }

	public virtual void set_height(int value) { }

	public void set_isCubemap(bool value) { }

	public void set_isPowerOfTwo(bool value) { }

	public void set_isVolume(bool value) { }

	public void set_memorylessMode(RenderTextureMemoryless value) { }

	public void set_stencilFormat(GraphicsFormat value) { }

	public void set_useDynamicScale(bool value) { }

	public void set_useMipMap(bool value) { }

	public void set_volumeDepth(int value) { }

	public void set_vrUsage(VRTextureUsage value) { }

	public virtual void set_width(int value) { }

	[FreeFunction("RenderTextureScripting::SetActive")]
	private static void SetActive(RenderTexture rt) { }

	[NativeName("SetColorFormat")]
	private void SetColorFormat(GraphicsFormat format) { }

	[FreeFunction(Name = "RenderTextureScripting::SetGlobalShaderProperty", HasExplicitThis = True)]
	public void SetGlobalShaderProperty(string propertyName) { }

	private void SetMipMapCount(int count) { }

	[NativeName("SetRenderTextureDescFromScript")]
	private void SetRenderTextureDescriptor(RenderTextureDescriptor desc) { }

	private void SetRenderTextureDescriptor_Injected(ref RenderTextureDescriptor desc) { }

	private void SetShadowSamplingMode(ShadowSamplingMode samplingMode) { }

	internal void SetSRGBReadWrite(bool srgb) { }

	[FreeFunction("RenderTextureSupportsStencil")]
	public static bool SupportsStencil(RenderTexture rt) { }

	private static void ValidateRenderTextureDesc(RenderTextureDescriptor desc) { }

}

