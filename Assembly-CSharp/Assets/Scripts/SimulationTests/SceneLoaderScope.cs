namespace Assets.Scripts.SimulationTests;

public abstract class SceneLoaderScope : IDisposable
{

	public abstract bool IsLoaded
	{
		 get { } //Length: 0
	}

	public abstract Scene Scene
	{
		 get { } //Length: 0
	}

	protected abstract void _Dispose() { }

	protected SceneLoaderScope() { }

	public override void Dispose() { }

	public abstract bool get_IsLoaded() { }

	public abstract Scene get_Scene() { }

}

