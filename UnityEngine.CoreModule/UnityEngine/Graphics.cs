namespace UnityEngine;

[NativeHeader("Runtime/Graphics/CopyTexture.h")]
[NativeHeader("Runtime/Shaders/ComputeShader.h")]
[NativeHeader("Runtime/Camera/LightProbeProxyVolume.h")]
[NativeHeader("Runtime/Graphics/ColorGamut.h")]
[NativeHeader("Runtime/Misc/PlayerSettings.h")]
[NativeHeader("Runtime/Graphics/GraphicsScriptBindings.h")]
public class Graphics
{
	internal static readonly int kMaxDrawMeshInstanceCount; //Field offset: 0x0
	internal static Dictionary<Int32, RenderInstancedDataLayout> s_RenderInstancedDataLayouts; //Field offset: 0x8

	[StaticAccessor("GetGfxDevice()", StaticAccessorType::Dot (0))]
	public static GraphicsTier activeTier
	{
		 get { } //Length: 42
		 set { } //Length: 49
	}

	public static OpenGLESVersion minOpenGLESVersion
	{
		 get { } //Length: 91
	}

	public static bool preserveFramebufferAlpha
	{
		 get { } //Length: 91
	}

	private static Graphics() { }

	public static void Blit(Texture source, RenderTexture dest, Material mat, int pass) { }

	public static void Blit(Texture source, RenderTexture dest) { }

	public static void Blit(Texture source, RenderTexture dest, Material mat) { }

	public static void Blit(Texture source, RenderTexture dest, Vector2 scale, Vector2 offset) { }

	[FreeFunction("GraphicsScripting::Blit")]
	private static void Blit2(Texture source, RenderTexture dest) { }

	[FreeFunction("GraphicsScripting::Blit")]
	private static void Blit4(Texture source, RenderTexture dest, Vector2 scale, Vector2 offset) { }

	private static void Blit4_Injected(Texture source, RenderTexture dest, ref Vector2 scale, ref Vector2 offset) { }

	public static void CopyTexture(Texture src, int srcElement, int srcMip, int srcX, int srcY, int srcWidth, int srcHeight, Texture dst, int dstElement, int dstMip, int dstX, int dstY) { }

	public static void CopyTexture(Texture src, int srcElement, int srcMip, Texture dst, int dstElement, int dstMip) { }

	[FreeFunction("CopyTexture")]
	private static void CopyTexture_Region(Texture src, int srcElement, int srcMip, int srcX, int srcY, int srcWidth, int srcHeight, Texture dst, int dstElement, int dstMip, int dstX, int dstY) { }

	[FreeFunction("CopyTexture")]
	private static void CopyTexture_Slice(Texture src, int srcElement, int srcMip, Texture dst, int dstElement, int dstMip) { }

	[ExcludeFromDocs]
	public static void DrawMesh(Mesh mesh, Matrix4x4 matrix, Material material, int layer, Camera camera, int submeshIndex, MaterialPropertyBlock properties) { }

	public static void DrawMesh(Mesh mesh, Matrix4x4 matrix, Material material, int layer, Camera camera, int submeshIndex, MaterialPropertyBlock properties, ShadowCastingMode castShadows, bool receiveShadows, Transform probeAnchor, LightProbeUsage lightProbeUsage, LightProbeProxyVolume lightProbeProxyVolume) { }

	[ExcludeFromDocs]
	public static void DrawMesh(Mesh mesh, Matrix4x4 matrix, Material material, int layer) { }

	public static void DrawMeshInstanced(Mesh mesh, int submeshIndex, Material material, Matrix4x4[] matrices, int count, MaterialPropertyBlock properties, ShadowCastingMode castShadows, bool receiveShadows, int layer, Camera camera, LightProbeUsage lightProbeUsage, LightProbeProxyVolume lightProbeProxyVolume) { }

	[ExcludeFromDocs]
	public static void DrawMeshInstanced(Mesh mesh, int submeshIndex, Material material, Matrix4x4[] matrices, int count, MaterialPropertyBlock properties, ShadowCastingMode castShadows, bool receiveShadows, int layer, Camera camera) { }

