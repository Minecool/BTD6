namespace NinjaKiwi.Common;

[Extension]
public static class RectTransformExtensions
{
	internal enum AnchorPresets
	{
		TopLeft = 0,
		TopCenter = 1,
		TopRight = 2,
		MiddleLeft = 3,
		MiddleCenter = 4,
		MiddleRight = 5,
		BottomLeft = 6,
		BottonCenter = 7,
		BottomRight = 8,
		VertStretchLeft = 9,
		VertStretchRight = 10,
		VertStretchCenter = 11,
		HorStretchTop = 12,
		HorStretchMiddle = 13,
		HorStretchBottom = 14,
		StretchAll = 15,
	}

	internal enum PivotPresets
	{
		TopLeft = 0,
		TopCenter = 1,
		TopRight = 2,
		MiddleLeft = 3,
		MiddleCenter = 4,
		MiddleRight = 5,
		BottomLeft = 6,
		BottomCenter = 7,
		BottomRight = 8,
	}


	[Extension]
	public static void GetScreenCorners(RectTransform transform, Camera cam, Vector3[] fourCornersArray) { }

	[Extension]
	public static Bounds GetWorldBounds(RectTransform t) { }

	[Extension]
	public static Vector3 NormalisedToWorldPoint(RectTransform transform, Vector2 normalisedPoint) { }

	[Extension]
	public static void SetAnchor(RectTransform source, AnchorPresets align, int offsetX = 0, int offsetY = 0) { }

	[Extension]
	public static void SetBottom(RectTransform rt, float bottom) { }

	[Extension]
	public static void SetLeft(RectTransform rt, float left) { }

	[Extension]
	public static void SetOffset(RectTransform rectTransform, float left, float right, float top, float bottom) { }

	[Extension]
	public static void SetPivot(RectTransform source, PivotPresets preset) { }

	[Extension]
	public static void SetRight(RectTransform rt, float right) { }

	[Extension]
	public static void SetTop(RectTransform rt, float top) { }

	[Extension]
	public static void StretchToFill(RectTransform rt) { }

}

