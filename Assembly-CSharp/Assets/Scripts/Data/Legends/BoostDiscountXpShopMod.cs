namespace Assets.Scripts.Data.Legends;

public class BoostDiscountXpShopMod : RogueXpShopMod
{
	public float boostDiscountPerLevel; //Field offset: 0x10

	public BoostDiscountXpShopMod() { }

	public virtual void ApplyMapStartEffect(int level, ILegendsDataProvider legendsDataProvider) { }

	public virtual string GetBuffText(int level) { }

}

