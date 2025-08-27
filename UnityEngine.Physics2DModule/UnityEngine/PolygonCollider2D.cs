namespace UnityEngine;

[NativeHeader("Modules/Physics2D/Public/PolygonCollider2D.h")]
public sealed class PolygonCollider2D : Collider2D
{

	public Vector2[] points
	{
		[NativeMethod("SetPoints_Binding")]
		 set { } //Length: 66
	}

	[NativeMethod("SetPoints_Binding")]
	public void set_points(Vector2[] value) { }

}

