namespace Assets.Scripts.Models.Map.Spawners;

public class MoabOnlySplitterModel : SplitterModel
{
	public Boolean[] moabOnlyPath; //Field offset: 0x40

	public MoabOnlySplitterModel(string name, String[] paths, Boolean[] moabOnlyPath, string overriddenBossPath) { }

	public virtual Model Clone() { }

	public virtual Splitter GetSplitter() { }

}

