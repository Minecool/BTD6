namespace Assets.Scripts.Models.Store.Loot;

public class AchievementLoot : BaseLoot
{
	private readonly string achievementName; //Field offset: 0x20

	public AchievementLoot(string achievementName) { }

	[CompilerGenerated]
	private bool <Apply>b__2_0(ActiveAchievement a) { }

	public virtual void Apply(LootFrom from) { }

	public virtual void ApplySprite(Image img) { }

	public virtual void Convert(LootSet newLootSet) { }

	public virtual bool Display() { }

	public virtual int GetQuantity() { }

	public virtual string GetTitle() { }

	private bool HasSameName(ActiveAchievement achievement, string achievementName) { }

	public virtual void Serialize(StringBuilder sb) { }

}

