namespace Assets.Scripts.Data.Legends;

public class LegendaryTilesXpShopMod : RogueXpShopMod
{
	public int legendaryTilesPerLevel; //Field offset: 0x10

	public LegendaryTilesXpShopMod() { }

	public virtual void ApplyMapStartEffect(int level, ILegendsDataProvider legendsDataProvider) { }

	public virtual string GetBuffText(int level) { }

}

