namespace Assets.Scripts.Unity.Map.Spawners;

public class RuleSplitter : Splitter
{
	public SplitterRule[] pathsRules; //Field offset: 0x38
	private RuleSplitterModel def; //Field offset: 0x40

	public virtual SplitterModel Def
	{
		 get { } //Length: 523
	}

	public RuleSplitter() { }

	public virtual SplitterModel get_Def() { }

}

