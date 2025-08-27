namespace Assets.Scripts.Models.Store.Loot;

public class BossLeaderboardBadgeLoot : LeaderboardBadgeLoot
{
	public bool isElite; //Field offset: 0x38

	public BossLeaderboardBadgeLoot(LeaderboardBadgeType badgeType, int quantity, bool isElite) { }

	public BossLeaderboardBadgeLoot(String[] param) { }

	public virtual void Apply(LootFrom from) { }

	public virtual void ApplySprite(Image img) { }

	public virtual void Convert(LootSet newLootSet) { }

}

