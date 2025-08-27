namespace Assets.Scripts.Models.Store.Loot;

public class FullTowerAndParagonUnlockLoot : BaseLoot
{
	public string tower; //Field offset: 0x20

	public FullTowerAndParagonUnlockLoot(string tower) { }

	public FullTowerAndParagonUnlockLoot(String[] param) { }

	public virtual void Apply(LootFrom from) { }

	public virtual void ApplySprite(Image img) { }

	public virtual void Convert(LootSet newLootSet) { }

	public virtual bool Display() { }

	public virtual int GetQuantity() { }

	public virtual string GetTitle() { }

	public virtual void Serialize(StringBuilder sb) { }

	public virtual string ToString() { }

}

