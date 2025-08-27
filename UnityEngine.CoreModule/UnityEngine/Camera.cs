namespace UnityEngine;

[NativeHeader("Runtime/Camera/RenderManager.h")]
[NativeHeader("Runtime/Graphics/CommandBuffer/RenderingCommandBuffer.h")]
[NativeHeader("Runtime/Camera/Camera.h")]
[NativeHeader("Runtime/GfxDevice/GfxDeviceTypes.h")]
[NativeHeader("Runtime/Graphics/RenderTexture.h")]
[NativeHeader("Runtime/Misc/GameObjectUtility.h")]
[NativeHeader("Runtime/Shaders/Shader.h")]
[RequireComponent(typeof(Transform))]
[UsedByNativeCode]
public sealed class Camera : Behaviour
{
	internal sealed class CameraCallback : MulticastDelegate
	{

		public CameraCallback(object object, IntPtr method) { }

		public override void Invoke(Camera cam) { }

	}

	internal enum GateFitMode
	{
		Vertical = 1,
		Horizontal = 2,
		Fill = 3,
		Overscan = 4,
		None = 0,
	}

	internal struct GateFitParameters
	{
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
		private GateFitMode <mode>k__BackingField; //Field offset: 0x0
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
		private float <aspect>k__BackingField; //Field offset: 0x4

		public float aspect
		{
			[CompilerGenerated]
			[IsReadOnly]
			 get { } //Length: 6
		}

		public GateFitMode mode
		{
			[CompilerGenerated]
			[IsReadOnly]
			 get { } //Length: 3
		}

		[CompilerGenerated]
		[IsReadOnly]
		public float get_aspect() { }

		[CompilerGenerated]
		[IsReadOnly]
		public GateFitMode get_mode() { }

	}

	internal enum MonoOrStereoscopicEye
	{
		Left = 0,
		Right = 1,
		Mono = 2,
	}

	public enum ProjectionMatrixMode
	{
		Explicit = 0,
		Implicit = 1,
		PhysicalPropertiesBased = 2,
	}

	[Obsolete("The RenderRequest struct is obsolete, use the function overload with RequestData of supported types such as RenderPipeline.StandardRequest", True)]
	internal struct RenderRequest
	{
		private readonly RenderRequestMode m_CameraRenderMode; //Field offset: 0x0
		private readonly RenderTexture m_ResultRT; //Field offset: 0x8
		private readonly RenderRequestOutputSpace m_OutputSpace; //Field offset: 0x10

	}

	[Obsolete("The RenderRequest struct is obsolete, use the function overload with RequestData of supported types such as RenderPipeline.StandardRequest", True)]
	internal enum RenderRequestMode
	{
		None = 0,
		ObjectId = 1,
		Depth = 2,
		VertexNormal = 3,
		WorldPosition = 4,
		EntityId = 5,
		BaseColor = 6,
		SpecularColor = 7,
		Metallic = 8,
		Emission = 9,
		Normal = 10,
		Smoothness = 11,
		Occlusion = 12,
		DiffuseColor = 13,
	}

	[Obsolete("The RenderRequest struct is obsolete, use the function overload with RequestData of supported types such as RenderPipeline.StandardRequest", True)]
	internal enum RenderRequestOutputSpace
	{
		ScreenSpace = -1,
		UV0 = 0,
		UV1 = 1,
		UV2 = 2,
		UV3 = 3,
		UV4 = 4,
		UV5 = 5,
		UV6 = 6,
		UV7 = 7,
		UV8 = 8,
	}

	internal enum SceneViewFilterMode
	{
		Off = 0,
		ShowFiltered = 1,
	}

	internal enum StereoscopicEye
	{
		Left = 0,
		Right = 1,
	}

	public const float kMinAperture = 0.7; //Field offset: 0x0
	public const float kMaxAperture = 32; //Field offset: 0x0
	public const int kMinBladeCount = 3; //Field offset: 0x0
	public const int kMaxBladeCount = 11; //Field offset: 0x0
	public static CameraCallback onPreCull; //Field offset: 0x0
	public static CameraCallback onPreRender; //Field offset: 0x8
	public static CameraCallback onPostRender; //Field offset: 0x10

	public RenderTexture activeTexture
	{
		[NativeName("GetCurrentTargetTexture")]
		 get { } //Length: 51
	}

	public RenderingPath actualRenderingPath
	{
		[NativeName("CalculateRenderingPath")]
		 get { } //Length: 51
	}

