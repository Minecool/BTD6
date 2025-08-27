namespace UnityEngine;

[NativeHeader("Runtime/Export/Graphics/Light.bindings.h")]
[NativeHeader("Runtime/Camera/Light.h")]
[RequireComponent(typeof(Transform))]
[RequireComponent(typeof(Transform))]
public sealed class Light : Behaviour
{
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private LightShape <shape>k__BackingField; //Field offset: 0x18
	private int m_BakedIndex; //Field offset: 0x1C

	public Vector2 areaSize
	{
		 get { } //Length: 137
		 set { } //Length: 128
	}

	[Obsolete("light.attenuate was removed; all lights always attenuate now", True)]
	public bool attenuate
	{
		 get { } //Length: 5
		 set { } //Length: 3
	}

	[EditorBrowsable(EditorBrowsableState::Never (1))]
	[Obsolete("warning bakedIndex has been removed please use bakingOutput.isBaked instead.", True)]
	public int bakedIndex
	{
		 get { } //Length: 6
		 set { } //Length: 4
	}

	public LightBakingOutput bakingOutput
	{
		 get { } //Length: 147
		 set { } //Length: 133
	}

	public float bounceIntensity
	{
		 get { } //Length: 118
		 set { } //Length: 134
	}

	public Vector4 boundingSphereOverride
	{
		 get { } //Length: 142
		 set { } //Length: 133
	}

	public Color color
	{
		 get { } //Length: 142
		 set { } //Length: 133
	}

	public float colorTemperature
	{
		 get { } //Length: 118
		 set { } //Length: 134
	}

	public int commandBufferCount
	{
		 get { } //Length: 118
	}

	public Texture cookie
	{
		 get { } //Length: 144
		 set { } //Length: 177
	}

	public float cookieSize
	{
		 get { } //Length: 118
		 set { } //Length: 134
	}

	public int cullingMask
	{
		 get { } //Length: 118
		 set { } //Length: 131
	}

	public float dilatedRange
	{
		 get { } //Length: 118
	}

	public bool enableSpotReflector
	{
		 get { } //Length: 118
		 set { } //Length: 134
	}

	public Flare flare
	{
		 get { } //Length: 144
		 set { } //Length: 177
	}

	public bool forceVisible
	{
		 get { } //Length: 118
		 set { } //Length: 134
	}

	public float innerSpotAngle
	{
		 get { } //Length: 118
		 set { } //Length: 134
	}

	public float intensity
	{
		 get { } //Length: 118
		 set { } //Length: 134
	}

	public Single[] layerShadowCullDistances
	{
		[FreeFunction("Light_Bindings::GetLayerShadowCullDistances", HasExplicitThis = True, ThrowsException = False)]
		 get { } //Length: 288
		[FreeFunction("Light_Bindings::SetLayerShadowCullDistances", HasExplicitThis = True, ThrowsException = True)]
		 set { } //Length: 261
	}

	public LightShadowCasterMode lightShadowCasterMode
	{
		 get { } //Length: 118
		 set { } //Length: 131
	}

	public LightUnit lightUnit
	{
		 get { } //Length: 118
		 set { } //Length: 131
	}

	public float luxAtDistance
	{
		 get { } //Length: 118
		 set { } //Length: 134
	}

	[Obsolete("Use QualitySettings.pixelLightCount instead.")]
	public static int pixelLightCount
	{
		 get { } //Length: 42
		 set { } //Length: 49
	}

	public float range
	{
		 get { } //Length: 118
		 set { } //Length: 134
	}

	public int renderingLayerMask
	{
		 get { } //Length: 118
		 set { } //Length: 131
	}

	public LightRenderMode renderMode
	{
		 get { } //Length: 118
		[FreeFunction("Light_Bindings::SetRenderMode", HasExplicitThis = True, ThrowsException = True)]
		 set { } //Length: 131
	}

	public float shadowBias
	{
		 get { } //Length: 118
		 set { } //Length: 134
	}

	[Obsolete("light.shadowConstantBias was removed, use light.shadowBias", True)]
	public float shadowConstantBias
	{
		 get { } //Length: 6
		 set { } //Length: 3
	}

	public int shadowCustomResolution
	{
		 get { } //Length: 118
		 set { } //Length: 131
	}

