namespace UnityEngine;

[NativeHeader("Runtime/Shaders/GraphicsCapsScriptBindings.h")]
[NativeHeader("Runtime/Input/GetInput.h")]
[NativeHeader("Runtime/Camera/RenderLoops/MotionVectorRenderLoop.h")]
[NativeHeader("Runtime/Graphics/GraphicsFormatUtility.bindings.h")]
[NativeHeader("Runtime/Misc/SystemInfo.h")]
[NativeHeader("Runtime/Graphics/Mesh/MeshScriptBindings.h")]
public sealed class SystemInfo
{

	[NativeProperty]
	public static float batteryLevel
	{
		 get { } //Length: 42
	}

	public static CopyTextureSupport copyTextureSupport
	{
		 get { } //Length: 42
	}

	public static string deviceModel
	{
		 get { } //Length: 42
	}

	public static string deviceName
	{
		 get { } //Length: 42
	}

	public static DeviceType deviceType
	{
		 get { } //Length: 42
	}

	public static string deviceUniqueIdentifier
	{
		 get { } //Length: 42
	}

	public static FoveatedRenderingCaps foveatedRenderingCaps
	{
		 get { } //Length: 42
	}

	public static int graphicsDeviceID
	{
		 get { } //Length: 42
	}

	public static string graphicsDeviceName
	{
		 get { } //Length: 42
	}

	public static GraphicsDeviceType graphicsDeviceType
	{
		 get { } //Length: 42
	}

	public static string graphicsDeviceVendor
	{
		 get { } //Length: 42
	}

	public static int graphicsDeviceVendorID
	{
		 get { } //Length: 42
	}

	public static string graphicsDeviceVersion
	{
		 get { } //Length: 42
	}

	public static int graphicsMemorySize
	{
		 get { } //Length: 42
	}

	public static int graphicsShaderLevel
	{
		 get { } //Length: 42
	}

	public static bool graphicsUVStartsAtTop
	{
		 get { } //Length: 42
	}

	public static bool hasHiddenSurfaceRemovalOnGPU
	{
		 get { } //Length: 42
	}

	public static HDRDisplaySupportFlags hdrDisplaySupportFlags
	{
		 get { } //Length: 42
	}

	public static long maxGraphicsBufferSize
	{
		 get { } //Length: 42
	}

	internal static int maxRenderTextureSize
	{
		internal get { } //Length: 42
	}

	public static int maxTextureSize
	{
		 get { } //Length: 42
	}

	public static string operatingSystem
	{
		 get { } //Length: 42
	}

	public static OperatingSystemFamily operatingSystemFamily
	{
		 get { } //Length: 42
	}

	public static int processorCount
	{
		 get { } //Length: 42
	}

	public static int processorFrequency
	{
		 get { } //Length: 42
	}

	public static string processorType
	{
		 get { } //Length: 42
	}

	public static int supportedRenderTargetCount
	{
		 get { } //Length: 42
	}

	public static bool supportsComputeShaders
	{
		 get { } //Length: 42
	}

	public static bool supportsGraphicsFence
	{
		 get { } //Length: 42
	}

	public static bool supportsInstancing
	{
		 get { } //Length: 42
	}

	public static bool supportsMultisampleAutoResolve
	{
		 get { } //Length: 42
	}

	public static int supportsMultisampledTextures
	{
		 get { } //Length: 42
	}

	public static bool supportsMultisampleResolveDepth
	{
		 get { } //Length: 42
	}

	public static bool supportsMultisampleResolveStencil
	{
		 get { } //Length: 42
	}

	public static bool supportsMultiview
	{
		 get { } //Length: 42
	}

	public static bool supportsRenderTargetArrayIndexFromVertexShader
	{
		 get { } //Length: 42
	}

	public static bool supportsShadows
	{
		 get { } //Length: 42
	}

	public static bool supportsStoreAndResolveAction
	{
		 get { } //Length: 42
	}

	public static int systemMemorySize
	{
		 get { } //Length: 42
	}

	public static bool usesLoadStoreActions
	{
		 get { } //Length: 42
	}

	public static bool usesReversedZBuffer
	{
		 get { } //Length: 42
	}

	public static float get_batteryLevel() { }

	public static CopyTextureSupport get_copyTextureSupport() { }

	public static string get_deviceModel() { }

	public static string get_deviceName() { }

	public static DeviceType get_deviceType() { }

	public static string get_deviceUniqueIdentifier() { }

	public static FoveatedRenderingCaps get_foveatedRenderingCaps() { }

	public static int get_graphicsDeviceID() { }

