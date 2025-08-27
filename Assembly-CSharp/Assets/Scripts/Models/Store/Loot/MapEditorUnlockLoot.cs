namespace Assets.Scripts.Models.Store.Loot;

public class MapEditorUnlockLoot : BaseLoot
{

	public MapEditorUnlockLoot() { }

	public MapEditorUnlockLoot(String[] param) { }

	public virtual void Apply(LootFrom from) { }

	public virtual void ApplySprite(Image img) { }

	public virtual void Convert(LootSet newLootSet) { }

	public virtual int GetQuantity() { }

	public virtual string GetTitle() { }

	private void Popup() { }

	public virtual void Serialize(StringBuilder sb) { }

}

