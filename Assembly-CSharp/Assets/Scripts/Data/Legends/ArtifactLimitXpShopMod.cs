namespace Assets.Scripts.Data.Legends;

public class ArtifactLimitXpShopMod : RogueXpShopMod
{
	public int artifactLimit; //Field offset: 0x10

	public ArtifactLimitXpShopMod() { }

	public virtual void ApplyMapStartEffect(int level, ILegendsDataProvider legendsDataProvider) { }

	public virtual string GetBuffText(int level) { }

}

