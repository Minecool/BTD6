namespace Assets.Scripts.Data.Legends;

public class RogueHeroStarterKit
{
	public string heroID; //Field offset: 0x10
	public ArtifactDataBase artifactData; //Field offset: 0x18
	public List<RogueInstaMonkey> startingInstas; //Field offset: 0x20

	public RogueHeroStarterKit() { }

}

