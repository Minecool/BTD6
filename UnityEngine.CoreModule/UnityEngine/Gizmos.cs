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

	private static void DrawIcon_Injected(in Vector3 center, ref ManagedSpanWrapper name, bool allowScaling, in Color tint) { }

	[NativeThrows]
	public static void DrawLine(Vector3 from, Vector3 to) { }

	private static void DrawLine_Injected(in Vector3 from, in Vector3 to) { }

	public static void set_color(Color value) { }

	private static void set_color_Injected(in Color value) { }

	public static void set_matrix(Matrix4x4 value) { }

	private static void set_matrix_Injected(in Matrix4x4 value) { }

}

