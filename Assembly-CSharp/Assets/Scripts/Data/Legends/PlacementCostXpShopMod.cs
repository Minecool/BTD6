namespace Assets.Scripts.Data.Legends;

public class PlacementCostXpShopMod : RogueXpShopMod
{
	public int placementCooldownPerLevel; //Field offset: 0x10

	public PlacementCostXpShopMod() { }

	public virtual void ApplyMapStartEffect(int level, ILegendsDataProvider legendsDataProvider) { }

}

