namespace Assets.Scripts.Models.Store.Loot;

public class RaceBadgeLoot : LeaderboardBadgeLoot
{

	public RaceBadgeLoot(LeaderboardBadgeType badgeType, int quantity) { }

	public RaceBadgeLoot(String[] param) { }

	public virtual void Apply(LootFrom from) { }

	public virtual void ApplySprite(Image img) { }

	public virtual void Convert(LootSet newLootSet) { }

}

