namespace UnityEngine;

[NativeHeader("Modules/Physics/MeshCollider.h")]
[NativeHeader("Runtime/Graphics/Mesh/Mesh.h")]
[RequiredByNativeCode]
public class MeshCollider : Collider
{

	public bool convex
	{
		 get { } //Length: 51
		 set { } //Length: 66
	}

	public MeshColliderCookingOptions cookingOptions
	{
		 get { } //Length: 51
		 set { } //Length: 64
	}

	[Obsolete("MeshCollider.inflateMesh is no longer supported. The new cooking algorithm doesn't need inflation to be used.")]
	public bool inflateMesh
	{
		 get { } //Length: 5
		 set { } //Length: 3
	}

	public Mesh sharedMesh
	{
		 get { } //Length: 51
		 set { } //Length: 66
	}

	[Obsolete("MeshCollider.skinWidth is no longer used.")]
	public float skinWidth
	{
		 get { } //Length: 6
		 set { } //Length: 3
	}

	[EditorBrowsable(EditorBrowsableState::Never (1))]
	[Obsolete("Configuring smooth sphere collisions is no longer needed.", True)]
	public bool smoothSphereCollisions
	{
		 get { } //Length: 5
		 set { } //Length: 3
	}

	public MeshCollider() { }

	public bool get_convex() { }

	public MeshColliderCookingOptions get_cookingOptions() { }

	public bool get_inflateMesh() { }

	public Mesh get_sharedMesh() { }

	public float get_skinWidth() { }

	public bool get_smoothSphereCollisions() { }

	public void set_convex(bool value) { }

	public void set_cookingOptions(MeshColliderCookingOptions value) { }

	public void set_inflateMesh(bool value) { }

	public void set_sharedMesh(Mesh value) { }

	public void set_skinWidth(float value) { }

	public void set_smoothSphereCollisions(bool value) { }

}

