namespace NinjaKiwi.Common;

public static class MonoBehaviourSingletonUtility
{
	public static bool applicationIsQuitting; //Field offset: 0x0

	[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType::BeforeSceneLoad (1))]
	private static void OnApplicationStart() { }

}

