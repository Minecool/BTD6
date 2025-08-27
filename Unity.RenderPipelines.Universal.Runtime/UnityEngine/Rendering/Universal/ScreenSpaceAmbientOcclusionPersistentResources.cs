namespace UnityEngine.Rendering.Universal;

[CategoryInfo(Name = "R: SSAO Shader", Order = 1000)]
[ElementInfo(Order = 0)]
[HideInInspector]
[SupportedOnRenderPipeline(typeof(UniversalRenderPipelineAsset))]
internal class ScreenSpaceAmbientOcclusionPersistentResources : IRenderPipelineResources, IRenderPipelineGraphicsSettings
{
	[ResourcePath("Shaders/Utils/ScreenSpaceAmbientOcclusion.shader", SearchType::ProjectPath (0))]
	[SerializeField]
	private Shader m_Shader; //Field offset: 0x10
	[HideInInspector]
	[SerializeField]
	private int m_Version; //Field offset: 0x18

	public override bool isAvailableInPlayerBuild
	{
		 get { } //Length: 3
	}

	public Shader Shader
	{
		 get { } //Length: 5
		 set { } //Length: 101
	}

	public override int version
	{
		 get { } //Length: 4
	}

	public ScreenSpaceAmbientOcclusionPersistentResources() { }

	public override bool get_isAvailableInPlayerBuild() { }

	public Shader get_Shader() { }

	public override int get_version() { }

	public void set_Shader(Shader value) { }

}

