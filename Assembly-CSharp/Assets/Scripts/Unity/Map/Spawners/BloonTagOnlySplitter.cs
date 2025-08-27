namespace Assets.Scripts.Unity.Map.Spawners;

public class BloonTagOnlySplitter : Splitter
{
	public String[] tagOnlyPath; //Field offset: 0x38
	private BloonTagOnlySplitterModel def; //Field offset: 0x40

	public virtual SplitterModel Def
	{
		 get { } //Length: 523
	}

	public BloonTagOnlySplitter() { }

	public virtual SplitterModel get_Def() { }

}

