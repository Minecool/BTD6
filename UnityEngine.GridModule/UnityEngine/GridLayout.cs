namespace UnityEngine;

[NativeHeader("Modules/Grid/Public/GridMarshalling.h")]
[NativeType(Header = "Modules/Grid/Public/Grid.h")]
[RequireComponent(typeof(Transform))]
public class GridLayout : Behaviour
{
	internal enum CellLayout
	{
		Rectangle = 0,
		Hexagon = 1,
		Isometric = 2,
		IsometricZAsY = 3,
	}

	internal enum CellSwizzle
	{
		XYZ = 0,
		XZY = 1,
		YXZ = 2,
		YZX = 3,
		ZXY = 4,
		ZYX = 5,
	}


	public GridLayout() { }

	[FreeFunction("GridLayoutBindings::CellToLocalInterpolated", HasExplicitThis = True)]
	public Vector3 CellToLocalInterpolated(Vector3 cellPosition) { }

	private static void CellToLocalInterpolated_Injected(IntPtr _unity_self, in Vector3 cellPosition, out Vector3 ret) { }

	[RequiredByNativeCode]
	private void DoNothing() { }

	[FreeFunction("GridLayoutBindings::GetLayoutCellCenter", HasExplicitThis = True)]
	public Vector3 GetLayoutCellCenter() { }

	private static void GetLayoutCellCenter_Injected(IntPtr _unity_self, out Vector3 ret) { }

	[FreeFunction("GridLayoutBindings::LocalToWorld", HasExplicitThis = True)]
	public Vector3 LocalToWorld(Vector3 localPosition) { }

	private static void LocalToWorld_Injected(IntPtr _unity_self, in Vector3 localPosition, out Vector3 ret) { }

}

