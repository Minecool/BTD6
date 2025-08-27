namespace Assets.Scripts.Models.CorvusSpells;

public abstract class CorvusSpellModel : TowerBasedShopItemModel
{
	internal enum CorvusSpellCategory
	{
		Passive = 0,
		Active = 1,
		Utility = 2,
		Invalid = 3,
	}

	public int initialManaCost; //Field offset: 0x50
	public PrefabReference placingPrefabReference; //Field offset: 0x58
	public CorvusSpellType spellType; //Field offset: 0x60
	public int unlocksAtLevel; //Field offset: 0x64
	public int corvusAnimationState; //Field offset: 0x68
	public int spiritAnimationState; //Field offset: 0x6C
	public EffectModel corvusEffectModel; //Field offset: 0x70
	public EffectModel spiritEffectModel; //Field offset: 0x78
	public SoundModel soundModel; //Field offset: 0x80
	public EffectModel effectDuringCorvusModel; //Field offset: 0x88
	public EffectModel effectDuringSpiritModel; //Field offset: 0x90

	public CorvusSpellCategory SpellCategory
	{
		 get { } //Length: 52
	}

	public CorvusSpellModel(string name, string locsKey, CorvusSpellType spellType, int unlocksAtLevel, SpriteReference icon, int initialManaCost, PrefabReference placingPrefabReference, int corvusAnimationState, int spiritAnimationState, EffectModel corvusEffectModel, EffectModel spiritEffectModel, SoundModel soundModel, EffectModel effectDuringCorvusModel, EffectModel effectDuringSpiritModel) { }

	public CorvusSpellCategory get_SpellCategory() { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

}