	public static Camera[] allCameras
	{
		 get { } //Length: 129
	}

	public static int allCamerasCount
	{
		 get { } //Length: 42
	}

	public bool allowDynamicResolution
	{
		 get { } //Length: 51
		 set { } //Length: 66
	}

	public bool allowHDR
	{
		 get { } //Length: 51
		 set { } //Length: 66
	}

	public bool allowMSAA
	{
		 get { } //Length: 51
		 set { } //Length: 66
	}

	public float anamorphism
	{
		 get { } //Length: 51
		 set { } //Length: 67
	}

	public float aperture
	{
		 get { } //Length: 51
		 set { } //Length: 67
	}

	public bool areVRStereoViewMatricesWithinSingleCullTolerance
	{
		[NativeName("AreVRStereoViewMatricesWithinSingleCullTolerance")]
		 get { } //Length: 51
	}

	public float aspect
	{
		 get { } //Length: 51
		 set { } //Length: 67
	}

	public Color backgroundColor
	{
		 get { } //Length: 75
		 set { } //Length: 66
	}

	public float barrelClipping
	{
		 get { } //Length: 51
		 set { } //Length: 67
	}

	public int bladeCount
	{
		 get { } //Length: 51
		 set { } //Length: 64
	}

	public Matrix4x4 cameraToWorldMatrix
	{
		 get { } //Length: 87
	}

	public CameraType cameraType
	{
		 get { } //Length: 51
		 set { } //Length: 64
	}

	public CameraClearFlags clearFlags
	{
		 get { } //Length: 51
		 set { } //Length: 64
	}

	public bool clearStencilAfterLightingPass
	{
		 get { } //Length: 51
		 set { } //Length: 66
	}

	public int commandBufferCount
	{
		 get { } //Length: 51
	}

	public int cullingMask
	{
		 get { } //Length: 51
		 set { } //Length: 64
	}

	public Matrix4x4 cullingMatrix
	{
		 get { } //Length: 87
		 set { } //Length: 66
	}

	public static Camera current
	{
		[FreeFunction("GetCurrentCameraPPtr")]
		 get { } //Length: 42
	}

	public Vector2 curvature
	{
		 get { } //Length: 68
		 set { } //Length: 61
	}

	public float depth
	{
		 get { } //Length: 51
		 set { } //Length: 67
	}

	public DepthTextureMode depthTextureMode
	{
		 get { } //Length: 51
		 set { } //Length: 64
	}

	public int eventMask
	{
		 get { } //Length: 51
		 set { } //Length: 64
	}

	[NativeProperty("Far")]
	public float farClipPlane
	{
		 get { } //Length: 51
		 set { } //Length: 67
	}

	[NativeProperty("VerticalFieldOfView")]
	public float fieldOfView
	{
		 get { } //Length: 51
		 set { } //Length: 67
	}

	public float focalLength
	{
		 get { } //Length: 51
		 set { } //Length: 67
	}

	public float focusDistance
	{
		 get { } //Length: 51
		 set { } //Length: 67
	}

	[NativeProperty("ForceIntoRT")]
	public bool forceIntoRenderTexture
	{
		 get { } //Length: 51
		 set { } //Length: 66
	}

	public GateFitMode gateFit
	{
		 get { } //Length: 51
		 set { } //Length: 64
	}

	public int iso
	{
		 get { } //Length: 51
		 set { } //Length: 64
	}

	public Single[] layerCullDistances
	{
		 get { } //Length: 51
		 set { } //Length: 155
	}

	public bool layerCullSpherical
	{
		 get { } //Length: 51
		 set { } //Length: 66
	}

	public Vector2 lensShift
	{
		 get { } //Length: 68
		 set { } //Length: 61
	}

	public static Camera main
	{
		[FreeFunction("FindMainCamera")]
		 get { } //Length: 42
	}

	[NativeProperty("Near")]
	public float nearClipPlane
	{
		 get { } //Length: 51
		 set { } //Length: 67
	}

	public Matrix4x4 nonJitteredProjectionMatrix
	{
		 get { } //Length: 87
		 set { } //Length: 66
	}

	public OpaqueSortMode opaqueSortMode
	{
		 get { } //Length: 51
		 set { } //Length: 64
	}

	public bool orthographic
	{
		 get { } //Length: 51
		 set { } //Length: 66
	}

	public float orthographicSize
	{
		 get { } //Length: 51
		 set { } //Length: 67
	}

