namespace Assets.Scripts.Models.Map.Spawners;

public class AlternateRoundMultiPathSplitterModel : SplitterModel
{
	public Int32[] groupPaths; //Field offset: 0x40

	public AlternateRoundMultiPathSplitterModel(string name, String[] paths, Int32[] groupPaths, string overriddenBossPath) { }

	public virtual Model Clone() { }

	public virtual Splitter GetSplitter() { }

}

