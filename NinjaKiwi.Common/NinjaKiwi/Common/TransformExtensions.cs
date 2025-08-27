namespace NinjaKiwi.Common;

[Extension]
public static class TransformExtensions
{

	[Extension]
	public static Bounds CalculateLocalBounds(Transform transform) { }

	[Extension]
	public static void DestroyAllChildren(Transform transform) { }

	[Extension]
	public static Transform FindActiveChildThatContainsName(Transform transform, string name, bool recursive = true) { }

	[Extension]
	public static Transform FindChildWithName(Transform transform, string name) { }

	[Extension]
	public static Canvas GetRootCanvas(Transform t) { }

}