	public Matrix4x4 shadowMatrixOverride
	{
		 get { } //Length: 154
		 set { } //Length: 133
	}

	public float shadowNearPlane
	{
		 get { } //Length: 118
		 set { } //Length: 134
	}

	public float shadowNormalBias
	{
		 get { } //Length: 118
		 set { } //Length: 134
	}

	[Obsolete("light.shadowObjectSizeBias was removed, use light.shadowBias", True)]
	public float shadowObjectSizeBias
	{
		 get { } //Length: 6
		 set { } //Length: 3
	}

	public LightShadowResolution shadowResolution
	{
		 get { } //Length: 118
		[FreeFunction("Light_Bindings::SetShadowResolution", HasExplicitThis = True, ThrowsException = True)]
		 set { } //Length: 131
	}

	public LightShadows shadows
	{
		[NativeMethod("GetShadowType")]
		 get { } //Length: 118
		[FreeFunction("Light_Bindings::SetShadowType", HasExplicitThis = True, ThrowsException = True)]
		 set { } //Length: 131
	}

	[EditorBrowsable(EditorBrowsableState::Never (1))]
	[Obsolete("Shadow softness is removed in Unity 5.0+", True)]
	public float shadowSoftness
	{
		 get { } //Length: 11
		 set { } //Length: 3
	}

	[EditorBrowsable(EditorBrowsableState::Never (1))]
	[Obsolete("Shadow softness is removed in Unity 5.0+", True)]
	public float shadowSoftnessFade
	{
		 get { } //Length: 11
		 set { } //Length: 3
	}

	public float shadowStrength
	{
		 get { } //Length: 118
		[FreeFunction("Light_Bindings::SetShadowStrength", HasExplicitThis = True)]
		 set { } //Length: 134
	}

	[Obsolete("This property has been deprecated. Use Light.type instead.")]
	public LightShape shape
	{
		[CompilerGenerated]
		 get { } //Length: 4
		[CompilerGenerated]
		 set { } //Length: 4
	}

	public float spotAngle
	{
		 get { } //Length: 118
		 set { } //Length: 134
	}

	[NativeProperty("LightType")]
	public LightType type
	{
		 get { } //Length: 118
		 set { } //Length: 131
	}

	public bool useBoundingSphereOverride
	{
		 get { } //Length: 118
		 set { } //Length: 134
	}

	public bool useColorTemperature
	{
		 get { } //Length: 118
		 set { } //Length: 134
	}

	public bool useShadowMatrixOverride
	{
		 get { } //Length: 118
		 set { } //Length: 134
	}

	public bool useViewFrustumForShadowCasterCull
	{
		 get { } //Length: 118
		 set { } //Length: 134
	}

	public Light() { }

	public void AddCommandBuffer(LightEvent evt, CommandBuffer buffer) { }

	public void AddCommandBuffer(LightEvent evt, CommandBuffer buffer, ShadowMapPass shadowPassMask) { }

	public void AddCommandBufferAsync(LightEvent evt, CommandBuffer buffer, ComputeQueueType queueType) { }

	public void AddCommandBufferAsync(LightEvent evt, CommandBuffer buffer, ShadowMapPass shadowPassMask, ComputeQueueType queueType) { }

	[FreeFunction("Light_Bindings::AddCommandBufferAsync", HasExplicitThis = True)]
	internal void AddCommandBufferAsyncInternal(LightEvent evt, CommandBuffer buffer, ShadowMapPass shadowPassMask, ComputeQueueType queueType) { }

	private static void AddCommandBufferAsyncInternal_Injected(IntPtr _unity_self, LightEvent evt, IntPtr buffer, ShadowMapPass shadowPassMask, ComputeQueueType queueType) { }

	[FreeFunction("Light_Bindings::AddCommandBuffer", HasExplicitThis = True)]
	internal void AddCommandBufferInternal(LightEvent evt, CommandBuffer buffer, ShadowMapPass shadowPassMask) { }

	private static void AddCommandBufferInternal_Injected(IntPtr _unity_self, LightEvent evt, IntPtr buffer, ShadowMapPass shadowPassMask) { }

	public Vector2 get_areaSize() { }

	private static void get_areaSize_Injected(IntPtr _unity_self, out Vector2 ret) { }

	public bool get_attenuate() { }

	public int get_bakedIndex() { }

