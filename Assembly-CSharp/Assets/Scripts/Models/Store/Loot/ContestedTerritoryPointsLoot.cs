namespace Assets.Scripts.Models.Store.Loot;

public class ContestedTerritoryPointsLoot : BaseQuantityLoot
{

	public ContestedTerritoryPointsLoot(int quantity) { }

	public ContestedTerritoryPointsLoot(String[] param) { }

	public virtual void Apply(LootFrom from) { }

	public virtual void ApplySprite(Image img) { }

	public virtual void Convert(LootSet newLootSet) { }

	public virtual string GetMinDescription() { }

	public virtual string GetTitle() { }

}