	[NativeConditional("UNITY_EDITOR")]
	public ulong overrideSceneCullingMask
	{
		 get { } //Length: 51
		 set { } //Length: 66
	}

	public int pixelHeight
	{
		[FreeFunction("CameraScripting::GetPixelHeight", HasExplicitThis = True)]
		 get { } //Length: 51
	}

	[NativeProperty("ScreenViewportRect")]
	public Rect pixelRect
	{
		 get { } //Length: 75
		 set { } //Length: 66
	}

	public int pixelWidth
	{
		[FreeFunction("CameraScripting::GetPixelWidth", HasExplicitThis = True)]
		 get { } //Length: 51
	}

	[Obsolete("PreviewCullingLayer is obsolete. Use scene culling masks instead.", False)]
	internal static int PreviewCullingLayer
	{
		internal get { } //Length: 8
	}

	public Matrix4x4 previousViewProjectionMatrix
	{
		 get { } //Length: 87
	}

	public Matrix4x4 projectionMatrix
	{
		 get { } //Length: 87
		 set { } //Length: 66
	}

	internal ProjectionMatrixMode projectionMatrixMode
	{
		internal get { } //Length: 51
	}

	[NativeProperty("NormalizedViewportRect")]
	public Rect rect
	{
		 get { } //Length: 75
		 set { } //Length: 66
	}

	public RenderingPath renderingPath
	{
		 get { } //Length: 51
		 set { } //Length: 64
	}

	public int scaledPixelHeight
	{
		[FreeFunction("CameraScripting::GetScaledPixelHeight", HasExplicitThis = True)]
		 get { } //Length: 51
	}

	public int scaledPixelWidth
	{
		[FreeFunction("CameraScripting::GetScaledPixelWidth", HasExplicitThis = True)]
		 get { } //Length: 51
	}

	public Scene scene
	{
		[FreeFunction("CameraScripting::GetScene", HasExplicitThis = True)]
		 get { } //Length: 68
		[FreeFunction("CameraScripting::SetScene", HasExplicitThis = True)]
		 set { } //Length: 59
	}

	[NativeConditional("UNITY_EDITOR")]
	internal ulong sceneCullingMask
	{
		internal get { } //Length: 51
	}

	[NativeConditional("UNITY_EDITOR")]
	public SceneViewFilterMode sceneViewFilterMode
	{
		 get { } //Length: 51
	}

	public Vector2 sensorSize
	{
		 get { } //Length: 68
		 set { } //Length: 61
	}

	public float shutterSpeed
	{
		 get { } //Length: 51
		 set { } //Length: 67
	}

	internal Material skyboxMaterial
	{
		internal get { } //Length: 51
	}

	public MonoOrStereoscopicEye stereoActiveEye
	{
		[FreeFunction("CameraScripting::GetStereoActiveEye", HasExplicitThis = True)]
		 get { } //Length: 51
	}

	public float stereoConvergence
	{
		 get { } //Length: 51
		 set { } //Length: 67
	}

	public bool stereoEnabled
	{
		[NativeMethod("GetStereoEnabledForBuiltInOrSRP")]
		 get { } //Length: 51
	}

	public float stereoSeparation
	{
		 get { } //Length: 51
		 set { } //Length: 67
	}

	public StereoTargetEyeMask stereoTargetEye
	{
		 get { } //Length: 51
		 set { } //Length: 64
	}

	public int targetDisplay
	{
		 get { } //Length: 51
		 set { } //Length: 64
	}

	public RenderTexture targetTexture
	{
		 get { } //Length: 51
		 set { } //Length: 66
	}

	public Vector3 transparencySortAxis
	{
		 get { } //Length: 77
		 set { } //Length: 66
	}

	public TransparencySortMode transparencySortMode
	{
		 get { } //Length: 51
		 set { } //Length: 64
	}

	[NativeProperty("UseJitteredProjectionMatrixForTransparent")]
	public bool useJitteredProjectionMatrixForTransparentRendering
	{
		 get { } //Length: 51
		 set { } //Length: 66
	}

	public bool useOcclusionCulling
	{
		 get { } //Length: 51
		 set { } //Length: 66
	}

	public bool usePhysicalProperties
	{
		 get { } //Length: 51
		 set { } //Length: 66
	}

	public Vector3 velocity
	{
		 get { } //Length: 77
	}

	public Matrix4x4 worldToCameraMatrix
	{
		 get { } //Length: 87
		 set { } //Length: 66
	}

	public Camera() { }

