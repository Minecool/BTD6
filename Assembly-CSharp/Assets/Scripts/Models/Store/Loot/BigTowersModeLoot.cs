namespace Assets.Scripts.Models.Store.Loot;

public class BigTowersModeLoot : BaseLoot
{

	public BigTowersModeLoot() { }

	public BigTowersModeLoot(String[] param) { }

	public virtual void Apply(LootFrom from) { }

	public virtual void ApplySprite(Image img) { }

	public virtual void Convert(LootSet newLootSet) { }

	public virtual int GetQuantity() { }

	public virtual string GetTitle() { }

	public virtual void Serialize(StringBuilder sb) { }

}

