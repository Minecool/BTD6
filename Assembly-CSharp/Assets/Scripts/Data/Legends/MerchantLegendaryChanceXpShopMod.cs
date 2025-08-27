namespace Assets.Scripts.Data.Legends;

public class MerchantLegendaryChanceXpShopMod : RogueXpShopMod
{
	public float chanceIncreasePerLevel; //Field offset: 0x10

	public MerchantLegendaryChanceXpShopMod() { }

	public virtual void ApplyMapStartEffect(int level, ILegendsDataProvider legendsDataProvider) { }

	public virtual string GetBuffText(int level) { }

}

