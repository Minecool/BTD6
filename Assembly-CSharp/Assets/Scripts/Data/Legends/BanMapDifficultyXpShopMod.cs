namespace Assets.Scripts.Data.Legends;

public class BanMapDifficultyXpShopMod : RogueXpShopMod
{
	public List<String> bannedDifficulties; //Field offset: 0x10

	public BanMapDifficultyXpShopMod() { }

	public virtual void ApplyMapStartEffect(int level, ILegendsDataProvider legendsDataProvider) { }

}

