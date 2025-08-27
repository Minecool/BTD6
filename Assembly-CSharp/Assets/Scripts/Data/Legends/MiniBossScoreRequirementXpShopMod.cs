namespace Assets.Scripts.Data.Legends;

public class MiniBossScoreRequirementXpShopMod : RogueXpShopMod
{
	public float reductionPerLevel; //Field offset: 0x10

	public MiniBossScoreRequirementXpShopMod() { }

	public virtual void ApplyMapStartEffect(int level, ILegendsDataProvider legendsDataProvider) { }

	public virtual string GetBuffText(int level) { }

}

