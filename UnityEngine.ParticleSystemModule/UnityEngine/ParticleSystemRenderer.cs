namespace UnityEngine;

[NativeHeader("Modules/ParticleSystem/ParticleSystemRenderer.h")]
[NativeHeader("Modules/ParticleSystem/ScriptBindings/ParticleSystemRendererScriptBindings.h")]
[NativeHeader("ParticleSystemScriptingClasses.h")]
[RequireComponent(typeof(Transform))]
public sealed class ParticleSystemRenderer : Renderer
{
	public struct BakeTextureOutput
	{
		[NativeName("first")]
		internal Texture2D vertices; //Field offset: 0x0
		[NativeName("second")]
		internal Texture2D indices; //Field offset: 0x8

	}


	public int activeTrailVertexStreamsCount
	{
		 get { } //Length: 51
	}

	public int activeVertexStreamsCount
	{
		 get { } //Length: 51
	}

	[NativeName("RenderAlignment")]
	public ParticleSystemRenderSpace alignment
	{
		 get { } //Length: 51
		 set { } //Length: 64
	}

	public bool allowRoll
	{
		 get { } //Length: 51
		 set { } //Length: 66
	}

	public float cameraVelocityScale
	{
		 get { } //Length: 51
		 set { } //Length: 67
	}

	public bool enableGPUInstancing
	{
		 get { } //Length: 51
		 set { } //Length: 66
	}

	public Vector3 flip
	{
		 get { } //Length: 77
		 set { } //Length: 66
	}

	public bool freeformStretching
	{
		 get { } //Length: 51
		 set { } //Length: 66
	}

	public float lengthScale
	{
		 get { } //Length: 51
		 set { } //Length: 67
	}

	public SpriteMaskInteraction maskInteraction
	{
		 get { } //Length: 51
		 set { } //Length: 64
	}

	public float maxParticleSize
	{
		 get { } //Length: 51
		 set { } //Length: 67
	}

	public Mesh mesh
	{
		[FreeFunction(Name = "ParticleSystemRendererScriptBindings::GetMesh", HasExplicitThis = True)]
		 get { } //Length: 51
		[FreeFunction(Name = "ParticleSystemRendererScriptBindings::SetMesh", HasExplicitThis = True)]
		 set { } //Length: 66
	}

	public int meshCount
	{
		 get { } //Length: 51
	}

	public ParticleSystemMeshDistribution meshDistribution
	{
		 get { } //Length: 51
		 set { } //Length: 64
	}

	public float minParticleSize
	{
		 get { } //Length: 51
		 set { } //Length: 67
	}

	public float normalDirection
	{
		 get { } //Length: 51
		 set { } //Length: 67
	}

	internal Material oldTrailMaterial
	{
		internal set { } //Length: 66
	}

	public Vector3 pivot
	{
		 get { } //Length: 77
		 set { } //Length: 66
	}

	public ParticleSystemRenderMode renderMode
	{
		 get { } //Length: 51
		 set { } //Length: 64
	}

	public bool rotateWithStretchDirection
	{
		 get { } //Length: 51
		 set { } //Length: 66
	}

	public float shadowBias
	{
		 get { } //Length: 51
		 set { } //Length: 67
	}

	public float sortingFudge
	{
		 get { } //Length: 51
		 set { } //Length: 67
	}

	public ParticleSystemSortMode sortMode
	{
		 get { } //Length: 51
		 set { } //Length: 64
	}

	public Material trailMaterial
	{
		 get { } //Length: 51
		 set { } //Length: 66
	}

	public float velocityScale
	{
		 get { } //Length: 51
		 set { } //Length: 67
	}

	public ParticleSystemRenderer() { }

	[Obsolete("AreVertexStreamsEnabled is deprecated. Use GetActiveVertexStreams instead.", False)]
	public bool AreVertexStreamsEnabled(ParticleSystemVertexStreams streams) { }

	public void BakeMesh(Mesh mesh, Camera camera, ParticleSystemBakeMeshOptions options) { }

	[Obsolete("BakeMesh with useTransform is deprecated. Use BakeMesh with ParticleSystemBakeMeshOptions instead.", False)]
	public void BakeMesh(Mesh mesh, bool useTransform = false) { }

	[Obsolete("BakeMesh with useTransform is deprecated. Use BakeMesh with ParticleSystemBakeMeshOptions instead.", False)]
	public void BakeMesh(Mesh mesh, Camera camera, bool useTransform = false) { }

