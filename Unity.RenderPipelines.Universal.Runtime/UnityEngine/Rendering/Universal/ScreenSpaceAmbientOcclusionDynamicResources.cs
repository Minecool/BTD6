namespace UnityEngine.Rendering.Universal;

[CategoryInfo(Name = "R: SSAO Noise Textures", Order = 1000)]
[ElementInfo(Order = 0)]
[HideInInspector]
[SupportedOnRenderPipeline(typeof(UniversalRenderPipelineAsset))]
internal class ScreenSpaceAmbientOcclusionDynamicResources : IRenderPipelineResources, IRenderPipelineGraphicsSettings
{
	[ResourceFormattedPaths("Textures/BlueNoise256/LDR_LLL1_{0}.png", 0, 7, SearchType::ProjectPath (0))]
	[SerializeField]
	private Texture2D[] m_BlueNoise256Textures; //Field offset: 0x10
	[HideInInspector]
	[SerializeField]
	private int m_Version; //Field offset: 0x18

	public Texture2D[] BlueNoise256Textures
	{
		 get { } //Length: 5
		 set { } //Length: 101
	}

	public override bool isAvailableInPlayerBuild
	{
		 get { } //Length: 3
	}

	public override int version
	{
		 get { } //Length: 4
	}

	public ScreenSpaceAmbientOcclusionDynamicResources() { }

	public Texture2D[] get_BlueNoise256Textures() { }

	public override bool get_isAvailableInPlayerBuild() { }

	public override int get_version() { }

	public void set_BlueNoise256Textures(Texture2D[] value) { }

}

