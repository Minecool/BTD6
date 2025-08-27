namespace UnityEngine;

[NativeHeader("Runtime/Export/Gizmos/Gizmos.bindings.h")]
[StaticAccessor("GizmoBindings", StaticAccessorType::DoubleColon (2))]
public sealed class Gizmos
{

	public static Color color
	{
		 set { } //Length: 51
	}

	public static Matrix4x4 matrix
	{
		 set { } //Length: 51
	}

	[NativeThrows]
	public static void DrawIcon(Vector3 center, string name, bool allowScaling, Color tint) { }

	private static void DrawIcon_Injected(ref Vector3 center, string name, bool allowScaling, ref Color tint) { }

	[NativeThrows]
	public static void DrawLine(Vector3 from, Vector3 to) { }

	private static void DrawLine_Injected(ref Vector3 from, ref Vector3 to) { }

	public static void set_color(Color value) { }

	private static void set_color_Injected(ref Color value) { }

	public static void set_matrix(Matrix4x4 value) { }

	private static void set_matrix_Injected(ref Matrix4x4 value) { }

}