	public void BakeMesh(Mesh mesh, ParticleSystemBakeMeshOptions options) { }

	public int BakeTexture(ref Texture2D verticesTexture, ParticleSystemBakeTextureOptions options) { }

	public int BakeTexture(ref Texture2D verticesTexture, ref Texture2D indicesTexture, ParticleSystemBakeTextureOptions options) { }

	public int BakeTexture(ref Texture2D verticesTexture, ref Texture2D indicesTexture, Camera camera, ParticleSystemBakeTextureOptions options) { }

	public int BakeTexture(ref Texture2D verticesTexture, Camera camera, ParticleSystemBakeTextureOptions options) { }

	[FreeFunction(Name = "ParticleSystemRendererScriptBindings::BakeTexture", HasExplicitThis = True)]
	private BakeTextureOutput BakeTextureInternal(Texture2D verticesTexture, Texture2D indicesTexture, Camera camera, ParticleSystemBakeTextureOptions options, out int indexCount) { }

	private void BakeTextureInternal_Injected(Texture2D verticesTexture, Texture2D indicesTexture, Camera camera, ParticleSystemBakeTextureOptions options, out int indexCount, out BakeTextureOutput ret) { }

	[FreeFunction(Name = "ParticleSystemRendererScriptBindings::BakeTextureNoIndices", HasExplicitThis = True)]
	private Texture2D BakeTextureNoIndicesInternal(Texture2D verticesTexture, Camera camera, ParticleSystemBakeTextureOptions options, out int indexCount) { }

	public void BakeTrailsMesh(Mesh mesh, Camera camera, ParticleSystemBakeMeshOptions options) { }

	public void BakeTrailsMesh(Mesh mesh, ParticleSystemBakeMeshOptions options) { }

	[Obsolete("BakeTrailsMesh with useTransform is deprecated. Use BakeTrailsMesh with ParticleSystemBakeMeshOptions instead.", False)]
	public void BakeTrailsMesh(Mesh mesh, Camera camera, bool useTransform = false) { }

	[Obsolete("BakeTrailsMesh with useTransform is deprecated. Use BakeTrailsMesh with ParticleSystemBakeMeshOptions instead.", False)]
	public void BakeTrailsMesh(Mesh mesh, bool useTransform = false) { }

	public int BakeTrailsTexture(ref Texture2D verticesTexture, ref Texture2D indicesTexture, ParticleSystemBakeTextureOptions options) { }

	public int BakeTrailsTexture(ref Texture2D verticesTexture, ref Texture2D indicesTexture, Camera camera, ParticleSystemBakeTextureOptions options) { }

	[FreeFunction(Name = "ParticleSystemRendererScriptBindings::BakeTrailsTexture", HasExplicitThis = True)]
	private BakeTextureOutput BakeTrailsTextureInternal(Texture2D verticesTexture, Texture2D indicesTexture, Camera camera, ParticleSystemBakeTextureOptions options, out int indexCount) { }

	private void BakeTrailsTextureInternal_Injected(Texture2D verticesTexture, Texture2D indicesTexture, Camera camera, ParticleSystemBakeTextureOptions options, out int indexCount, out BakeTextureOutput ret) { }

	[Obsolete("DisableVertexStreams is deprecated. Use SetActiveVertexStreams instead.", False)]
	public void DisableVertexStreams(ParticleSystemVertexStreams streams) { }

	[Obsolete("EnableVertexStreams is deprecated. Use SetActiveVertexStreams instead.", False)]
	public void EnableVertexStreams(ParticleSystemVertexStreams streams) { }

	public int get_activeTrailVertexStreamsCount() { }

	public int get_activeVertexStreamsCount() { }

	public ParticleSystemRenderSpace get_alignment() { }

	public bool get_allowRoll() { }

	public float get_cameraVelocityScale() { }

	public bool get_enableGPUInstancing() { }

	public Vector3 get_flip() { }

	private void get_flip_Injected(out Vector3 ret) { }

	public bool get_freeformStretching() { }

	public float get_lengthScale() { }

	public SpriteMaskInteraction get_maskInteraction() { }

	public float get_maxParticleSize() { }

	[FreeFunction(Name = "ParticleSystemRendererScriptBindings::GetMesh", HasExplicitThis = True)]
	public Mesh get_mesh() { }

	public int get_meshCount() { }

	public ParticleSystemMeshDistribution get_meshDistribution() { }

	public float get_minParticleSize() { }

