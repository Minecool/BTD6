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

	private void CellToLocalInterpolated_Injected(ref Vector3 cellPosition, out Vector3 ret) { }

	[RequiredByNativeCode]
	private void DoNothing() { }

	[FreeFunction("GridLayoutBindings::GetLayoutCellCenter", HasExplicitThis = True)]
	public Vector3 GetLayoutCellCenter() { }

	private void GetLayoutCellCenter_Injected(out Vector3 ret) { }

	[FreeFunction("GridLayoutBindings::LocalToWorld", HasExplicitThis = True)]
	public Vector3 LocalToWorld(Vector3 localPosition) { }

	private void LocalToWorld_Injected(ref Vector3 localPosition, out Vector3 ret) { }

}

