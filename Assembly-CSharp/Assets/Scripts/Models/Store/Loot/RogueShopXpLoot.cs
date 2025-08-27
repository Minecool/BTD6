namespace Assets.Scripts.Models.Store.Loot;

public class RogueShopXpLoot : BaseLoot
{
	public int amount; //Field offset: 0x20

	public RogueShopXpLoot(int amount) { }

	public RogueShopXpLoot(String[] param) { }

	public virtual void Apply(LootFrom from) { }

	public virtual void ApplySprite(Image img) { }

	public virtual void Convert(LootSet newLootSet) { }

	public virtual string GetMinDescription() { }

	public virtual int GetQuantity() { }

	public virtual string GetTitle() { }

	public virtual void Serialize(StringBuilder sb) { }

}

