namespace UnityEngine;

[NativeHeader("Runtime/Graphics/Mesh/MeshFilter.h")]
[RequireComponent(typeof(Transform))]
public sealed class MeshFilter : Component
{

	public Mesh mesh
	{
		[NativeName("GetInstantiatedMeshFromScript")]
		 get { } //Length: 51
		[NativeName("SetInstantiatedMesh")]
		 set { } //Length: 66
	}

	public Mesh sharedMesh
	{
		 get { } //Length: 51
		 set { } //Length: 66
	}

	public MeshFilter() { }

	[RequiredByNativeCode]
	private void DontStripMeshFilter() { }

	[NativeName("GetInstantiatedMeshFromScript")]
	public Mesh get_mesh() { }

	public Mesh get_sharedMesh() { }

	[NativeName("SetInstantiatedMesh")]
	public void set_mesh(Mesh value) { }

	public void set_sharedMesh(Mesh value) { }

}

