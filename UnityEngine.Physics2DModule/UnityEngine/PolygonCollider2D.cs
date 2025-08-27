namespace UnityEngine;

[NativeHeader("Modules/Physics2D/Public/PolygonCollider2D.h")]
public sealed class PolygonCollider2D : Collider2D
{

	public Vector2[] points
	{
		[NativeMethod("SetPoints_Binding")]
		 set { } //Length: 261
	}

	public PolygonCollider2D() { }

	[NativeMethod("SetPoints_Binding")]
	public void set_points(Vector2[] value) { }

	private static void set_points_Injected(IntPtr _unity_self, ref ManagedSpanWrapper value) { }

}

