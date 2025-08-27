namespace Assets.Scripts.Models.Store.Loot;

public class BossBadgeLoot : BaseQuantityLoot
{
	public BossType bossType; //Field offset: 0x30
	public bool isElite; //Field offset: 0x34
	public string bossLocs; //Field offset: 0x38

	public BossBadgeLoot(BossType bossType, int quantity, bool isElite, string bossLocs) { }

	public BossBadgeLoot(String[] param) { }

	public virtual bool AlwaysDisplayQuantity() { }

	public virtual void Apply(LootFrom from) { }

	public virtual void ApplySprite(Image img) { }

	public virtual void Convert(LootSet newLootSet) { }

	public virtual string GetTitle() { }

	public virtual void Serialize(StringBuilder sb) { }

}

