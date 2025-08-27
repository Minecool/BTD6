namespace Assets.Scripts.Models;

[Implementation(typeof(TowerBasedShopItem), False, False, new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {}])]
public class TowerBasedShopItemModel : TowerBehaviorModel
{
	public string locsId; //Field offset: 0x30
	public Int32[] iconSwapLevels; //Field offset: 0x38
	public SpriteReference defaultIcon; //Field offset: 0x40
	public SpriteReference[] defaultIconSwaps; //Field offset: 0x48

	public TowerBasedShopItemModel(string name, string locsId, SpriteReference defaultIcon, SpriteReference[] defaultIconSwaps, Int32[] iconSwapLevels) { }

	public void ApplyAudioSwap(SkinData data, CreateSoundOnGeraldoItemModel geraldoItemSoundModel) { }

	public virtual Model Clone() { }

	public ProjectileModel GetClonedCosmeticProjectileMode(ProjectileModel originalProjectileModel, string towerBaseId, int owner) { }

	protected TowerModel GetClonedCosmeticTowerModel(TowerModel originalTowerModel, string towerBaseId, int owner) { }

	public string GetDescription(ILocProvider locProvider, int level) { }

	public PrefabReference GetEffectCosmetic(PrefabReference original, string towerBaseId, int owner) { }

	public SpriteReference GetIcon(string towerBaseId, int currentLevel, int inputId, bool useCosmetics) { }

	private SpriteReference GetIcon(int currentLevel, SpriteReference icon, SpriteReference[] iconSwaps, Int32[] iconSwapLevels) { }

	public string GetTitle(ILocProvider locProvider) { }

	protected Tower GetTower(string baseId, Simulation sim, int owner) { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

	private void LoadSpritesForPierceModel(GameObject spriteObject, SetSpriteFromPierceModel setSpriteFromPierce) { }

	private bool TryGetNonDefaultTowerCosmetics(string towerBaseId, int owner, out SkinData cosmetics) { }

}

