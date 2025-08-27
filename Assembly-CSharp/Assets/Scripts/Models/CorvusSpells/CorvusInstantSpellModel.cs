namespace Assets.Scripts.Models.CorvusSpells;

public abstract class CorvusInstantSpellModel : CorvusSpellModel
{
	public float duration; //Field offset: 0x98
	public float cooldown; //Field offset: 0x9C

	public CorvusInstantSpellModel(string name, string locsKey, CorvusSpellType spellType, int unlocksAtLevel, SpriteReference icon, int initialManaCost, PrefabReference placingPrefabReference, int corvusAnimationState, int spiritAnimationState, EffectModel corvusEffectModel, EffectModel spiritEffectModel, SoundModel soundModel, EffectModel effectDuringCorvusModel, EffectModel effectDuringSpiritModel, float duration, float cooldown) { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

}

