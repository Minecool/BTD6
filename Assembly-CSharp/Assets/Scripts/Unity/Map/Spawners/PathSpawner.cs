namespace Assets.Scripts.Unity.Map.Spawners;

public class PathSpawner : MonoBehaviour
{
	public Splitter forwardSplitter; //Field offset: 0x20
	public Splitter reverseSplitter; //Field offset: 0x28
	private PathSpawnerModel def; //Field offset: 0x30

	public PathSpawnerModel Def
	{
		 get { } //Length: 228
	}

	public PathSpawner() { }

	public PathSpawnerModel get_Def() { }

}