	public static string get_graphicsDeviceName() { }

	public static GraphicsDeviceType get_graphicsDeviceType() { }

	public static string get_graphicsDeviceVendor() { }

	public static int get_graphicsDeviceVendorID() { }

	public static string get_graphicsDeviceVersion() { }

	public static int get_graphicsMemorySize() { }

	public static int get_graphicsShaderLevel() { }

	public static bool get_graphicsUVStartsAtTop() { }

	public static bool get_hasHiddenSurfaceRemovalOnGPU() { }

	public static HDRDisplaySupportFlags get_hdrDisplaySupportFlags() { }

	public static long get_maxGraphicsBufferSize() { }

	internal static int get_maxRenderTextureSize() { }

	public static int get_maxTextureSize() { }

	public static string get_operatingSystem() { }

	public static OperatingSystemFamily get_operatingSystemFamily() { }

	public static int get_processorCount() { }

	public static int get_processorFrequency() { }

	public static string get_processorType() { }

	public static int get_supportedRenderTargetCount() { }

	public static bool get_supportsComputeShaders() { }

	public static bool get_supportsGraphicsFence() { }

	public static bool get_supportsInstancing() { }

	public static bool get_supportsMultisampleAutoResolve() { }

	public static int get_supportsMultisampledTextures() { }

	public static bool get_supportsMultisampleResolveDepth() { }

	public static bool get_supportsMultisampleResolveStencil() { }

	public static bool get_supportsMultiview() { }

	public static bool get_supportsRenderTargetArrayIndexFromVertexShader() { }

	public static bool get_supportsShadows() { }

	public static bool get_supportsStoreAndResolveAction() { }

	public static int get_systemMemorySize() { }

	public static bool get_usesLoadStoreActions() { }

	public static bool get_usesReversedZBuffer() { }

	[FreeFunction("systeminfo::GetBatteryLevel")]
	private static float GetBatteryLevel() { }

	[FreeFunction("ScriptingGraphicsCaps::GetCompatibleFormat")]
	public static GraphicsFormat GetCompatibleFormat(GraphicsFormat format, FormatUsage usage) { }

	[FreeFunction("ScriptingGraphicsCaps::GetCopyTextureSupport")]
	private static CopyTextureSupport GetCopyTextureSupport() { }

	[FreeFunction("systeminfo::GetDeviceModel")]
	private static string GetDeviceModel() { }

	[FreeFunction("systeminfo::GetDeviceName")]
	private static string GetDeviceName() { }

	[FreeFunction("systeminfo::GetDeviceType")]
	private static DeviceType GetDeviceType() { }

	[FreeFunction("systeminfo::GetDeviceUniqueIdentifier")]
	private static string GetDeviceUniqueIdentifier() { }

	[FreeFunction("ScriptingGraphicsCaps::GetFoveatedRenderingCaps")]
	private static FoveatedRenderingCaps GetFoveatedRenderingCaps() { }

	[FreeFunction("ScriptingGraphicsCaps::GetGraphicsDeviceID")]
	private static int GetGraphicsDeviceID() { }

	[FreeFunction("ScriptingGraphicsCaps::GetGraphicsDeviceName")]
	private static string GetGraphicsDeviceName() { }

	[FreeFunction("ScriptingGraphicsCaps::GetGraphicsDeviceType")]
	private static GraphicsDeviceType GetGraphicsDeviceType() { }

	[FreeFunction("ScriptingGraphicsCaps::GetGraphicsDeviceVendor")]
	private static string GetGraphicsDeviceVendor() { }

	[FreeFunction("ScriptingGraphicsCaps::GetGraphicsDeviceVendorID")]
	private static int GetGraphicsDeviceVendorID() { }

	[FreeFunction("ScriptingGraphicsCaps::GetGraphicsDeviceVersion")]
	private static string GetGraphicsDeviceVersion() { }

	[FreeFunction("ScriptingGraphicsCaps::GetGraphicsFormat")]
	public static GraphicsFormat GetGraphicsFormat(DefaultFormat format) { }

	[FreeFunction("ScriptingGraphicsCaps::GetGraphicsMemorySize")]
	private static int GetGraphicsMemorySize() { }

	[FreeFunction("ScriptingGraphicsCaps::GetGraphicsShaderLevel")]
	private static int GetGraphicsShaderLevel() { }

	[FreeFunction("ScriptingGraphicsCaps::GetGraphicsUVStartsAtTop")]
	private static bool GetGraphicsUVStartsAtTop() { }

	[FreeFunction("ScriptingGraphicsCaps::GetHDRDisplaySupportFlags")]
	private static HDRDisplaySupportFlags GetHDRDisplaySupportFlags() { }

