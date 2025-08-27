namespace Assets.Scripts.Models.Store.Loot;

public class TowerXPLoot : BaseQuantityLoot
{
	public string tower; //Field offset: 0x30

	public TowerXPLoot(int quantity, string tower) { }

	public TowerXPLoot(String[] param) { }

	public virtual bool AlwaysDisplayQuantity() { }

	public virtual void Apply(LootFrom from) { }

	public virtual void ApplySprite(Image img) { }

	public virtual void Convert(LootSet newLootSet) { }

	public virtual bool Display() { }

	public virtual string GetTitle() { }

	public virtual void Serialize(StringBuilder sb) { }

	public virtual string ToString() { }

}

