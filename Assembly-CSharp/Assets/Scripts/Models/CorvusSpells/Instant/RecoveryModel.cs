namespace Assets.Scripts.Models.CorvusSpells.Instant;

[Implementation(typeof(Recovery), False, False, new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {}])]
public class RecoveryModel : CorvusInstantSpellModel
{
	public float spellRecoveryRate; //Field offset: 0xA0
	public float absorptionDuration; //Field offset: 0xA4

	public RecoveryModel(string name, int unlocksAtLevel, SpriteReference icon, int initialManaCost, PrefabReference placingPrefabReference, int corvusAnimationState, int spiritAnimationState, EffectModel corvusEffectModel, EffectModel spiritEffectModel, SoundModel soundModel, EffectModel effectDuringCorvusModel, EffectModel effectDuringSpiritModel, float duration, float cooldown, float spellRecoveryRate, float absorptionDuration) { }

	public virtual Model Clone() { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

}