	[FreeFunction("ScriptingGraphicsCaps::GetMaxRenderTextureSize")]
	private static int GetMaxRenderTextureSize() { }

	[FreeFunction("ScriptingGraphicsCaps::GetMaxTextureSize")]
	private static int GetMaxTextureSize() { }

	[FreeFunction("systeminfo::GetOperatingSystem")]
	private static string GetOperatingSystem() { }

	[FreeFunction("systeminfo::GetOperatingSystemFamily")]
	private static OperatingSystemFamily GetOperatingSystemFamily() { }

	[FreeFunction("systeminfo::GetPhysicalMemoryMB")]
	private static int GetPhysicalMemoryMB() { }

	[FreeFunction("systeminfo::GetProcessorCount")]
	private static int GetProcessorCount() { }

	[FreeFunction("systeminfo::GetProcessorFrequencyMHz")]
	private static int GetProcessorFrequencyMHz() { }

	[FreeFunction("systeminfo::GetProcessorType")]
	private static string GetProcessorType() { }

	[FreeFunction("ScriptingGraphicsCaps::GetRenderTextureSupportedMSAASampleCount")]
	public static int GetRenderTextureSupportedMSAASampleCount(RenderTextureDescriptor desc) { }

	private static int GetRenderTextureSupportedMSAASampleCount_Injected(ref RenderTextureDescriptor desc) { }

	[FreeFunction("ScriptingGraphicsCaps::HasHiddenSurfaceRemovalOnGPU")]
	private static bool HasHiddenSurfaceRemovalOnGPU() { }

	[FreeFunction("ScriptingGraphicsCaps::HasRenderTexture")]
	private static bool HasRenderTextureNative(RenderTextureFormat format) { }

	[FreeFunction("ScriptingGraphicsCaps::IsFormatSupported")]
	public static bool IsFormatSupported(GraphicsFormat format, FormatUsage usage) { }

	private static bool IsValidEnumValue(Enum value) { }

	[FreeFunction("ScriptingGraphicsCaps::MaxGraphicsBufferSize")]
	private static long MaxGraphicsBufferSize() { }

	[FreeFunction("ScriptingGraphicsCaps::SupportedRenderTargetCount")]
	private static int SupportedRenderTargetCount() { }

	[FreeFunction("ScriptingGraphicsCaps::SupportsComputeShaders")]
	private static bool SupportsComputeShaders() { }

	[FreeFunction("ScriptingGraphicsCaps::SupportsGPUFence")]
	private static bool SupportsGPUFence() { }

	[FreeFunction("ScriptingGraphicsCaps::SupportsInstancing")]
	private static bool SupportsInstancing() { }

	[FreeFunction("ScriptingGraphicsCaps::SupportsMultisampleAutoResolve")]
	private static bool SupportsMultisampleAutoResolve() { }

	[FreeFunction("ScriptingGraphicsCaps::SupportsMultisampledTextures")]
	private static int SupportsMultisampledTextures() { }

	[FreeFunction("ScriptingGraphicsCaps::SupportsMultisampleResolveDepth")]
	private static bool SupportsMultisampleResolveDepth() { }

	[FreeFunction("ScriptingGraphicsCaps::SupportsMultisampleResolveStencil")]
	private static bool SupportsMultisampleResolveStencil() { }

	[FreeFunction("ScriptingGraphicsCaps::SupportsMultiview")]
	private static bool SupportsMultiview() { }

	[FreeFunction("ScriptingGraphicsCaps::SupportsRenderTargetArrayIndexFromVertexShader")]
	private static bool SupportsRenderTargetArrayIndexFromVertexShader() { }

	public static bool SupportsRenderTextureFormat(RenderTextureFormat format) { }

	[FreeFunction("ScriptingGraphicsCaps::SupportsShadows")]
	private static bool SupportsShadows() { }

	[FreeFunction("ScriptingGraphicsCaps::SupportsStoreAndResolveAction")]
	private static bool SupportsStoreAndResolveAction() { }

	public static bool SupportsTextureFormat(TextureFormat format) { }

	[FreeFunction("ScriptingGraphicsCaps::SupportsTextureFormat")]
	private static bool SupportsTextureFormatNative(TextureFormat format) { }

	[FreeFunction("ScriptingGraphicsCaps::UsesLoadStoreActions")]
	private static bool UsesLoadStoreActions() { }

	[FreeFunction("ScriptingGraphicsCaps::UsesReversedZBuffer")]
	private static bool UsesReversedZBuffer() { }

}

