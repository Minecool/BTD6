namespace Assets.Scripts.Models.Map.Spawners;

public class PathSpawnerModel : Model
{
	public SplitterModel forwardSplitter; //Field offset: 0x30
	public SplitterModel reverseSplitter; //Field offset: 0x38

	public PathSpawnerModel(string name, SplitterModel forwardSplitter, SplitterModel reverseSplitter) { }

	public virtual Model Clone() { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

}

