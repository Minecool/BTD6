namespace UnityEngine;

[NativeHeader("Runtime/Camera/RenderManager.h")]
[NativeHeader("Runtime/Camera/Camera.h")]
[NativeHeader("Runtime/Graphics/RenderTexture.h")]
[NativeHeader("Runtime/Misc/GameObjectUtility.h")]
[NativeHeader("Runtime/GfxDevice/GfxDeviceTypes.h")]
[NativeHeader("Runtime/Graphics/CommandBuffer/RenderingCommandBuffer.h")]
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
	internal uint m_NonSerializedVersion; //Field offset: 0x18

	public RenderTexture activeTexture
	{
		[NativeName("GetCurrentTargetTexture")]
		 get { } //Length: 144
	}

	public RenderingPath actualRenderingPath
	{
		[NativeName("CalculateRenderingPath")]
		 get { } //Length: 118
	}

	public static Camera[] allCameras
	{
		 get { } //Length: 179
	}

	public static int allCamerasCount
	{
		 get { } //Length: 42
	}

	public bool allowDynamicResolution
	{
		 get { } //Length: 118
		 set { } //Length: 134
	}

	public bool allowHDR
	{
		 get { } //Length: 118
		 set { } //Length: 134
	}

	public bool allowMSAA
	{
		 get { } //Length: 118
		 set { } //Length: 134
	}

	public float anamorphism
	{
		 get { } //Length: 118
		 set { } //Length: 134
	}

	public float aperture
	{
		 get { } //Length: 118
		 set { } //Length: 134
	}

	public bool areVRStereoViewMatricesWithinSingleCullTolerance
	{
		[NativeName("AreVRStereoViewMatricesWithinSingleCullTolerance")]
		 get { } //Length: 118
	}

	public float aspect
	{
		 get { } //Length: 118
		 set { } //Length: 134
	}

	public Color backgroundColor
	{
		 get { } //Length: 142
		 set { } //Length: 133
	}

	public float barrelClipping
	{
		 get { } //Length: 118
		 set { } //Length: 134
	}

	public int bladeCount
	{
		 get { } //Length: 118
		 set { } //Length: 131
	}

	public Matrix4x4 cameraToWorldMatrix
	{
		 get { } //Length: 154
	}

	public CameraType cameraType
	{
		 get { } //Length: 118
		 set { } //Length: 131
	}

	public CameraClearFlags clearFlags
	{
		 get { } //Length: 118
		 set { } //Length: 131
	}

	public bool clearStencilAfterLightingPass
	{
		 get { } //Length: 118
		 set { } //Length: 134
	}

	public int commandBufferCount
	{
		 get { } //Length: 118
	}

	public int cullingMask
	{
		 get { } //Length: 118
		 set { } //Length: 131
	}

	public Matrix4x4 cullingMatrix
	{
		 get { } //Length: 154
		 set { } //Length: 133
	}

	public static Camera current
	{
		 get { } //Length: 84
	}

	private static Camera currentInternal
	{
		[FreeFunction("GetCurrentCameraPPtr")]
		private get { } //Length: 84
	}

	public Vector2 curvature
	{
		 get { } //Length: 137
		 set { } //Length: 128
	}

	public float depth
	{
		 get { } //Length: 118
		 set { } //Length: 134
	}

	public DepthTextureMode depthTextureMode
	{
		 get { } //Length: 118
		 set { } //Length: 131
	}

	public int eventMask
	{
		 get { } //Length: 118
		 set { } //Length: 131
	}

	[NativeProperty("Far")]
	public float farClipPlane
	{
		 get { } //Length: 118
		 set { } //Length: 134
	}

	[NativeProperty("VerticalFieldOfView")]
	public float fieldOfView
	{
		 get { } //Length: 118
		 set { } //Length: 134
	}

	public float focalLength
	{
		 get { } //Length: 118
		 set { } //Length: 134
	}

	public float focusDistance
	{
		 get { } //Length: 118
		 set { } //Length: 134
	}

	[NativeProperty("ForceIntoRT")]
	public bool forceIntoRenderTexture
	{
		 get { } //Length: 118
		 set { } //Length: 134
	}

	public GateFitMode gateFit
	{
		 get { } //Length: 118
		 set { } //Length: 131
	}

	public int iso
	{
		 get { } //Length: 118
		 set { } //Length: 131
	}

	public Single[] layerCullDistances
	{
		 get { } //Length: 9
		 set { } //Length: 355
	}

	public bool layerCullSpherical
	{
		 get { } //Length: 118
		 set { } //Length: 302
	}

	[NativeProperty("LayerCullSpherical")]
	internal bool layerCullSphericalInternal
	{
		internal get { } //Length: 118
		internal set { } //Length: 134
	}

	public Vector2 lensShift
	{
		 get { } //Length: 137
		 set { } //Length: 128
	}

	public static Camera main
	{
		[FreeFunction("FindMainCamera")]
		 get { } //Length: 84
	}

	[NativeProperty("Near")]
	public float nearClipPlane
	{
		 get { } //Length: 118
		 set { } //Length: 134
	}

	public Matrix4x4 nonJitteredProjectionMatrix
	{
		 get { } //Length: 154
		 set { } //Length: 133
	}

	public OpaqueSortMode opaqueSortMode
	{
		 get { } //Length: 118
		 set { } //Length: 131
	}

	public bool orthographic
	{
		 get { } //Length: 118
		 set { } //Length: 134
	}

	public float orthographicSize
	{
		 get { } //Length: 118
		 set { } //Length: 134
	}

	[NativeConditional("UNITY_EDITOR")]
	public ulong overrideSceneCullingMask
	{
		 get { } //Length: 118
		 set { } //Length: 133
	}

	public int pixelHeight
	{
		[FreeFunction("CameraScripting::GetPixelHeight", HasExplicitThis = True)]
		 get { } //Length: 118
	}

	[NativeProperty("ScreenViewportRect")]
	public Rect pixelRect
	{
		 get { } //Length: 142
		 set { } //Length: 133
	}

	public int pixelWidth
	{
		[FreeFunction("CameraScripting::GetPixelWidth", HasExplicitThis = True)]
		 get { } //Length: 118
	}

	[Obsolete("PreviewCullingLayer is obsolete. Use scene culling masks instead.", False)]
	internal static int PreviewCullingLayer
	{
		internal get { } //Length: 8
	}

	public Matrix4x4 previousViewProjectionMatrix
	{
		 get { } //Length: 154
	}

	public Matrix4x4 projectionMatrix
	{
		 get { } //Length: 154
		 set { } //Length: 133
	}

	internal ProjectionMatrixMode projectionMatrixMode
	{
		internal get { } //Length: 118
	}

	[NativeProperty("NormalizedViewportRect")]
	public Rect rect
	{
		 get { } //Length: 142
		 set { } //Length: 133
	}

	[NativeConditional("UNITY_EDITOR")]
	public bool renderCloudsInSceneView
	{
		 get { } //Length: 118
		 set { } //Length: 134
	}

	public RenderingPath renderingPath
	{
		 get { } //Length: 118
		 set { } //Length: 131
	}

	public int scaledPixelHeight
	{
		[FreeFunction("CameraScripting::GetScaledPixelHeight", HasExplicitThis = True)]
		 get { } //Length: 118
	}

	public int scaledPixelWidth
	{
		[FreeFunction("CameraScripting::GetScaledPixelWidth", HasExplicitThis = True)]
		 get { } //Length: 118
	}

	public Scene scene
	{
		[FreeFunction("CameraScripting::GetScene", HasExplicitThis = True)]
		 get { } //Length: 135
		[FreeFunction("CameraScripting::SetScene", HasExplicitThis = True)]
		 set { } //Length: 126
	}

	[NativeConditional("UNITY_EDITOR")]
	internal ulong sceneCullingMask
	{
		internal get { } //Length: 118
	}

	[NativeConditional("UNITY_EDITOR")]
	public SceneViewFilterMode sceneViewFilterMode
	{
		 get { } //Length: 118
	}

	public Vector2 sensorSize
	{
		 get { } //Length: 137
		 set { } //Length: 128
	}

	public float shutterSpeed
	{
		 get { } //Length: 118
		 set { } //Length: 134
	}

	internal Material skyboxMaterial
	{
		internal get { } //Length: 144
	}

	public MonoOrStereoscopicEye stereoActiveEye
	{
		[FreeFunction("CameraScripting::GetStereoActiveEye", HasExplicitThis = True)]
		 get { } //Length: 118
	}

	public float stereoConvergence
	{
		 get { } //Length: 118
		 set { } //Length: 134
	}

	public bool stereoEnabled
	{
		[NativeMethod("GetStereoEnabledForBuiltInOrSRP")]
		 get { } //Length: 118
	}

	public float stereoSeparation
	{
		 get { } //Length: 118
		 set { } //Length: 134
	}

	public StereoTargetEyeMask stereoTargetEye
	{
		 get { } //Length: 118
		 set { } //Length: 299
	}

	[NativeProperty("StereoTargetEye")]
	internal StereoTargetEyeMask stereoTargetEyeInternal
	{
		internal get { } //Length: 118
		internal set { } //Length: 131
	}

	public int targetDisplay
	{
		 get { } //Length: 118
		 set { } //Length: 131
	}

	public RenderTexture targetTexture
	{
		 get { } //Length: 144
		 set { } //Length: 177
	}

	public Vector3 transparencySortAxis
	{
		 get { } //Length: 144
		 set { } //Length: 133
	}

	public TransparencySortMode transparencySortMode
	{
		 get { } //Length: 118
		 set { } //Length: 131
	}

	[NativeConditional("UNITY_EDITOR")]
	internal bool useInteractiveLightBakingData
	{
		internal get { } //Length: 118
		internal set { } //Length: 134
	}

	[NativeProperty("UseJitteredProjectionMatrixForTransparent")]
	public bool useJitteredProjectionMatrixForTransparentRendering
	{
		 get { } //Length: 118
		 set { } //Length: 134
	}

	public bool useOcclusionCulling
	{
		 get { } //Length: 118
		 set { } //Length: 134
	}

	public bool usePhysicalProperties
	{
		 get { } //Length: 118
		 set { } //Length: 134
	}

	public Vector3 velocity
	{
		 get { } //Length: 144
	}

	public Matrix4x4 worldToCameraMatrix
	{
		 get { } //Length: 154
		 set { } //Length: 133
	}

	public Camera() { }

	public void AddCommandBuffer(CameraEvent evt, CommandBuffer buffer) { }

	public void AddCommandBufferAsync(CameraEvent evt, CommandBuffer buffer, ComputeQueueType queueType) { }

	[NativeName("AddCommandBufferAsync")]
	private void AddCommandBufferAsyncImpl(CameraEvent evt, CommandBuffer buffer, ComputeQueueType queueType) { }

	private static void AddCommandBufferAsyncImpl_Injected(IntPtr _unity_self, CameraEvent evt, IntPtr buffer, ComputeQueueType queueType) { }

	[NativeName("AddCommandBuffer")]
	private void AddCommandBufferImpl(CameraEvent evt, CommandBuffer buffer) { }

	private static void AddCommandBufferImpl_Injected(IntPtr _unity_self, CameraEvent evt, IntPtr buffer) { }

	[RequiredByNativeCode]
	private static void BumpNonSerializedVersion(Camera cam) { }

	public void CalculateFrustumCorners(Rect viewport, float z, MonoOrStereoscopicEye eye, Vector3[] outCorners) { }

	[FreeFunction("CameraScripting::CalculateViewportRayVectors", HasExplicitThis = True)]
	private void CalculateFrustumCornersInternal(Rect viewport, float z, MonoOrStereoscopicEye eye, out Vector3[] outCorners) { }

	private static void CalculateFrustumCornersInternal_Injected(IntPtr _unity_self, in Rect viewport, float z, MonoOrStereoscopicEye eye, out BlittableArrayWrapper outCorners) { }

	[FreeFunction("CameraScripting::CalculateObliqueMatrix", HasExplicitThis = True)]
	public Matrix4x4 CalculateObliqueMatrix(Vector4 clipPlane) { }

	private static void CalculateObliqueMatrix_Injected(IntPtr _unity_self, in Vector4 clipPlane, out Matrix4x4 ret) { }

	public static void CalculateProjectionMatrixFromPhysicalProperties(out Matrix4x4 output, float focalLength, Vector2 sensorSize, Vector2 lensShift, float nearClip, float farClip, GateFitParameters gateFitParameters = null) { }

	[NativeName("CalculateProjectionMatrixFromPhysicalProperties")]
	private static void CalculateProjectionMatrixFromPhysicalPropertiesInternal(out Matrix4x4 output, float focalLength, Vector2 sensorSize, Vector2 lensShift, float nearClip, float farClip, float gateAspect, GateFitMode gateFitMode) { }

	private static void CalculateProjectionMatrixFromPhysicalPropertiesInternal_Injected(out Matrix4x4 output, float focalLength, in Vector2 sensorSize, in Vector2 lensShift, float nearClip, float farClip, float gateAspect, GateFitMode gateFitMode) { }

	[FreeFunction("CameraScripting::CopyFrom", HasExplicitThis = True)]
	public void CopyFrom(Camera other) { }

	private static void CopyFrom_Injected(IntPtr _unity_self, IntPtr other) { }

	public void CopyStereoDeviceProjectionMatrixToNonJittered(StereoscopicEye eye) { }

	private static void CopyStereoDeviceProjectionMatrixToNonJittered_Injected(IntPtr _unity_self, StereoscopicEye eye) { }

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

	private static IntPtr get_activeTexture_Injected(IntPtr _unity_self) { }

	[NativeName("CalculateRenderingPath")]
	public RenderingPath get_actualRenderingPath() { }

	private static RenderingPath get_actualRenderingPath_Injected(IntPtr _unity_self) { }

	public static Camera[] get_allCameras() { }

	public static int get_allCamerasCount() { }

	public bool get_allowDynamicResolution() { }

	private static bool get_allowDynamicResolution_Injected(IntPtr _unity_self) { }

	public bool get_allowHDR() { }

	private static bool get_allowHDR_Injected(IntPtr _unity_self) { }

	public bool get_allowMSAA() { }

	private static bool get_allowMSAA_Injected(IntPtr _unity_self) { }

	public float get_anamorphism() { }

	private static float get_anamorphism_Injected(IntPtr _unity_self) { }

	public float get_aperture() { }

	private static float get_aperture_Injected(IntPtr _unity_self) { }

	[NativeName("AreVRStereoViewMatricesWithinSingleCullTolerance")]
	public bool get_areVRStereoViewMatricesWithinSingleCullTolerance() { }

	private static bool get_areVRStereoViewMatricesWithinSingleCullTolerance_Injected(IntPtr _unity_self) { }

	public float get_aspect() { }

	private static float get_aspect_Injected(IntPtr _unity_self) { }

	public Color get_backgroundColor() { }

	private static void get_backgroundColor_Injected(IntPtr _unity_self, out Color ret) { }

	public float get_barrelClipping() { }

	private static float get_barrelClipping_Injected(IntPtr _unity_self) { }

	public int get_bladeCount() { }

	private static int get_bladeCount_Injected(IntPtr _unity_self) { }

	public Matrix4x4 get_cameraToWorldMatrix() { }

	private static void get_cameraToWorldMatrix_Injected(IntPtr _unity_self, out Matrix4x4 ret) { }

	public CameraType get_cameraType() { }

	private static CameraType get_cameraType_Injected(IntPtr _unity_self) { }

	public CameraClearFlags get_clearFlags() { }

	private static CameraClearFlags get_clearFlags_Injected(IntPtr _unity_self) { }

	public bool get_clearStencilAfterLightingPass() { }

	private static bool get_clearStencilAfterLightingPass_Injected(IntPtr _unity_self) { }

	public int get_commandBufferCount() { }

	private static int get_commandBufferCount_Injected(IntPtr _unity_self) { }

	public int get_cullingMask() { }

	private static int get_cullingMask_Injected(IntPtr _unity_self) { }

	public Matrix4x4 get_cullingMatrix() { }

	private static void get_cullingMatrix_Injected(IntPtr _unity_self, out Matrix4x4 ret) { }

	public static Camera get_current() { }

	[FreeFunction("GetCurrentCameraPPtr")]
	private static Camera get_currentInternal() { }

	private static IntPtr get_currentInternal_Injected() { }

	public Vector2 get_curvature() { }

	private static void get_curvature_Injected(IntPtr _unity_self, out Vector2 ret) { }

	public float get_depth() { }

	private static float get_depth_Injected(IntPtr _unity_self) { }

	public DepthTextureMode get_depthTextureMode() { }

	private static DepthTextureMode get_depthTextureMode_Injected(IntPtr _unity_self) { }

	public int get_eventMask() { }

	private static int get_eventMask_Injected(IntPtr _unity_self) { }

	public float get_farClipPlane() { }

	private static float get_farClipPlane_Injected(IntPtr _unity_self) { }

	public float get_fieldOfView() { }

	private static float get_fieldOfView_Injected(IntPtr _unity_self) { }

	public float get_focalLength() { }

	private static float get_focalLength_Injected(IntPtr _unity_self) { }

	public float get_focusDistance() { }

	private static float get_focusDistance_Injected(IntPtr _unity_self) { }

	public bool get_forceIntoRenderTexture() { }

	private static bool get_forceIntoRenderTexture_Injected(IntPtr _unity_self) { }

	public GateFitMode get_gateFit() { }

	private static GateFitMode get_gateFit_Injected(IntPtr _unity_self) { }

	public int get_iso() { }

	private static int get_iso_Injected(IntPtr _unity_self) { }

	public Single[] get_layerCullDistances() { }

	public bool get_layerCullSpherical() { }

	internal bool get_layerCullSphericalInternal() { }

	private static bool get_layerCullSphericalInternal_Injected(IntPtr _unity_self) { }

	public Vector2 get_lensShift() { }

	private static void get_lensShift_Injected(IntPtr _unity_self, out Vector2 ret) { }

	[FreeFunction("FindMainCamera")]
	public static Camera get_main() { }

	private static IntPtr get_main_Injected() { }

	public float get_nearClipPlane() { }

	private static float get_nearClipPlane_Injected(IntPtr _unity_self) { }

	public Matrix4x4 get_nonJitteredProjectionMatrix() { }

	private static void get_nonJitteredProjectionMatrix_Injected(IntPtr _unity_self, out Matrix4x4 ret) { }

	public OpaqueSortMode get_opaqueSortMode() { }

	private static OpaqueSortMode get_opaqueSortMode_Injected(IntPtr _unity_self) { }

	public bool get_orthographic() { }

	private static bool get_orthographic_Injected(IntPtr _unity_self) { }

	public float get_orthographicSize() { }

	private static float get_orthographicSize_Injected(IntPtr _unity_self) { }

	public ulong get_overrideSceneCullingMask() { }

	private static ulong get_overrideSceneCullingMask_Injected(IntPtr _unity_self) { }

	[FreeFunction("CameraScripting::GetPixelHeight", HasExplicitThis = True)]
	public int get_pixelHeight() { }

	private static int get_pixelHeight_Injected(IntPtr _unity_self) { }

	public Rect get_pixelRect() { }

	private static void get_pixelRect_Injected(IntPtr _unity_self, out Rect ret) { }

	[FreeFunction("CameraScripting::GetPixelWidth", HasExplicitThis = True)]
	public int get_pixelWidth() { }

	private static int get_pixelWidth_Injected(IntPtr _unity_self) { }

	internal static int get_PreviewCullingLayer() { }

	public Matrix4x4 get_previousViewProjectionMatrix() { }

	private static void get_previousViewProjectionMatrix_Injected(IntPtr _unity_self, out Matrix4x4 ret) { }

	public Matrix4x4 get_projectionMatrix() { }

	private static void get_projectionMatrix_Injected(IntPtr _unity_self, out Matrix4x4 ret) { }

	internal ProjectionMatrixMode get_projectionMatrixMode() { }

	private static ProjectionMatrixMode get_projectionMatrixMode_Injected(IntPtr _unity_self) { }

	public Rect get_rect() { }

	private static void get_rect_Injected(IntPtr _unity_self, out Rect ret) { }

	public bool get_renderCloudsInSceneView() { }

	private static bool get_renderCloudsInSceneView_Injected(IntPtr _unity_self) { }

	public RenderingPath get_renderingPath() { }

	private static RenderingPath get_renderingPath_Injected(IntPtr _unity_self) { }

	[FreeFunction("CameraScripting::GetScaledPixelHeight", HasExplicitThis = True)]
	public int get_scaledPixelHeight() { }

	private static int get_scaledPixelHeight_Injected(IntPtr _unity_self) { }

	[FreeFunction("CameraScripting::GetScaledPixelWidth", HasExplicitThis = True)]
	public int get_scaledPixelWidth() { }

	private static int get_scaledPixelWidth_Injected(IntPtr _unity_self) { }

	[FreeFunction("CameraScripting::GetScene", HasExplicitThis = True)]
	public Scene get_scene() { }

	private static void get_scene_Injected(IntPtr _unity_self, out Scene ret) { }

	internal ulong get_sceneCullingMask() { }

	private static ulong get_sceneCullingMask_Injected(IntPtr _unity_self) { }

	public SceneViewFilterMode get_sceneViewFilterMode() { }

	public Vector2 get_sensorSize() { }

	private static void get_sensorSize_Injected(IntPtr _unity_self, out Vector2 ret) { }

	public float get_shutterSpeed() { }

	private static float get_shutterSpeed_Injected(IntPtr _unity_self) { }

	internal Material get_skyboxMaterial() { }

	private static IntPtr get_skyboxMaterial_Injected(IntPtr _unity_self) { }

	[FreeFunction("CameraScripting::GetStereoActiveEye", HasExplicitThis = True)]
	public MonoOrStereoscopicEye get_stereoActiveEye() { }

	private static MonoOrStereoscopicEye get_stereoActiveEye_Injected(IntPtr _unity_self) { }

	public float get_stereoConvergence() { }

	private static float get_stereoConvergence_Injected(IntPtr _unity_self) { }

	[NativeMethod("GetStereoEnabledForBuiltInOrSRP")]
	public bool get_stereoEnabled() { }

	private static bool get_stereoEnabled_Injected(IntPtr _unity_self) { }

	public float get_stereoSeparation() { }

	private static float get_stereoSeparation_Injected(IntPtr _unity_self) { }

	public StereoTargetEyeMask get_stereoTargetEye() { }

	internal StereoTargetEyeMask get_stereoTargetEyeInternal() { }

	private static StereoTargetEyeMask get_stereoTargetEyeInternal_Injected(IntPtr _unity_self) { }

	public int get_targetDisplay() { }

	private static int get_targetDisplay_Injected(IntPtr _unity_self) { }

	public RenderTexture get_targetTexture() { }

	private static IntPtr get_targetTexture_Injected(IntPtr _unity_self) { }

	public Vector3 get_transparencySortAxis() { }

	private static void get_transparencySortAxis_Injected(IntPtr _unity_self, out Vector3 ret) { }

	public TransparencySortMode get_transparencySortMode() { }

	private static TransparencySortMode get_transparencySortMode_Injected(IntPtr _unity_self) { }

	internal bool get_useInteractiveLightBakingData() { }

	private static bool get_useInteractiveLightBakingData_Injected(IntPtr _unity_self) { }

	public bool get_useJitteredProjectionMatrixForTransparentRendering() { }

	private static bool get_useJitteredProjectionMatrixForTransparentRendering_Injected(IntPtr _unity_self) { }

	public bool get_useOcclusionCulling() { }

	private static bool get_useOcclusionCulling_Injected(IntPtr _unity_self) { }

	public bool get_usePhysicalProperties() { }

	private static bool get_usePhysicalProperties_Injected(IntPtr _unity_self) { }

	public Vector3 get_velocity() { }

	private static void get_velocity_Injected(IntPtr _unity_self, out Vector3 ret) { }

	public Matrix4x4 get_worldToCameraMatrix() { }

	private static void get_worldToCameraMatrix_Injected(IntPtr _unity_self, out Matrix4x4 ret) { }

	public static int GetAllCameras(Camera[] cameras) { }

	[FreeFunction("CameraScripting::GetAllCamerasCount")]
	private static int GetAllCamerasCount() { }

	[FreeFunction("CameraScripting::GetAllCameras")]
	private static int GetAllCamerasImpl(out Camera[] cam) { }

	private static int GetAllCamerasImpl_Injected(out Camera[] cam) { }

	internal String[] GetCameraBufferWarnings() { }

	private static String[] GetCameraBufferWarnings_Injected(IntPtr _unity_self) { }

	public CommandBuffer[] GetCommandBuffers(CameraEvent evt) { }

	[FreeFunction("CameraScripting::GetCommandBuffers", HasExplicitThis = True)]
	internal CommandBuffer[] GetCommandBuffersImpl(CameraEvent evt) { }

	private static CommandBuffer[] GetCommandBuffersImpl_Injected(IntPtr _unity_self, CameraEvent evt) { }

	[FreeFunction("ScriptableRenderPipeline_Bindings::GetCullingParameters_Internal")]
	[NativeHeader("Runtime/Export/RenderPipeline/ScriptableRenderPipeline.bindings.h")]
	private static bool GetCullingParameters_Internal(Camera camera, bool stereoAware, out ScriptableCullingParameters cullingParameters, int managedCullingParametersSize) { }

	private static bool GetCullingParameters_Internal_Injected(IntPtr camera, bool stereoAware, out ScriptableCullingParameters cullingParameters, int managedCullingParametersSize) { }

	[NativeConditional("UNITY_EDITOR")]
	private int GetFilterMode() { }

	private static int GetFilterMode_Injected(IntPtr _unity_self) { }

	internal Vector2 GetFrustumPlaneSizeAt(float distance) { }

	private static void GetFrustumPlaneSizeAt_Injected(IntPtr _unity_self, float distance, out Vector2 ret) { }

	public float GetGateFittedFieldOfView() { }

	private static float GetGateFittedFieldOfView_Injected(IntPtr _unity_self) { }

	public Vector2 GetGateFittedLensShift() { }

	private static void GetGateFittedLensShift_Injected(IntPtr _unity_self, out Vector2 ret) { }

	[FreeFunction("CameraScripting::GetLayerCullDistances", HasExplicitThis = True)]
	private Single[] GetLayerCullDistances() { }

	private static void GetLayerCullDistances_Injected(IntPtr _unity_self, out BlittableArrayWrapper ret) { }

	internal Vector3 GetLocalSpaceAim() { }

	private static void GetLocalSpaceAim_Injected(IntPtr _unity_self, out Vector3 ret) { }

	public Matrix4x4 GetStereoNonJitteredProjectionMatrix(StereoscopicEye eye) { }

	private static void GetStereoNonJitteredProjectionMatrix_Injected(IntPtr _unity_self, StereoscopicEye eye, out Matrix4x4 ret) { }

	[FreeFunction("CameraScripting::GetStereoProjectionMatrix", HasExplicitThis = True)]
	public Matrix4x4 GetStereoProjectionMatrix(StereoscopicEye eye) { }

	private static void GetStereoProjectionMatrix_Injected(IntPtr _unity_self, StereoscopicEye eye, out Matrix4x4 ret) { }

	[FreeFunction("CameraScripting::GetStereoViewMatrix", HasExplicitThis = True)]
	public Matrix4x4 GetStereoViewMatrix(StereoscopicEye eye) { }

	private static void GetStereoViewMatrix_Injected(IntPtr _unity_self, StereoscopicEye eye, out Matrix4x4 ret) { }

	[NativeName("HorizontalToVerticalFieldOfView_Safe")]
	public static float HorizontalToVerticalFieldOfView(float horizontalFieldOfView, float aspectRatio) { }

	internal void OnlyUsedForTesting1() { }

	internal void OnlyUsedForTesting2() { }

	public void RemoveAllCommandBuffers() { }

	[NativeName("RemoveAllCommandBuffers")]
	private void RemoveAllCommandBuffersImpl() { }

	private static void RemoveAllCommandBuffersImpl_Injected(IntPtr _unity_self) { }

	public void RemoveCommandBuffer(CameraEvent evt, CommandBuffer buffer) { }

	[NativeName("RemoveCommandBuffer")]
	private void RemoveCommandBufferImpl(CameraEvent evt, CommandBuffer buffer) { }

	private static void RemoveCommandBufferImpl_Injected(IntPtr _unity_self, CameraEvent evt, IntPtr buffer) { }

	public void RemoveCommandBuffers(CameraEvent evt) { }

	[NativeName("RemoveCommandBuffers")]
	private void RemoveCommandBuffersImpl(CameraEvent evt) { }

	private static void RemoveCommandBuffersImpl_Injected(IntPtr _unity_self, CameraEvent evt) { }

	[FreeFunction("CameraScripting::Render", HasExplicitThis = True)]
	public void Render() { }

	private static void Render_Injected(IntPtr _unity_self) { }

	[FreeFunction("CameraScripting::RenderDontRestore", HasExplicitThis = True)]
	public void RenderDontRestore() { }

	private static void RenderDontRestore_Injected(IntPtr _unity_self) { }

	public bool RenderToCubemap(Cubemap cubemap, int faceMask) { }

	public bool RenderToCubemap(RenderTexture cubemap, int faceMask) { }

	public bool RenderToCubemap(RenderTexture cubemap) { }

	public bool RenderToCubemap(Cubemap cubemap) { }

	public bool RenderToCubemap(RenderTexture cubemap, int faceMask, MonoOrStereoscopicEye stereoEye) { }

	[NativeName("RenderToCubemap")]
	private bool RenderToCubemapEyeImpl(RenderTexture cubemap, int faceMask, MonoOrStereoscopicEye stereoEye) { }

	private static bool RenderToCubemapEyeImpl_Injected(IntPtr _unity_self, IntPtr cubemap, int faceMask, MonoOrStereoscopicEye stereoEye) { }

	[FreeFunction("CameraScripting::RenderToCubemap", HasExplicitThis = True)]
	private bool RenderToCubemapImpl(Texture tex, int faceMask) { }

	private static bool RenderToCubemapImpl_Injected(IntPtr _unity_self, IntPtr tex, int faceMask) { }

	[FreeFunction("CameraScripting::RenderWithShader", HasExplicitThis = True)]
	public void RenderWithShader(Shader shader, string replacementTag) { }

	private static void RenderWithShader_Injected(IntPtr _unity_self, IntPtr shader, ref ManagedSpanWrapper replacementTag) { }

	public void Reset() { }

	private static void Reset_Injected(IntPtr _unity_self) { }

	public void ResetAspect() { }

	private static void ResetAspect_Injected(IntPtr _unity_self) { }

	public void ResetCullingMatrix() { }

	private static void ResetCullingMatrix_Injected(IntPtr _unity_self) { }

	public void ResetProjectionMatrix() { }

	private static void ResetProjectionMatrix_Injected(IntPtr _unity_self) { }

	public void ResetReplacementShader() { }

	private static void ResetReplacementShader_Injected(IntPtr _unity_self) { }

	public void ResetStereoProjectionMatrices() { }

	private static void ResetStereoProjectionMatrices_Injected(IntPtr _unity_self) { }

	public void ResetStereoViewMatrices() { }

	private static void ResetStereoViewMatrices_Injected(IntPtr _unity_self) { }

	public void ResetTransparencySortSettings() { }

	private static void ResetTransparencySortSettings_Injected(IntPtr _unity_self) { }

	public void ResetWorldToCameraMatrix() { }

	private static void ResetWorldToCameraMatrix_Injected(IntPtr _unity_self) { }

	private Ray ScreenPointToRay(Vector2 pos, MonoOrStereoscopicEye eye) { }

	public Ray ScreenPointToRay(Vector3 pos, MonoOrStereoscopicEye eye) { }

	public Ray ScreenPointToRay(Vector3 pos) { }

	private static void ScreenPointToRay_Injected(IntPtr _unity_self, in Vector2 pos, MonoOrStereoscopicEye eye, out Ray ret) { }

	public Vector3 ScreenToViewportPoint(Vector3 position) { }

	private static void ScreenToViewportPoint_Injected(IntPtr _unity_self, in Vector3 position, out Vector3 ret) { }

	public Vector3 ScreenToWorldPoint(Vector3 position) { }

	public Vector3 ScreenToWorldPoint(Vector3 position, MonoOrStereoscopicEye eye) { }

	private static void ScreenToWorldPoint_Injected(IntPtr _unity_self, in Vector3 position, MonoOrStereoscopicEye eye, out Vector3 ret) { }

	public void set_allowDynamicResolution(bool value) { }

	private static void set_allowDynamicResolution_Injected(IntPtr _unity_self, bool value) { }

	public void set_allowHDR(bool value) { }

	private static void set_allowHDR_Injected(IntPtr _unity_self, bool value) { }

	public void set_allowMSAA(bool value) { }

	private static void set_allowMSAA_Injected(IntPtr _unity_self, bool value) { }

	public void set_anamorphism(float value) { }

	private static void set_anamorphism_Injected(IntPtr _unity_self, float value) { }

	public void set_aperture(float value) { }

	private static void set_aperture_Injected(IntPtr _unity_self, float value) { }

	public void set_aspect(float value) { }

	private static void set_aspect_Injected(IntPtr _unity_self, float value) { }

	public void set_backgroundColor(Color value) { }

	private static void set_backgroundColor_Injected(IntPtr _unity_self, in Color value) { }

	public void set_barrelClipping(float value) { }

	private static void set_barrelClipping_Injected(IntPtr _unity_self, float value) { }

	public void set_bladeCount(int value) { }

	private static void set_bladeCount_Injected(IntPtr _unity_self, int value) { }

	public void set_cameraType(CameraType value) { }

	private static void set_cameraType_Injected(IntPtr _unity_self, CameraType value) { }

	public void set_clearFlags(CameraClearFlags value) { }

	private static void set_clearFlags_Injected(IntPtr _unity_self, CameraClearFlags value) { }

	public void set_clearStencilAfterLightingPass(bool value) { }

	private static void set_clearStencilAfterLightingPass_Injected(IntPtr _unity_self, bool value) { }

	public void set_cullingMask(int value) { }

	private static void set_cullingMask_Injected(IntPtr _unity_self, int value) { }

	public void set_cullingMatrix(Matrix4x4 value) { }

	private static void set_cullingMatrix_Injected(IntPtr _unity_self, in Matrix4x4 value) { }

	public void set_curvature(Vector2 value) { }

	private static void set_curvature_Injected(IntPtr _unity_self, in Vector2 value) { }

	public void set_depth(float value) { }

	private static void set_depth_Injected(IntPtr _unity_self, float value) { }

	public void set_depthTextureMode(DepthTextureMode value) { }

	private static void set_depthTextureMode_Injected(IntPtr _unity_self, DepthTextureMode value) { }

	public void set_eventMask(int value) { }

	private static void set_eventMask_Injected(IntPtr _unity_self, int value) { }

	public void set_farClipPlane(float value) { }

	private static void set_farClipPlane_Injected(IntPtr _unity_self, float value) { }

	public void set_fieldOfView(float value) { }

	private static void set_fieldOfView_Injected(IntPtr _unity_self, float value) { }

	public void set_focalLength(float value) { }

	private static void set_focalLength_Injected(IntPtr _unity_self, float value) { }

	public void set_focusDistance(float value) { }

	private static void set_focusDistance_Injected(IntPtr _unity_self, float value) { }

	public void set_forceIntoRenderTexture(bool value) { }

	private static void set_forceIntoRenderTexture_Injected(IntPtr _unity_self, bool value) { }

	public void set_gateFit(GateFitMode value) { }

	private static void set_gateFit_Injected(IntPtr _unity_self, GateFitMode value) { }

	public void set_iso(int value) { }

	private static void set_iso_Injected(IntPtr _unity_self, int value) { }

	public void set_layerCullDistances(Single[] value) { }

	public void set_layerCullSpherical(bool value) { }

	internal void set_layerCullSphericalInternal(bool value) { }

	private static void set_layerCullSphericalInternal_Injected(IntPtr _unity_self, bool value) { }

	public void set_lensShift(Vector2 value) { }

	private static void set_lensShift_Injected(IntPtr _unity_self, in Vector2 value) { }

	public void set_nearClipPlane(float value) { }

	private static void set_nearClipPlane_Injected(IntPtr _unity_self, float value) { }

	public void set_nonJitteredProjectionMatrix(Matrix4x4 value) { }

	private static void set_nonJitteredProjectionMatrix_Injected(IntPtr _unity_self, in Matrix4x4 value) { }

	public void set_opaqueSortMode(OpaqueSortMode value) { }

	private static void set_opaqueSortMode_Injected(IntPtr _unity_self, OpaqueSortMode value) { }

	public void set_orthographic(bool value) { }

	private static void set_orthographic_Injected(IntPtr _unity_self, bool value) { }

	public void set_orthographicSize(float value) { }

	private static void set_orthographicSize_Injected(IntPtr _unity_self, float value) { }

	public void set_overrideSceneCullingMask(ulong value) { }

	private static void set_overrideSceneCullingMask_Injected(IntPtr _unity_self, ulong value) { }

	public void set_pixelRect(Rect value) { }

	private static void set_pixelRect_Injected(IntPtr _unity_self, in Rect value) { }

	public void set_projectionMatrix(Matrix4x4 value) { }

	private static void set_projectionMatrix_Injected(IntPtr _unity_self, in Matrix4x4 value) { }

	public void set_rect(Rect value) { }

	private static void set_rect_Injected(IntPtr _unity_self, in Rect value) { }

	public void set_renderCloudsInSceneView(bool value) { }

	private static void set_renderCloudsInSceneView_Injected(IntPtr _unity_self, bool value) { }

	public void set_renderingPath(RenderingPath value) { }

	private static void set_renderingPath_Injected(IntPtr _unity_self, RenderingPath value) { }

	[FreeFunction("CameraScripting::SetScene", HasExplicitThis = True)]
	public void set_scene(Scene value) { }

	private static void set_scene_Injected(IntPtr _unity_self, in Scene value) { }

	public void set_sensorSize(Vector2 value) { }

	private static void set_sensorSize_Injected(IntPtr _unity_self, in Vector2 value) { }

	public void set_shutterSpeed(float value) { }

	private static void set_shutterSpeed_Injected(IntPtr _unity_self, float value) { }

	public void set_stereoConvergence(float value) { }

	private static void set_stereoConvergence_Injected(IntPtr _unity_self, float value) { }

	public void set_stereoSeparation(float value) { }

	private static void set_stereoSeparation_Injected(IntPtr _unity_self, float value) { }

	public void set_stereoTargetEye(StereoTargetEyeMask value) { }

	internal void set_stereoTargetEyeInternal(StereoTargetEyeMask value) { }

	private static void set_stereoTargetEyeInternal_Injected(IntPtr _unity_self, StereoTargetEyeMask value) { }

	public void set_targetDisplay(int value) { }

	private static void set_targetDisplay_Injected(IntPtr _unity_self, int value) { }

	public void set_targetTexture(RenderTexture value) { }

	private static void set_targetTexture_Injected(IntPtr _unity_self, IntPtr value) { }

	public void set_transparencySortAxis(Vector3 value) { }

	private static void set_transparencySortAxis_Injected(IntPtr _unity_self, in Vector3 value) { }

	public void set_transparencySortMode(TransparencySortMode value) { }

	private static void set_transparencySortMode_Injected(IntPtr _unity_self, TransparencySortMode value) { }

	internal void set_useInteractiveLightBakingData(bool value) { }

	private static void set_useInteractiveLightBakingData_Injected(IntPtr _unity_self, bool value) { }

	public void set_useJitteredProjectionMatrixForTransparentRendering(bool value) { }

	private static void set_useJitteredProjectionMatrixForTransparentRendering_Injected(IntPtr _unity_self, bool value) { }

	public void set_useOcclusionCulling(bool value) { }

	private static void set_useOcclusionCulling_Injected(IntPtr _unity_self, bool value) { }

	public void set_usePhysicalProperties(bool value) { }

	private static void set_usePhysicalProperties_Injected(IntPtr _unity_self, bool value) { }

	public void set_worldToCameraMatrix(Matrix4x4 value) { }

	private static void set_worldToCameraMatrix_Injected(IntPtr _unity_self, in Matrix4x4 value) { }

	[FreeFunction("CameraScripting::SetLayerCullDistances", HasExplicitThis = True)]
	private void SetLayerCullDistances(Single[] d) { }

	private static void SetLayerCullDistances_Injected(IntPtr _unity_self, ref ManagedSpanWrapper d) { }

	public void SetReplacementShader(Shader shader, string replacementTag) { }

	private static void SetReplacementShader_Injected(IntPtr _unity_self, IntPtr shader, ref ManagedSpanWrapper replacementTag) { }

	public void SetStereoProjectionMatrix(StereoscopicEye eye, Matrix4x4 matrix) { }

	private static void SetStereoProjectionMatrix_Injected(IntPtr _unity_self, StereoscopicEye eye, in Matrix4x4 matrix) { }

	public void SetStereoViewMatrix(StereoscopicEye eye, Matrix4x4 matrix) { }

	private static void SetStereoViewMatrix_Injected(IntPtr _unity_self, StereoscopicEye eye, in Matrix4x4 matrix) { }

	public void SetTargetBuffers(RenderBuffer colorBuffer, RenderBuffer depthBuffer) { }

	public void SetTargetBuffers(RenderBuffer[] colorBuffer, RenderBuffer depthBuffer) { }

	[FreeFunction("CameraScripting::SetTargetBuffers", HasExplicitThis = True)]
	private void SetTargetBuffersImpl(RenderBuffer color, RenderBuffer depth) { }

	private static void SetTargetBuffersImpl_Injected(IntPtr _unity_self, in RenderBuffer color, in RenderBuffer depth) { }

	[FreeFunction("CameraScripting::SetTargetBuffers", HasExplicitThis = True)]
	private void SetTargetBuffersMRTImpl(RenderBuffer[] color, RenderBuffer depth) { }

	private static void SetTargetBuffersMRTImpl_Injected(IntPtr _unity_self, ref ManagedSpanWrapper color, in RenderBuffer depth) { }

	[FreeFunction("CameraScripting::SetupCurrent")]
	public static void SetupCurrent(Camera cur) { }

	private static void SetupCurrent_Injected(IntPtr cur) { }

	[FreeFunction("CameraScripting::SubmitBuiltInObjectIDRenderRequest", HasExplicitThis = True)]
	[NativeConditional("UNITY_EDITOR")]
	private Object[] SubmitBuiltInObjectIDRenderRequest(RenderTexture target, int mipLevel, CubemapFace cubemapFace, int depthSlice) { }

	private static Object[] SubmitBuiltInObjectIDRenderRequest_Injected(IntPtr _unity_self, IntPtr target, int mipLevel, CubemapFace cubemapFace, int depthSlice) { }

	public void SubmitRenderRequest(RequestData renderRequest) { }

	[Obsolete("SubmitRenderRequests is obsolete, use SubmitRenderRequest with RequestData of supported types such as RenderPipeline.StandardRequest", True)]
	public void SubmitRenderRequests(List<RenderRequest> renderRequests) { }

	[FreeFunction("CameraScripting::SubmitRenderRequests", HasExplicitThis = True)]
	private void SubmitRenderRequestsInternal(object requests) { }

	private static void SubmitRenderRequestsInternal_Injected(IntPtr _unity_self, object requests) { }

	public bool TryGetCullingParameters(out ScriptableCullingParameters cullingParameters) { }

	public bool TryGetCullingParameters(bool stereoAware, out ScriptableCullingParameters cullingParameters) { }

	public static float VerticalToHorizontalFieldOfView(float verticalFieldOfView, float aspectRatio) { }

	private Ray ViewportPointToRay(Vector2 pos, MonoOrStereoscopicEye eye) { }

	public Ray ViewportPointToRay(Vector3 pos, MonoOrStereoscopicEye eye) { }

	public Ray ViewportPointToRay(Vector3 pos) { }

	private static void ViewportPointToRay_Injected(IntPtr _unity_self, in Vector2 pos, MonoOrStereoscopicEye eye, out Ray ret) { }

	public Vector3 ViewportToScreenPoint(Vector3 position) { }

	private static void ViewportToScreenPoint_Injected(IntPtr _unity_self, in Vector3 position, out Vector3 ret) { }

	public Vector3 ViewportToWorldPoint(Vector3 position, MonoOrStereoscopicEye eye) { }

	public Vector3 ViewportToWorldPoint(Vector3 position) { }

	private static void ViewportToWorldPoint_Injected(IntPtr _unity_self, in Vector3 position, MonoOrStereoscopicEye eye, out Vector3 ret) { }

	public Vector3 WorldToScreenPoint(Vector3 position) { }

	public Vector3 WorldToScreenPoint(Vector3 position, MonoOrStereoscopicEye eye) { }

	private static void WorldToScreenPoint_Injected(IntPtr _unity_self, in Vector3 position, MonoOrStereoscopicEye eye, out Vector3 ret) { }

	public Vector3 WorldToViewportPoint(Vector3 position, MonoOrStereoscopicEye eye) { }

	public Vector3 WorldToViewportPoint(Vector3 position) { }

	private static void WorldToViewportPoint_Injected(IntPtr _unity_self, in Vector3 position, MonoOrStereoscopicEye eye, out Vector3 ret) { }

}

