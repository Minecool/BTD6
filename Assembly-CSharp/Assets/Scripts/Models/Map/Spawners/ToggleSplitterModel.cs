namespace Assets.Scripts.Models.Map.Spawners;

public class ToggleSplitterModel : SplitterModel
{

	public ToggleSplitterModel(string name, String[] paths, string overriddenBossPath) { }

	public virtual Model Clone() { }

	public virtual Splitter GetSplitter() { }

}

