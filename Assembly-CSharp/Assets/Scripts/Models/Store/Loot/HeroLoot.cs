namespace Assets.Scripts.Models.Store.Loot;

public class HeroLoot : BaseLoot
{
	public string hero; //Field offset: 0x20
	private readonly bool display; //Field offset: 0x28

	public HeroLoot(string hero) { }

	public HeroLoot(string hero, bool display) { }

	public HeroLoot(String[] param) { }

	public virtual void Apply(LootFrom from) { }

	public virtual void ApplySprite(Image img) { }

	public virtual void Convert(LootSet newLootSet) { }

	public static ValueTuple<String, Boolean> Deserialize(String[] param) { }

	public virtual bool Display() { }

	public virtual int GetQuantity() { }

	public virtual string GetTitle() { }

	private SpriteReference GetTowerSpriteReference() { }

	public virtual void Serialize(StringBuilder sb) { }

}

