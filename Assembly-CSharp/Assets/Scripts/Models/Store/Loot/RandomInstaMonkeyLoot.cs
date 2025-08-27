namespace Assets.Scripts.Models.Store.Loot;

public class RandomInstaMonkeyLoot : BaseQuantityLoot
{
	public int tier; //Field offset: 0x30
	public string fixedBaseTower; //Field offset: 0x38
	public TowerSet fixedTowerSetType; //Field offset: 0x40

	public RandomInstaMonkeyLoot(int quantity, int tier, string fixedBaseTower, TowerSet fixedTowerSetType) { }

	public RandomInstaMonkeyLoot(String[] param) { }

	public virtual bool AlwaysDisplayQuantity() { }

	public virtual void Apply(LootFrom from) { }

	public virtual void ApplySprite(Image img) { }

	public virtual void Convert(LootSet newLootSet) { }

	public virtual string GetTitle() { }

	public virtual void Serialize(StringBuilder sb) { }

	public virtual string ToString() { }

}

