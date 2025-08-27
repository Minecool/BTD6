namespace UnityEngine;

[NativeHeader("Modules/Physics2D/Public/EdgeCollider2D.h")]
public sealed class EdgeCollider2D : Collider2D
{

	public Vector2[] points
	{
		 set { } //Length: 261
	}

	public EdgeCollider2D() { }

	public void set_points(Vector2[] value) { }

	private static void set_points_Injected(IntPtr _unity_self, ref ManagedSpanWrapper value) { }

}

