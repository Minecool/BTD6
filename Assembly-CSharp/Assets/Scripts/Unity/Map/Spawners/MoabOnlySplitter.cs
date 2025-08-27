namespace Assets.Scripts.Unity.Map.Spawners;

public class MoabOnlySplitter : Splitter
{
	public Boolean[] moabOnlyPath; //Field offset: 0x38
	private MoabOnlySplitterModel def; //Field offset: 0x40

	public virtual SplitterModel Def
	{
		 get { } //Length: 523
	}

	public MoabOnlySplitter() { }

	public virtual SplitterModel get_Def() { }

}

