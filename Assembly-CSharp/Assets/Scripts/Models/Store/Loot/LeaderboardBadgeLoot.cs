namespace Assets.Scripts.Models.Store.Loot;

public abstract class LeaderboardBadgeLoot : BaseQuantityLoot
{
	public LeaderboardBadgeType badgeType; //Field offset: 0x30

	public LeaderboardBadgeLoot(int quantity) { }

	public LeaderboardBadgeLoot(String[] param) { }

	public LeaderboardBadgeLoot() { }

	public virtual bool AlwaysDisplayQuantity() { }

	public virtual void Apply(LootFrom from) { }

	public virtual void ApplySprite(Image img) { }

	public virtual void Convert(LootSet newLootSet) { }

	public virtual int GetQuantity() { }

	public virtual string GetTitle() { }

	public virtual void Serialize(StringBuilder sb) { }

	public virtual string ToString() { }

}

