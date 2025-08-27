namespace Assets.Scripts.Data.Legends;

public class FinalBossHpXpShopMod : RogueXpShopMod
{
	public float bossHpReductionPerLevel; //Field offset: 0x10

	public FinalBossHpXpShopMod() { }

	public virtual void ApplyMapStartEffect(int level, ILegendsDataProvider legendsDataProvider) { }

	public virtual string GetBuffText(int level) { }

}

