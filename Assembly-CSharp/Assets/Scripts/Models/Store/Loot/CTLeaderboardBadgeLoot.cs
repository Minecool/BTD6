namespace Assets.Scripts.Models.Store.Loot;

public class CTLeaderboardBadgeLoot : LeaderboardBadgeLoot
{
	public bool isGlobal; //Field offset: 0x38
	public bool isTeam; //Field offset: 0x39

	public CTLeaderboardBadgeLoot(LeaderboardBadgeType badgeType, int quantity, bool isGlobal, bool isTeam) { }

	public CTLeaderboardBadgeLoot(String[] param) { }

	public virtual void Apply(LootFrom from) { }

	public virtual void ApplySprite(Image img) { }

	private void ConfirmValidity() { }

	public virtual void Convert(LootSet newLootSet) { }

}

