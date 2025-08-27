namespace UnityEngine.UI;

public class MaskUtilities
{

	public MaskUtilities() { }

	public static Transform FindRootSortOverrideCanvas(Transform start) { }

	public static RectMask2D GetRectMaskForClippable(IClippable clippable) { }

	public static void GetRectMasksForClip(RectMask2D clipper, List<RectMask2D> masks) { }

	public static int GetStencilDepth(Transform transform, Transform stopAfter) { }

	public static bool IsDescendantOrSelf(Transform father, Transform child) { }

	public static void Notify2DMaskStateChanged(Component mask) { }

	public static void NotifyStencilStateChanged(Component mask) { }

}

