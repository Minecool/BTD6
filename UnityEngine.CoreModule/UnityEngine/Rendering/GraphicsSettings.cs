namespace UnityEngine.Rendering;

[NativeHeader("Runtime/Camera/GraphicsSettings.h")]
[StaticAccessor("GetGraphicsSettings()", StaticAccessorType::Dot (0))]
public sealed class GraphicsSettings : object
{

	public static RenderPipelineAsset currentRenderPipeline
	{
		 get { } //Length: 152
	}

	public static uint defaultRenderingLayerMask
	{
		 set { } //Length: 49
	}

	[NativeName("CurrentRenderPipeline")]
	private static ScriptableObject INTERNAL_currentRenderPipeline
	{
		private get { } //Length: 42
	}

	public static bool lightsUseColorTemperature
	{
		 set { } //Length: 51
	}

	public static bool lightsUseLinearIntensity
	{
		 get { } //Length: 42
		 set { } //Length: 51
	}

	public static bool useScriptableRenderPipelineBatching
	{
		 set { } //Length: 51
	}

	public static RenderPipelineAsset get_currentRenderPipeline() { }

	private static ScriptableObject get_INTERNAL_currentRenderPipeline() { }

	public static bool get_lightsUseLinearIntensity() { }

	public static RenderPipelineGlobalSettings GetSettingsForRenderPipeline() { }

	[NativeName("GetSettingsForRenderPipeline")]
	private static object GetSettingsForRenderPipeline(string renderpipelineName) { }

	public static bool HasShaderDefine(GraphicsTier tier, BuiltinShaderDefine defineHash) { }

	public static bool HasShaderDefine(BuiltinShaderDefine defineHash) { }

	[NativeName("RegisterRenderPipelineSettings")]
	private static void RegisterRenderPipeline(string renderpipelineName, object settings) { }

	public static void RegisterRenderPipelineSettings(RenderPipelineGlobalSettings settings) { }

	public static void set_defaultRenderingLayerMask(uint value) { }

	public static void set_lightsUseColorTemperature(bool value) { }

	public static void set_lightsUseLinearIntensity(bool value) { }

	public static void set_useScriptableRenderPipelineBatching(bool value) { }

	[NativeName("UnregisterRenderPipelineSettings")]
	private static void UnregisterRenderPipeline(string renderpipelineName) { }

	public static void UnregisterRenderPipelineSettings() { }

}

