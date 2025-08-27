namespace UnityEngine;

[NativeHeader("Modules/Grid/Public/GridMarshalling.h")]
[NativeType(Header = "Modules/Grid/Public/Grid.h")]
[RequireComponent(typeof(Transform))]
public sealed class Grid : GridLayout
{

	public Vector3 cellGap
	{
		[FreeFunction("GridBindings::GetCellGap", HasExplicitThis = True)]
		 get { } //Length: 77
		[FreeFunction("GridBindings::SetCellGap", HasExplicitThis = True)]
		 set { } //Length: 66
	}

	public CellLayout cellLayout
	{
		 get { } //Length: 51
		 set { } //Length: 64
	}

	public Vector3 cellSize
	{
		[FreeFunction("GridBindings::GetCellSize", HasExplicitThis = True)]
		 get { } //Length: 77
		[FreeFunction("GridBindings::SetCellSize", HasExplicitThis = True)]
		 set { } //Length: 66
	}

	public CellSwizzle cellSwizzle
	{
		 get { } //Length: 51
		 set { } //Length: 64
	}

	public Grid() { }

	[FreeFunction("GridBindings::GetCellGap", HasExplicitThis = True)]
	public Vector3 get_cellGap() { }

	private void get_cellGap_Injected(out Vector3 ret) { }

	public CellLayout get_cellLayout() { }

	[FreeFunction("GridBindings::GetCellSize", HasExplicitThis = True)]
	public Vector3 get_cellSize() { }

	private void get_cellSize_Injected(out Vector3 ret) { }

	public CellSwizzle get_cellSwizzle() { }

	public Vector3 GetCellCenterLocal(Vector3Int position) { }

	public Vector3 GetCellCenterWorld(Vector3Int position) { }

	[FreeFunction("GridBindings::InverseCellSwizzle")]
	public static Vector3 InverseSwizzle(CellSwizzle swizzle, Vector3 position) { }

	private static void InverseSwizzle_Injected(CellSwizzle swizzle, ref Vector3 position, out Vector3 ret) { }

	[FreeFunction("GridBindings::SetCellGap", HasExplicitThis = True)]
	public void set_cellGap(Vector3 value) { }

	private void set_cellGap_Injected(ref Vector3 value) { }

	public void set_cellLayout(CellLayout value) { }

	[FreeFunction("GridBindings::SetCellSize", HasExplicitThis = True)]
	public void set_cellSize(Vector3 value) { }

	private void set_cellSize_Injected(ref Vector3 value) { }

	public void set_cellSwizzle(CellSwizzle value) { }

	[FreeFunction("GridBindings::CellSwizzle")]
	public static Vector3 Swizzle(CellSwizzle swizzle, Vector3 position) { }

	private static void Swizzle_Injected(CellSwizzle swizzle, ref Vector3 position, out Vector3 ret) { }

}