	public LightBakingOutput get_bakingOutput() { }

	private static void get_bakingOutput_Injected(IntPtr _unity_self, out LightBakingOutput ret) { }

	public float get_bounceIntensity() { }

	private static float get_bounceIntensity_Injected(IntPtr _unity_self) { }

	public Vector4 get_boundingSphereOverride() { }

	private static void get_boundingSphereOverride_Injected(IntPtr _unity_self, out Vector4 ret) { }

	public Color get_color() { }

	private static void get_color_Injected(IntPtr _unity_self, out Color ret) { }

	public float get_colorTemperature() { }

	private static float get_colorTemperature_Injected(IntPtr _unity_self) { }

	public int get_commandBufferCount() { }

	private static int get_commandBufferCount_Injected(IntPtr _unity_self) { }

	public Texture get_cookie() { }

	private static IntPtr get_cookie_Injected(IntPtr _unity_self) { }

	public float get_cookieSize() { }

	private static float get_cookieSize_Injected(IntPtr _unity_self) { }

	public int get_cullingMask() { }

	private static int get_cullingMask_Injected(IntPtr _unity_self) { }

	public float get_dilatedRange() { }

	private static float get_dilatedRange_Injected(IntPtr _unity_self) { }

	public bool get_enableSpotReflector() { }

	private static bool get_enableSpotReflector_Injected(IntPtr _unity_self) { }

	public Flare get_flare() { }

	private static IntPtr get_flare_Injected(IntPtr _unity_self) { }

	public bool get_forceVisible() { }

	private static bool get_forceVisible_Injected(IntPtr _unity_self) { }

	public float get_innerSpotAngle() { }

	private static float get_innerSpotAngle_Injected(IntPtr _unity_self) { }

	public float get_intensity() { }

	private static float get_intensity_Injected(IntPtr _unity_self) { }

	[FreeFunction("Light_Bindings::GetLayerShadowCullDistances", HasExplicitThis = True, ThrowsException = False)]
	public Single[] get_layerShadowCullDistances() { }

	private static void get_layerShadowCullDistances_Injected(IntPtr _unity_self, out BlittableArrayWrapper ret) { }

	public LightShadowCasterMode get_lightShadowCasterMode() { }

	private static LightShadowCasterMode get_lightShadowCasterMode_Injected(IntPtr _unity_self) { }

	public LightUnit get_lightUnit() { }

	private static LightUnit get_lightUnit_Injected(IntPtr _unity_self) { }

	public float get_luxAtDistance() { }

	private static float get_luxAtDistance_Injected(IntPtr _unity_self) { }

	public static int get_pixelLightCount() { }

	public float get_range() { }

	private static float get_range_Injected(IntPtr _unity_self) { }

	public int get_renderingLayerMask() { }

	private static int get_renderingLayerMask_Injected(IntPtr _unity_self) { }

	public LightRenderMode get_renderMode() { }

	private static LightRenderMode get_renderMode_Injected(IntPtr _unity_self) { }

	public float get_shadowBias() { }

	private static float get_shadowBias_Injected(IntPtr _unity_self) { }

	public float get_shadowConstantBias() { }

	public int get_shadowCustomResolution() { }

	private static int get_shadowCustomResolution_Injected(IntPtr _unity_self) { }

	public Matrix4x4 get_shadowMatrixOverride() { }

	private static void get_shadowMatrixOverride_Injected(IntPtr _unity_self, out Matrix4x4 ret) { }

	public float get_shadowNearPlane() { }

	private static float get_shadowNearPlane_Injected(IntPtr _unity_self) { }

	public float get_shadowNormalBias() { }

	private static float get_shadowNormalBias_Injected(IntPtr _unity_self) { }

	public float get_shadowObjectSizeBias() { }

	public LightShadowResolution get_shadowResolution() { }

	private static LightShadowResolution get_shadowResolution_Injected(IntPtr _unity_self) { }

	[NativeMethod("GetShadowType")]
	public LightShadows get_shadows() { }

	private static LightShadows get_shadows_Injected(IntPtr _unity_self) { }

	public float get_shadowSoftness() { }

	public float get_shadowSoftnessFade() { }

	public float get_shadowStrength() { }

	private static float get_shadowStrength_Injected(IntPtr _unity_self) { }

	[CompilerGenerated]
	public LightShape get_shape() { }

