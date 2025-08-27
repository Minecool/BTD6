namespace Assets.Scripts.Models.CorvusSpells;

public abstract class CorvusContinuousSpellModel : CorvusSpellModel
{
	public int ongoingManaCost; //Field offset: 0x98
	public float manaDrainInterval; //Field offset: 0x9C

	public CorvusContinuousSpellModel(string name, string locsKey, CorvusSpellType spellType, int unlocksAtLevel, SpriteReference icon, int initialManaCost, PrefabReference placingPrefabReference, int corvusAnimationState, int spiritAnimationState, EffectModel corvusEffectModel, EffectModel spiritEffectModel, SoundModel soundModel, int ongoingManaCost, float manaDrainInterval, EffectModel effectDuringCorvusModel, EffectModel effectDuringSpiritModel) { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

}

