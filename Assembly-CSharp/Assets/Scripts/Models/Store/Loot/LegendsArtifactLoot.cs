namespace Assets.Scripts.Models.Store.Loot;

public class LegendsArtifactLoot : BaseLoot
{
	public string legendsName; //Field offset: 0x20
	public string artifactName; //Field offset: 0x28

	public LegendsArtifactLoot(string legendsName, string artifactName) { }

	public LegendsArtifactLoot(String[] param) { }

	public virtual void Apply(LootFrom from) { }

	public virtual void ApplySprite(Image img) { }

	public virtual void Convert(LootSet newLootSet) { }

	public virtual int GetQuantity() { }

	public virtual string GetTitle() { }

	public virtual void Serialize(StringBuilder sb) { }

}

