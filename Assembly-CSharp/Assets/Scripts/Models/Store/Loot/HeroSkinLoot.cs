namespace Assets.Scripts.Models.Store.Loot;

public class HeroSkinLoot : BaseLoot
{
	public string hero; //Field offset: 0x20
	public string skin; //Field offset: 0x28
	private readonly bool display; //Field offset: 0x30
	public bool showUnlockScreenImmediately; //Field offset: 0x31

	public HeroSkinLoot(string hero, string skin, bool showUnlockScreenImmediately) { }

	public HeroSkinLoot(string hero, string skin, bool display, bool showUnlockScreenImmediately) { }

	public HeroSkinLoot(String[] param) { }

	public virtual void Apply(LootFrom from) { }

	public virtual void ApplySprite(Image img) { }

	public virtual void Convert(LootSet newLootSet) { }

	public virtual bool Display() { }

	public virtual int GetQuantity() { }

	public virtual string GetTitle() { }

	private SpriteReference GetTowerSpriteReference() { }

	private void OpenUiAfterRewardsClose() { }

	public virtual void Serialize(StringBuilder sb) { }

	private void ShowTailingRewards() { }

	private void ShowUnlockScreenIfPossible(bool openImmediately) { }

}

