namespace UnityEngine;

[NativeHeader("Modules/Grid/Public/GridMarshalling.h")]
[NativeType(Header = "Modules/Grid/Public/Grid.h")]
[RequireComponent(typeof(Transform))]
public sealed class Grid : GridLayout
{

	public Vector3 cellGap
	{
		[FreeFunction("GridBindings::GetCellGap", HasExplicitThis = True)]
		 get { } //Length: 144
		[FreeFunction("GridBindings::SetCellGap", HasExplicitThis = True)]
		 set { } //Length: 133
	}

	public CellLayout cellLayout
	{
		 get { } //Length: 118
		 set { } //Length: 131
	}

	public Vector3 cellSize
	{
		[FreeFunction("GridBindings::GetCellSize", HasExplicitThis = True)]
		 get { } //Length: 144
		[FreeFunction("GridBindings::SetCellSize", HasExplicitThis = True)]
		 set { } //Length: 133
	}

	public CellSwizzle cellSwizzle
	{
		 get { } //Length: 118
		 set { } //Length: 452
	}

	public Grid() { }

	[FreeFunction("GridBindings::GetCellGap", HasExplicitThis = True)]
	public Vector3 get_cellGap() { }

	private static void get_cellGap_Injected(IntPtr _unity_self, out Vector3 ret) { }

	public CellLayout get_cellLayout() { }

	private static CellLayout get_cellLayout_Injected(IntPtr _unity_self) { }

	[FreeFunction("GridBindings::GetCellSize", HasExplicitThis = True)]
	public Vector3 get_cellSize() { }

	private static void get_cellSize_Injected(IntPtr _unity_self, out Vector3 ret) { }

	public CellSwizzle get_cellSwizzle() { }

	private static CellSwizzle get_cellSwizzle_Injected(IntPtr _unity_self) { }

	public Vector3 GetCellCenterLocal(Vector3Int position) { }

	public Vector3 GetCellCenterWorld(Vector3Int position) { }

	[FreeFunction("GridBindings::InverseCellSwizzle")]
	public static Vector3 InverseSwizzle(CellSwizzle swizzle, Vector3 position) { }

	private static void InverseSwizzle_Injected(CellSwizzle swizzle, in Vector3 position, out Vector3 ret) { }

	[FreeFunction("GridBindings::SetCellGap", HasExplicitThis = True)]
	public void set_cellGap(Vector3 value) { }

	private static void set_cellGap_Injected(IntPtr _unity_self, in Vector3 value) { }

	public void set_cellLayout(CellLayout value) { }

	private static void set_cellLayout_Injected(IntPtr _unity_self, CellLayout value) { }

	[FreeFunction("GridBindings::SetCellSize", HasExplicitThis = True)]
	public void set_cellSize(Vector3 value) { }

	private static void set_cellSize_Injected(IntPtr _unity_self, in Vector3 value) { }

	public void set_cellSwizzle(CellSwizzle value) { }

	private static void set_cellSwizzle_Injected(IntPtr _unity_self, CellSwizzle value) { }

	[FreeFunction("GridBindings::CellSwizzle")]
	public static Vector3 Swizzle(CellSwizzle swizzle, Vector3 position) { }

	private static void Swizzle_Injected(CellSwizzle swizzle, in Vector3 position, out Vector3 ret) { }

}