	public void AddCommandBuffer(CameraEvent evt, CommandBuffer buffer) { }

	public void AddCommandBufferAsync(CameraEvent evt, CommandBuffer buffer, ComputeQueueType queueType) { }

	[NativeName("AddCommandBufferAsync")]
	private void AddCommandBufferAsyncImpl(CameraEvent evt, CommandBuffer buffer, ComputeQueueType queueType) { }

	[NativeName("AddCommandBuffer")]
	private void AddCommandBufferImpl(CameraEvent evt, CommandBuffer buffer) { }

	public void CalculateFrustumCorners(Rect viewport, float z, MonoOrStereoscopicEye eye, Vector3[] outCorners) { }

	[FreeFunction("CameraScripting::CalculateViewportRayVectors", HasExplicitThis = True)]
	private void CalculateFrustumCornersInternal(Rect viewport, float z, MonoOrStereoscopicEye eye, out Vector3[] outCorners) { }

	private void CalculateFrustumCornersInternal_Injected(ref Rect viewport, float z, MonoOrStereoscopicEye eye, out Vector3[] outCorners) { }

	[FreeFunction("CameraScripting::CalculateObliqueMatrix", HasExplicitThis = True)]
	public Matrix4x4 CalculateObliqueMatrix(Vector4 clipPlane) { }

	private void CalculateObliqueMatrix_Injected(ref Vector4 clipPlane, out Matrix4x4 ret) { }

	public static void CalculateProjectionMatrixFromPhysicalProperties(out Matrix4x4 output, float focalLength, Vector2 sensorSize, Vector2 lensShift, float nearClip, float farClip, GateFitParameters gateFitParameters = null) { }

	[NativeName("CalculateProjectionMatrixFromPhysicalProperties")]
	private static void CalculateProjectionMatrixFromPhysicalPropertiesInternal(out Matrix4x4 output, float focalLength, Vector2 sensorSize, Vector2 lensShift, float nearClip, float farClip, float gateAspect, GateFitMode gateFitMode) { }

	private static void CalculateProjectionMatrixFromPhysicalPropertiesInternal_Injected(out Matrix4x4 output, float focalLength, ref Vector2 sensorSize, ref Vector2 lensShift, float nearClip, float farClip, float gateAspect, GateFitMode gateFitMode) { }

	[FreeFunction("CameraScripting::CopyFrom", HasExplicitThis = True)]
	public void CopyFrom(Camera other) { }

	public void CopyStereoDeviceProjectionMatrixToNonJittered(StereoscopicEye eye) { }

	[NativeName("FieldOfViewToFocalLength_Safe")]
	public static float FieldOfViewToFocalLength(float fieldOfView, float sensorSize) { }

	[RequiredByNativeCode]
	private static void FireOnPostRender(Camera cam) { }

	[RequiredByNativeCode]
	private static void FireOnPreCull(Camera cam) { }

	[RequiredByNativeCode]
	private static void FireOnPreRender(Camera cam) { }

	[NativeName("FocalLengthToFieldOfView_Safe")]
	public static float FocalLengthToFieldOfView(float focalLength, float sensorSize) { }

	[NativeName("GetCurrentTargetTexture")]
	public RenderTexture get_activeTexture() { }

	[NativeName("CalculateRenderingPath")]
	public RenderingPath get_actualRenderingPath() { }

	public static Camera[] get_allCameras() { }

	public static int get_allCamerasCount() { }

	public bool get_allowDynamicResolution() { }

	public bool get_allowHDR() { }

	public bool get_allowMSAA() { }

	public float get_anamorphism() { }

	public float get_aperture() { }

	[NativeName("AreVRStereoViewMatricesWithinSingleCullTolerance")]
	public bool get_areVRStereoViewMatricesWithinSingleCullTolerance() { }

	public float get_aspect() { }

	public Color get_backgroundColor() { }

	private void get_backgroundColor_Injected(out Color ret) { }

	public float get_barrelClipping() { }

	public int get_bladeCount() { }

	public Matrix4x4 get_cameraToWorldMatrix() { }

	private void get_cameraToWorldMatrix_Injected(out Matrix4x4 ret) { }

	public CameraType get_cameraType() { }

	public CameraClearFlags get_clearFlags() { }

	public bool get_clearStencilAfterLightingPass() { }

	public int get_commandBufferCount() { }

	public int get_cullingMask() { }

	public Matrix4x4 get_cullingMatrix() { }

	private void get_cullingMatrix_Injected(out Matrix4x4 ret) { }

