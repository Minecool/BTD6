namespace Assets.Scripts.Models.Store.Loot;

public class InstaRankLoot : BaseLoot
{
	public int rank; //Field offset: 0x20

	public InstaRankLoot(int rank) { }

	public InstaRankLoot(String[] param) { }

	public virtual void Apply(LootFrom from) { }

	public virtual void ApplySprite(Image img) { }

	public virtual void Convert(LootSet newLootSet) { }

	public virtual string GetMinDescription() { }

	public virtual int GetQuantity() { }

	public virtual string GetTitle() { }

	private bool IsPlayerAboveCurrentRank() { }

	public virtual void Serialize(StringBuilder sb) { }

}

