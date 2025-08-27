namespace Assets.Scripts;

public class RuntimeInitializeOnLoad
{

	public RuntimeInitializeOnLoad() { }

	[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType::BeforeSceneLoad (1))]
	private static void OnBeforeSceneLoadRuntimeMethod() { }

}

