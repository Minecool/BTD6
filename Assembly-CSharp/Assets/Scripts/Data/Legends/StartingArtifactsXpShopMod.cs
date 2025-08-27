namespace Assets.Scripts.Data.Legends;

public class StartingArtifactsXpShopMod : RogueXpShopMod
{
	public int artifactPowerPerLevel; //Field offset: 0x10

	public StartingArtifactsXpShopMod() { }

	public virtual int GetAdditionalStartingArtifactPower(int level) { }

	public virtual string GetBuffText(int level) { }

}