	[FreeFunction("GetCurrentCameraPPtr")]
	public static Camera get_current() { }

	public Vector2 get_curvature() { }

	private void get_curvature_Injected(out Vector2 ret) { }

	public float get_depth() { }

	public DepthTextureMode get_depthTextureMode() { }

	public int get_eventMask() { }

	public float get_farClipPlane() { }

	public float get_fieldOfView() { }

	public float get_focalLength() { }

	public float get_focusDistance() { }

	public bool get_forceIntoRenderTexture() { }

	public GateFitMode get_gateFit() { }

	public int get_iso() { }

	public Single[] get_layerCullDistances() { }

	public bool get_layerCullSpherical() { }

	public Vector2 get_lensShift() { }

	private void get_lensShift_Injected(out Vector2 ret) { }

	[FreeFunction("FindMainCamera")]
	public static Camera get_main() { }

	public float get_nearClipPlane() { }

	public Matrix4x4 get_nonJitteredProjectionMatrix() { }

	private void get_nonJitteredProjectionMatrix_Injected(out Matrix4x4 ret) { }

	public OpaqueSortMode get_opaqueSortMode() { }

	public bool get_orthographic() { }

	public float get_orthographicSize() { }

	public ulong get_overrideSceneCullingMask() { }

	[FreeFunction("CameraScripting::GetPixelHeight", HasExplicitThis = True)]
	public int get_pixelHeight() { }

	public Rect get_pixelRect() { }

	private void get_pixelRect_Injected(out Rect ret) { }

	[FreeFunction("CameraScripting::GetPixelWidth", HasExplicitThis = True)]
	public int get_pixelWidth() { }

	internal static int get_PreviewCullingLayer() { }

	public Matrix4x4 get_previousViewProjectionMatrix() { }

	private void get_previousViewProjectionMatrix_Injected(out Matrix4x4 ret) { }

	public Matrix4x4 get_projectionMatrix() { }

	private void get_projectionMatrix_Injected(out Matrix4x4 ret) { }

	internal ProjectionMatrixMode get_projectionMatrixMode() { }

	public Rect get_rect() { }

	private void get_rect_Injected(out Rect ret) { }

	public RenderingPath get_renderingPath() { }

	[FreeFunction("CameraScripting::GetScaledPixelHeight", HasExplicitThis = True)]
	public int get_scaledPixelHeight() { }

	[FreeFunction("CameraScripting::GetScaledPixelWidth", HasExplicitThis = True)]
	public int get_scaledPixelWidth() { }

	[FreeFunction("CameraScripting::GetScene", HasExplicitThis = True)]
	public Scene get_scene() { }

	private void get_scene_Injected(out Scene ret) { }

	internal ulong get_sceneCullingMask() { }

	public SceneViewFilterMode get_sceneViewFilterMode() { }

	public Vector2 get_sensorSize() { }

	private void get_sensorSize_Injected(out Vector2 ret) { }

	public float get_shutterSpeed() { }

	internal Material get_skyboxMaterial() { }

	[FreeFunction("CameraScripting::GetStereoActiveEye", HasExplicitThis = True)]
	public MonoOrStereoscopicEye get_stereoActiveEye() { }

	public float get_stereoConvergence() { }

	[NativeMethod("GetStereoEnabledForBuiltInOrSRP")]
	public bool get_stereoEnabled() { }

	public float get_stereoSeparation() { }

	public StereoTargetEyeMask get_stereoTargetEye() { }

	public int get_targetDisplay() { }

	public RenderTexture get_targetTexture() { }

	public Vector3 get_transparencySortAxis() { }

	private void get_transparencySortAxis_Injected(out Vector3 ret) { }

	public TransparencySortMode get_transparencySortMode() { }

	public bool get_useJitteredProjectionMatrixForTransparentRendering() { }

	public bool get_useOcclusionCulling() { }

	public bool get_usePhysicalProperties() { }

	public Vector3 get_velocity() { }

	private void get_velocity_Injected(out Vector3 ret) { }

	public Matrix4x4 get_worldToCameraMatrix() { }

	private void get_worldToCameraMatrix_Injected(out Matrix4x4 ret) { }

	public static int GetAllCameras(Camera[] cameras) { }

	[FreeFunction("CameraScripting::GetAllCamerasCount")]
	private static int GetAllCamerasCount() { }

	[FreeFunction("CameraScripting::GetAllCameras")]
	private static int GetAllCamerasImpl(out Camera[] cam) { }

