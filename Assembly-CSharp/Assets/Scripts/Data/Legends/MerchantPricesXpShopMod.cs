namespace Assets.Scripts.Data.Legends;

public class MerchantPricesXpShopMod : RogueXpShopMod
{
	public float multiplierPerLevel; //Field offset: 0x10

	public MerchantPricesXpShopMod() { }

	public virtual void ApplyMapStartEffect(int level, ILegendsDataProvider legendsDataProvider) { }

	public virtual string GetBuffText(int level) { }

}

