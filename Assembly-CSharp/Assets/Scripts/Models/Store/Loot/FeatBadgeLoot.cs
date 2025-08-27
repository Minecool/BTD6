namespace Assets.Scripts.Models.Store.Loot;

public class FeatBadgeLoot : BaseQuantityLoot
{

	public FeatBadgeLoot(int quantity) { }

	public FeatBadgeLoot(String[] param) { }

	public virtual void Apply(LootFrom from) { }

	public virtual void ApplySprite(Image img) { }

	public virtual void Convert(LootSet newLootSet) { }

	public virtual string GetTitle() { }

}

