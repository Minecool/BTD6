namespace Assets.Scripts.Models.Store.Loot;

public class InstaMonkeyLoot : BaseQuantityLoot
{
	public string baseTower; //Field offset: 0x30
	public Int32[] tiers; //Field offset: 0x38

	public InstaMonkeyLoot(string baseTower, Int32[] tiers, int quantity) { }

	public InstaMonkeyLoot(String[] param) { }

	public virtual void Apply(LootFrom from) { }

	public virtual void ApplySprite(Image img) { }

	public virtual void Convert(LootSet newLootSet) { }

	public int GetMainTier() { }

	public virtual string GetMinDescription() { }

	public virtual string GetTitle() { }

	private int ParseCharToInt(char c) { }

	public virtual void Serialize(StringBuilder sb) { }

	public bool TiersEqual(Int32[] compTiers) { }

	public virtual string ToString() { }

}