	[NativeMethod(Name = "GraphicsScripting::ExecuteCommandBuffer", IsFreeFunction = True, ThrowsException = True)]
	public static void ExecuteCommandBuffer(CommandBuffer buffer) { }

	public static GraphicsTier get_activeTier() { }

	public static OpenGLESVersion get_minOpenGLESVersion() { }

	public static bool get_preserveFramebufferAlpha() { }

	[NativeMethod(Name = "GetMinOpenGLESVersion")]
	[StaticAccessor("GetPlayerSettings()", StaticAccessorType::Dot (0))]
	internal static OpenGLESVersion GetMinOpenGLESVersion() { }

	[NativeMethod(Name = "GetPreserveFramebufferAlpha")]
	[StaticAccessor("GetPlayerSettings()", StaticAccessorType::Dot (0))]
	internal static bool GetPreserveFramebufferAlpha() { }

	[FreeFunction("GraphicsScripting::BlitMaterial")]
	private static void Internal_BlitMaterial5(Texture source, RenderTexture dest, Material mat, int pass, bool setRT) { }

	[FreeFunction("GraphicsScripting::DrawMesh")]
	private static void Internal_DrawMesh(Mesh mesh, int submeshIndex, Matrix4x4 matrix, Material material, int layer, Camera camera, MaterialPropertyBlock properties, ShadowCastingMode castShadows, bool receiveShadows, Transform probeAnchor, LightProbeUsage lightProbeUsage, LightProbeProxyVolume lightProbeProxyVolume) { }

	private static void Internal_DrawMesh_Injected(Mesh mesh, int submeshIndex, ref Matrix4x4 matrix, Material material, int layer, Camera camera, MaterialPropertyBlock properties, ShadowCastingMode castShadows, bool receiveShadows, Transform probeAnchor, LightProbeUsage lightProbeUsage, LightProbeProxyVolume lightProbeProxyVolume) { }

	[FreeFunction("GraphicsScripting::DrawMeshInstanced")]
	private static void Internal_DrawMeshInstanced(Mesh mesh, int submeshIndex, Material material, Matrix4x4[] matrices, int count, MaterialPropertyBlock properties, ShadowCastingMode castShadows, bool receiveShadows, int layer, Camera camera, LightProbeUsage lightProbeUsage, LightProbeProxyVolume lightProbeProxyVolume) { }

	[FreeFunction("GraphicsScripting::DrawTexture")]
	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEngine.IMGUIModule"}])]
	internal static void Internal_DrawTexture(ref Internal_DrawTextureArguments args) { }

	[FreeFunction("GraphicsScripting::GetMaxDrawMeshInstanceCount", IsThreadSafe = True)]
	private static int Internal_GetMaxDrawMeshInstanceCount() { }

	[FreeFunction("GraphicsScripting::SetNullRT")]
	private static void Internal_SetNullRT() { }

	[NativeMethod(Name = "GraphicsScripting::SetRTSimple", IsFreeFunction = True, ThrowsException = True)]
	private static void Internal_SetRTSimple(RenderBuffer color, RenderBuffer depth, int mip, CubemapFace face, int depthSlice) { }

	private static void Internal_SetRTSimple_Injected(ref RenderBuffer color, ref RenderBuffer depth, int mip, CubemapFace face, int depthSlice) { }

	public static void set_activeTier(GraphicsTier value) { }

	[ExcludeFromDocs]
	public static void SetRenderTarget(RenderTexture rt) { }

	[ExcludeFromDocs]
	public static void SetRenderTarget(RenderTexture rt, int mipLevel) { }

	public static void SetRenderTarget(RenderTexture rt, int mipLevel, CubemapFace face, int depthSlice) { }

	internal static void SetRenderTargetImpl(RenderTexture rt, int mipLevel, CubemapFace face, int depthSlice) { }

	internal static void SetRenderTargetImpl(RenderBuffer colorBuffer, RenderBuffer depthBuffer, int mipLevel, CubemapFace face, int depthSlice) { }

}

