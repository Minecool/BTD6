namespace Assets.Scripts.Models.Store.Loot;

public class LegendsFeatLoot : BaseLoot
{
	public string legendsName; //Field offset: 0x20
	public string featName; //Field offset: 0x28

	public LegendsFeatLoot(string legendsName, string featName) { }

	public LegendsFeatLoot(String[] param) { }

	public virtual void Apply(LootFrom from) { }

	public virtual void ApplySprite(Image img) { }

	public virtual void Convert(LootSet newLootSet) { }

	public virtual string GetMinDescription() { }

	public virtual int GetQuantity() { }

	public virtual string GetTitle() { }

	private SpriteReference GetTowerSpriteReference() { }

	public virtual void Serialize(StringBuilder sb) { }

}

