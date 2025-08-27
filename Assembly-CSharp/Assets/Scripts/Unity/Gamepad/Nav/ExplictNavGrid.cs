namespace Assets.Scripts.Unity.Gamepad.Nav;

public class ExplictNavGrid
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Comparison<Selectable> <>9__3_0; //Field offset: 0x8

		private static <>c() { }

		public <>c() { }

		internal int <VerticalLink>b__3_0(Selectable a, Selectable b) { }

	}

	private ExplicitNearest nearest; //Field offset: 0x10
	public Action explictNavFix; //Field offset: 0x18
	private NavCell[2] cells; //Field offset: 0x20

	public ExplictNavGrid(NavCell[2] cells) { }

	public void AutoConnectHorizontal(List<Selectable> leftSet, List<Selectable> rightSet) { }

	public void AutoConnectVertical(List<Selectable> topSet, List<Selectable> bottomSet) { }

	public void AutoLink(List<Selectable> items) { }

	public void ClearNav(List<Selectable> items) { }

	public void FillActiveSelectables(List<Selectable> res, Transform[] transforms) { }

	public void FullClearNav(List<Selectable>[2] grid) { }

	private NavCell GetNextDownY(int x, int y, int rows) { }

	private NavCell GetNextRightX(int x, int y, int cols) { }

	private void Select() { }

	public void UpdateNav() { }

	private void UpdateNavSets() { }

	public void VerticalLink(List<Selectable> items) { }

}

