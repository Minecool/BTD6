namespace Assets.Scripts.Models.Store.Loot;

public class SweepstakesTicketLoot : BaseQuantityLoot
{
	private string localizedTitle; //Field offset: 0x30

	public SweepstakesTicketLoot(int quantity) { }

	public SweepstakesTicketLoot(String[] param) { }

	public virtual void Apply(LootFrom from) { }

	public virtual void ApplySprite(Image img) { }

	public virtual void Convert(LootSet newLootSet) { }

	public virtual string GetTitle() { }

	public void SetLocalizedTitle(string title) { }

}

