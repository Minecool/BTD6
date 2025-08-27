namespace UnityEngine;

[NativeHeader("Modules/Physics/SphereCollider.h")]
[RequiredByNativeCode]
public class SphereCollider : Collider
{

	public Vector3 center
	{
		 get { } //Length: 77
		 set { } //Length: 66
	}

	public float radius
	{
		 get { } //Length: 51
		 set { } //Length: 470
	}

	public SphereCollider() { }

	public Vector3 get_center() { }

	private void get_center_Injected(out Vector3 ret) { }

	public float get_radius() { }

	public void set_center(Vector3 value) { }

	private void set_center_Injected(ref Vector3 value) { }

	public void set_radius(float value) { }

}

