namespace Assets.Scripts.Unity.Gamepad;

[Extension]
public static class ScrollRectExtension
{
	private static Vector3[] viewportCorners; //Field offset: 0x0
	private static Vector3[] selectionCorners; //Field offset: 0x8

	private static ScrollRectExtension() { }

	[Extension]
	public static void SnapContentToSelected(ScrollRect sr, RectTransform selection, float padding = 20) { }

}