	internal String[] GetCameraBufferWarnings() { }

	[FreeFunction("CameraScripting::GetCommandBuffers", HasExplicitThis = True)]
	public CommandBuffer[] GetCommandBuffers(CameraEvent evt) { }

	[FreeFunction("ScriptableRenderPipeline_Bindings::GetCullingParameters_Internal")]
	[NativeHeader("Runtime/Export/RenderPipeline/ScriptableRenderPipeline.bindings.h")]
	private static bool GetCullingParameters_Internal(Camera camera, bool stereoAware, out ScriptableCullingParameters cullingParameters, int managedCullingParametersSize) { }

	[NativeConditional("UNITY_EDITOR")]
	private int GetFilterMode() { }

	internal Vector2 GetFrustumPlaneSizeAt(float distance) { }

	private void GetFrustumPlaneSizeAt_Injected(float distance, out Vector2 ret) { }

	public float GetGateFittedFieldOfView() { }

	public Vector2 GetGateFittedLensShift() { }

	private void GetGateFittedLensShift_Injected(out Vector2 ret) { }

	[FreeFunction("CameraScripting::GetLayerCullDistances", HasExplicitThis = True)]
	private Single[] GetLayerCullDistances() { }

	internal Vector3 GetLocalSpaceAim() { }

	private void GetLocalSpaceAim_Injected(out Vector3 ret) { }

	public Matrix4x4 GetStereoNonJitteredProjectionMatrix(StereoscopicEye eye) { }

	private void GetStereoNonJitteredProjectionMatrix_Injected(StereoscopicEye eye, out Matrix4x4 ret) { }

	[FreeFunction("CameraScripting::GetStereoProjectionMatrix", HasExplicitThis = True)]
	public Matrix4x4 GetStereoProjectionMatrix(StereoscopicEye eye) { }

	private void GetStereoProjectionMatrix_Injected(StereoscopicEye eye, out Matrix4x4 ret) { }

	[FreeFunction("CameraScripting::GetStereoViewMatrix", HasExplicitThis = True)]
	public Matrix4x4 GetStereoViewMatrix(StereoscopicEye eye) { }

	private void GetStereoViewMatrix_Injected(StereoscopicEye eye, out Matrix4x4 ret) { }

	[NativeName("HorizontalToVerticalFieldOfView_Safe")]
	public static float HorizontalToVerticalFieldOfView(float horizontalFieldOfView, float aspectRatio) { }

	internal void OnlyUsedForTesting1() { }

	internal void OnlyUsedForTesting2() { }

	public void RemoveAllCommandBuffers() { }

	public void RemoveCommandBuffer(CameraEvent evt, CommandBuffer buffer) { }

	[NativeName("RemoveCommandBuffer")]
	private void RemoveCommandBufferImpl(CameraEvent evt, CommandBuffer buffer) { }

	public void RemoveCommandBuffers(CameraEvent evt) { }

	[FreeFunction("CameraScripting::Render", HasExplicitThis = True)]
	public void Render() { }

	[FreeFunction("CameraScripting::RenderDontRestore", HasExplicitThis = True)]
	public void RenderDontRestore() { }

	public bool RenderToCubemap(Cubemap cubemap, int faceMask) { }

	public bool RenderToCubemap(Cubemap cubemap) { }

	public bool RenderToCubemap(RenderTexture cubemap, int faceMask) { }

	public bool RenderToCubemap(RenderTexture cubemap, int faceMask, MonoOrStereoscopicEye stereoEye) { }

	public bool RenderToCubemap(RenderTexture cubemap) { }

	[NativeName("RenderToCubemap")]
	private bool RenderToCubemapEyeImpl(RenderTexture cubemap, int faceMask, MonoOrStereoscopicEye stereoEye) { }

	[FreeFunction("CameraScripting::RenderToCubemap", HasExplicitThis = True)]
	private bool RenderToCubemapImpl(Texture tex, int faceMask) { }

	[FreeFunction("CameraScripting::RenderWithShader", HasExplicitThis = True)]
	public void RenderWithShader(Shader shader, string replacementTag) { }

	public void Reset() { }

	public void ResetAspect() { }

	public void ResetCullingMatrix() { }

	public void ResetProjectionMatrix() { }

	public void ResetReplacementShader() { }

	public void ResetStereoProjectionMatrices() { }

	public void ResetStereoViewMatrices() { }

	public void ResetTransparencySortSettings() { }

	public void ResetWorldToCameraMatrix() { }

