namespace UnityEngine;

[NativeHeader("Runtime/Graphics/Mesh/SkinnedMeshRenderer.h")]
[RequiredByNativeCode]
public class SkinnedMeshRenderer : Renderer
{

	public Transform[] bones
	{
		 get { } //Length: 51
		 set { } //Length: 66
	}

	public bool forceMatrixRecalculationPerRender
	{
		 get { } //Length: 51
		 set { } //Length: 66
	}

	public SkinQuality quality
	{
		 get { } //Length: 51
		 set { } //Length: 64
	}

	public Transform rootBone
	{
		 get { } //Length: 51
		 set { } //Length: 66
	}

	[NativeProperty("Mesh")]
	public Mesh sharedMesh
	{
		 get { } //Length: 51
		 set { } //Length: 66
	}

	[NativeProperty("SkinnedMeshMotionVectors")]
	public bool skinnedMotionVectors
	{
		 get { } //Length: 51
		 set { } //Length: 66
	}

	public bool updateWhenOffscreen
	{
		 get { } //Length: 51
		 set { } //Length: 66
	}

	public Target vertexBufferTarget
	{
		 get { } //Length: 51
		 set { } //Length: 64
	}

	public SkinnedMeshRenderer() { }

	public void BakeMesh(Mesh mesh, bool useScale) { }

	public void BakeMesh(Mesh mesh) { }

	public Transform[] get_bones() { }

	public bool get_forceMatrixRecalculationPerRender() { }

	public SkinQuality get_quality() { }

	public Transform get_rootBone() { }

	public Mesh get_sharedMesh() { }

	public bool get_skinnedMotionVectors() { }

	public bool get_updateWhenOffscreen() { }

	public Target get_vertexBufferTarget() { }

	public float GetBlendShapeWeight(int index) { }

	public GraphicsBuffer GetPreviousVertexBuffer() { }

	[FreeFunction(Name = "SkinnedMeshRendererScripting::GetPreviousVertexBufferPtr", HasExplicitThis = True)]
	private GraphicsBuffer GetPreviousVertexBufferImpl() { }

	public GraphicsBuffer GetVertexBuffer() { }

	[FreeFunction(Name = "SkinnedMeshRendererScripting::GetVertexBufferPtr", HasExplicitThis = True)]
	private GraphicsBuffer GetVertexBufferImpl() { }

	public void set_bones(Transform[] value) { }

	public void set_forceMatrixRecalculationPerRender(bool value) { }

	public void set_quality(SkinQuality value) { }

	public void set_rootBone(Transform value) { }

	public void set_sharedMesh(Mesh value) { }

	public void set_skinnedMotionVectors(bool value) { }

	public void set_updateWhenOffscreen(bool value) { }

	public void set_vertexBufferTarget(Target value) { }

	public void SetBlendShapeWeight(int index, float value) { }

}

