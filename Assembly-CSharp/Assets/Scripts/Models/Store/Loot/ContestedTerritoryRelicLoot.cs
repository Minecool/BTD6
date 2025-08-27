namespace Assets.Scripts.Models.Store.Loot;

public class ContestedTerritoryRelicLoot : BaseQuantityLoot
{
	public string relicType; //Field offset: 0x30

	public ContestedTerritoryRelicLoot(string relicType) { }

	public ContestedTerritoryRelicLoot(String[] param) { }

	public virtual void Apply(LootFrom from) { }

	public virtual void ApplySprite(Image img) { }

	public virtual void Convert(LootSet newLootSet) { }

	public virtual string GetMinDescription() { }

	public virtual string GetTitle() { }

}

