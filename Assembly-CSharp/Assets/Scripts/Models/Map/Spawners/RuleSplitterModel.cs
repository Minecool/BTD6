namespace Assets.Scripts.Models.Map.Spawners;

public class RuleSplitterModel : SplitterModel
{
	public SplitterRule[] splitterRules; //Field offset: 0x40

	public RuleSplitterModel(string name, String[] paths, SplitterRule[] splitterRules, string overriddenBossPath) { }

	public virtual Model Clone() { }

	public virtual Splitter GetSplitter() { }

}

