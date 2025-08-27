namespace NinjaKiwi.Common;

[Extension]
public static class GameObjectExtensions
{
	internal sealed class GameObjectCallback : MulticastDelegate
	{

		public GameObjectCallback(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(GameObject obj, AsyncCallback callback, object object) { }

		public override void EndInvoke(IAsyncResult result) { }

		public override void Invoke(GameObject obj) { }

	}


	[Extension]
	public static void ForEachChildInLayer(GameObject obj, int layer, GameObjectCallback callback) { }

	[Extension]
	public static Bounds GetBounds(GameObject obj) { }

	[Extension]
	public static T GetComponentOrAdd(GameObject gameObject) { }

	[Extension]
	public static Component GetComponentOrAdd(GameObject gameObject, Type type) { }

	[Extension]
	public static bool IsUnityObjectDestroyed(object obj) { }

	[Extension]
	public static string SceneName(Transform t) { }

	[Extension]
	public static string ScenePath(Transform t) { }

	[Extension]
	public static void SetActiveIfNotAlready(GameObject obj, bool active) { }

	[Extension]
	public static void SetLayerRecursively(GameObject obj, int layer) { }

}

