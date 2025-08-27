namespace Assets.Scripts.Models.Store.Loot;

public abstract class BaseLoot
{
	protected static string serializeSeparator; //Field offset: 0x0
	public string transactionID; //Field offset: 0x10
	public bool isLimitedTimeItem; //Field offset: 0x18

	public bool IsLeaderboardBadge
	{
		 get { } //Length: 97
	}

	private static BaseLoot() { }

	public BaseLoot() { }

	public BaseLoot(String[] param) { }

	public override bool AlwaysDisplayQuantity() { }

	public abstract void Apply(LootFrom from) { }

	public abstract void ApplySprite(Image img) { }

	public abstract void Convert(LootSet newLootSet) { }

	public override bool Display() { }

	public bool get_IsLeaderboardBadge() { }

	public override Nullable<Int32> GetBonusQuantity() { }

	public override string GetMinDescription() { }

	public abstract int GetQuantity() { }

	public override int GetSortOrder() { }

	public abstract string GetTitle() { }

	public abstract void Serialize(StringBuilder sb) { }

}

