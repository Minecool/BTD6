namespace Assets.Scripts.SimulationTests;

public class RuntimeSceneScope : SceneLoaderScope
{
	private AsyncOperationHandle<SceneInstance> loadOperation; //Field offset: 0x10

	public virtual bool IsLoaded
	{
		 get { } //Length: 58
	}

	public virtual Scene Scene
	{
		 get { } //Length: 68
	}

	protected virtual void _Dispose() { }

	public RuntimeSceneScope(string sceneName) { }

	public virtual bool get_IsLoaded() { }

	public virtual Scene get_Scene() { }

}

