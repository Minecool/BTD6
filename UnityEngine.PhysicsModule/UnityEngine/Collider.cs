namespace UnityEngine;

[NativeHeader("Modules/Physics/Collider.h")]
[RequireComponent(typeof(Transform))]
[RequiredByNativeCode]
public class Collider : Component
{

	public bool enabled
	{
		 get { } //Length: 51
		 set { } //Length: 66
	}

	public Collider() { }

	public Vector3 ClosestPoint(Vector3 position) { }

	private void ClosestPoint_Injected(ref Vector3 position, out Vector3 ret) { }

	public bool get_enabled() { }

	private RaycastHit Raycast(Ray ray, float maxDistance, ref bool hasHit) { }

	public bool Raycast(Ray ray, out RaycastHit hitInfo, float maxDistance) { }

	private void Raycast_Injected(ref Ray ray, float maxDistance, ref bool hasHit, out RaycastHit ret) { }

	public void set_enabled(bool value) { }

}

