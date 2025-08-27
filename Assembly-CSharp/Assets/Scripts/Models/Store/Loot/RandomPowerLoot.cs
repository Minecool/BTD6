namespace Assets.Scripts.Models.Store.Loot;

public class RandomPowerLoot : BaseQuantityLoot
{
	public RandomPowerType randomPowerType; //Field offset: 0x30

	public RandomPowerLoot(RandomPowerType randomPowerType, int quantity) { }

	public RandomPowerLoot(String[] param) { }

	public virtual void Apply(LootFrom from) { }

	public virtual void ApplySprite(Image img) { }

	public virtual void Convert(LootSet newLootSet) { }

	public List<PowerModel> GetAttackPowers() { }

	public List<PowerModel> GetBestPowers() { }

	public List<PowerModel> GetPowers(String[] validPowerNames) { }

	public virtual string GetTitle() { }

	public virtual void Serialize(StringBuilder sb) { }

	public virtual string ToString() { }

}