	public Ray ScreenPointToRay(Vector3 pos, MonoOrStereoscopicEye eye) { }

	private Ray ScreenPointToRay(Vector2 pos, MonoOrStereoscopicEye eye) { }

	public Ray ScreenPointToRay(Vector3 pos) { }

	private void ScreenPointToRay_Injected(ref Vector2 pos, MonoOrStereoscopicEye eye, out Ray ret) { }

	public Vector3 ScreenToViewportPoint(Vector3 position) { }

	private void ScreenToViewportPoint_Injected(ref Vector3 position, out Vector3 ret) { }

	public Vector3 ScreenToWorldPoint(Vector3 position, MonoOrStereoscopicEye eye) { }

	public Vector3 ScreenToWorldPoint(Vector3 position) { }

	private void ScreenToWorldPoint_Injected(ref Vector3 position, MonoOrStereoscopicEye eye, out Vector3 ret) { }

	public void set_allowDynamicResolution(bool value) { }

	public void set_allowHDR(bool value) { }

	public void set_allowMSAA(bool value) { }

	public void set_anamorphism(float value) { }

	public void set_aperture(float value) { }

	public void set_aspect(float value) { }

	public void set_backgroundColor(Color value) { }

	private void set_backgroundColor_Injected(ref Color value) { }

	public void set_barrelClipping(float value) { }

	public void set_bladeCount(int value) { }

	public void set_cameraType(CameraType value) { }

	public void set_clearFlags(CameraClearFlags value) { }

	public void set_clearStencilAfterLightingPass(bool value) { }

	public void set_cullingMask(int value) { }

	public void set_cullingMatrix(Matrix4x4 value) { }

	private void set_cullingMatrix_Injected(ref Matrix4x4 value) { }

	public void set_curvature(Vector2 value) { }

	private void set_curvature_Injected(ref Vector2 value) { }

	public void set_depth(float value) { }

	public void set_depthTextureMode(DepthTextureMode value) { }

	public void set_eventMask(int value) { }

	public void set_farClipPlane(float value) { }

	public void set_fieldOfView(float value) { }

	public void set_focalLength(float value) { }

	public void set_focusDistance(float value) { }

	public void set_forceIntoRenderTexture(bool value) { }

	public void set_gateFit(GateFitMode value) { }

	public void set_iso(int value) { }

	public void set_layerCullDistances(Single[] value) { }

	public void set_layerCullSpherical(bool value) { }

	public void set_lensShift(Vector2 value) { }

	private void set_lensShift_Injected(ref Vector2 value) { }

	public void set_nearClipPlane(float value) { }

	public void set_nonJitteredProjectionMatrix(Matrix4x4 value) { }

	private void set_nonJitteredProjectionMatrix_Injected(ref Matrix4x4 value) { }

	public void set_opaqueSortMode(OpaqueSortMode value) { }

	public void set_orthographic(bool value) { }

	public void set_orthographicSize(float value) { }

	public void set_overrideSceneCullingMask(ulong value) { }

	public void set_pixelRect(Rect value) { }

	private void set_pixelRect_Injected(ref Rect value) { }

	public void set_projectionMatrix(Matrix4x4 value) { }

	private void set_projectionMatrix_Injected(ref Matrix4x4 value) { }

	public void set_rect(Rect value) { }

	private void set_rect_Injected(ref Rect value) { }

	public void set_renderingPath(RenderingPath value) { }

	[FreeFunction("CameraScripting::SetScene", HasExplicitThis = True)]
	public void set_scene(Scene value) { }

	private void set_scene_Injected(ref Scene value) { }

	public void set_sensorSize(Vector2 value) { }

	private void set_sensorSize_Injected(ref Vector2 value) { }

	public void set_shutterSpeed(float value) { }

	public void set_stereoConvergence(float value) { }

	public void set_stereoSeparation(float value) { }

	public void set_stereoTargetEye(StereoTargetEyeMask value) { }

	public void set_targetDisplay(int value) { }

	public void set_targetTexture(RenderTexture value) { }

	public void set_transparencySortAxis(Vector3 value) { }

	private void set_transparencySortAxis_Injected(ref Vector3 value) { }

	public void set_transparencySortMode(TransparencySortMode value) { }

	public void set_useJitteredProjectionMatrixForTransparentRendering(bool value) { }

	public void set_useOcclusionCulling(bool value) { }

	public void set_usePhysicalProperties(bool value) { }

	public void set_worldToCameraMatrix(Matrix4x4 value) { }

