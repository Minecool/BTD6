namespace Assets.Scripts.Models.Store.Loot;

public class MapUnlockLoot : BaseLoot
{
	private string keyType; //Field offset: 0x20

	public MapUnlockLoot(string keyType) { }

	public virtual void Apply(LootFrom from) { }

	public virtual void ApplySprite(Image img) { }

	public virtual void Convert(LootSet newLootSet) { }

	public virtual bool Display() { }

	public virtual int GetQuantity() { }

	public virtual string GetTitle() { }

	public virtual void Serialize(StringBuilder sb) { }

}

