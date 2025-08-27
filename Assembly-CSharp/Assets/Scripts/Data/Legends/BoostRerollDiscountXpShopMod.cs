namespace Assets.Scripts.Data.Legends;

public class BoostRerollDiscountXpShopMod : RogueXpShopMod
{
	public float discountPerLevel; //Field offset: 0x10

	public BoostRerollDiscountXpShopMod() { }

	public virtual void ApplyMapStartEffect(int level, ILegendsDataProvider legendsDataProvider) { }

	public virtual string GetBuffText(int level) { }

}

