namespace Assets.Scripts.Models.Map.Spawners;

public class BloonTagOnlySplitterModel : SplitterModel
{
	public String[] tagOnlyPath; //Field offset: 0x40

	public BloonTagOnlySplitterModel(string name, String[] paths, String[] tagOnlyPath, string overriddenBossPath) { }

	public virtual Model Clone() { }

	public virtual Splitter GetSplitter() { }

}

