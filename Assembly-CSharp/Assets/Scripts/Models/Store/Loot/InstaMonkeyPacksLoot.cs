namespace Assets.Scripts.Models.Store.Loot;

public class InstaMonkeyPacksLoot : BaseQuantityLoot
{

	public InstaMonkeyPacksLoot(int quantity) { }

	public InstaMonkeyPacksLoot(String[] param) { }

	public virtual void Apply(LootFrom from) { }

	public virtual void ApplySprite(Image img) { }

	public virtual void Convert(LootSet newLootSet) { }

	public virtual string GetTitle() { }

}

