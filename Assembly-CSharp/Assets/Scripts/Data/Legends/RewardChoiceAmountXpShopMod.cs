namespace Assets.Scripts.Data.Legends;

public class RewardChoiceAmountXpShopMod : RogueXpShopMod
{
	public int rewardPerLevel; //Field offset: 0x10

	public RewardChoiceAmountXpShopMod() { }

	public virtual void ApplyMapStartEffect(int level, ILegendsDataProvider legendsDataProvider) { }

	public virtual string GetBuffText(int level) { }

}

