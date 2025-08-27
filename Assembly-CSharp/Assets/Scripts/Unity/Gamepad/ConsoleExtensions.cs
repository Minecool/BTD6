namespace Assets.Scripts.Unity.Gamepad;

[Extension]
public static class ConsoleExtensions
{

	[Extension]
	public static void AutoNav(Selectable sel) { }

	[Extension]
	public static void DisableNav(Selectable sel) { }

	[Extension]
	public static void DisableNav(GameObject obj) { }

	[Extension]
	public static void DisableNestedNav(GameObject obj) { }

	[Extension]
	public static void DisableRaycast(GameObject obj) { }

	public static void EnableNonDrawingGraphicNav(GameObject gameObject) { }

	[Extension]
	public static string GetFullPath(GameObject obj) { }

}

