namespace Assets.Scripts.Models.Map.Spawners;

public class AlternateRoundSplitterModel : SplitterModel
{
	public bool doesNotLoop; //Field offset: 0x40
	public int roundsPerPath; //Field offset: 0x44
	public int currentRoundOffset; //Field offset: 0x48

	public AlternateRoundSplitterModel(string name, String[] paths, bool doesNotLoop, int roundsPerPath, int currentRoundOffset, string overriddenBossPath) { }

	public virtual Model Clone() { }

	public virtual Splitter GetSplitter() { }

}

