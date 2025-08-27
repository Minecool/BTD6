namespace Assets.Scripts.Data.Legends;

public class MiniGameScoreRequirementXpShopMod : RogueXpShopMod
{
	public float reductionPerLevel; //Field offset: 0x10

	public MiniGameScoreRequirementXpShopMod() { }

	public virtual void ApplyMapStartEffect(int level, ILegendsDataProvider legendsDataProvider) { }

	public virtual string GetBuffText(int level) { }

}