	public float get_spotAngle() { }

	private static float get_spotAngle_Injected(IntPtr _unity_self) { }

	public LightType get_type() { }

	private static LightType get_type_Injected(IntPtr _unity_self) { }

	public bool get_useBoundingSphereOverride() { }

	private static bool get_useBoundingSphereOverride_Injected(IntPtr _unity_self) { }

	public bool get_useColorTemperature() { }

	private static bool get_useColorTemperature_Injected(IntPtr _unity_self) { }

	public bool get_useShadowMatrixOverride() { }

	private static bool get_useShadowMatrixOverride_Injected(IntPtr _unity_self) { }

	public bool get_useViewFrustumForShadowCasterCull() { }

	private static bool get_useViewFrustumForShadowCasterCull_Injected(IntPtr _unity_self) { }

	public CommandBuffer[] GetCommandBuffers(LightEvent evt) { }

	[FreeFunction("Light_Bindings::GetCommandBuffers", HasExplicitThis = True)]
	internal CommandBuffer[] GetCommandBuffersInternal(LightEvent evt) { }

	private static CommandBuffer[] GetCommandBuffersInternal_Injected(IntPtr _unity_self, LightEvent evt) { }

	[FreeFunction("Light_Bindings::GetLights")]
	[Obsolete("Light.GetLights has been deprecated, use FindObjectsOfType in combination with light.cullingmask/light.type", False)]
	public static Light[] GetLights(LightType type, int layer) { }

	public void RemoveAllCommandBuffers() { }

	[NativeMethod("RemoveAllCommandBuffers")]
	internal void RemoveAllCommandBuffersInternal() { }

	private static void RemoveAllCommandBuffersInternal_Injected(IntPtr _unity_self) { }

	public void RemoveCommandBuffer(LightEvent evt, CommandBuffer buffer) { }

	[NativeMethod("RemoveCommandBuffer")]
	internal void RemoveCommandBufferInternal(LightEvent evt, CommandBuffer buffer) { }

	private static void RemoveCommandBufferInternal_Injected(IntPtr _unity_self, LightEvent evt, IntPtr buffer) { }

	public void RemoveCommandBuffers(LightEvent evt) { }

	[NativeMethod("RemoveCommandBuffers")]
	internal void RemoveCommandBuffersInternal(LightEvent evt) { }

	private static void RemoveCommandBuffersInternal_Injected(IntPtr _unity_self, LightEvent evt) { }

	public void Reset() { }

	private static void Reset_Injected(IntPtr _unity_self) { }

	public void set_areaSize(Vector2 value) { }

	private static void set_areaSize_Injected(IntPtr _unity_self, in Vector2 value) { }

	public void set_attenuate(bool value) { }

	public void set_bakedIndex(int value) { }

	public void set_bakingOutput(LightBakingOutput value) { }

	private static void set_bakingOutput_Injected(IntPtr _unity_self, in LightBakingOutput value) { }

	public void set_bounceIntensity(float value) { }

	private static void set_bounceIntensity_Injected(IntPtr _unity_self, float value) { }

	public void set_boundingSphereOverride(Vector4 value) { }

	private static void set_boundingSphereOverride_Injected(IntPtr _unity_self, in Vector4 value) { }

	public void set_color(Color value) { }

	private static void set_color_Injected(IntPtr _unity_self, in Color value) { }

	public void set_colorTemperature(float value) { }

	private static void set_colorTemperature_Injected(IntPtr _unity_self, float value) { }

	public void set_cookie(Texture value) { }

	private static void set_cookie_Injected(IntPtr _unity_self, IntPtr value) { }

	public void set_cookieSize(float value) { }

	private static void set_cookieSize_Injected(IntPtr _unity_self, float value) { }

	public void set_cullingMask(int value) { }

	private static void set_cullingMask_Injected(IntPtr _unity_self, int value) { }

	public void set_enableSpotReflector(bool value) { }

	private static void set_enableSpotReflector_Injected(IntPtr _unity_self, bool value) { }

	public void set_flare(Flare value) { }

	private static void set_flare_Injected(IntPtr _unity_self, IntPtr value) { }

	public void set_forceVisible(bool value) { }

	private static void set_forceVisible_Injected(IntPtr _unity_self, bool value) { }

