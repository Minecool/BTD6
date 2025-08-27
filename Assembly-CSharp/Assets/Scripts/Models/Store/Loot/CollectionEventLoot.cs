namespace Assets.Scripts.Models.Store.Loot;

public class CollectionEventLoot : BaseQuantityLoot
{

	public CollectionEventLoot(int quantity) { }

	public CollectionEventLoot(String[] param) { }

	public virtual bool AlwaysDisplayQuantity() { }

	public virtual void Apply(LootFrom from) { }

	public virtual void ApplySprite(Image img) { }

	public virtual void Convert(LootSet newLootSet) { }

	public virtual string GetMinDescription() { }

	public virtual string GetTitle() { }

}

