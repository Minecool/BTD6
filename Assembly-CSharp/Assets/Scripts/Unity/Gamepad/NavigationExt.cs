namespace Assets.Scripts.Unity.Gamepad;

public static class NavigationExt
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass17_0
	{
		public bool allowNoneNav; //Field offset: 0x10

		public <>c__DisplayClass17_0() { }

		internal bool <GetActiveSelectables>b__0(Selectable sel) { }

	}


	public static List<Selectable> ActiveExplicitFilter(Selectable[] selectables) { }

	public static List<Selectable> ActiveFilter(Selectable[] selectables) { }

	public static void AutoNav(List<Selectable> selectables) { }

	private static void FillGridItems(Selectable[2] items, int cols, int rows, GridLayoutGroup grid, int rowOffset, List<GameObject> children, int itemCount) { }

	public static List<GameObject> GetActiveChildren(Transform transform) { }

	public static Selectable GetActiveSelectable(GameObject obj) { }

	public static List<Selectable> GetActiveSelectables(Transform transform, bool allowNoneNav = false) { }

	private static void GetDimentions(GridLayoutGroup grid, int itemCount, out int cols, out int rows) { }

	public static Selectable GetSelectable(GameObject obj) { }

	public static bool IsChildOf(GameObject gameObject, GameObject parent) { }

	public static void LinkDown(Selectable sel, Selectable downTarget) { }

	public static void LinkGrid(GridLayoutGroup grid) { }

	public static void LinkGridCells(int cols, int rows, Selectable[2] items, Selectable navLeft = null) { }

	public static void LinkGrids(GridLayoutGroup[] grids, Selectable navLeft) { }

	public static void LinkHorizontal(Selectable up, Selectable down, Selectable left, Selectable right, IList<Selectable> selectables) { }

	public static void LinkHorizontal(Selectable left, Selectable right) { }

	public static void LinkLeft(Selectable sel, Selectable leftTarget) { }

	public static void LinkRight(Selectable sel, Selectable rightTarget) { }

	public static void LinkUp(Selectable sel, Selectable upTarget) { }

	public static void LinkVertical(Selectable top, Selectable bottom) { }

	public static void LinkVertical(Selectable up, Selectable down, Selectable left, Selectable right, IList<Selectable> selectables) { }

	public static void LinkVertical(Transform container) { }

	public static void LinkVerticalThenHorizontal(LayoutGroup[] layouts) { }

	public static void LinkVerticalThenHorizontal(List<Selectable[]> rows) { }

	public static void SetNav(Selectable sel, Selectable up, Selectable down, Selectable left, Selectable right) { }

	public static void SetRightTarget(List<Selectable> selectables, Selectable rightTarget) { }

	public static bool TrySelectFirstActive(Transform container) { }

	public static void ValidateGrid(int cols, int rows, Selectable[2] items) { }

}

