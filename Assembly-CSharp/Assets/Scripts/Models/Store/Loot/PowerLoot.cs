namespace Assets.Scripts.Models.Store.Loot;

public class PowerLoot : BaseQuantityLoot
{
	public string power; //Field offset: 0x30

	public PowerLoot(string power, int quantity) { }

	public PowerLoot(String[] param) { }

	public virtual void Apply(LootFrom from) { }

	public virtual void ApplySprite(Image img) { }

	public virtual void Convert(LootSet newLootSet) { }

	public virtual string GetTitle() { }

	public virtual void Serialize(StringBuilder sb) { }

	public virtual string ToString() { }

}

