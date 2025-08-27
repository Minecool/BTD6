namespace UnityEngine;

[NativeHeader("Modules/Physics/BoxCollider.h")]
[RequiredByNativeCode]
public class BoxCollider : Collider
{

	public Vector3 center
	{
		 get { } //Length: 77
		 set { } //Length: 66
	}

	[Obsolete("Use BoxCollider.size instead. (UnityUpgradable) -> size")]
	public Vector3 extents
	{
		 get { } //Length: 138
		 set { } //Length: 116
	}

	public Vector3 size
	{
		 get { } //Length: 77
		 set { } //Length: 66
	}

	public BoxCollider() { }

	public Vector3 get_center() { }

	private void get_center_Injected(out Vector3 ret) { }

	public Vector3 get_extents() { }

	public Vector3 get_size() { }

	private void get_size_Injected(out Vector3 ret) { }

	public void set_center(Vector3 value) { }

	private void set_center_Injected(ref Vector3 value) { }

	public void set_extents(Vector3 value) { }

	public void set_size(Vector3 value) { }

	private void set_size_Injected(ref Vector3 value) { }

}

