namespace Assets.Scripts.Unity.Map.Spawners;

public class AlternateRoundSplitter : Splitter
{
	public bool doesNotLoop; //Field offset: 0x38
	public int roundsPerPath; //Field offset: 0x3C
	public int currentRoundOffset; //Field offset: 0x40
	private AlternateRoundSplitterModel def; //Field offset: 0x48

	public virtual SplitterModel Def
	{
		 get { } //Length: 562
	}

	public AlternateRoundSplitter() { }

	public virtual SplitterModel get_Def() { }

}

