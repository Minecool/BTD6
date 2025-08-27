namespace Assets.Scripts.Models.Store.Loot;

public class TowerUnlockLoot : BaseLoot
{
	public string baseTowerId; //Field offset: 0x20
	public bool showUnlockScreen; //Field offset: 0x28
	public bool showUnlockScreenImmediately; //Field offset: 0x29

	public TowerUnlockLoot(string baseTowerId, bool showUnlockScreen, bool showUnlockScreenImmediately) { }

	public TowerUnlockLoot(String[] param) { }

	public virtual void Apply(LootFrom from) { }

	public virtual void ApplySprite(Image img) { }

	public virtual void Convert(LootSet newLootSet) { }

	public virtual bool Display() { }

	public virtual string GetMinDescription() { }

	public virtual int GetQuantity() { }

	public virtual string GetTitle() { }

	private SpriteReference GetTowerSpriteReference() { }

	private string GetUnlockUISceneName() { }

	private void OpenUiAfterRewardsClose() { }

	public virtual void Serialize(StringBuilder sb) { }

	private void ShowUnlockScreenIfPossible(bool openImmediately) { }

}

