namespace Assets.Scripts.Data.Legends;

public class MerchantRareChanceXpShopMod : RogueXpShopMod
{
	public float chanceIncreasePerLevel; //Field offset: 0x10

	public MerchantRareChanceXpShopMod() { }

	public virtual void ApplyMapStartEffect(int level, ILegendsDataProvider legendsDataProvider) { }

	public virtual string GetBuffText(int level) { }

}

