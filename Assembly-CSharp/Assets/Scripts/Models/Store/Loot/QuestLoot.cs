namespace Assets.Scripts.Models.Store.Loot;

public class QuestLoot : BaseLoot
{
	private readonly string questName; //Field offset: 0x20
	private readonly int questPartIndex; //Field offset: 0x28

	public QuestLoot(string questName, int questPartIndex) { }

	[CompilerGenerated]
	private bool <Apply>b__3_0(QuestDetails x) { }

	public virtual void Apply(LootFrom from) { }

	public virtual void ApplySprite(Image img) { }

	public virtual void Convert(LootSet newLootSet) { }

	public virtual bool Display() { }

	public virtual int GetQuantity() { }

	public virtual string GetTitle() { }

	public virtual void Serialize(StringBuilder sb) { }

}