	public void set_innerSpotAngle(float value) { }

	private static void set_innerSpotAngle_Injected(IntPtr _unity_self, float value) { }

	public void set_intensity(float value) { }

	private static void set_intensity_Injected(IntPtr _unity_self, float value) { }

	[FreeFunction("Light_Bindings::SetLayerShadowCullDistances", HasExplicitThis = True, ThrowsException = True)]
	public void set_layerShadowCullDistances(Single[] value) { }

	private static void set_layerShadowCullDistances_Injected(IntPtr _unity_self, ref ManagedSpanWrapper value) { }

	public void set_lightShadowCasterMode(LightShadowCasterMode value) { }

	private static void set_lightShadowCasterMode_Injected(IntPtr _unity_self, LightShadowCasterMode value) { }

	public void set_lightUnit(LightUnit value) { }

	private static void set_lightUnit_Injected(IntPtr _unity_self, LightUnit value) { }

	public void set_luxAtDistance(float value) { }

	private static void set_luxAtDistance_Injected(IntPtr _unity_self, float value) { }

	public static void set_pixelLightCount(int value) { }

	public void set_range(float value) { }

	private static void set_range_Injected(IntPtr _unity_self, float value) { }

	public void set_renderingLayerMask(int value) { }

	private static void set_renderingLayerMask_Injected(IntPtr _unity_self, int value) { }

	[FreeFunction("Light_Bindings::SetRenderMode", HasExplicitThis = True, ThrowsException = True)]
	public void set_renderMode(LightRenderMode value) { }

	private static void set_renderMode_Injected(IntPtr _unity_self, LightRenderMode value) { }

	public void set_shadowBias(float value) { }

	private static void set_shadowBias_Injected(IntPtr _unity_self, float value) { }

	public void set_shadowConstantBias(float value) { }

	public void set_shadowCustomResolution(int value) { }

	private static void set_shadowCustomResolution_Injected(IntPtr _unity_self, int value) { }

	public void set_shadowMatrixOverride(Matrix4x4 value) { }

	private static void set_shadowMatrixOverride_Injected(IntPtr _unity_self, in Matrix4x4 value) { }

	public void set_shadowNearPlane(float value) { }

	private static void set_shadowNearPlane_Injected(IntPtr _unity_self, float value) { }

	public void set_shadowNormalBias(float value) { }

	private static void set_shadowNormalBias_Injected(IntPtr _unity_self, float value) { }

	public void set_shadowObjectSizeBias(float value) { }

	[FreeFunction("Light_Bindings::SetShadowResolution", HasExplicitThis = True, ThrowsException = True)]
	public void set_shadowResolution(LightShadowResolution value) { }

	private static void set_shadowResolution_Injected(IntPtr _unity_self, LightShadowResolution value) { }

	[FreeFunction("Light_Bindings::SetShadowType", HasExplicitThis = True, ThrowsException = True)]
	public void set_shadows(LightShadows value) { }

	private static void set_shadows_Injected(IntPtr _unity_self, LightShadows value) { }

	public void set_shadowSoftness(float value) { }

	public void set_shadowSoftnessFade(float value) { }

	[FreeFunction("Light_Bindings::SetShadowStrength", HasExplicitThis = True)]
	public void set_shadowStrength(float value) { }

	private static void set_shadowStrength_Injected(IntPtr _unity_self, float value) { }

	[CompilerGenerated]
	public void set_shape(LightShape value) { }

	public void set_spotAngle(float value) { }

	private static void set_spotAngle_Injected(IntPtr _unity_self, float value) { }

	public void set_type(LightType value) { }

	private static void set_type_Injected(IntPtr _unity_self, LightType value) { }

	public void set_useBoundingSphereOverride(bool value) { }

	private static void set_useBoundingSphereOverride_Injected(IntPtr _unity_self, bool value) { }

	public void set_useColorTemperature(bool value) { }

	private static void set_useColorTemperature_Injected(IntPtr _unity_self, bool value) { }

	public void set_useShadowMatrixOverride(bool value) { }

	private static void set_useShadowMatrixOverride_Injected(IntPtr _unity_self, bool value) { }

	public void set_useViewFrustumForShadowCasterCull(bool value) { }

	private static void set_useViewFrustumForShadowCasterCull_Injected(IntPtr _unity_self, bool value) { }

}

