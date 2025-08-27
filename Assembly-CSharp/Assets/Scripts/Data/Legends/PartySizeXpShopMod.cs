namespace Assets.Scripts.Data.Legends;

public class PartySizeXpShopMod : RogueXpShopMod
{
	public int partySizePerLevel; //Field offset: 0x10

	public PartySizeXpShopMod() { }

	public virtual void ApplyMapStartEffect(int level, ILegendsDataProvider legendsDataProvider) { }

	public virtual string GetBuffText(int level) { }

}

