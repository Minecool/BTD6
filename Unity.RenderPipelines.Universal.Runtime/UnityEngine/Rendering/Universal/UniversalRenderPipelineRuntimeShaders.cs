namespace UnityEngine.Rendering.Universal;

[CategoryInfo(Name = "R: Runtime Shaders", Order = 1000)]
[HideInInspector]
[SupportedOnRenderPipeline(typeof(UniversalRenderPipelineAsset))]
public class UniversalRenderPipelineRuntimeShaders : IRenderPipelineResources, IRenderPipelineGraphicsSettings
{
	[HideInInspector]
	[SerializeField]
	private int m_Version; //Field offset: 0x10
	[ResourcePath("Shaders/Utils/FallbackError.shader", SearchType::ProjectPath (0))]
	[SerializeField]
	private Shader m_FallbackErrorShader; //Field offset: 0x18
	[ResourcePath("Shaders/Utils/BlitHDROverlay.shader", SearchType::ProjectPath (0))]
	[SerializeField]
	internal Shader m_BlitHDROverlay; //Field offset: 0x20
	[ResourcePath("Shaders/Utils/CoreBlit.shader", SearchType::ProjectPath (0))]
	[SerializeField]
	internal Shader m_CoreBlitPS; //Field offset: 0x28
	[ResourcePath("Shaders/Utils/CoreBlitColorAndDepth.shader", SearchType::ProjectPath (0))]
	[SerializeField]
	internal Shader m_CoreBlitColorAndDepthPS; //Field offset: 0x30
	[ResourcePath("Shaders/Utils/Sampling.shader", SearchType::ProjectPath (0))]
	[SerializeField]
	private Shader m_SamplingPS; //Field offset: 0x38
	[Header("Terrain")]
	[ResourcePath("Shaders/Terrain/TerrainDetailLit.shader", SearchType::ProjectPath (0))]
	[SerializeField]
	private Shader m_TerrainDetailLit; //Field offset: 0x40
	[ResourcePath("Shaders/Terrain/WavingGrassBillboard.shader", SearchType::ProjectPath (0))]
	[SerializeField]
	private Shader m_TerrainDetailGrassBillboard; //Field offset: 0x48
	[ResourcePath("Shaders/Terrain/WavingGrass.shader", SearchType::ProjectPath (0))]
	[SerializeField]
	private Shader m_TerrainDetailGrass; //Field offset: 0x50

	public Shader blitHDROverlay
	{
		 get { } //Length: 5
		 set { } //Length: 101
	}

	public Shader coreBlitColorAndDepthPS
	{
		 get { } //Length: 5
		 set { } //Length: 101
	}

	public Shader coreBlitPS
	{
		 get { } //Length: 5
		 set { } //Length: 101
	}

	public Shader fallbackErrorShader
	{
		 get { } //Length: 5
		 set { } //Length: 101
	}

	public Shader samplingPS
	{
		 get { } //Length: 5
		 set { } //Length: 101
	}

	public Shader terrainDetailGrassBillboardShader
	{
		 get { } //Length: 5
		 set { } //Length: 101
	}

	public Shader terrainDetailGrassShader
	{
		 get { } //Length: 5
		 set { } //Length: 101
	}

	public Shader terrainDetailLitShader
	{
		 get { } //Length: 5
		 set { } //Length: 101
	}

	private override bool UnityEngine.Rendering.IRenderPipelineGraphicsSettings.isAvailableInPlayerBuild
	{
		private get { } //Length: 3
	}

	public override int version
	{
		 get { } //Length: 94
	}

	public UniversalRenderPipelineRuntimeShaders() { }

	public Shader get_blitHDROverlay() { }

	public Shader get_coreBlitColorAndDepthPS() { }

	public Shader get_coreBlitPS() { }

	public Shader get_fallbackErrorShader() { }

	public Shader get_samplingPS() { }

	public Shader get_terrainDetailGrassBillboardShader() { }

	public Shader get_terrainDetailGrassShader() { }

	public Shader get_terrainDetailLitShader() { }

	public override int get_version() { }

	public void set_blitHDROverlay(Shader value) { }

	public void set_coreBlitColorAndDepthPS(Shader value) { }

	public void set_coreBlitPS(Shader value) { }

	public void set_fallbackErrorShader(Shader value) { }

	public void set_samplingPS(Shader value) { }

	public void set_terrainDetailGrassBillboardShader(Shader value) { }

	public void set_terrainDetailGrassShader(Shader value) { }

	public void set_terrainDetailLitShader(Shader value) { }

	private override bool UnityEngine.Rendering.IRenderPipelineGraphicsSettings.get_isAvailableInPlayerBuild() { }

}

