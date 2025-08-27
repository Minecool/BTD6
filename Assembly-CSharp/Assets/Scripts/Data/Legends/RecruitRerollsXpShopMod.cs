namespace Assets.Scripts.Data.Legends;

public class RecruitRerollsXpShopMod : RogueXpShopMod
{
	public int rerollsPerLevel; //Field offset: 0x10

	public RecruitRerollsXpShopMod() { }

	public virtual void ApplyMapStartEffect(int level, ILegendsDataProvider legendsDataProvider) { }

	public virtual string GetBuffText(int level) { }

}

