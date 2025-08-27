namespace Assets.Scripts.Models.Store.Loot;

public class RogueXpShopItemLoot : BaseLoot
{
	public string xpShopItemName; //Field offset: 0x20
	public int level; //Field offset: 0x28

	public RogueXpShopItemLoot(string xpShopItemName, int level) { }

	public RogueXpShopItemLoot(String[] param) { }

	[CompilerGenerated]
	private bool <Apply>b__9_0(RogueXpShopItem x) { }

	[CompilerGenerated]
	private bool <ApplySprite>b__10_0(RogueXpShopItem x) { }

	[CompilerGenerated]
	private bool <GetTitle>b__6_0(RogueXpShopItem x) { }

	public virtual void Apply(LootFrom from) { }

	public virtual void ApplySprite(Image img) { }

	public virtual void Convert(LootSet newLootSet) { }

	public virtual string GetMinDescription() { }

	public virtual int GetQuantity() { }

	public virtual string GetTitle() { }

	public virtual void Serialize(StringBuilder sb) { }

}

