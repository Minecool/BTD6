namespace Assets.Scripts.Unity.Map.Spawners;

public class AlternateRoundMultiPathSplitter : Splitter
{
	[Tooltip("Each number represents how many paths in the list above are grouped together per round")]
	public Int32[] groupPaths; //Field offset: 0x38
	private AlternateRoundMultiPathSplitterModel def; //Field offset: 0x40

	public virtual SplitterModel Def
	{
		 get { } //Length: 523
	}

	public AlternateRoundMultiPathSplitter() { }

	public virtual SplitterModel get_Def() { }

}