	public float get_normalDirection() { }

	public Vector3 get_pivot() { }

	private void get_pivot_Injected(out Vector3 ret) { }

	public ParticleSystemRenderMode get_renderMode() { }

	public bool get_rotateWithStretchDirection() { }

	public float get_shadowBias() { }

	public float get_sortingFudge() { }

	public ParticleSystemSortMode get_sortMode() { }

	public Material get_trailMaterial() { }

	public float get_velocityScale() { }

	[FreeFunction(Name = "ParticleSystemRendererScriptBindings::GetActiveTrailVertexStreams", HasExplicitThis = True)]
	public void GetActiveTrailVertexStreams(List<ParticleSystemVertexStream> streams) { }

	[FreeFunction(Name = "ParticleSystemRendererScriptBindings::GetActiveVertexStreams", HasExplicitThis = True)]
	public void GetActiveVertexStreams(List<ParticleSystemVertexStream> streams) { }

	[Obsolete("GetEnabledVertexStreams is deprecated. Use GetActiveVertexStreams instead.", False)]
	public ParticleSystemVertexStreams GetEnabledVertexStreams(ParticleSystemVertexStreams streams) { }

	[FreeFunction(Name = "ParticleSystemRendererScriptBindings::GetMeshes", HasExplicitThis = True)]
	[RequiredByNativeCode]
	public int GetMeshes(out Mesh[] meshes) { }

	[FreeFunction(Name = "ParticleSystemRendererScriptBindings::GetMeshWeightings", HasExplicitThis = True)]
	public int GetMeshWeightings(out Single[] weightings) { }

	[Obsolete("Internal_GetVertexStreams is deprecated. Use GetActiveVertexStreams instead.", False)]
	internal ParticleSystemVertexStreams Internal_GetEnabledVertexStreams(ParticleSystemVertexStreams streams) { }

	[Obsolete("Internal_SetVertexStreams is deprecated. Use SetActiveVertexStreams instead.", False)]
	internal void Internal_SetVertexStreams(ParticleSystemVertexStreams streams, bool enabled) { }

	public void set_alignment(ParticleSystemRenderSpace value) { }

	public void set_allowRoll(bool value) { }

	public void set_cameraVelocityScale(float value) { }

	public void set_enableGPUInstancing(bool value) { }

	public void set_flip(Vector3 value) { }

	private void set_flip_Injected(ref Vector3 value) { }

	public void set_freeformStretching(bool value) { }

	public void set_lengthScale(float value) { }

	public void set_maskInteraction(SpriteMaskInteraction value) { }

	public void set_maxParticleSize(float value) { }

	[FreeFunction(Name = "ParticleSystemRendererScriptBindings::SetMesh", HasExplicitThis = True)]
	public void set_mesh(Mesh value) { }

	public void set_meshDistribution(ParticleSystemMeshDistribution value) { }

	public void set_minParticleSize(float value) { }

	public void set_normalDirection(float value) { }

	internal void set_oldTrailMaterial(Material value) { }

	public void set_pivot(Vector3 value) { }

	private void set_pivot_Injected(ref Vector3 value) { }

	public void set_renderMode(ParticleSystemRenderMode value) { }

	public void set_rotateWithStretchDirection(bool value) { }

	public void set_shadowBias(float value) { }

	public void set_sortingFudge(float value) { }

	public void set_sortMode(ParticleSystemSortMode value) { }

	public void set_trailMaterial(Material value) { }

	public void set_velocityScale(float value) { }

	[FreeFunction(Name = "ParticleSystemRendererScriptBindings::SetActiveTrailVertexStreams", HasExplicitThis = True)]
	public void SetActiveTrailVertexStreams(List<ParticleSystemVertexStream> streams) { }

	[FreeFunction(Name = "ParticleSystemRendererScriptBindings::SetActiveVertexStreams", HasExplicitThis = True)]
	public void SetActiveVertexStreams(List<ParticleSystemVertexStream> streams) { }

	public void SetMeshes(Mesh[] meshes) { }

	[FreeFunction(Name = "ParticleSystemRendererScriptBindings::SetMeshes", HasExplicitThis = True)]
	public void SetMeshes(Mesh[] meshes, int size) { }

	public void SetMeshWeightings(Single[] weightings) { }

	[FreeFunction(Name = "ParticleSystemRendererScriptBindings::SetMeshWeightings", HasExplicitThis = True)]
	public void SetMeshWeightings(Single[] weightings, int size) { }

}

