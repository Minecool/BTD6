namespace Assets.Scripts.Data.Legends;

public class UpgradeIncreaseXpShopMod : RogueXpShopMod
{
	public float upgradeCostMultiplier; //Field offset: 0x10

	public UpgradeIncreaseXpShopMod() { }

	public virtual void ApplyMapStartEffect(int level, ILegendsDataProvider legendsDataProvider) { }

	public virtual string GetBuffText(int level) { }

}

