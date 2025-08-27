namespace UnityEngine;

[NativeHeader("Modules/Physics/Collider.h")]
public class Collider : Component
{

	public bool enabled
	{
		 get { } //Length: 118
		 set { } //Length: 134
	}

	public Collider() { }

	public Vector3 ClosestPoint(Vector3 position) { }

	private static void ClosestPoint_Injected(IntPtr _unity_self, in Vector3 position, out Vector3 ret) { }

	public bool get_enabled() { }

	private static bool get_enabled_Injected(IntPtr _unity_self) { }

	private RaycastHit Raycast(Ray ray, float maxDistance, ref bool hasHit) { }

	public bool Raycast(Ray ray, out RaycastHit hitInfo, float maxDistance) { }

	private static void Raycast_Injected(IntPtr _unity_self, in Ray ray, float maxDistance, ref bool hasHit, out RaycastHit ret) { }

	public void set_enabled(bool value) { }

	private static void set_enabled_Injected(IntPtr _unity_self, bool value) { }

}