	private void set_worldToCameraMatrix_Injected(ref Matrix4x4 value) { }

	[FreeFunction("CameraScripting::SetLayerCullDistances", HasExplicitThis = True)]
	private void SetLayerCullDistances(Single[] d) { }

	public void SetReplacementShader(Shader shader, string replacementTag) { }

	public void SetStereoProjectionMatrix(StereoscopicEye eye, Matrix4x4 matrix) { }

	private void SetStereoProjectionMatrix_Injected(StereoscopicEye eye, ref Matrix4x4 matrix) { }

	public void SetStereoViewMatrix(StereoscopicEye eye, Matrix4x4 matrix) { }

	private void SetStereoViewMatrix_Injected(StereoscopicEye eye, ref Matrix4x4 matrix) { }

	public void SetTargetBuffers(RenderBuffer colorBuffer, RenderBuffer depthBuffer) { }

	public void SetTargetBuffers(RenderBuffer[] colorBuffer, RenderBuffer depthBuffer) { }

	[FreeFunction("CameraScripting::SetTargetBuffers", HasExplicitThis = True)]
	private void SetTargetBuffersImpl(RenderBuffer color, RenderBuffer depth) { }

	private void SetTargetBuffersImpl_Injected(ref RenderBuffer color, ref RenderBuffer depth) { }

	[FreeFunction("CameraScripting::SetTargetBuffers", HasExplicitThis = True)]
	private void SetTargetBuffersMRTImpl(RenderBuffer[] color, RenderBuffer depth) { }

	private void SetTargetBuffersMRTImpl_Injected(RenderBuffer[] color, ref RenderBuffer depth) { }

	[FreeFunction("CameraScripting::SetupCurrent")]
	public static void SetupCurrent(Camera cur) { }

	[FreeFunction("CameraScripting::SubmitBuiltInObjectIDRenderRequest", HasExplicitThis = True)]
	[NativeConditional("UNITY_EDITOR")]
	private Object[] SubmitBuiltInObjectIDRenderRequest(RenderTexture target, int mipLevel, CubemapFace cubemapFace, int depthSlice) { }

	public void SubmitRenderRequest(RequestData renderRequest) { }

	[Obsolete("SubmitRenderRequests is obsolete, use SubmitRenderRequest with RequestData of supported types such as RenderPipeline.StandardRequest", True)]
	public void SubmitRenderRequests(List<RenderRequest> renderRequests) { }

	[FreeFunction("CameraScripting::SubmitRenderRequests", HasExplicitThis = True)]
	private void SubmitRenderRequestsInternal(object requests) { }

	public bool TryGetCullingParameters(out ScriptableCullingParameters cullingParameters) { }

	public bool TryGetCullingParameters(bool stereoAware, out ScriptableCullingParameters cullingParameters) { }

	public static float VerticalToHorizontalFieldOfView(float verticalFieldOfView, float aspectRatio) { }

	private Ray ViewportPointToRay(Vector2 pos, MonoOrStereoscopicEye eye) { }

	public Ray ViewportPointToRay(Vector3 pos, MonoOrStereoscopicEye eye) { }

	public Ray ViewportPointToRay(Vector3 pos) { }

	private void ViewportPointToRay_Injected(ref Vector2 pos, MonoOrStereoscopicEye eye, out Ray ret) { }

	public Vector3 ViewportToScreenPoint(Vector3 position) { }

	private void ViewportToScreenPoint_Injected(ref Vector3 position, out Vector3 ret) { }

	public Vector3 ViewportToWorldPoint(Vector3 position) { }

	public Vector3 ViewportToWorldPoint(Vector3 position, MonoOrStereoscopicEye eye) { }

	private void ViewportToWorldPoint_Injected(ref Vector3 position, MonoOrStereoscopicEye eye, out Vector3 ret) { }

	public Vector3 WorldToScreenPoint(Vector3 position) { }

	public Vector3 WorldToScreenPoint(Vector3 position, MonoOrStereoscopicEye eye) { }

	private void WorldToScreenPoint_Injected(ref Vector3 position, MonoOrStereoscopicEye eye, out Vector3 ret) { }

	public Vector3 WorldToViewportPoint(Vector3 position) { }

	public Vector3 WorldToViewportPoint(Vector3 position, MonoOrStereoscopicEye eye) { }

	private void WorldToViewportPoint_Injected(ref Vector3 position, MonoOrStereoscopicEye eye, out Vector3 ret) { }

}

