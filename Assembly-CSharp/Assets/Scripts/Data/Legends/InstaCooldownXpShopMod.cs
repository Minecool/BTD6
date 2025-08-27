namespace Assets.Scripts.Data.Legends;

public class InstaCooldownXpShopMod : RogueXpShopMod
{
	public int cooldownPerLevel; //Field offset: 0x10

	public InstaCooldownXpShopMod() { }

	public virtual void ApplyMapStartEffect(int level, ILegendsDataProvider legendsDataProvider) { }

	public virtual string GetBuffText(int level) { }

}

