namespace Assets.Scripts.Models.Store.Loot;

public class LegendsUnlockLoot : BaseLoot
{
	public LegendsType legendsType; //Field offset: 0x20
	public bool canUnlock; //Field offset: 0x24

	public LegendsUnlockLoot(LegendsType legendsType, bool canUnlock) { }

	public LegendsUnlockLoot(String[] param) { }

	public virtual void Apply(LootFrom from) { }

	public virtual void ApplySprite(Image img) { }

	public virtual void Convert(LootSet newLootSet) { }

	public virtual int GetQuantity() { }

	public virtual string GetTitle() { }

	private SpriteReference GetTowerSpriteReference() { }

	public virtual void Serialize(StringBuilder sb) { }

}

