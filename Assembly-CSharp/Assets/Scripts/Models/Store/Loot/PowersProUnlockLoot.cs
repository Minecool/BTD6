namespace Assets.Scripts.Models.Store.Loot;

public class PowersProUnlockLoot : BaseLoot
{
	public string proPowerId; //Field offset: 0x20
	public bool isFullUnlock; //Field offset: 0x28

	public PowersProUnlockLoot(string proPowerId, bool isFullUnlock) { }

	public PowersProUnlockLoot(String[] param) { }

	public virtual void Apply(LootFrom from) { }

	public virtual void ApplySprite(Image img) { }

	public virtual void Convert(LootSet newLootSet) { }

	public virtual int GetQuantity() { }

	public virtual string GetTitle() { }

	public virtual void Serialize(StringBuilder sb) { }

	public virtual string ToString() { }

}

