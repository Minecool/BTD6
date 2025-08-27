namespace Assets.Scripts.Models.Store.Loot;

public class TrophyStoreItemLoot : BaseLoot
{
	public string trophyStoreItemUID; //Field offset: 0x20

	public TrophyStoreItemLoot(string id) { }

	public TrophyStoreItemLoot(String[] param) { }

	public virtual void Apply(LootFrom from) { }

	public virtual void ApplySprite(Image img) { }

	public virtual void Convert(LootSet newLootSet) { }

	public virtual int GetQuantity() { }

	public virtual string GetTitle() { }

	public virtual void Serialize(StringBuilder sb) { }

}

